using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstTask
    {
        //good test data
        //create some test data to pass to the method 
        string TaskName = "500 word essay";
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsTask AnExpenses = new clsTask();
            //test to see that is exists
            Assert.IsNotNull(AnExpenses);
        }


        [TestMethod]
        public void TaskNamePropertyOK()
        {
            clsTask AnDMS = new clsTask();
            String TestData;
            TestData = "500 word essay";
            AnDMS.TaskName = TestData;
            Assert.AreEqual(AnDMS.TaskName, TestData);
        }

        [TestMethod]
        public void TaskIDPropertyOK()
        {
            clsTask AnDMS = new clsTask();
            int TestData;
            TestData = 1;
            AnDMS.TaskID = TestData;
            Assert.AreEqual(AnDMS.TaskID, TestData);

        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //test to see that it exists
            Assert.IsNotNull(AnDMS);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //craete an instance of class of we want to create
            clsTask AnDMS = new clsTask();
            //Bollen variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 TaskID = 1;
            //invoke the method
            Found = AnDMS.Find(TaskID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void FindTaskIDOk()
        {
            //craete an instance of class of we want to create
            clsTask AnDMS = new clsTask();
            //Bollen variable to store the result of the validation
            Boolean Found = false;
            //boolean varaiable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use withj the method
            Int32 TaskID = 1;
            //invoke the method
            Found = AnDMS.Find(TaskID);
            //check the TaskID 
            if (AnDMS.TaskID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //Create an isntance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string varaiable to store any error message
            string Error = "";
            //invoke the method 
            Error = AnDMS.Valid(TaskName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TaskNameMinlessone()
        {
            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TaskName = ""; //thsi should trigger an error
            //invoke the method 
            Error = AnDMS.Valid(TaskName);
            //test to see that the reslut is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TaskNameMin()
        {
            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TaskName = "a"; //this should be ok
            //invoke the method
            Error = AnDMS.Valid(TaskName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TaskNameMinPlusone()
        {
            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string TaskName = "aa";
            Error = AnDMS.Valid(TaskName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
            ;
        }

        [TestMethod]
        public void TaskNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TaskName = "";
            TaskName = TaskName.PadRight(99,'a');
            //invoke the method
            Error = AnDMS.Valid(TaskName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TaskNameMid()
        {
            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TaskName = "";
            TaskName = TaskName.PadRight(50, 'a');
            //invoke the method
            Error = AnDMS.Valid(TaskName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TaskNameMax()
        {

            //create an instance of the class we want to create
            clsTask AnDMS = new clsTask();
            //string variable to store any error message
            String Error = "aaaaaa";
            //create some test data to pass to the method
            string TaskName = "";
            TaskName = TaskName.PadRight(100, 'a');
            //invoke the method
            Error = AnDMS.Valid(TaskName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");



        }
        [TestMethod]
        public void ReportByTaskNoneFound()
        {
            //
        }







    }
    
}


 