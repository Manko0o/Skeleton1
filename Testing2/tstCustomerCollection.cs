using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clscustomer> TestList = new List<clscustomer>();
            //add an item to the list
            //create the item of test data
            clscustomer TestItem = new clscustomer();
            //set its properties
            TestItem.Registered = true;
            TestItem.CustomerNo = 1;
            TestItem.Name = "Rushil Ramesh";
            TestItem.Email = "tandelrushil007@gmail.com";
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance fof the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clscustomer TestCustomer = new clscustomer();
            //set the properties of the test object
            TestCustomer.Registered = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.Name = "Rushil Ramesh";
            TestCustomer.Email = "tandelrushil007@gmail.com";
            TestCustomer.DOB = Convert.ToDateTime("16/08/1999");
            TestCustomer.Address = "60, Rainworth road, LE5 4QE";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the sae
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clscustomer> TestList = new List<clscustomer>();
            clscustomer TestItem = new clscustomer();

            TestItem.Registered = true;
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Name = "Rushil Ramesh";
            TestItem.Email = "tandelrushil007@gmail.com";
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            TestItem.CustomerNo = 1;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
