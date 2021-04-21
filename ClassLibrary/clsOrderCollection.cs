using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList;

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

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            RecordCount = DB.Count;
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