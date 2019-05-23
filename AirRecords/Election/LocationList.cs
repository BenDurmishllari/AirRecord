using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirRecords
{
    public class LocationList
    {
        
        public List<Location> Locations { get; set; }

        public LocationList()
        {
            this.Locations = new List<Location>();
        }

        // method to display total values for each date
        public List<String> CalculateTotalParticulates()
        {
            List<String> particulatedataList = new List<string>();

            var parTotal =
                from Location in this.Locations
                from Particulate in Location.Particulates
                group Particulate by Particulate.Date into datareading

                let total = (from cand in datareading select
                (int)cand.Value).Sum()
                orderby total descending
                select new
                {
                    Par = datareading.Key,
                    Total = total
                };


            foreach (var p in parTotal)
            {
                particulatedataList.Add(String.Format("Date: {0} Total Values: {1}", p.Par, p.Total));
            }

            return particulatedataList;
        }

        // method to get the highest value
        // for each location
        public List<String> CalculateTotalParticulates2()
        {
            List<String> particulatedataList = new List<string>();

            var parTotal =
                from Location in this.Locations
                from Particulate in Location.Particulates
                group Particulate by Location.Name into datareading

                let total = (from cand in datareading
                             select
                (int)cand.Value).Sum()
                orderby total descending
                select new
                {
                    Par = datareading.Key,
                    Total = total
                };


            foreach (var p in parTotal)
            {
                particulatedataList.Add(String.Format("Location: {0} Values: {1}", p.Par, p.Total));
            }

            return particulatedataList;
        }

        // method to get the highest value
        // from all the locations
        public string highestValue()
        {
            int highest = 0;
            var loc = "";
            string Date = "";

            foreach (var lo in Locations)
            {
                foreach (var r in lo.Particulates)
                {
                    if (r.Value > highest)
                    {
                        highest = r.Value;
                        loc = lo.Name;
                        Date = r.Date;
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(loc) && !string.IsNullOrWhiteSpace(Date) && highest !=0 )
            {
                return String.Format("The location: {0}, had the highest value: {1}, on date: {2}",
                                      loc,highest,Date);
            }
            else
            {
                return "Data not loaded! Please reaload the xml or the program.";
            }
        }



    }
}
