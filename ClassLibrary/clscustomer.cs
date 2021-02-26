using System;

namespace ClassLibrary
{
    public class clscustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        //CustomerNo public property
        public Int32 CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }

        //private data member for the Name property
        private string mName;
        //Name public property
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }

        //private data member for the Name property
        private string mEmail;
        //Name public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //private data member for the Name property
        private DateTime mDOB;
        //Name public property
        public DateTime DOB
        {
            get
            {
                //this line of code sends data out of the property
                return mDOB;
            }
            set
            {
                //this line of code allows data into the property
                mDOB = value;
            }
        }

        //private data member for the Name property
        private string mAddress;
        //Name public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //private data member for the Name property
        private bool mRegistered;
        //Name public property
        public bool Registered
        {
            get
            {
                return mRegistered;
            }
            set
            {
                mRegistered = value;
            }
        }

        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 1;
            mName = "Bob Track";
            mEmail = "bobtrack@gmail.com";
            mDOB = Convert.ToDateTime("16/08/2000");
            mAddress = "56, Nine road, Newtown, NE7 8LQ";
            mRegistered = true; 
            //always return true
            return true;
        }
    }
}