using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
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
            DB.Execute("sproc_tblStockManagement_Selectall");
            PopulateArray(DB);
            //get the count of records
           // RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
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
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
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
        

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@BookName", mThisStock.BookName);
            DB.AddParameter("@AuthorName", mThisStock.AuthorName);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@PublishDate", mThisStock.PublishDate);
            //execute the querry returnining the primary key value
            return DB.Execute("sproc_tblStockManagement_Insert");
        }
        public int Update()
        {
            //Updates an existing record to  the database based on the values of ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@BookName", mThisStock.BookName);
            DB.AddParameter("@AuthorName", mThisStock.AuthorName);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@PublishDate", mThisStock.PublishDate);
            //execute the querry returnining the primary key value
            return DB.Execute("sproc_tblStockManagement_Update");
        }

        public void Delete()
        {
           clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            //execute the querry returnining the primary key value
             DB.Execute("sproc_tblStockManagement_Delete");
        }

        public void ReportbyBookName(string BookName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookName", BookName);
            DB.Execute("sproc_tblStockManagement_FilterByBookName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();

            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.BookName = Convert.ToString(DB.DataTable.Rows[Index]["BookName"]);
                AStock.AuthorName = Convert.ToString(DB.DataTable.Rows[Index]["AuthorName"]);
                AStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AStock.PublishDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PublishDate"]);
                mStockList.Add(AStock);
                Index++;
            }
        }
    }
    }
    
        