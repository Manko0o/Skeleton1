﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnDeleteYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffID);
        StaffBook.Delete();
        Response.Redirect("StaffList.aspx");
    }


    protected void btnDeleteNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}