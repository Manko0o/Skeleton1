﻿using System;

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

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", StaffID);

            DB.Execute("sproc_tblStaffManagement_FilterByStaffID");

            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDateofBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateofBirth"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        private Int32 mStaffID;
        private string mName;
        private DateTime mDateofBirth;
        private string mSurname;
        private string mPhoneNumber;
        private bool mAvailability;
    }
}