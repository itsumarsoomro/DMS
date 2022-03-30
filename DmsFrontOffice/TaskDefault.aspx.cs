using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TaskDefault : System.Web.UI.Page
{
    //this function the load event for page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Upadate the list box
            DisplayTask();
        }
    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the seesion object to indicate this is a new record
        Session["TaskID"] = -1;
        //redirect to the data enrty page
        Response.Redirect("AnTask.aspx");
    }

    void DisplayTask()
    {
        //create an instance of the county Collection
        DmsClasses.clsTaskCollection Tasks = new DmsClasses.clsTaskCollection();
        //set the data source to the list of Task in the collection
        ListBoxTask.DataSource = Tasks.TaskList;
        //set the name of the primary key
        ListBoxTask.DataValueField = "TaskID";
        //set the data field to display
        ListBoxTask.DataTextField = "TaskName";
        //bind the data to the list
        ListBoxTask.DataBind();
    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 TaskID;
        //if a record has been selected from the list
        if (ListBoxTask.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            TaskID = Convert.ToInt32(ListBoxTask.SelectedValue);
            //store the data session object
            Session["TaskID"] = TaskID;
            //redirect to the delete page
            Response.Redirect("TaskDelete.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            LabelError.Text = "Please select a record to delete from the list";
        }

    }

    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 TaskID;
        //if a record has been selected from the list
        if (ListBoxTask.SelectedIndex != -1)
        {
            //get the primarym key value of the record to edit
            TaskID = Convert.ToInt32(ListBoxTask.SelectedValue);
            //store the data in the session object
            Session["TaskID"] = TaskID;
            //redirect to the edit page
            Response.Redirect("AnTask.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            LabelError.Text = "Please select a record to delete from the list";
        }


    }
    

    }