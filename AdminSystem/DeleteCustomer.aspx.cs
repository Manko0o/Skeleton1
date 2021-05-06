using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsCustomerCollection Customer = new ClassLibrary.clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerNo);
        Customer.Delete();
        Response.Redirect("CustomerList.aspx");
    }
}