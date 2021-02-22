using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstcustomer
    {
        public object Acustomer { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //test to see that this exists
            Assert.IsNotNull(Acustomer);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Acustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Bob Track";
            //assign the data to the property
            Acustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "bobtrack@gmail.com";
            //assign the data to the property
            Acustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Email, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Acustomer.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.DOB, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "56, Nine road, Newtown, NE7 8LQ";
            //assign the data to the property
            Acustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Address, TestData);
        }

        [TestMethod]
        public void RegisteredPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            Acustomer.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Available, TestData);
        }
    }
}
