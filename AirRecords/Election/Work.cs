using System;

namespace AirRecords
{
	public class Work
	{
        public ConfigRecord configRecord { get; private set; } // Data used when this work is processed - config record
        private IConstituencyFileReader IOhandler; // Data used when this work is processed - config record

		public Work(ConfigRecord data, IConstituencyFileReader IOhandler) //extra param for IcyclistIO
		{
			this.configRecord = data; // Data is initialised when the work is instantiated
            this.IOhandler = IOhandler;
		}

		public Location ReadData()
		{
            // Reads the specified file and extracts the cyclist data from it to store in a cyclist object.
            // Note that result remains null until this method is executed
            return IOhandler.ReadConstituencyDataFromFile(configRecord);
		} 
	}
}
