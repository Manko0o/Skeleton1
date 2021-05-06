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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            Int32 Primarykey = 0;
            TestItem.Available = true;
            TestItem.ProductID = 1;
            TestItem.BookName = "Unfinished";
            TestItem.AuthorName = "Priyanka Chopra";
            TestItem.Price = 11;
            TestItem.PublishDate =Convert.ToDateTime("09/02/2021");

            AllStocks.ThisStock = TestItem;
            Primarykey = AllStocks.Add();
            TestItem.ProductID = Primarykey;
            AllStocks.ThisStock.Find(Primarykey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            Int32 Primarykey = 0;
            TestItem.Available = true;
            TestItem.ProductID = 1;
            TestItem.BookName = "Unfinished";
            TestItem.AuthorName = "Priyanka Chopra";
            TestItem.Price = 11;
            TestItem.PublishDate = Convert.ToDateTime("09/02/2021");

            AllStocks.ThisStock = TestItem;
            Primarykey = AllStocks.Add();
            TestItem.ProductID = Primarykey;
            AllStocks.ThisStock.Find(Primarykey);
            //modify the data
            TestItem.Available = false;
            TestItem.ProductID = 11;
            TestItem.BookName = "Becoming";
            TestItem.AuthorName = "Michelle Obama";
            TestItem.Price = 17;
            TestItem.PublishDate = Convert.ToDateTime("21/05/2011");
            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(Primarykey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
         [TestMethod]
         public void DeleteMethodOK()
         {
             clsStockCollection AllStocks = new clsStockCollection();
             clsStock TestItem = new clsStock();
             Int32 PrimaryKey = 0;
             TestItem.Available = true;
             TestItem.ProductID = 1;
             TestItem.BookName = "Unfinished";
             TestItem.AuthorName = "Priyanka Chopra";
             TestItem.Price = 11;
             TestItem.PublishDate = Convert.ToDateTime("09/02/2021");
             AllStocks.ThisStock = TestItem;
             PrimaryKey = AllStocks.Add();
             TestItem.ProductID = PrimaryKey;
             AllStocks.ThisStock.Find(PrimaryKey);
             AllStocks.Delete();
             Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
             Assert.IsFalse(Found);
             }
        [TestMethod]
        public void ReportByBookNameMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredBooks = new clsStockCollection();
            FilteredBooks.ReportbyBookName("");
            Assert.AreEqual(AllStocks.Count, FilteredBooks.Count);

        }
        [TestMethod]
        public void ReportByBookNameNoneFound()
        {
            clsStockCollection FilteredBooks = new clsStockCollection();
            FilteredBooks.ReportbyBookName("heyYou!");
            Assert.AreEqual(0, FilteredBooks.Count);
        }
        [TestMethod]
        public void ReportByBookNameTestDataFound()
        {
            clsStockCollection FilterStocks = new clsStockCollection();
            Boolean OK = true;
            FilterStocks.ReportbyBookName("Wakanda");
            if (FilterStocks.Count == 2)
            {
                if (FilterStocks.StockList[0].ProductID !=326 )
                {
                    OK = false;
                }
                if (FilterStocks.StockList[1].ProductID != 330)
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
        
    

