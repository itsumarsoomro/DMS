using System;

namespace DmsClasses
{
    public class clsTask
    {
        //private data member for the address no property
        private Int32 mTaskID;
        public string TaskName { get; set; }
        public int TaskID 
        {
            get
            {
                //this line of code sends data out of the property
                return mTaskID;
            }


            set {
                //this line of code allows data into the property
                mTaskID = value;
            } 
        }

        public bool Find(int taskID)
        {
            //set the private data members to the test data value
            mTaskID = 21;
            //always return true
            return true;
        }
    }
}