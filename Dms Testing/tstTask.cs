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
            clsTask  AnExpenses = new clsTask();
            //test to see that is exists
            Assert.IsNotNull(AnExpenses);
        }
    }

    public class clsTask
    {
        public bool Active { get; private set; }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsTask AnDMS = new clsTask();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Assert.AreEqual(AnDMS.Active, TestData);

        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTask  AnDMS = new clsTask ();
            //test to see that it exists
            Assert.IsNotNull(AnDMS);
        }

       



    }
}
