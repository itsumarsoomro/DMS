using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsClasses
{
    public class clsHolidays
    {
        //private data member for the EmpId property
        private Int32 mEmpID;
        public Int32 EmpID {
            get
            {
                //this line of code sends data out of the property
                return mEmpID;
            }
            set
            {
                //this lone of code allows data into the property
                mEmpID = value; 
            } 
        }

        private string mEmpName;
        public string EmpName { 
            get
            {
                //this line of code sends data out of the property
                return mEmpName;
            }
            set
            {
                //this lone of code allows data into the property
                mEmpName = value; 
            } 
        }

        private string mEmpDepart;
        public string EmpDepart {
            get
            {
                //this line of code sends data out of the property
                return mEmpDepart; }
            set 
            {
                //this lone of code allows data into the property
                mEmpDepart = value; } 
        }

        private string mReason;
        public string Reason {
            get
            {
                //this line of code sends data out of the property
                return mReason; 
            }
            set
            {
                //this lone of code allows data into the property
                mReason = value; } 
        }


        private DateTime mStartDate;
        public DateTime StartDate {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }

        private DateTime mEndDate;
        public DateTime EndDate {
            get
            {
                return mEndDate;
            }
            set
            {
                mEndDate = value;
            }
        }

        public bool Find(Int32 EmpID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@EmpID", EmpID);
            //execute the stored procedure
            DB.Execute("sproc_tblHolidays_FilterByEmpID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mEmpID = Convert.ToInt32(DB.DataTable.Rows[0]["EmpID"]);
                mEmpName = Convert.ToString(DB.DataTable.Rows[0]["EmpName"]);
                mEmpDepart = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mReason = Convert.ToString(DB.DataTable.Rows[0]["Reason"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HolidayStartDate"]);
                mEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HolidayEndDate"]);
                return true;
            }
            //if no record was found
            else
            {
                //return flase indicating a problem
                return false;
            }

            //// set the private data members to test data value
            //mEmpID = 22;
            //mEmpName = "Ali";
            //mEmpDepart = "IT";
            //mReason = "Fever";
            //mStartDate = Convert.ToDateTime("09/03/2021");
            //mEndDate = Convert.ToDateTime("05/03/2021");
            ////always return true
            //return true;
        }

        public string Valid(string empName, string empDepart, string reason, string startDate, string enDate)
          
        {
            //create a string to store the error
            string Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the employee name is blank
            if (empName.Length == 0)
            {
                //record the errror
                Error = Error + "The employee name may not be blank : ";
                
                   }
            //if the employee name is larger than 50 characters
            if(empName.Length > 19)
            {
                //record the error
                Error = Error + "The employee name should be less than 19 characters : ";
            }



            //if the employee department is blank
            if (empDepart.Length == 0)
            {
                //record the errror
                Error = Error + "The employee department may not be blank : ";

            }
            //if the employee department is larger than 50 characters
            if (empDepart.Length > 20)
            {
                //record the error
                Error = Error + "The employee name should be less than 20 characters : ";
            }



            //if the reason is blank
            if (reason.Length == 0)
            {
                //record the errror
                Error = Error + "The reason may not be blank : ";

            }
            //if the reason is larger than 50 characters
            if (reason.Length > 20)
            {
                //record the error
                Error = Error + "The reason should be less than 20 characters : ";
            }


            ////cppy the date added value to  the datetemp variable 
            //DateTemp = Convert.ToDateTime(startDate);
            //if (DateTemp < DateTime.Now.Date)
            //{
            //    //record the error
            //    Error = Error + "The date cannot be so old : ";
            //}

            ////check to see if the date is greater than today's date
            //if (DateTemp > DateTime.Now.Date)
            //{
            //    //record the error
            //    Error = Error + "The date cannot be in the future : ";
            //}


            //try
            //{
            //    //copy the dateAdded value to the DateTemp variable
            //    DateTemp = Convert.ToDateTime(startDate);
            //    if (DateTemp < DateTime.Now.Date)
            //    {
            //        //record the error
            //        Error = Error + "The date cannot be in the past : ";
            //    }
            //    //check to see if the date is greater than today's date
            //    if (DateTemp > DateTime.Now.Date)
            //    {
            //        //record the error
            //        Error = Error + "The date cannot be in the future : ";
            //    }
            //}
            //catch
            //{
            //    //record the error
            //    Error = Error + "The date was not a valid date : ";
            //}

            //return any errors
            return Error;

        }
    }

    

    }





