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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mRegistered = Convert.ToBoolean(DB.DataTable.Rows[0]["Registered"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}