using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList

        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }


        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                ////not now
                ///
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            PopulateArray(DB);
            
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookName", mThisOrder.BookName);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@BookName", mThisOrder.BookName);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            DB.Execute("sproc_tblOrderProcessing_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrderProcessing_Delete");
        }

        public void ReportByBookName(String BookName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookName", BookName);
            DB.Execute("sproc_tblOrderProcessing_FilterByBookName");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.BookName = Convert.ToString(DB.DataTable.Rows[Index]["BookName"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                mOrderList.Add(AnOrder);
                Index++;
            }

        }
    }
}
    
    
