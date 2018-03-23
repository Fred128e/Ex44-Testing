using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationUsingDB;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPaymentTotalTest()
        {
            Program testProgram = new Program();
            Person testPerson = new Person(1,"Frederik");
            Assert.AreEqual(74.3,testProgram.GetPaymentTotal(new MyDataProvider(),testPerson));
        }
        [TestMethod]
        public void SavePersonTest()
        {
            IDataProvider testProvider = new MyDataProvider();
            Person testPerson = new Person(1,"Frederik");
            Assert.AreEqual();
            
            
        }
        [TestMethod]
        public void GetTopThreePeopleTest()
        {

        }
    }

}
