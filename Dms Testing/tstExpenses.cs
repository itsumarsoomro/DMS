using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstExpenses
    {

        //good test data
        //create some test data to pass to the mthod
        string Expenses = "3000";
        string Category = "Salary";
        string Name = "Sarah";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void NameMin()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinLessOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Category = "";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMin()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Category = "a";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Category = "aa";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Category = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Category = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Category = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Category = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMinLessOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Expenses = "";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMin()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Expenses = "a";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Expenses = "aa";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMaxLessOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Expenses = "";
            Expenses = Expenses.PadRight(49, 'a');
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMax()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Expenses = "";
            Expenses = Expenses.PadRight(50, 'a');
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = ""; ;
            //this should fail
            string Expenses = "";
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpensesMid()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Expenses = "";
            Expenses = Expenses.PadRight(25, 'a');
            //invoke the method
            Error = AnExpenses.Valid(Name, Category, Expenses);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }

    public class   clsOrder
    {
        
    }
}



