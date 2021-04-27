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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }

    }
    void DisplayStocks()
    {
        //create an instance of the Country Collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to the list of countries in the collection
        lstStocks.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStocks.DataValueField = "ProductId";
        lstStocks.DataTextField = "BookName";
        lstStocks.DataBind();
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }
}
