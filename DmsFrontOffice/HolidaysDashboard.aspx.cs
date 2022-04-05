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
            lblError.Visible = true;
            //display an error
            lblError.Text = "Please select a record to Delete from the list!!!";

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
            lblError.Visible = true;
            //display an error
            lblError.Text = "Please select a holiday record to Edit from the list!!!";
        }
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HolidaysPositions.aspx");
    }

 

    protected void btnApplyAll_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayHolidays(txtboxEmpID.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    private int DisplayHolidays(string ReasonFilter)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsHolidaysCollection HolidaysList = new clsHolidaysCollection();
        //var to store the count of records
        Int32 RecordCount;

        //var to store the house no
        string EmpID;
        string EmpName;
        string EmpDepart;
        //var to store the street name
        string Reason;
        //var to store the primary key value
        string StartDate;
        string EnDate;
    

        //var to store the index
        // string StockID;
        Int32 Index = 0;
        //clear the list of any existing items
        lstHolidays.Items.Clear();


        //call the filter by LocationFilter method
        HolidaysList.ReportByReason(ReasonFilter);
        //get the count of records found
        RecordCount = HolidaysList.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            EmpID = Convert.ToString(HolidaysList.HolidaysList[Index].EmpID);
            //get the house no from the query results
            EmpName = Convert.ToString(HolidaysList.HolidaysList[Index].EmpName);
            //get the street from the query results
            EmpDepart = Convert.ToString(HolidaysList.HolidaysList[Index].EmpDepart);
            Reason = Convert.ToString(HolidaysList.HolidaysList[Index].Reason);
            StartDate = Convert.ToString(HolidaysList.HolidaysList[Index].StartDate);
            EnDate = Convert.ToString(HolidaysList.HolidaysList[Index].EndDate);


            //set up a new object of class list item 

            ListItem NewItem = new ListItem( "EmpID: "+ EmpID +" | " + "EmpName: " + EmpName + " |" + " EmpDepart: " + EmpDepart + " |" + " Reason: " + Reason + " |" + " StartDAte: " + StartDate + " |" + " EndDate: " + EnDate);

            //add the new item to the list

            lstHolidays.Items.Add(NewItem);

            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void lstHolidays_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}