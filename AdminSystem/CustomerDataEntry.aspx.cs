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
        Acustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        Acustomer.Name = txtName.Text;
        Acustomer.Email = txtEmail.Text;
        Acustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        Acustomer.Address = txtEmail.Text;


        //store the name in the session object
        Session["Acustomer"] = Acustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}