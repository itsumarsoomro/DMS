using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class HolidaysDefault : System.Web.UI.Page
{
    //variable to store the primary key wtih page level scope
    //Int32 EmpID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the ID of the Employee to be processed
        //EmpID = Convert.ToInt32(Session["EmpID"]);
        if (IsPostBack == false)
        {
            //populate  the list of holidays
            DisplayHolidays();
        }
    }

    private void DisplayHolidays()
    {
        //create an instance of the holiday collection
        DmsClasses.clsHolidaysCollection HolidaysBook = new DmsClasses.clsHolidaysCollection();
        //set the data source of the list of the holidays in the collection
        lstHolidays.DataSource = HolidaysBook.HolidaysList;
        //set the name of the primary key
        lstHolidays.DataValueField = "EmpID";
        //set the data field to display
        lstHolidays.DataTextField = "EmpName";        
        //bind the data to the list
        lstHolidays.DataBind();
    }



    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["EmpID"] = -1;
        //redirect to the data entry oage
        Response.Redirect("AnHolidays.aspx");
    }
    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 EmpID;
        //if a record has been selected from list
        if (lstHolidays.SelectedIndex != -1)
        {
            //get the primary key of the record to delete
            EmpID = Convert.ToInt32(lstHolidays.SelectedValue);
            //store the data in the session object
            Session["EmpID"] = EmpID;
            //redirect to the delete page
            Response.Redirect("HolidaysDelete.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";

        }
    }
    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 EmpID;
        //if a record has been selected from the list
        if (lstHolidays.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            EmpID = Convert.ToInt32(lstHolidays.SelectedValue);
            //store the data in the session object
            Session["EmpID"] = EmpID;
            //redirect to the edit page
            Response.Redirect("AnHolidays.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a holiday record to Edit from the list";
        }
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}