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

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clscustomer TestItem = new clscustomer();
            Int32 PrimaryKey = 0;
            TestItem.Registered = true;
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Name = "Rushil";
            TestItem.Email = "Ramesh";
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            TestItem.CustomerNo = 1;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNo = PrimaryKey;

            TestItem.Registered = false;
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Name = "John";
            TestItem.Email = "Steve";
            TestItem.Address = "64, Worth road, LE7 4WE";
            TestItem.CustomerNo = 10;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clscustomer TestItem = new clscustomer();
            Int32 PrimaryKey = 0;
            TestItem.Registered = true;
            TestItem.DOB = Convert.ToDateTime("16/08/1999");
            TestItem.Name = "Rushil";
            TestItem.Email = "Ramesh";
            TestItem.Address = "60, Rainworth road, LE5 4QE";
            TestItem.CustomerNo = 1;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNo = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByName("Alexa");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsCustomerCollection FilteredNames = new clsCustomerCollection();
            Boolean OK = true;
            FilteredNames.ReportByName("Alexa");
            if (FilteredNames.Count == 2)
            {
                if (FilteredNames.CustomerList[0].CustomerNo !=1)
                {
                    OK = false;
                }

                if (FilteredNames.CustomerList[1].CustomerNo !=2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
