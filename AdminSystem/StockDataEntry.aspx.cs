using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    /*Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if(ProductID != -1)
            {
                DisplayStocks();
            }
        }
    }
    
    void DisplayStocks()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(ProductID);
        txtProductID.Text = Stock.ThisStock.ProductID.ToString();
        txtBookName.Text = Stock.ThisStock.BookName;
        txtAuthorName.Text = Stock.ThisStock.AuthorName;
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        txtPublishedDate.Text = Stock.ThisStock.PublishDate.ToString();
    }
    */
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the product Id
        string ProductID = txtProductID.Text;
        //capture the bookname
        string BookName = txtBookName.Text.TrimEnd();
        //capture the author name
        string AuthorName = txtAuthorName.Text.TrimEnd();
        //capture the price
        string Price = txtPrice.Text;
        //capture the publish date
        string PublishDate = txtPublishedDate.Text;
        //variable to store any error messages
        string Error = "";
        //validate the error
        Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
        if (Error == "")
        {
            //capture the product Id
            AStock.ProductID = Convert.ToInt32(ProductID);
            //capture the bookname
            AStock.BookName = BookName;
            //capture the author name
            AStock.AuthorName = AuthorName;
            //capture the price
            AStock.Price = Convert.ToDouble(Price);
            //capture the publish date
            AStock.PublishDate = Convert.ToDateTime(PublishDate);
            AStock.Available = chkAvailable.Checked;
            clsStockCollection StockList = new clsStockCollection();
           StockList.ThisStock = AStock;
            StockList.Add();
            Response.Redirect("StockList.aspx"); 

           /* if (ProductID == -1)
            {
                StockList.ThisStock = AStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(ProductID);
                StockList.ThisStock = AStock;
                StockList.Update();
            }
            
            Response.Redirect("StockList.aspx");*/

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //created an instance of the address class
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 ProductID;
        //variable to tore the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductID = Convert.ToInt32(txtProductID.Text);
        //find the record
        Found = AStock.Find(ProductID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtBookName.Text = AStock.BookName.TrimEnd();
            txtAuthorName.Text = AStock.AuthorName.TrimEnd();
            txtPrice.Text = AStock.Price.ToString();
            txtPublishedDate.Text = AStock.PublishDate.ToString();
            
        }


    }
}