using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AirRecords
{
    public class Particulates
    {
        public String Temperature { get; set; }
        public String Humidity { get; set; }
        public String Date { get; set; }
        public int Value { get; set; }

        public Particulates(String party, String firstName, String lastName, int value)
        {
            this.Temperature = party;
            this.Humidity = firstName;
            this.Date = lastName;
            this.Value = value;
        }

        public override String ToString()
        {
            return string.Format("Temp: {0} Hum: {1} Date: {2} Value: {3}", this.Temperature, this.Humidity, this.Date, this.Value);
        }
    }
}
