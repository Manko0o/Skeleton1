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
        //create a new  instance of clsStaff
        clsStaff AStaff = new clsStaff
        {
            //capture the name
            StaffID = Convert.ToInt32(txtStaffID.Text),
            Name = txtName.Text,
            Surname = txtSurname.Text,
            DateofBirth = Convert.ToDateTime(txtDob.Text),
            PhoneNumber = txtPhoneNumber.Text,
        };

        //store the name in the session object
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();

        Int32 StaffID;

        Boolean Found = false;

        StaffID = Convert.ToInt32(txtStaffID.Text);

        Found = AStaff.Find(StaffID);

        if (Found == true)
        {
            txtName.Text = AStaff.Name;
            txtSurname.Text = AStaff.Surname;
            txtPhoneNumber.Text = AStaff.PhoneNumber;
            txtDob.Text = AStaff.DateofBirth.ToString();
        }
    }
}