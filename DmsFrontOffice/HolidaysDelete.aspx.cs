using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class HolidaysDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 EmpID;

    //event handle for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the holiday to be deleted from the session object
        EmpID = Convert.ToInt32(Session["EmpID"]);
    }

    void DeleteHoliday()
    {
        //fucntion to delete the selected record
        clsHolidaysCollection HolidayBook = new clsHolidaysCollection();
        //find the record to delete
        HolidayBook.ThisHolidays.Find(EmpID);
        //delete the record
        HolidayBook.Delete();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteHoliday();
        //redirect back to the main page
        Response.Redirect("HolidaysDashboard.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("HolidaysDashboard.aspx");
    }
}