using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsClasses;

namespace DmsClasses
{
    public class clsExpenses
    {
        //private data member for Expenses
        private Int32 mExpenses;
        //public property for Expenses
        public int Expenses
        {
            get
            {
                //return the private data
                return mExpenses;
            }
            set
            {
                //set the private data
                mExpenses = value;
            }
        }

        //private data member for Name
        private string mName;
        //public property for Name
        public string Name
        {
            get
            {
                //return private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }
        }

        //private data member for category
        private string mCategory;
        //public property for category
        public string Category
        {
            get
            {
                //return private data
                return mCategory;
            }
            set
            {
                //set the private data
                mCategory = value;
            }
        }

        //private data member for the address no property
        private Int32 mExpensesNo;
        //ExpensesNo public property
        public Int32 ExpensesNo
        {
            get
            {
                //this line of code sends data out of the property
                return mExpensesNo;
            }
            set
            {
                //this line of code allows data into the property
                mExpensesNo = value;
            }
        }

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        public bool Find(Int32 ExpensesNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@ExpensesNo", ExpensesNo);
            //execute the stored procedure
            DB.Execute("sproc_tblExpenses_FilterByExpensesNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mExpensesNo = Convert.ToInt32(DB.DataTable.Rows[0]["ExpensesNo"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mExpenses = Convert.ToInt32(DB.DataTable.Rows[0]["Expenses"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return flase indicating a problem
                return false;
            }
        }
    }
}
