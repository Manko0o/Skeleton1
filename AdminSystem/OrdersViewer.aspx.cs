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
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order ID on the page
        Response.Write(AnOrder.OrderNo);
        Response.Write(AnOrder.BookName);
        Response.Write(AnOrder.Quantity);
        Response.Write(AnOrder.OrderDate);
        Response.Write(AnOrder.Price);
        Response.Write(AnOrder.Dispatched);


    }
}