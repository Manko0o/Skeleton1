using System;

namespace ClassLibrary
{

    public class clsStock
    {
        private Int32 mProductID;
        private string mBookName;
        private string mAuthorName;
        private bool mAvailable;
        private double mPrice;
        private DateTime mPublishDate;


        public Int32 ProductID
        {
            get
            {
                //Sends data out of the property
                return mProductID;
            }
            set
            {
                //Allows data into the property
                mProductID = value;
            }
        }
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
        public string AuthorName
        {
            get
            {
                return mAuthorName;
            }
            set
            {
                mAuthorName = value;
            }
        }
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
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

        public DateTime PublishDate
        {
            get
            {
                return mPublishDate;
            }
            set
            {
                mPublishDate = value;
            }
        }




        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblStockManagement_FilterByProductID");
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mBookName = Convert.ToString(DB.DataTable.Rows[0]["BookName"]); 
                mAuthorName = Convert.ToString(DB.DataTable.Rows[0]["AuthorName"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mPrice =  Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mPublishDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PublishDate"]);
                //always return true
                return true;
                //throw new NotImplementedException();
            }
            else
            {
                return false;
            }

        }
    
        public string Valid(string bookName, string authorName, string price, string publishDate)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            double PriceTemp;
            //if the BookName is blank 
            if (bookName.Length == 0)
            {
                //record the error
                Error = Error + "The BookName should not be blank : ";
            }
            //if the Bookname is greater than 20 characters 
            if (bookName.Length > 50 )
            {
                //record the error
                Error = Error + "The BookName must be less than 50 Characters : ";
            }
            if (authorName.Length == 0)
            {
                //record the error
                Error = Error + "The AuthorName should not be blank : ";
            }
            //if the Bookname is greater than 20 characters 
            if (authorName.Length > 50)
            {
                //record the error
                Error = Error + "The AuthorName must be less than 50 Characters : ";
            }
            //copy the dateAdded value to the DateTemp varaible
            try
            {
                DateTemp = Convert.ToDateTime(publishDate);
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }

            try
            {
                PriceTemp = Convert.ToDouble(price);
                if (PriceTemp < 0)
                {
                    //record error
                    Error = Error + "The price cannot be negative : ";
                }
                //check to see if the date is greater than today's date
            }
            catch
            {
                //record the error
                Error = Error + "The price was not valid : ";
            }
            //return any error messages

            return Error;
        }
        
    }
}
