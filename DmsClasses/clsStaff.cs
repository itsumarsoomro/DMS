using System;

namespace DmsClasses
{
    public class clsStaff
    {
        public string Password;

        public string StaffID { get; set; }
        public string StaffName { get; set; }


        //staffno private member variable
        private Int32 mStaffNo;
        private int mStaffName;
        private int mAddress;
        private int mPassword;
        private int mStaffID;

        //StaffNo public property
        public Int32 StaffNo
        {

            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the prperty
                mStaffNo = value;
            }


        
        
        
        
        }

        public string Address { get; set; }

        public bool Find(int staffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the staff no to search for
            DB.AddParameter("StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one reord is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffName = Convert.ToInt32(DB.DataTable.Rows[0]["StaffName"]);
                mAddress = Convert.ToInt32(DB.DataTable.Rows[0]["Address"]);
                mPassword = Convert.ToInt32(DB.DataTable.Rows[0]["Password"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string Address, string StaffID, string Password, string StaffName)
        {
            //Create a string vsrsible to store the error
            String Error = "";
            //if the StaffName is blank
            if (StaffName.Length ==0)
            {
                //record the error
                Error = Error + "The Staff name may not be blank : ";
            }
            //if the staffname is greater then 6 characters
            if (StaffName.Length > 10)
            {
                //record the error
                Error = Error + "The Staff name must be less than 10 characters : ";
            }


            //is the Address blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 50 characters : ";
            }


            //is the StaffID blank
            if (StaffID.Length == 0)
            {
                //record the error
                Error = Error + "The StaffID may not be blank : ";
            }
            //if the StaffID is too long
            if (StaffID.Length > 11)
            {
                //record the error
                Error = Error + "The StaffId must be less than 9 characters : ";
            }

            //is the password blank
            if (Password.Length == 0)
            {
                //record the error
                Error = Error + "The Password may not be blank : ";
            }
            //if the password is too long
            if (Password.Length > 8)
            {
                //record the error
                Error = Error + "The password must be less than 8 characters : ";
            }




            //return any error messages
            return Error;
        }
    }
}