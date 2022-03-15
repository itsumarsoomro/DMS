using System;
using System.Collections.Generic;

namespace DmsClasses
{
    public class clsHolidaysCollection
    {
        ////create the items of test data
        //clsHolidays TestItem = new clsHolidays();
        ////set its properties
        //TestItem.EmpID = 1;
        //    TestItem.EmpName = "Oxe";
        //    TestItem.EmpDepart = "Health";
        //    TestItem.Reason = "Health issues";
        //    TestItem.StartDate = DateTime.Now.Date;
        //    // add item to test list
        //    mHolidayList.Add(TestItem);
        //    //re initialise the object for some new data
        //    TestItem = new clsHoliday();
        ////set its properties
        //TestItem.EmpID = 2;
        //    TestItem.EmpName = "Oxerr";
        //    TestItem.EmpDepart = "Healthr";
        //    TestItem.Reason = "Health issuesr";
        //    TestItem.StartDate = DateTime.Now.Date;
        //    //add the item to the test list
        //    mHolidayList.Add(TestItem);

        //private data mmember for the list
        List<clsHolidays> mHolidayList = new List<clsHolidays>();

        //public property for the holiday list
        public List<clsHolidays> HolidaysList
        {
            get
            {
                return mHolidayList;
            }
            set
            {
                //set the private data
                mHolidayList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mHolidayList.Count;
            }
            set
            {
                //we shall worry about it later
            }
        }
        public clsHolidays ThisHoliday { get; set; }

        public clsHolidaysCollection()
        {
            //objcetv for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblHolidays_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            int Index = 0;
            //var to store the record count 
            int RecordsCount = 0;
            //get the count of records
            RecordsCount = DB.Count;
            //clear the private array list
            mHolidayList = new List<clsHolidays>();
            //while there are records to process
            while (Index < RecordsCount)
            {
                //create a blank Holiday
                clsHolidays AllHoliday = new clsHolidays();
                //read in the fields from the current records
                AllHoliday.EmpID = Convert.ToInt32(DB.DataTable.Rows[Index]["EmpID"]);
                AllHoliday.EmpName = Convert.ToString(DB.DataTable.Rows[0]["EmpName"]);
                AllHoliday.EmpDepart = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                AllHoliday.Reason = Convert.ToString(DB.DataTable.Rows[0]["Reason"]);
                AllHoliday.StartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HolidayStartDate"]);
                //add the record to the private data memberv
                mHolidayList.Add(AllHoliday);
                //point at the record
                Index++;
            }
        }
    }
}