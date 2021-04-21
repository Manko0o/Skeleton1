using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        public string SomeCountsTwo { get; private set; }

        [TestMethod]
        public void InstanceOK()

        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()

        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            //properties
            TestItem.OrderNo = 1;
            TestItem.BookName = "The Good Times";
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.Dispatched = true;

            TestList.Add(TestItem);

            AllOrder.OrderList = TestList;

            Assert.AreEqual(AllOrder.OrderList, TestList);

        }


        [TestMethod]
        public void CountOnePropertyOK()

        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            //this is to create some test data, so that it is assigned to property
            Int32 SomeCounts = 2;
            AllOrder.Count = SomeCounts;
            Assert.AreEqual(AllOrder.Count, SomeCounts);
 
        }

        [TestMethod]
        public void CountPropertiesOK()

        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            //this is to create some test data, so that it is assigned to property
            Int32 SomeCounts = 0;
            Int32 SomeCountsTwo = 0;
            AllOrder.Count = SomeCounts;
            AllOrder.Count = SomeCountsTwo;
            Assert.AreEqual(AllOrder.Count, SomeCounts, SomeCountsTwo);

        }


        [TestMethod]
        public void ListandCountsOK()

        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            //properties
            TestItem.OrderNo = 1;
            TestItem.BookName = "The Good Times";
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.Dispatched = true;

            TestList.Add(TestItem);

            AllOrder.OrderList = TestList;

            Assert.AreEqual(AllOrder.Count, TestList.Count);

        }

       



    }
}
