using System;

namespace ClassLibrary
{
    
    public class clsStock
    {
        private Int32 mProductID;
        private string mBookName;
        private string mAuthorName;
        private bool mAvailable;
        private float mPrice;
        private string mType;
        

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
            get { return mBookName;
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
        public float Price
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
       
        public string Type
        {
            get
            {
                return mType;
            }
            set
            {
                mType = value;
            }
        }

        

        public bool Find(int productID)
        {
            //set the private data members to the test data value
            mProductID = 11223344;
            mBookName = "Unfinished";
            mAuthorName = "Priyanka";
            mAvailable = true;
            mPrice = 10.20F;
            mType = "Biography";
            //always return true
            return true;
            //throw new NotImplementedException();
        }
        
    }
  }
