using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


using AirRecords;
using TestTheClass = AirRecords.Location;
    

namespace UnitTestProject1
{
    [TestClass]
    public class Location
    {
        public Location(string v)
        {
        }

        [TestMethod]
        public void CalculateTotalParticulates()
        {
           
            Particulates subjectA = new Particulates("test", "test", "test", 5);
            Location sunderland = new Location("Bane");
           
             sunderland.CalculateTotalParticulates();
            

           //var a =  sunderland.CalculateTotalParticulates();
            Assert.AreEqual(a, 5);
           
            

        }
    }
}
