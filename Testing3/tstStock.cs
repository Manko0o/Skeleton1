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
        
    }
}
