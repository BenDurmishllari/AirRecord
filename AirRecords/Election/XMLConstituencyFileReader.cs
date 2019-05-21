using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Election
{
    public class XMLConstituencyFileReader : IConstituencyFileReader
    {
        public Location ReadConstituencyDataFromFile(ConfigRecord configRecord)
        {
            // Open the file to read from on the local file system.
            // If this file is missing then return immediately from this method.

            if (!File.Exists(configRecord.Filename))
            {
                // Cannot open the file as it does not exist for whatever reason, so return immediately.
                return null;
            }

            // Open file and load into memory as XML
            XDocument xmlDoc = XDocument.Load(configRecord.Filename);

            // Create constituency (should only be one in file but retrieve first to be sure)
            var con = (from c in xmlDoc.Descendants("Location")
                                    select c).First();

            Location constituency = new Location(con.Attribute("name").Value);

            // Obtain candidates from this constituency
            var cand = from c in con.Descendants("Reading")
                          select c;

            foreach (var c in cand)
            {
                
                var temperature = c.Element("temperature").Value;
                var humidity = c.Element("humidity").Value;
                var date = c.Attribute("date").Value;
                var value = Int32.Parse(c.Element("value").Value);

                Particulates candidate = new Particulates( temperature, humidity, date, value);
                constituency.Particulates.Add(candidate);
            }

            return constituency;
        }
    }
}
