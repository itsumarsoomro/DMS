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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //create some test data to assign to the property
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ExpensesNo = 1;
            //invoke the method
            Found = AnExpenses.Find(ExpensesNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestExpensesNoFound()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 ExpensesNo = 21;
            //invoke the method
            Found = AnExpenses.Find(ExpensesNo);
            //check the expense no
            if (AnExpenses.ExpensesNo != 21)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ExpensesNo = 21;
            //invoke the method
            Found = AnExpenses.Find(ExpensesNo);
            //check the property
            if (AnExpenses.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

    public class   clsOrder
    {
        
    }
}



