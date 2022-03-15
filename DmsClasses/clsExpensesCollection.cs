using System;
using System.Collections.Generic;

namespace DmsClasses
{
    public class clsExpensesCollection
    {
        public clsExpenses ThisExpenses { get; set; }

        //private data member for the list
        List<clsExpenses> mExpensesList = new List<clsExpenses>();

        //public property for the expenses list
        public List<clsExpenses> ExpensesList
        {
            get
            {
                //return the private data
                return mExpensesList;
            }
            set
            {
                //set the private data
                mExpensesList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mExpensesList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constrctor for the class
        public clsExpensesCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblExpenses_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank expenses
                clsExpenses AnExpenses = new clsExpenses();
                //read in the fuields from the currennt record
                AnExpenses.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnExpenses.ExpensesNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ExpensesNo"]);
                AnExpenses.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnExpenses.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AnExpenses.Expenses = Convert.ToInt32(DB.DataTable.Rows[Index]["Expenses"]);
                //add the record to the private data member
                mExpensesList.Add(AnExpenses);
                //point at the next record
                Index++;
            }
        }
    }
}