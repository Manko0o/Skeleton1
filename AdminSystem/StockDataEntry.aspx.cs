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

        AStock.ProductId = int.Parse(txtProductID.Text);
        AStock.BookName = txtBookName.Text;
        AStock.AuthorName = txtAuthorName.Text;
        AStock.Price = float.Parse(txtPrice.Text);
        AStock.Type = txtType.Text;
      //  AStock.Available = bool.Parse(chkAvailable.Text);

        Session["AStock"] = AStock;

        // navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}