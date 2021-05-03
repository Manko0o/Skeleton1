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
        clsStaff AStaff = new clsStaff();
        //capture the name

        string StaffID = txtStaffID.Text;
        string Name = txtName.Text;
        string Surname = txtSurname.Text;
        string DateofBirth = txtDob.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Error = "";
        Error = AStaff.Valid(Name, Surname, DateofBirth, PhoneNumber);

        if (Error == "")
        {
            AStaff.StaffID = Convert.ToInt32(StaffID);
            AStaff.Name = Name;
            AStaff.Surname = Surname;
            AStaff.DateofBirth = Convert.ToDateTime(DateofBirth);
            AStaff.PhoneNumber = PhoneNumber;
            AStaff.Availability = chkAvailability.Checked;
            //store the name in the session object
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AStaff;
            StaffList.Add();
            //navigate to the viewer page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    protected void txtDob_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffID_TextChanged(object sender, EventArgs e)
    {

    }
}