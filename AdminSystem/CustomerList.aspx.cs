﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerNo"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByName(txtFilter.Text);
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByName("");
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();
    }
}