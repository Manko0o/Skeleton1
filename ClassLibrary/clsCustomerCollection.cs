using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        List<clscustomer> mCustomerList = new List<clscustomer>();
        clscustomer mThisCustomer = new clscustomer();
        public List<clscustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clscustomer ThisCustomer { get; set; }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clscustomer Acustomer = new clscustomer();
                Acustomer.Registered = Convert.ToBoolean(DB.DataTable.Rows[Index]["True"]);
                Acustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                Acustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Acustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Acustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Acustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);

                mCustomerList.Add(Acustomer);

                Index++;
            }

        }
    }

}
