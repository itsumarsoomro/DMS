using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class HolidaysViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsHolidays
        clsHolidays AnHolidays = new clsHolidays();
        //get the data from the session object
        AnHolidays = (clsHolidays)Session["AnHolidays"];
        //display the Employee name for this entry
        Response.Write(AnHolidays.EmpName);
    }
}