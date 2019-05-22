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

       
    }
}
