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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
    
        string OrderNo = txtOrderNo.Text;
        string BookName = txtBookName.Text;
        string Quantity = txtQuantity.Text;
        string OrderDate = txtOrderDate.Text;
        string Price = txtPrice.Text;
        string Error = "";
        Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
        if (Error == "")

        {
            AnOrder.OrderNo = Convert.ToInt32(OrderNo);
            AnOrder.BookName = BookName;
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.Price = Convert.ToInt32(Price);
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {

        }
        {
            lblError.Text = Error;




        }
    }


      
        
 

protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AnOrder.Find(OrderNo);
        if (Found == true)
        {
            txtBookName.Text = AnOrder.BookName;
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtPrice.Text = AnOrder.Price.ToString();
        }
}

protected void txtOrderNo_TextChanged(object sender, EventArgs e)
    {

    }





    
}
