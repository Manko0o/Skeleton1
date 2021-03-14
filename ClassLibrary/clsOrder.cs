using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        private Int32 mQuantity;

    
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
    set
            {
                mQuantity = value;
            }
        }


        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }


        private string mBookName;


        public string BookName
        {
            get
            {
                return mBookName;
            }
            set
            {
                mBookName = value;
            }
        }


        private double mPrice;


        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }


        private int mOrderNo;


        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }


        private bool mDispatched;


        public bool Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }








        public bool Find(int Quantity)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Quantity we are searching for
            DB.AddParameter("@Quantity", Quantity);
            //below code then executes the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByQuantity");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mBookName = Convert.ToString(DB.DataTable.Rows[0]["BookName"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                //return to signify that everything worked OK
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}