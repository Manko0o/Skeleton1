using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }


        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Josh";
            //assign the data to the property
            AStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }


        [TestMethod]
        public void DateofBirthPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateofBirth = TestData;
            Assert.AreEqual(AStaff.DateofBirth, TestData);
        }



        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            AStaff.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Surname, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "+447250957320";
            //assign the data to the property
            AStaff.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneNumber, TestData);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Availability, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestNameFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.Name != "Filip")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.Surname != "Kobeszko")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateofBirthFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.DateofBirth != Convert.ToDateTime("15/01/2001"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.PhoneNumber != "07387666666")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = AStaff.Find(StaffID);
            //check the StaffID 
            if (AStaff.Availability != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }



}
