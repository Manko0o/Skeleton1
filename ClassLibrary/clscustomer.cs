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

        public bool Find(int CustomerNo)
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

        //function for the public validation method
        public string Valid(string Name, string Email, string DOB, string Address)
        {
            String Error = "";
            DateTime DateTemp;

            if (Name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }

            if (Name.Length > 50)
            {
                //record the error
                Error = Error + "The Name must be less than 50 Characters : ";
            }

            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }

            if (Email.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 Characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DOB);
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

            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The address should not be blank : ";
            }

            if (Address.Length > 60)
            {
                //record the error
                Error = Error + "The address must be less than 60 Characters : ";
            }

            

            return Error;

        }

    }
}