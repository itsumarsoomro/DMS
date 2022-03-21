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
            TestItem.EndDate = DateTime.Now.Date;
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
            TestHolidays.EndDate = DateTime.Now.Date;
            //assign the data to the property
            AllHolidays.ThisHolidays = TestHolidays;
            //test to see that the two valuees are the same
            Assert.AreEqual(AllHolidays.ThisHolidays, TestHolidays);
        }

        [TestMethod]
        public void ListAndCountOK()
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
            TestItem.EndDate = DateTime.Now.Date;
            ///add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllHolidays.HolidaysList = TestList;
            //test to see that te two values are the same
            Assert.AreEqual(AllHolidays.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of class we want to create
        //    clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllHolidays.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create ab instance of the class we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //create the item of test data
            clsHolidays TestItem = new clsHolidays();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties

            TestItem.EmpID =  6;
            TestItem.EmpName = "23";
            TestItem.EmpDepart = "test";
            TestItem.Reason = "test";
            TestItem.StartDate = Convert.ToDateTime("3/19/2022");
            TestItem.EndDate = Convert.ToDateTime("3/20/2022");
            //set this addres to the test data
            AllHolidays.ThisHolidays = TestItem;
            //add the record
            PrimaryKey = AllHolidays.Add();
            //set the primary key of the test data
            TestItem.EmpID = PrimaryKey;
            //Find the record
            AllHolidays.ThisHolidays.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllHolidays.ThisHolidays, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create ab instance of the class we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //create the item of test data
            clsHolidays TestItem = new clsHolidays();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmpID = 6;
            TestItem.EmpName = "23";
            TestItem.EmpDepart = "test";
            TestItem.Reason = "test";
            TestItem.StartDate = Convert.ToDateTime("3/19/2022");
            TestItem.EndDate = Convert.ToDateTime("3/20/2022");
            //set this addres to the test data
            AllHolidays.ThisHolidays = TestItem;
            //add the record
            PrimaryKey = AllHolidays.Add();
            //set the primary key of the test data
            TestItem.EmpID = PrimaryKey;
            //Find the record
            AllHolidays.ThisHolidays.Find(PrimaryKey);
            //delete the record
            AllHolidays.Delete();
            //now find the record
            Boolean Found = AllHolidays.ThisHolidays.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create ab instance of the class we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //create the item of test data
            clsHolidays TestItem = new clsHolidays();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            //TestItem.EmpID = 6;
            TestItem.EmpName = "23";
            TestItem.EmpDepart = "test";
            TestItem.Reason = "test";
            TestItem.StartDate = Convert.ToDateTime("3/19/2022");
            TestItem.EndDate = Convert.ToDateTime("3/20/2022");
            //set this addres to the test data
            AllHolidays.ThisHolidays = TestItem;
            //add the record
            PrimaryKey = AllHolidays.Add();
            //set the primary key of the test data
            TestItem.EmpID = PrimaryKey;
            //modify the test
            TestItem.EmpName = "24";
            TestItem.EmpDepart = "tests";
            TestItem.Reason = "tests";
            TestItem.StartDate = Convert.ToDateTime("3/17/2022");
            TestItem.EndDate = Convert.ToDateTime("3/19/2022");
            //set the record based inn thew new test data
            AllHolidays.ThisHolidays = TestItem;
            //update the record
            AllHolidays.Update();
            //find the record
            AllHolidays.ThisHolidays.Find(PrimaryKey);
            //test to see this holiday mateches the test data
            Assert.AreEqual(AllHolidays.ThisHolidays, TestItem);
        }        
        [TestMethod]
        public void ReportByReasonOK()
        {
            //create ab instance of the class we want to create
            clsHolidaysCollection AllHolidays = new clsHolidaysCollection();
            //create an instance of the filtered data
            clsHolidaysCollection FilteredHolidays = new clsHolidaysCollection();
            //apply a blank string (should return all the records)
            FilteredHolidays.ReportByReason("");
            //test to see that the two values are same
            Assert.AreEqual(AllHolidays.Count, FilteredHolidays.Count);
        }
        [TestMethod]
        public void ReportByReasonNoneFound()
        {
            //create an instance of the filtered data
            clsHolidaysCollection FilteredHolidays = new clsHolidaysCollection();
            //apply a blank string (should return all the records)
            FilteredHolidays.ReportByReason("NotExisted");
            //test to see that the two values are same
            Assert.AreEqual(0, FilteredHolidays.Count);
        }
    }
        }

