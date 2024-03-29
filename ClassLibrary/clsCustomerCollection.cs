﻿using System;
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
        public clscustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public clsCustomerCollection()
        {
            //Int32 Index = 0;
            //Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);

            //while (Index < RecordCount)
            //{
            //    clscustomer Acustomer = new clscustomer();
            //    Acustomer.Registered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Registered"]);
            //    Acustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
            //    Acustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
            //    Acustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
            //    Acustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
            //    Acustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);

            //    mCustomerList.Add(Acustomer);

            //    Index++;
            //}

        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DOB", mThisCustomer.DOB);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Registered", mThisCustomer.Registered);
            //execute the querry returnining the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DOB", mThisCustomer.DOB);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Registered", mThisCustomer.Registered);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Name", Name);
            DB.Execute("sproc_tblCustomer_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clscustomer>();
            while (Index < RecordCount)
            {
                clscustomer Acustomer = new clscustomer();
                Acustomer.Registered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Registered"]);
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