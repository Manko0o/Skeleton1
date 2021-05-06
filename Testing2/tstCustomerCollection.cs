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
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clscustomer> TestList = new List<clscustomer>();
            clscustomer TestItem = new clscustomer();

            TestItem.Registered = true;
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Name = "Rushil";
            TestItem.Email = "Ramesh";
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            TestItem.CustomerNo = 1;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;



            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clscustomer TestCustomer = new clscustomer();

            TestCustomer.Registered = true;
            TestCustomer.DOB = Convert.ToDateTime("16/08/1999");
            TestCustomer.Name = "Rushil";
            TestCustomer.Email = "Ramesh";
            TestCustomer.Address = "60, Rainworth road, LE5 4QE";
            TestCustomer.CustomerNo = 1;

            AllCustomers.ThisCustomer = TestCustomer;



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
            TestItem.Name = "Rushil";
            TestItem.Email = "Ramesh";
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            TestItem.CustomerNo = 1;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;



            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance fof the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clscustomer TestItem = new clscustomer();
            Int32 Primarykey = 0;
            TestItem.Registered = true;
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Name = "Rushil";
            TestItem.Email = "Ramesh";
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            TestItem.CustomerNo = 1;

            AllCustomers.ThisCustomer = TestItem;
            Primarykey = AllCustomers.Add();
            TestItem.CustomerNo = Primarykey;
            AllCustomers.ThisCustomer.Find(Primarykey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }
}
