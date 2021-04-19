﻿using System;
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

        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.BookName = txtBookName.Text;
        AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.Price = Convert.ToDouble(txtPrice.Text);
        
     
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void txtOrderNo_TextChanged(object sender, EventArgs e)
    {

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
          //  txtOrderNo.Text = AnOrder.OrderNo;
            txtBookName.Text = AnOrder.BookName;
           // txtQuantity.Text = AnOrder.Quantity;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
           // txtPrice.Text = AnOrder.Price;


        }
    }
}