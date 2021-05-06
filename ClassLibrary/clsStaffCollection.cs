using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
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
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
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

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaffManagement_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateofBirth);
            DB.AddParameter("@Availability", mThisStaff.Availability);

            return DB.Execute("sproc_tblStaffManagement_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateofBirth);
            DB.AddParameter("@Availability", mThisStaff.Availability);

            DB.Execute("sproc_tblStaffManagement_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", mThisStaff.StaffID);


            DB.Execute("sproc_tblStaffManagement_Delete");
        }

        public void ReportBySurname(String Surname)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Surname", Surname);
            DB.Execute("sproc_tblStaffManagement_FilterbySurname");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount; ;

            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();

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