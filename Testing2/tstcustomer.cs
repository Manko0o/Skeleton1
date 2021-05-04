using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstcustomer
    {
        //good test data
        //create some test data to pass to the method
        string Name = "Rushil Ramesh";
        string Email = "tandelrushil007@gmail.com";
        string DOB = "16/08/1999";
        string Address = "60, Rainworth road, GA6 9PE";
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clscustomer Acustomer = new clscustomer();
            String Error = "";
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            Assert.AreEqual(Error, "");
        }


        //Name Validations
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaa"; //this should be ok
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should fail
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should fail
            Name = Name.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //email validations
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should fail
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should fail
            Email = Email.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //address validations
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(59, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(60, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(30, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should fail
            Address = Address.PadRight(61, 'a');
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should fail
            Address = Address.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = Acustomer.Valid(Name, Email, DOB, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
