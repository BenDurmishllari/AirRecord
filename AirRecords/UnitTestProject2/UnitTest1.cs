using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AirRecords;
using tester =  AirRecords.Location;

namespace UnitTestProject2
{
    [TestClass]
    public class LocationTests

    {
        [TestMethod]
        public void Calculate_total()  
        {
            tester A = new tester("123");
            Particulates B = new Particulates("test", "test", "test", 5);
            A.Particulates.Add(B);
            
            Assert.AreEqual(A.totalpartcalculate(), 5);
        }
    }
}
