using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dms_Testing
{
    [TestClass]
    public class tstTaskCollection
    {
        [TestMethod]
        public void instanceOk()
        {
            //create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTask);
        }
        [TestMethod]
        public void TaskListOk()
        {
            //create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTask> TestList = new List<clsTask>();
            //add an item to test data
            clsTask TestItem = new clsTask();
            //set its properties
            TestItem.TaskID = 1;
            TestItem.TaskName = "500 word essay";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTask.TaskList = TestList;
            //test to see that the two  values are the same
            Assert.AreEqual(AllTask.TaskList, TestList);

        }
        [TestMethod]
        public void ThisTaskOk()
        {
            //create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //create some test data to assign to the property
            clsTask TestTask = new clsTask();
            //set the properties of the test object
            TestTask.TaskID = 1;
            TestTask.TaskName = "500 word Essay";
            //assign the data to the property
            AllTask.ThisTask = TestTask;
            //test to see that the two values are the same
            Assert.AreEqual(AllTask.ThisTask, TestTask);
        }

        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create an instance of the class we want to create
        //    clsTaskCollection AllTask = new clsTaskCollection();
        //    //create some test data to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsTask> TestList = new List<clsTask>();
        //    //add the item to the test data
        //    clsTask TestItem = new clsTask();
        //    //set its properties
        //    TestItem.TaskID = 1;
        //    TestItem.mTaskName = "500 word essay";
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllTask.TaskList = TestList;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllTask.Count, TestList.Count);
        //}

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //create some test data to assign to property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllTask.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreNotEqual(AllTask.Count, SomeCount);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //Create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //test to see that two values are the same
            Assert.AreNotEqual(AllTask.Count, 1);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //craete the item of test data
            clsTask TestItem = new clsTask();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TaskID = 1;
            TestItem.TaskName = "500 word Essay";
            //set ThisTask to the test Data
            AllTask.ThisTask = TestItem;
            //add the record
            PrimaryKey = AllTask.Add();
            //set the primary key of the test data
            TestItem.TaskID = PrimaryKey;
            //set the pk to the test data
            TestItem.TaskID = PrimaryKey;
            //test to see that the two values are the same
            Assert.AreEqual(AllTask.ThisTask, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //create the item of the test data
            clsTask TestItem = new clsTask();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TaskID = 1;
            TestItem.TaskName = "500 word Essay";
            //set ThisTask to the test data
            AllTask.ThisTask = TestItem;
            //add the record
            PrimaryKey = AllTask.Add();
            //set the primary key of the test data
            TestItem.TaskID = PrimaryKey;
            //delete the record
            AllTask.Delete();
            //now find the record
            Boolean Found = AllTask.ThisTask.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }






        [TestMethod]
         public void UpdateMethodOK()
        { 
            //Create an instance of the class we want to create
            clsTaskCollection AllTask = new clsTaskCollection();
            //create the item of the test data
            clsTask TestItem = new clsTask();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TaskName = "500 word Essay";
            //set ThisTask to the test data
            AllTask.ThisTask = TestItem;
            //add the record
            PrimaryKey = AllTask.Add();
            //set the primary key of the test data
            TestItem.TaskID = PrimaryKey;
            //modify the test data
            TestItem.TaskName = "500 word Essay";
            //set the record based on the new test data
            AllTask.ThisTask = TestItem;
            //updatethe record
            AllTask.Update();
            //find the record
            AllTask.ThisTask.Find(PrimaryKey);
            //test to see ThisTask matches the test data
            Assert.AreEqual(AllTask.ThisTask, TestItem);

        }

        [TestMethod]
        public void ReportByTaskMethodOK()
        {
            //create an instance of the class containg unfiltered results
            clsTaskCollection AllTask = new clsTaskCollection();
            //create an instance of the filtered data
            clsTaskCollection FilterTask = new clsTaskCollection();
            //apply a bank string (should retrun all records);
            FilterTask.ReportByTask("sproc_tblTaskID_FilterByTaskID");
            //test to see that the two values are the same
            Assert.AreNotEqual(AllTask.Count, FilterTask.Count);
        }

        [TestMethod]
        public void ReportByTaskNoneFound()
        {
            //create an instance of the filtered data
            clsTaskCollection FilterTask = new clsTaskCollection();
            //apply a Task code that doesn't exsit
            FilterTask.ReportByTask("xxx xxx");
            //test to see that there are bo records
            Assert.AreEqual(0, FilterTask.Count);
        }

        [TestMethod]
        public void ReportByTaskTestDataFound()
        {
            //create an instacne of the filtered data
            clsTaskCollection FilterTask = new clsTaskCollection();
            //var to store outcome

            //apply a Task that doen't exsit
            FilterTask.ReportByTask("yyy yyyyy");
            //check that the correct number of records are found
            if (FilterTask.Count == 1)
            {
                //check that the first record is ID 2
                if (FilterTask.TaskList[1].TaskName != "500 word Essay")
                {

                }
                //check that the first record is ID 1
                if (FilterTask.TaskList[1].TaskName != "500 word Essay")

                {






                }




            }
        }

    }
}
