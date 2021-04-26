using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList
        {
            get
        { 
             //return the private data
             return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        //constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the recored count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index <RecordCount)
            {
                //create a blank address
                clsStock AStock = new clsStock();
                //read in the feilds from the current record
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.BookName = Convert.ToString(DB.DataTable.Rows[Index]["BookName"]);
                AStock.AuthorName = Convert.ToString(DB.DataTable.Rows[Index]["AuthorName"]);
                AStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AStock.PublishDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PublishDate"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }

           /* //create the items of the tests of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Available = true;
            TestItem.ProductID = 1;
            TestItem.BookName = "Unfinished";
            TestItem.AuthorName = "Priyanka Chopra";
            TestItem.Price = 11;
            TestItem.PublishDate = DateTime.Now.Date;
            //add the item to the test list
            mStockList.Add(TestItem);
            //re initialise the object for some data
            TestItem = new clsStock();
            //set its properties
            TestItem.Available = true;
            TestItem.ProductID = 1;
            TestItem.BookName = "Unfinished";
            TestItem.AuthorName = "Priyanka Chopra";
            TestItem.Price = 11;
            TestItem.PublishDate = DateTime.Now.Date;
            //add the item to the test list
            mStockList.Add(TestItem); */


        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public object ThisStock { get; set; }
    }
}