using System;
using System.Collections.Generic;

namespace DmsClasses
{
    public class clsExpensesCollection
    {
        public clsExpenses ThisExpenses
        {
            get
            {
                //return the private data
                return mThisExpenses;
            }
            set
            {
                //set the private data
                mThisExpenses = value;
            }
        }

        //private data member for the list
        List<clsExpenses> mExpensesList = new List<clsExpenses>();
        //private data member thisExpenses
        clsExpenses mThisExpenses = new clsExpenses();

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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblExpenses_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisExpenses
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisExpenses.Name);
            DB.AddParameter("@Category", mThisExpenses.Category);
            DB.AddParameter("@Expenses", mThisExpenses.Expenses);
            DB.AddParameter("@Active", mThisExpenses.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblExpenses_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by mThisExpenses
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ExpensesNo", mThisExpenses.ExpensesNo);
            //execute the stored procedure
            DB.Execute("sproc_tblExpenses_Delete");
        }

        public void Update()
        {
            //update an exsiting record based on the values of thisExpenses
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ExpensesNo", mThisExpenses.ExpensesNo);
            DB.AddParameter("@Name", mThisExpenses.Name);
            DB.AddParameter("@Category", mThisExpenses.Category);
            DB.AddParameter("@Expenses", mThisExpenses.Expenses);
            DB.AddParameter("@Active", mThisExpenses.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblExpenses_Update");
        }

        public void ReportByCategory(string Category)
        {
            //filters the records based on a full or partial category
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Category parameter to the database
            DB.AddParameter("@Category", Category);
            //execute the stored procedure
            DB.Execute("sproc_tblExpenses_FilterByCategory");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mExpensesList = new List<clsExpenses>();
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