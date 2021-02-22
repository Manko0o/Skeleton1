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


        private int mOrderId;


        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
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
            mQuantity = 10;
            mOrderDate = Convert.ToDateTime("15/02/2021");
            mBookName = "Amazing Book";
            mPrice = 1.5;
            mOrderId = 1;
            mDispatched = true;
            return true;
        }
    }
}