using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnDMS = new clsStaff();
        //capture the name
        string StaffName = txtStaffName.Text;
        string Password = txtPassword.Text;
        string StaffID = txtStaffID.Text;
        string Address = txtAddress.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnDMS.Valid(StaffName, Password, StaffID, Address);
        if (Error == "")



        {
            //capture the name
            AnDMS.StaffName = txtStaffName.Text;
            //capture the password
            AnDMS.Password = txtPassword.Text;
            //capture the staffID
            AnDMS.StaffID = txtStaffID.Text;
            //capture the Address
            AnDMS.Address = txtAddress.Text;

            Session["AnStaff"] = AnDMS;
            //Redirect to the viewer page 
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
       
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ///create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the findn operation
        Boolean Found=false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Found = AnStaff.Find(StaffNo);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = AnStaff.Address;
            txtStaffName.Text = AnStaff.StaffName;
            txtStaffID.Text = AnStaff.StaffID;
           
            txtPassword.Text = AnStaff.Password;


        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}

