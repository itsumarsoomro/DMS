using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstExpenses
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsOrder AnExpenses = new clsOrder();
            //test to see that is exists
            Assert.IsNotNull(AnExpenses);
        }

        [TestMethod]
        public void ExpensesPropertyOK()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnExpenses.Expenses = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnExpenses.Expenses, TestData);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //create some test data to assign to the property
            string TestData = "Utilities";
            //assign the data to the property
            AnExpenses.Category = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnExpenses.Category, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //create some test data to assign to the property
            string TestData = "Andy";
            //assign the data to the property
            AnExpenses.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnExpenses.Name, TestData);
        }
    }


    public class   clsOrder
    {
        
    }
}

}

