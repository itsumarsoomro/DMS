using System;
using System.Collections.Generic;

namespace DmsClasses
{
    public class clsTaskCollection
    {
        //private data memeber fo the list
        List<clsTask> mTaskList = new List<clsTask>();

        //private variable
        clsTask mThisTask = new clsTask();
        public clsTaskCollection()
        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblTask_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }


        public clsTask ThisTask
        {
            get
            {
                //return the private data
                return mThisTask;
            }
            set
            {
                //set the private data
                mThisTask = value;
            }
        }
            

      





        
        
           

            //public property for the Task List
            public List<clsTask> TaskList
            {
                get
                {
                    //return the private data
                    return mTaskList;
                }
                set
                {
                    //set the private data
                    mTaskList = value;
                }
            }
            //public property for count
            public int Count
            {
                get
                {
                    //return the count of the list
                    return mTaskList.Count;
                }
                set
                {
                    // we shall worry about this later
                }
            }

        public int Add()
        {
            //adds a  new reocrd to the database based on the values of mThisTask
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@TaskID", mThisTask.TaskID);
            DB.AddParameter("@TaskName", mThisTask.TaskName);
            //excute the query returning the primary key value
            return DB.Execute("sproc_tblTask_Insert");

        }
        public void Delete()
        {
            //deletes the record pointed to by thisTask
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TaskID", mThisTask.TaskID);
            //execute the stored procedure
            DB.Execute("sproc_tblTask_Delete");
        }
        public void Update()
        {
            //update an exsting record based on the value of thisTask
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters dor the stored procedure
            DB.AddParameter("@TaskID", mThisTask.TaskID);
            DB.AddParameter("@TaskName", mThisTask.TaskName);
            //excute the stored procedure
            DB.Execute("sproc_tblTask_Update");
        }

        public void ReportByTask(string Task)
        {
            //filters the records based on full or partial Task
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TaskName", Task);
            //send the Task Parameter to thje database

           DB.Execute("sproc_tblTaskID_FilterByTaskID");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the paramter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private arry list
            mTaskList = new List<clsTask>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a balnk Task
                clsTask AnTask = new clsTask();
                //read in the feilds fro nthe current record
                AnTask.TaskID = Convert.ToInt32(DB.DataTable.Rows[Index]["TaskID"]);
                AnTask.TaskName = Convert.ToString(DB.DataTable.Rows[Index]["TaskName"]);
                //add the record to the private data memeber
                mTaskList.Add(AnTask);
                //point at the next record
                Index++;
            }
        }
    }
    }



    
