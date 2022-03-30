using System;
using System.Collections.Generic;

namespace DmsClasses
{
    public class clsHolidaysCollection
    {
       
        //private data mmember for the list
        List<clsHolidays> mHolidayList = new List<clsHolidays>();

        //private data member thisBook
        clsHolidays mThisHoliday = new clsHolidays();
 
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
        public clsHolidays ThisHolidays
        {
            get
            {
                //return the private data
                return mThisHoliday;
            }
            set
            {
                //set the private data
                mThisHoliday = value;
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
                AllHoliday.EmpName = Convert.ToString(DB.DataTable.Rows[Index]["EmpName"]);
                AllHoliday.EmpDepart = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                AllHoliday.Reason = Convert.ToString(DB.DataTable.Rows[Index]["Reason"]);
                AllHoliday.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HolidayStartDate"]);
                AllHoliday.EndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HolidayEndDate"]);
                //add the record to the private data memberv
                mHolidayList.Add(AllHoliday);
                //point at the record
                Index++;
            }
        }

     
        public int Add()
        {
            //adds a new record to the database based on the values of mHolidays
            //set theprimary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure            
            DB.AddParameter("@EmpName", mThisHoliday.EmpName);
            DB.AddParameter("@EmpDepart", mThisHoliday.EmpDepart);
            DB.AddParameter("@Reason", mThisHoliday.Reason);
            DB.AddParameter("@HolidayStartDate", mThisHoliday.StartDate);
            DB.AddParameter("@HolidayEndDate", mThisHoliday.EndDate);
            //return the primary key of the new record
            return DB.Execute("sproc_tblHolidays_Insert");
        }

    
        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmpID", mThisHoliday.EmpID);
            //execute the stored procedure
            DB.Execute("sproc_tblHolidays_Delete");       
        }

        public void Update()
        {
            //update an exisitng record based on the values of thisHolidays
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmpID", mThisHoliday.EmpID);
            DB.AddParameter("@EmpName", mThisHoliday.EmpName);
            DB.AddParameter("@EmpDepart", mThisHoliday.EmpDepart);
            DB.AddParameter("@Reason", mThisHoliday.Reason);
            DB.AddParameter("@HolidayStartDate", mThisHoliday.StartDate);
            DB.AddParameter("@HolidayEndDate", mThisHoliday.EndDate);
            //execute the stored procedure
            DB.Execute("sproc_tblHolidays_Update");
        }

        public void ReportByReason(string Reason)
        {
            //filters the record based on a full or partial reason
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the reason parameter to the database
            DB.AddParameter("@Reason", Reason);
            //execute the stored procedure
            DB.Execute("sproc_tblHolidays_FilterByRecords");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}