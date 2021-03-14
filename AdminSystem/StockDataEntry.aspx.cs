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

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStock AStock = new clsStock();

        AStock.ProductID = Convert.ToInt32(txtProductID.Text);
        AStock.BookName = txtBookName.Text;
        AStock.AuthorName = txtAuthorName.Text;
        AStock.Price = Convert.ToDouble(txtPrice.Text);
        AStock.PublishDate = Convert.ToDateTime("09/02/2021");
        //  AStock.Available = bool.Parse(chkAvailable.Text);

        Session["AStock"] = AStock;

        // navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
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
            txtBookName.Text = AStock.BookName;
            txtAuthorName.Text = AStock.AuthorName;
            txtPrice.Text = AStock.Price.ToString();
            txtPublishedDate.Text = AStock.PublishDate.ToString();
        }


    }
}