using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnHolidays : System.Web.UI.Page
{
    //function for adding new records
    void Add()
    {
        //create an instance of the holidays
        clsHolidaysCollection HolidayBook = new clsHolidaysCollection();
        //validate the data on the web form
        String Error = HolidayBook.ThisHoliday.Valid(txtName.Text, txtDepartment.Text, txtReason.Text, txtStartdate.Text, txtEndate.Text );
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            HolidayBook.ThisHoliday.EmpName = txtName.Text;
            HolidayBook.ThisHoliday.EmpDepart = txtDepartment.Text;
            HolidayBook.ThisHoliday.Reason = txtReason.Text;
            HolidayBook.ThisHoliday.StartDate = Convert.ToDateTime(txtStartdate);
            HolidayBook.ThisHoliday.EndDate = Convert.ToDateTime(txtEndate);
            //add the record
            HolidayBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("HolidaysDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect back to main page
        Response.Redirect("Default.aspx");
        ////create a new instance of clsHolidays
        //clsHolidays AnHolidays = new clsHolidays();
        ////capture the Emp Name
        //string EmpName = txtName.Text;
        ////capture the Employee department
        //string EmpDepart = txtDepartment.Text;
        ////capture the reason
        //string Reason = txtReason.Text;
        ////capture the start date
        //string StartDate = txtStartdate.Text;
        ////capture the end date
        //string EndDate = txtEndate.Text;

        ////varaiable to store any error message
        //string Error = "";

        //Error = AnHolidays.Valid(EmpName, EmpDepart, Reason, StartDate, EndDate);
        
        //if (Error == "")
        //{
        //    //capture the employee name 
        //    AnHolidays.EmpName = EmpName;
        //    //capture the employee department
        //    AnHolidays.EmpDepart = EmpDepart;
        //    //capture the reason
        //    AnHolidays.Reason = Reason;
        //    //capture the start date 
        //    AnHolidays.StartDate = Convert.ToDateTime(StartDate);
        //    //capture the end date
        //    AnHolidays.EndDate = Convert.ToDateTime(EndDate);

        //    //stpre the holiday in session object
        //    Session["AnHolidays"] = AnHolidays;
        //    //redirect to the viewer page
        //    Response.Redirect("HolidaysViewer.aspx");

        //}
      
        //else
        //{
        //    //display the error message
        //    lblError.Text = Error;
        //}

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
        //if not found

        else
        {
            //return error message
            lblError.Text = "This Employee ID does not exist please try again later.";
        }
    }
}