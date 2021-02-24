using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock AStock = new clsStock();
            bool TestData = true;
            AStock.Available = TestData;
            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 1;
            AStock.ProductID = TestData;
            Assert.AreEqual(AStock.ProductID, TestData);
        }

        [TestMethod]
        public void BookNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            String TestData = "Chicken";
            AStock.BookName = TestData;
            Assert.AreEqual(AStock.BookName, TestData);
        }

        [TestMethod]
        public void AuthorNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            String TestData = "KFC";
            AStock.AuthorName = TestData;
            Assert.AreEqual(AStock.AuthorName, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AStock = new clsStock();
            float TestData = 1.20F;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void TypePropertyOK()
        {
            clsStock AStock = new clsStock();
            String TestData = "Lemon";
            AStock.Type = TestData;
            Assert.AreEqual(AStock.Type, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1122;
            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 11223344;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the Product 
            if (AStock.ProductID != 11223344)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 11223344;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.BookName != "Unfinished")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAuthorNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 11223344;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.AuthorName != "Priyanka")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 11223344;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.Available != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 11223344;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.Price != 10.20F)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TypeFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 11223344;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.Type != "Biography")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}

