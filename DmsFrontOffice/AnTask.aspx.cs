using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnTask : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsTask
        clsTask AnDMS = new clsTask();
        //capture the Task ID
        AnDMS.TaskID = Convert.ToInt32(TextBoxTaskID.Text);
        //store the task in the session object
        Session["AnDMS"] = AnDMS;
        //redirect to the viewer page
        Response.Redirect("AnDMSViewer.aspx");

    }
}