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
}