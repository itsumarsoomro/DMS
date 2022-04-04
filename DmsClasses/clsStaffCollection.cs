using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DmsClasses
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();


        public List<clsStaff> StaffList 
        
        { 
            get
            {
                return mStaffList;

            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int StaffNo { get; private set; }
        public string Password { get; private set; }
        public string Address { get; private set; }
        public string StaffID { get; private set; }
        public object mTestList { get; private set; }

        //CONSTRUCTOR FOR THE CLASS
        //public clsStaffCollection()
        //{
        //    //create ab instance of the class we want to create
        //    clsStaffCollection TestItem = new clsStaffCollection();
        //    //set its properties
        //    //TestItem.Active = true;
        //    TestItem.StaffNo = 1;
        //    TestItem.Password = "xxxxxxxxxx";
        //    TestItem.Address = "some road";
        //    TestItem.StaffID = "3";
        //    //add the item to the test list
        //    mTestList.Add(TestItem);
        //    //re initialise the object for some new data
        //    TestItem = new clsStaff();
        //    //set iyts properties
        //    TestItem.StaffNo = 1;
        //    TestItem.Password = "xxxxxxxxxx";
        //    TestItem.Address = "some road";
        //    TestItem.StaffID = "3";
        //    //add the item to the test list
        //    mStaffList.Add(TestItem);
        //}





    }

}





    

