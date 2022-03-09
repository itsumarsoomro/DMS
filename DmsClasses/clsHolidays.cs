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

        public bool Find(int empID)
        {
            // set the private data members to test data value
            mEmpID = 22;
            mEmpName = "Ali";
            mEmpDepart = "IT";
            mReason = "Fever";
            mStartDate = Convert.ToDateTime("09/03/2021");
            mEndDate = Convert.ToDateTime("05/03/2021");
            //always return true
            return true;
        }
    }

  
}


