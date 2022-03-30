using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class TaskViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsTask
        clsTask AnDMS = new clsTask();
        //get the data from the session object
        AnDMS = (clsTask)Session["AnDMS"];
        //display the Task ID for this entry
        Response.Write(AnDMS.TaskID);
    }
}