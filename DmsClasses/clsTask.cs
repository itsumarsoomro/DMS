using System;

namespace DmsClasses
{
    public class clsTask
    {
        //private data member for the address no property
        private Int32 mTaskID;
        public string mTaskName { get; set; }
        public int TaskID
        {
            get
            {
                //this line of code sends data out of the property
                return mTaskID;
            }


            set
            {
                //this line of code allows data into the property
                mTaskID = value;
            }

        }
        public string TaskName
        {
            get
            {
                //this line of code sends data out of the property
                return mTaskName;
            }


            set
            {
                //this line of code allows data into the property
                mTaskName = value;
            }
        }



        public bool Find(int taskID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@TaskID", taskID);
            //excute the stored procedure
            DB.Execute("sproc_tblTask_FilterByTaskID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mTaskID = Convert.ToInt32(DB.DataTable.Rows[0]["TaskID"]);
                mTaskName = Convert.ToString(DB.DataTable.Rows[0]["TaskName"]);
                //return that everything worked Ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

           





        }
        public string Valid(string taskName)
        {
            //create a string varaiabel to store the error
            String Error = "";
            //if the TaskName is blank
            if (taskName.Length == 0)
            {
                //record the error
                Error = Error + "The Task name may not be blank : ";
            }
            //if the TaskName is blank
            if (taskName.Length > 100)
            {
                //record the error
                Error = Error + "The TaskName must be less than 100 characters :";
            }
            //retrun any error messages
            return Error;
        }

        

        


    }
    
    }


