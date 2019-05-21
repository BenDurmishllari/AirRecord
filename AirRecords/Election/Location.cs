using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election
{
    public class Location
    {
        int totalparticulate = 0;
        public String Name { get; set; }
        public List<Particulates> Particulates { get; set; }

        public Location(String name)
        {
            this.Name = name;
            this.Particulates = new List<Particulates>();
        }


        public int totalpartcalculate()
        {
            this.totalparticulate = 0;
            foreach(var i in Particulates)
            {
                this.totalparticulate = this.totalparticulate + i.Value;
            }
            return this.totalparticulate;
        }
        public override String ToString()
        {
            totalpartcalculate();
            
            return String.Format("Location: {0} Total Particulates: {1}", this.Name, this.totalparticulate);
        }
    }
}
