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

        public string Valid(object bookName, object quantity, object orderDate, object price)
        {
            return "";
        }

        public string Valid(string bookName, string quantity, string orderDate, string price, string price1)
        {
            String Error = "";
            DateTime DateTemp;
            if (bookName.Length == 0)
            {
                Error = Error + "The book name cannot be blank: ";
            }

            if (bookName.Length > 60)

            {
                Error = Error + "The book name must be less than 60 characters: ";


            }
            DateTemp = Convert.ToDateTime(OrderDate);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }
            return Error;
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








        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Quantity we are searching for
            DB.AddParameter("@OrderNo", OrderNo);
            //below code then executes the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderNo");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
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