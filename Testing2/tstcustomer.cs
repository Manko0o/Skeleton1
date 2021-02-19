using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstcustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clscustomer Ancustomer = new clscustomer();
            //test to see that this exists
            Assert.IsNotNull(Ancustomer);
        }
    }
}
