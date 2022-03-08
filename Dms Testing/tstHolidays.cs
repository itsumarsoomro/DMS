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

        [TestMethod]
        public void EmployeeIDOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnHolidays.EmpID = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EmpID, TestData);
        }

        [TestMethod]
        public void EmployeeNameOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            string TestData = "Mat";
            //assign the data to the property
            AnHolidays.EmpName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EmpName, TestData);
        }


        [TestMethod]
        public void DepartmentOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            string TestData = "IT";
            //assign the data to the property
            AnHolidays.EmpDepart = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EmpDepart, TestData);
        }

        [TestMethod]
        public void ReasonOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            string TestData = "Fever";
            //assign the data to the property
            AnHolidays.Reason = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.Reason, TestData);
        }

        [TestMethod]
        public void HolidayStartDateOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnHolidays.StartDate = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.StartDate, TestData);
        }

        [TestMethod]
        public void HolidayEndDateOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnHolidays.EndDate = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EndDate, TestData);
        }



    }

}
