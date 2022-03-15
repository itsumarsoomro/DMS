using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dms_Testing
{
    [TestClass]
    public class tstExpensesCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //test to see that it exists
            Assert.IsNotNull(AllExpenses);
        }

        [TestMethod]
        public void ExpensesListOk()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsExpenses> TestList = new List<clsExpenses>();
            //add an item of test data
            //create the item of test data
            clsExpenses TestItem = new clsExpenses();
            //set its properties
            TestItem.Active = true;
            TestItem.ExpensesNo = 1;
            TestItem.Name = "John";
            TestItem.Category = "Utilities";
            TestItem.Expenses = 3000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllExpenses.ExpensesList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllExpenses.ExpensesList, TestList);
        }

        [TestMethod]
        public void ThisExpensesPropertyOk()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create some test data to assign to the property
            clsExpenses TestExpenses = new clsExpenses();
            //set the properties of the test object
            TestExpenses.Active = true;
            TestExpenses.ExpensesNo = 1;
            TestExpenses.Name = "John";
            TestExpenses.Category = "Utilities";
            TestExpenses.Expenses = 3000;
            //assign the data to the property
            AllExpenses.ThisExpenses = TestExpenses;
            //test to see that the two values are the same
            Assert.AreEqual(AllExpenses.ThisExpenses, TestExpenses);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsExpenses> TestList = new List<clsExpenses>();
            //add an item of test data
            //create the item of test data
            clsExpenses TestItem = new clsExpenses();
            //set its properties
            TestItem.Active = true;
            TestItem.ExpensesNo = 1;
            TestItem.Name = "John";
            TestItem.Category = "Utilities";
            TestItem.Expenses = 3000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllExpenses.ExpensesList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllExpenses.Count, TestList.Count);
        }
    }
}
