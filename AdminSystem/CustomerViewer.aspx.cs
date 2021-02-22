using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clscustomer Acustomer = new clscustomer();
        //get the data from the session object
        Acustomer = (clscustomer)Session["Acustomer"];
        //display the name on the page
        Response.Write(Acustomer.CustomerNo);
        Response.Write(Acustomer.Name);
        Response.Write(Acustomer.Email);
        Response.Write(Acustomer.DOB);
        Response.Write(Acustomer.Address);

    }
}