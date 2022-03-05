using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstHolidays
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //test to see that it exists
            Assert.IsNotNull(AnHolidays);
        }

    }

}
