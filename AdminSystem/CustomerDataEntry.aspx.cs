using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clscustomer
        clscustomer Acustomer = new clscustomer();
        //capture the details
        string CustomerNo = txtCustomerNo.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string DOB = txtDOB.Text;
        string Address = txtAddress.Text;
        string Error = "";
        Error = Acustomer.Valid(Name, Email, DOB, Address);
        if (Error == "")
        {
            Acustomer.CustomerNo = Convert.ToInt32(CustomerNo);
            Acustomer.Name = Name;
            Acustomer.Email = Email;
            Acustomer.DOB = Convert.ToDateTime(DOB);
            Acustomer.Address = Address;
            Acustomer.Registered = chkRegistered.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = Acustomer;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblerror.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //created an instance of the customer class
        clscustomer Acustomer = new clscustomer();
        //variable to store the primary key
        Int32 CustomerNo;
        //variable to tore the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //find the record
        Found = Acustomer.Find(CustomerNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = Acustomer.Name;
            txtEmail.Text = Acustomer.Email;
            txtDOB.Text = Acustomer.DOB.ToString();
            txtAddress.Text = Acustomer.Address; 
        }
    }
}