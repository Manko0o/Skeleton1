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
            DB.Execute("sproc_tblStock_FilterByProductID");
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
            return"";
        }
    }
}
