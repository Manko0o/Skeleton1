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
        public void AvailablePropertyOK() {
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
            AStock.ProductId = TestData;
            Assert.AreEqual(AStock.ProductId, TestData);
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

    }
}
