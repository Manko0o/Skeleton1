﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        public object ThisOrder { get; private set; }

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
        public void ThisOrderProperty()

        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            //this is to create some test data, so that it is assigned to property
            //properties
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderNo = 1;
            TestOrder.BookName = "The Good Times";
            TestOrder.Quantity = 2;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.Price = 20;
            TestOrder.Dispatched = true;
            AllOrder.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
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

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.BookName = "The Good Times";
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.Dispatched = true;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.BookName = "The Good Times";
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.Dispatched = true;

            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();

            TestItem.OrderNo = PrimaryKey;
            TestItem.BookName = "In The Name Of 2020";
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 10;
            TestItem.Dispatched = false;

            AllOrder.ThisOrder = TestItem;
            AllOrder.Update();
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);













        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.BookName = "The Good Times";
            TestItem.Quantity = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.Dispatched = true;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrder.ThisOrder.Find(PrimaryKey);
            AllOrder.Delete();
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void ReportbyBookNameMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrderCollection FilteredBookName = new clsOrderCollection();
            FilteredBookName.ReportByBookName("");
            Assert.AreEqual(AllOrder.Count, FilteredBookName.Count);
        }

        [TestMethod]
        public void ReportbyBookNameNoneFound()
        {
           clsOrderCollection FilteredBookName = new clsOrderCollection();
            FilteredBookName.ReportByBookName("aaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual(0, FilteredBookName.Count);
        }

        [TestMethod]
        public void ReportByBookNameDataFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrder.ReportByBookName("aaaaaaaaaaaaaaaaaaaaaaaaaa");
            if (FilteredOrder.Count == 2)
            {
                if (FilteredOrder.OrderList[0].OrderNo != 1)
                {
                    OK = false;
                }
                if (FilteredOrder.OrderList[1].OrderNo != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }
    }
}
