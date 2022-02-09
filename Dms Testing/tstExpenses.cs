using DmsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dms_Testing
{
    [TestClass]
    public class tstExpenses
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsExpenses AnExpenses = new clsExpenses();
            //test to see that is exists
            Assert.IsNotNull(AnExpenses);
        }
    }
}
