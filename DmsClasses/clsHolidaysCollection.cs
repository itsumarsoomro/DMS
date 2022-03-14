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
    }
}