using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOK()
        {   
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Available = true;
            TestItem.ProductID = 1;
            TestItem.BookName = "Unfinished";
            TestItem.AuthorName = "Priyanka Chopra";
            TestItem.Price = 11;
            TestItem.PublishDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }
        
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.Available = true;
            TestStock.ProductID = 1;
            TestStock.BookName = "Unfinished";
            TestStock.AuthorName = "Priyanka Chopra";
            TestStock.Price = 11 ;
            TestStock.PublishDate = DateTime.Now.Date;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the sae
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Available = true;
            TestItem.ProductID = 1;
            TestItem.BookName = "Unfinished";
            TestItem.AuthorName = "Priyanka Chopra";
            TestItem.Price = 11;
            TestItem.PublishDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
      
        }
    }
