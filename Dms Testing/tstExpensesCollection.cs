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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create the item of test data
            clsExpenses TestItem = new clsExpenses();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.ExpensesNo = 1;
            TestItem.Name = "Terry";
            TestItem.Category = "Rent";
            TestItem.Expenses = 1500;
            //set ThisExpenses to the test data
            AllExpenses.ThisExpenses = TestItem;
            //Add the record
            PrimaryKey = AllExpenses.Add();
            //set the primary key of the test data
            TestItem.ExpensesNo = PrimaryKey;
            //find the record
            AllExpenses.ThisExpenses.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllExpenses.ThisExpenses, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create the item of test data
            clsExpenses TestItem = new clsExpenses();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.ExpensesNo = 1;
            TestItem.Name = "Terry";
            TestItem.Category = "Rent";
            TestItem.Expenses = 1500;
            //set ThisExpenses to the test data
            AllExpenses.ThisExpenses = TestItem;
            //Add the record
            PrimaryKey = AllExpenses.Add();
            //set the primary key of the test data
            TestItem.ExpensesNo = PrimaryKey;
            //find the record
            AllExpenses.ThisExpenses.Find(PrimaryKey);
            //delete the record
            AllExpenses.Delete();
            //now find the record
            Boolean Found = AllExpenses.ThisExpenses.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create the item of test data
            clsExpenses TestItem = new clsExpenses();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.ExpensesNo = 1;
            TestItem.Name = "Terry";
            TestItem.Category = "Rent";
            TestItem.Expenses = 1500;
            //set ThisExpenses to the test data
            AllExpenses.ThisExpenses = TestItem;
            //Add the record
            PrimaryKey = AllExpenses.Add();
            //set the primary key of the test data
            TestItem.ExpensesNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.ExpensesNo = 3;
            TestItem.Name = "Jom";
            TestItem.Category = "Inventory";
            TestItem.Expenses = 500;
            //set the record based on the new test data
            AllExpenses.ThisExpenses = TestItem;
            //update the record
            AllExpenses.Update();
            //find the record
            AllExpenses.ThisExpenses.Find(PrimaryKey);
            //test to see ThisExpenses matches the test data
            Assert.AreEqual(AllExpenses.ThisExpenses, TestItem);
        }

        [TestMethod]
        public void ReportByCategoryMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsExpensesCollection AllExpenses = new clsExpensesCollection();
            //create an instance of the filtered data
            clsExpensesCollection FilteredExpenses = new clsExpensesCollection();
            //apply a blank string (should return all records);
            FilteredExpenses.ReportByCategory("");
            //test to see that the two values are the same
            Assert.AreEqual(AllExpenses.Count, FilteredExpenses.Count);
        }

        //[TestMethod]
        //public void ReportByCategoryNoneFound()
        //{
        //    //create an instance of the filtered data
        //    clsExpensesCollection FilteredExpenses = new clsExpensesCollection();
        //    //apply a category that dosen't exist
        //    FilteredExpenses.ReportByCategory("xxxxxx");
        //    //test to see that there are no records
        //    Assert.AreEqual(0, FilteredExpenses.Count);
        //}

        //[TestMethod]
        //public void ReportByCategoryTestDataFound()
        //{
        //    //create an instance of the filtered data
        //    clsExpensesCollection FilteredExpenses = new clsExpensesCollection();
        //    //var to store outcome
        //    Boolean OK = true;
        //    //apply a category that dosen't exsist
        //    FilteredExpenses.ReportByCategory("xxxxxx");
        //    //check that the correct number of records are found
        //    if (FilteredExpenses.Count == 2)
        //    {
        //        //check that the first record is ID 108
        //        if (FilteredExpenses.ExpensesList[0].ExpensesNo != 108)
        //        {
        //            OK = false;
        //        }
        //        //check that the first record is ID 109
        //        if (FilteredExpenses.ExpensesList[1].ExpensesNo != 109)
        //        {
        //            OK = false;
        //        }
        //    }
        //    else
        //    {
        //        OK = false;
        //    }
        //    //test to see that there are no records
        //    Assert.IsTrue(OK);
        //}
    }
}
