using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstHolidays
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //test to see that it exists
            Assert.IsNotNull(AnHolidays);
        }

        [TestMethod]
        public void EmployeeIDOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnHolidays.EmpID = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EmpID, TestData);
        }

        [TestMethod]
        public void EmployeeNameOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            string TestData = "Mat";
            //assign the data to the property
            AnHolidays.EmpName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EmpName, TestData);
        }


        [TestMethod]
        public void DepartmentOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            string TestData = "IT";
            //assign the data to the property
            AnHolidays.EmpDepart = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EmpDepart, TestData);
        }

        [TestMethod]
        public void ReasonOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            string TestData = "Fever";
            //assign the data to the property
            AnHolidays.Reason = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.Reason, TestData);
        }

        [TestMethod]
        public void HolidayStartDateOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnHolidays.StartDate = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.StartDate, TestData);
        }

        [TestMethod]
        public void HolidayEndDateOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnHolidays.EndDate = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHolidays.EndDate, TestData);
        }

        [TestMethod]
        public void FoundMethodOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 EmpID = 54;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeidFound()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //bollean variable to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmpID = 60;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //check the Emp ID
            if (AnHolidays.EmpID != 60)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmployeeNameFound()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //bollean variable to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmpID = 60;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //check the Emp ID
            if (AnHolidays.EmpName != "HRR")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //bollean variable to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmpID = 60;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //check the Emp ID
            if (AnHolidays.EmpDepart != "Isssiak")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReasonFound()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //bollean variable to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmpID = 60;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //check the Emp ID
            if (AnHolidays.Reason != "Feverr")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHolidayStartDateFound()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //bollean variable to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmpID = 60;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //check the Emp ID
            if (AnHolidays.StartDate != Convert.ToDateTime("19/03/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHolidayEndDateFound()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //bollean variable to store the results of the validation
            Boolean Found = false;
            //bollean variable to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmpID = 60;
            //invoke the method
            Found = AnHolidays.Find(EmpID);
            //check the Emp ID
            if (AnHolidays.EndDate != Convert.ToDateTime("20/03/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsHolidays AnHolidays = new clsHolidays();
            //string variable to store any error messahe
            String Error = "";
            //invoke the method
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        string empName = "Hollie";
        string empDepart = "Health";
        string reason = "Cvoid";
        string startDate = "11/03/2022";
        string enDate = "20/03/2022";





        //Employee name validation testing




        [TestMethod]
        public void EmpNameMinMinusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = ""; // this should trigger and error
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMinBoundary()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "u";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMinPlusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "hh";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMaxMinusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "ogTXuM2BUGmpwAPScu4sF1e7FuHKsxmAzMTCyd4zK28emXbvx";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMaxBoundary()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "ogTXuM2BUGmpwAPScu4sF1e7FuHKsxmAzMTCyd4zK28emXbvx9";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMaxPlusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "ogTXuM2BUGmpwAPScu4sF1e7FuHKsxmAzMTCyd4zK28emXbvx9a";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameMidRange()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "7akubr52YcrS1k5cldnxCOpXp";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpNameExtremeMax()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empName = "";
            empName = empName.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }






        //Employee department validation testing




        [TestMethod]
        public void EmpDepartMinMinusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = ""; // this should trigger and error
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartMinBoundary()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "u";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartMinPlusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "hh";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartMaxMinusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "07YgI1Dng9fcp6trgPiwx9uZOXkuHrnM6IHI66utQ86Q9S3Gj";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartMaxBoundary()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "07YgI1Dng9fcp6trgPiwx9uZOXkuHrnM6IHI66utQ86Q9S3Gj0";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartMaxPlusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "07YgI1Dng9fcp6trgPiwx9uZOXkuHrnM6IHI66utQ86Q9S3Gj0a";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartMidRange()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "j2t8lPgtntG3vdty2J7DFqkaF";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmpDepartExtremeMax()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string empDepart = "";
            empDepart = empDepart.PadRight(200, 'a'); //this should fail
                                                      //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }






        //Reason validation testing 




        [TestMethod]
        public void ReasonMinMinusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = ""; // this should trigger and error
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMinBoundary()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "u";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMinPlusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "hh";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMaxMinusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "b3ivgtomn9PfIK8EoJu9K0xS6akd3m5NPhVyXCgPUk5H90vKz";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMaxBoundary()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "b3ivgtomn9PfIK8EoJu9K0xS6akd3m5NPhVyXCgPUk5H90vKzt";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMaxPlusOne()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "b3ivgtomn9PfIK8EoJu9K0xS6akd3m5NPhVyXCgPUk5H90vKzta";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReasonMidRange()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "R0NbBzx4t7JurNmdazqNOExHL";
            //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReasonExtremeMax()
        {
            //instance of the class
            clsHolidays AnHolidays = new clsHolidays();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string reason = "";
            empName = empName.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }





        //StartDate validation testing




        //[TestMethod]
        //public void StartDateExtremeMin()
        //{
        //    //instance of the class
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //create a string variable to store the result of validation
        //    string Error = "";
        //    // create a variable to store the test data
        //    DateTime TestDate;
        //    //set the date to todys date
        //    TestDate = Convert.ToDateTime("09/03/2021");
        //    //change the data whatever the date in 100 years ago
        //    TestDate = TestDate.AddYears(-100);
        //    //convert the date time to string variable
        //    string startDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void StartDateMinLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = Convert.ToDateTime("09/03/2021");
        //    //change the date to whatever the date is less 1 day
        //    TestDate = TestDate.AddDays(-1);
        //    //convert the date variable to a string variable
        //    string startDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void StartDateMin()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //convert the date variable to a string variable
        //    string startDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void StartDateMinPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is plus 1 day
        //    TestDate = TestDate.AddDays(1);
        //    //convert the date variable to a string variable
        //    string startDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void StartDateExtremeMax()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is plus 100 years
        //    TestDate = TestDate.AddYears(100);
        //    //convert the date variable to a string variable
        //    string startDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void InvalidStartDate()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass method
        //    String empName = "Umar";
        //    String empDepart = "IT";
        //    String reason = "Fever";
        //    String enDate = "15/03/2022";
        //    //set a startDate to no date value
        //    String startDate = "This is not a date!";
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");

        //}


        ////EndDate Validation testing


        //[TestMethod]
        //public void EndDateExtremeMin()
        //{
        //    //instance of the class
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //create a string variable to store the result of validation
        //    string Error = "";
        //    // create a variable to store the test data
        //    DateTime TestDate;
        //    //set the date to todys date
        //    TestDate = DateTime.Now.Date;
        //    //change the data whatever the date in 100 years ago
        //    TestDate = TestDate.AddYears(-100);
        //    //convert the date time to string variable
        //    string enDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void EndDateMinLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is less 1 day
        //    TestDate = TestDate.AddDays(-1);
        //    //convert the date variable to a string variable
        //    string enDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void EndDateMin()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //convert the date variable to a string variable
        //    string enDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void EndDateMinPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is plus 1 day
        //    TestDate = TestDate.AddDays(1);
        //    //convert the date variable to a string variable
        //    string enDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void EndDateExtremeMax()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date totodays date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is plus 100 years
        //    TestDate = TestDate.AddYears(100);
        //    //convert the date variable to a string variable
        //    string enDate = TestDate.ToString();
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void InvalidEndDate()
        //{
        //    //create an instance of the class we want to create
        //    clsHolidays AnHolidays = new clsHolidays();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass method
        //    String empName = "Umars";
        //    String empDepart = "ITms";
        //    String reason = "Fever";
        //    String startDate = "20/03/2022";
        //    //set a startDate to no date value
        //    String enDate = "This is not a date!";
        //    //invoke the method
        //    Error = AnHolidays.Valid(empName, empDepart, reason, startDate, enDate);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");

        //}

    }
}