using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstTask
    {
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
            Int32 TaskID = 21;
            //invoke the method
            Found = AnDMS.Find(TaskID);
            //test to see if the result is true
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void FindTaskID()
        {
            //craete an instance of class of we want to create
            clsTask AnDMS = new clsTask();
            //Bollen variable to store the result of the validation
            Boolean Found = false;
            //boolean varaiable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use withj the method
            Int32 TaskID = 21;
            //invoke the method
            Found = AnDMS.Find(TaskID);
            //check the TaskID 
            if (AnDMS.TaskID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        

        }
    
}


 