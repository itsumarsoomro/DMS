using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnHolidays : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 EmpID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the Employee to be processed
        EmpID = Convert.ToInt32(Session["EmpID"]);
        if (IsPostBack == false)
        {
            //populate  the list of holidays

            //if this is not a new record
            if (EmpID != -1)
            {
                DisplayHolidays();
            }
        }
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the holidays
        DmsClasses.clsHolidaysCollection HolidayBook = new DmsClasses.clsHolidaysCollection();
        //validate the data on the web form
        String Error = HolidayBook.ThisHolidays.Valid(txtName.Text, txtDepartment.Text, txtReason.Text, txtStartdate.Text, txtEndate.Text );
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            HolidayBook.ThisHolidays.EmpName = txtName.Text;
            HolidayBook.ThisHolidays.EmpDepart = txtDepartment.Text;
            HolidayBook.ThisHolidays.Reason = txtReason.Text;
            HolidayBook.ThisHolidays.StartDate = Convert.ToDateTime(txtStartdate);
            HolidayBook.ThisHolidays.EndDate = Convert.ToDateTime(txtEndate);
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

    //function for updating records
    void Update()
    {
        //create an instance of the holiday book
        DmsClasses.clsHolidaysCollection HolidaysBook = new DmsClasses.clsHolidaysCollection();
        //validate the data on the web form
        String Error = HolidaysBook.ThisHolidays.Valid(txtName.Text, txtDepartment.Text, txtReason.Text, txtStartdate.Text, txtEndate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            HolidaysBook.ThisHolidays.Find(EmpID);
            //get the data entered by the user
            HolidaysBook.ThisHolidays.EmpName = txtName.Text;
            HolidaysBook.ThisHolidays.EmpDepart = txtDepartment.Text;
            HolidaysBook.ThisHolidays.Reason = txtReason.Text;
            HolidaysBook.ThisHolidays.StartDate = Convert.ToDateTime(txtStartdate.Text);
            HolidaysBook.ThisHolidays.EndDate = Convert.ToDateTime(txtEndate.Text);
            //update the record
            HolidaysBook.Update();
            //all done so redirect back to main page
            Response.Redirect("HolidaysDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    private void DisplayHolidays()
    {
        //create an instance of the holiday book
        clsHolidaysCollection HolidaysBook = new clsHolidaysCollection();
        //find the record to update
        HolidaysBook.ThisHolidays.Find(EmpID);
        //display the data for this record
        txtName.Text = HolidaysBook.ThisHolidays.EmpName;
        txtDepartment.Text = HolidaysBook.ThisHolidays.EmpDepart;
        txtReason.Text = HolidaysBook.ThisHolidays.Reason;
        txtStartdate.Text = HolidaysBook.ThisHolidays.StartDate.ToString();
        txtEndate.Text = HolidaysBook.ThisHolidays.EndDate.ToString();      
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (EmpID == -1)
        {
            //add the new record
            Add();
            //all done so redirect back to main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //update the record
            Update();
        }
      

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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("HolidaysDefault.aspx");
    }
}