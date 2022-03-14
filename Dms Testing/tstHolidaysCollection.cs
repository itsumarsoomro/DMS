using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dms_Testing
{
    [TestClass]
    public class tstHolidaysCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create ab instance of the class we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //test to see that it exists
            Assert.IsNotNull(AllHolidays);
        }

        [TestMethod]
        public void HolidaysListOK()
        {
            //create ab instance of the class we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsHolidays> TestList = new List<clsHolidays>();
            //add an item to the list
            //create the item of test data
            clsHolidays TestItem = new clsHolidays();
            //set its properties
            TestItem.EmpID = 1;
            TestItem.EmpName = "Oxe";
            TestItem.EmpDepart = "Health";
            TestItem.Reason = "Health issues";
            TestItem.StartDate = DateTime.Now.Date;
            //      TestItem.enDate = DateTime.Now.Date;
            ///add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllHolidays.HolidaysList = TestList;
            //test to see that te two values are the same
            Assert.AreEqual(AllHolidays.HolidaysList, TestList);
        }

        //[TestMethod]
        //public void CountHolidaysOK()
        //{
        //    //create an instance of the clas we want to create
        //    clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllHolidays.Count = SomeCount;
        //    //test to see that the two values are same
        //    Assert.AreEqual(AllHolidays.Count, SomeCount);
        //}


        [TestMethod]
        public void ThisHolidayOK()
        {
            //create an instance of the clas we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //create some test data to assign to the property
            clsHolidays TestHolidays = new clsHolidays();
            //set the properties of the test object
            TestHolidays.EmpID = 1;
            TestHolidays.EmpName = "Oxe";
            TestHolidays.EmpDepart = "Health";
            TestHolidays.Reason = "Health issues";
            TestHolidays.StartDate = DateTime.Now.Date;
            //assign the data to the property
            AllHolidays.ThisHoliday = TestHolidays;
            //test to see that the two valuees are the same
            Assert.AreEqual(AllHolidays.ThisHoliday, TestHolidays);
        }

        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create ab instance of the class we want to create
        //    clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
        //    //create some test data to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsHolidays> TestList = new List<clsHolidays>();
        //    //add an item to the list
        //    //create the item of test data
        //    clsHolidays TestItem = new clsHolidays();
        //    //set its properties
        //    TestItem.EmpID = 1;
        //    TestItem.EmpName = "Oxe";
        //    TestItem.EmpDepart = "Health";
        //    TestItem.Reason = "Health issues";
        //    TestItem.StartDate = DateTime.Now.Date;
        //    //TestItem.enDate = DateTime.Now.Date;
        //    ///add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllHolidays.HolidaysList = TestList;
        //    //test to see that te two values are the same
        //    Assert.AreEqual(AllHolidays.Count, TestList.Count);
        //}

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of class we want to create
        //    clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllHolidays.Count, 2);
        //}

    }
}
