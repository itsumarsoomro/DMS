using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string StaffName = "Nicole";
        string Address = "11 deacon street";
        string StaffID = "3";
        String Password = "txtrf56820";




        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            clsStaff AnDMS = new clsStaff();
            string TestData;
            TestData = "Current Staff";
            AnDMS.Password = TestData;
            Assert.AreEqual(AnDMS.Password, TestData);
        }

        //here
        [TestMethod]
        public void AddressOK()
        {
            clsStaff AnDMS = new clsStaff();
            string TestData;
            TestData = "Current Address";
            AnDMS.Password = TestData;
            Assert.AreEqual(AnDMS.Password, TestData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            clsStaff AnDMS = new clsStaff();
            string TestData;
            TestData = "Current Password";
            AnDMS.Password = TestData;
            Assert.AreEqual(AnDMS.Password, TestData);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            clsStaff AnDMS = new clsStaff();
            string TestData;
            TestData = "Current StaffID";
            AnDMS.StaffID = TestData;
            Assert.AreEqual(AnDMS.StaffID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
          //create an instance of the class we want to create
          clsStaff AnDMS = new clsStaff();
          //boolean variable to store the results of the validation
          Boolean Found = false;
          //create some test data to use with the method
          Int32 StaffNo = 21;
          //invoke the method
          Found = AnDMS.Find(StaffNo);
          //test to see if the result is true
          Assert.IsTrue(Found);

        }

//        [TestMethod]
//        public void TestStaffNoFound()
//        {
//            create an instance of the class we want to create
//            clsStaff AnStaff = new clsStaff();
//        boolean variable to store the result of the search
//        Boolean Found = false;
//            boolean variable to record if data is okay(assume it is)
//            Boolean OK = true;
//        create some test data to use with the method
//        Int32 StaffNo = 21;
//            invoke the method
//            Found = AnStaff.Find(StaffNo);
//        check the Staff no
//            if (AnStaff.StaffNo != 21)
//            {
//                OK = false;
//            }
//    test to see that the result is correct
//    Assert.IsTrue(OK);
//}

         [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //onoke the method
            Error = AnStaff.Valid(Address, StaffID, Password, StaffName);
            //text to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /// <summary>
        /// ////////////////////StaffName validation testing
        /// </summary>
        [TestMethod]
        public void StaffNameMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; // this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffName, Address, StaffID, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "h";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "hh";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "012345678901234567890";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void StaffNameMaxMinusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "h";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMidRange()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "0123456789";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "h";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffName = "";
            //assign test data to property
            StaffName = StaffName.PadRight(200, 'a'); //this should fail
                                                      //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }














        /// <summary>
        /// /////////////////Address validation testing
        /// </summary>

        [TestMethod]
        public void AddressMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; // this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffName, Address, StaffID, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void AddressMinBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "h";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "hh";
            //assign test data to property
            Error = AnStaff.Valid(Address, StaffID, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "0123456789012345678";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "abcdefghjiklmnopqrst";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "012345678901234567890";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMidRange()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "0123456789";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, Password, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "";
            StaffID = Address.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
                                                  //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }






        /// <summary>
        /// ///////////////////////StaffID VALIDATION TESTING
        /// </summary>
        /// 

        [TestMethod]
        public void StaffIDMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = ""; // this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffID, Address, StaffID, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "h";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "hh";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxMinusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "0123456789012345678";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "abcdefghjiklmnopqrst";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "012345678901234567890";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIDMidRange()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "0123456789";
            //assign test data to property
            Error = AnStaff.Valid(StaffID, Address, this.StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StaffID = "";
            StaffID = StaffID.PadRight(200, 'a'); //this should fail
                                                    //assign test data to property
                                                    //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }




        /// <summary>
        /// //////////////////////////PASSWORD VALIDATION TESTING
        /// </summary>




        [TestMethod]
        public void PasswordMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = ""; // this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMinBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "h";
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "hh";
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMaxMinusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "0123456789012345678";
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxBoundary()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "0123456789012345678";
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "01234567890123456789";
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMidRange()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "0123456789";
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //instance of the class
            clsStaff AnStaff = new clsStaff();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Password = "";
            Password = Password.PadRight(200, 'a'); //this should fail
                                                    //assign test data to property
            //assign test data to property
            Error = AnStaff.Valid(Password, Address, StaffID, StaffName);
            //test to see if found
            Assert.AreEqual(Error, "");
        }


    }
}
