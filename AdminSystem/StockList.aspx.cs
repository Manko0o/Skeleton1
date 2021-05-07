using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
       
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayStocks();
            }
        }
    }

    void DisplayStocks()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(Convert.ToInt32(ProductID));
        
        lstStocks.DataSource = Stock.StockList;
        lstStocks.DataValueField = "ProductID";
        lstStocks.DataTextField = "BookName";
        lstStocks.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        if (lstStocks.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstStocks.SelectedValue);
            Session["ProductID"] = ProductId;
            Response.Redirect("StockDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record, so that it can be edited from the list";
        }
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        if (lstStocks.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstStocks.SelectedValue);
            Session["ProductID"] = ProductId;
            Response.Redirect("DeleteStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        Session["ProductId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void lstStocks_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportbyBookName(txtFilter.Text);
        lstStocks.DataSource = Stocks.StockList;
        lstStocks.DataValueField = "ProductId";
        lstStocks.DataTextField = "BookName";
        lstStocks.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportbyBookName("");
        txtFilter.Text = "";
        lstStocks.DataSource = Stocks.StockList;
        lstStocks.DataValueField = "ProductId";
        lstStocks.DataTextField = "BookName";
        lstStocks.DataBind();


    }
}



