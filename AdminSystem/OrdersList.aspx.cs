using System;
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
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrder.DataSource = Orders.OrderList;
        lstOrder.DataValueField = "OrderNo";
        lstOrder.DataTextField = "BookName";
        lstOrder.DataBind();
    }






    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrdersDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record, so that it can be edited from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("DeleteOrder.aspx");

        }
        else
        {
            lblError.Text = "Please select a record, which you want to delete from the list";
        }
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("DeleteOrder.aspx");

        }
        else
        {
            lblError.Text = "Please select a record, which you want to delete from the list";
        }
    }
}
