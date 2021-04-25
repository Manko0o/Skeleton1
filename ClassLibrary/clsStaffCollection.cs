using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public clsStaff ThisStaff { get; set; }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaffManagement_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AStaff.DateofBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);

                mStaffList.Add(AStaff);

                Index++;
            }

        }
    }
}