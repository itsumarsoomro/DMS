using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnHolidays : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsHolidays
        clsHolidays AnHolidays = new clsHolidays();
        //capture the Emp Name
        AnHolidays.EmpName = txtName.Text;
        //store the Id in the session object
        Session["AnHolidays"] = AnHolidays;
        //redirect to the viewer page
        Response.Redirect("HolidaysViewer.aspx");

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a instance of new class
        clsHolidays AnHolidays = new clsHolidays();
        //varaible to store the primary key
        Int32 EmpID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        EmpID = Convert.ToInt32(txtId.Text);
        //find the record
        Found = AnHolidays.Find(EmpID);
        //if found true
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AnHolidays.EmpName;
            txtDepartment.Text = AnHolidays.EmpDepart;
            txtReason.Text = AnHolidays.Reason;
            txtStartdate.Text = AnHolidays.StartDate.ToString();
            txtEndate.Text = AnHolidays.EndDate.ToString();
        }

    }
}