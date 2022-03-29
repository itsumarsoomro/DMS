using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsClasses;

namespace Dms_Testing
{
    class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //CREATE AN INSTANCE OF THE CLASS
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create ab instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            //TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.Password = "xxxxxxxxxx";
            TestItem.Address = "some road";
            TestItem.StaffID = "3";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create ab instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            //TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.Password = "xxxxxxxxxx";
            TestItem.Address = "some road";
            TestItem.StaffID = "3";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

         [TestMethod]
         public void CountPropertyOK()
         {
            //CREATE an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //createsome test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
                
         }







    }
}
