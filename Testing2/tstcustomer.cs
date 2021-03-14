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
            string TestData = "Abi Sunn";
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
            string TestData = "abisunn@gmail.com";
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
            string TestData = "60, Gate road, GA6 9PE";
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
            Acustomer.Registered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Registered, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we eant to create
            clscustomer Acustomer = new clscustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = Acustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we eant to create
            clscustomer Acustomer = new clscustomer();
            //boolean varaible to store the result of the search
            Boolean Found = false;
            //boolean varaible to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = Acustomer.Find(CustomerNo);
            //check the customer no
            if (Acustomer.CustomerNo !=1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //Bolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the methods
            Found = Acustomer.Find(CustomerNo);
            //check the customer no 
            if (Acustomer.Name != "Abi Sunn")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //Bolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the methods
            Found = Acustomer.Find(CustomerNo);
            //check the customer no
            if (Acustomer.Email != "abisunn@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //Bolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the methods
            Found = Acustomer.Find(CustomerNo);
            //check the customer no
            if (Acustomer.DOB != Convert.ToDateTime("15/01/1998"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //Bolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the methods
            Found = Acustomer.Find(CustomerNo);
            //check the customer no
            if (Acustomer.Address != "60, Gate road, GA6 9PE")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRegisteredFound()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //Bolean variable to store the results of the serach
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the methods
            Found = Acustomer.Find(CustomerNo);
            //check the customer no 
            if (Acustomer.Registered != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
