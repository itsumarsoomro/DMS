using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TaskDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 TaskID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Task to be delelted from the session object
        TaskID = Convert.ToInt32(Session["TaskID"]);
    }
    void DeleteTask()
    {
        //function to delete the selected record

        //Create a new instance of the Task Book
        clsTaskCollection Task = new clsTaskCollection();
        //find the record to delete
        Task.ThisTask.Find(TaskID);
        //delete the record
        Task.Delete();
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteTask();
        //redirect back to the main page
        Response.Redirect("TaskDefault.aspx");
    }
}