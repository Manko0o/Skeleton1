using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public string Surname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }

        public DateTime DateofBirth
        {
            get
            {
                return mDateofBirth;
            }
            set
            {
                mDateofBirth = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public bool Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }
        }


        public bool Find(int staffID)
        {
            //set the private data members to the test data value
            mStaffID = 123456;
            mName = "Josh";
            mSurname = "Smith";
            mDateofBirth = Convert.ToDateTime("13/07/2003");
            mPhoneNumber = "+447111111111";
            mAvailability = true;
            //always return true
            return true;
        }

        private Int32 mStaffID;
        private string mName;
        private DateTime mDateofBirth;
        private string mSurname;
        private string mPhoneNumber;
        private bool mAvailability;
    }
}