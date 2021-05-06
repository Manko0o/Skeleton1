using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {

        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            if (OrderNo != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNo);
        txtOrderNo.Text = OrderBook.ThisOrder.OrderNo.ToString();
        txtBookName.Text = OrderBook.ThisOrder.BookName;
        txtQuantity.Text = OrderBook.ThisOrder.Quantity.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtPrice.Text = OrderBook.ThisOrder.Price.ToString();
        chkDispatched.Checked = OrderBook.ThisOrder.Dispatched;

    }



    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string BookName = txtBookName.Text;
        string Quantity = txtQuantity.Text;
        string OrderDate = txtOrderDate.Text;
        string Price = txtPrice.Text;
        string Error = "";
        Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
        if (Error == "")

        {

            AnOrder.OrderNo = OrderNo;
            AnOrder.BookName = BookName;
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.Price = Convert.ToInt32(Price);
            AnOrder.Dispatched = chkDispatched.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderNo == -1)
            {

                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }


            else
            {

                OrderList.ThisOrder.Find(Convert.ToInt32(OrderNo));
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();

            }
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            lblError.Text = "Invalid";
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







    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}
