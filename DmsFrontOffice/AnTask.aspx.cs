using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnTask : System.Web.UI.Page
{
    public int TaskID { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Task to be processed
        TaskID = Convert.ToInt32(Session["TaskID"]);
        if (IsPostBack == false)
        {
            //populate the list of counties
            DisplayTask();
            //if this isn not a new record
            if (TaskID != -1)
            {
                //display the current data for the record
                DisplayTask();
            }
        }
    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
       if (TaskID == -1)
        {
            //Add the new record
            Add();
        }
       else
        {
            //update the record
            Update();
        }
    }
        

        

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the Task class
        clsTask AnDMS = new clsTask();
        //variable to store the primary key
        Int32 TaskID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key enetred by the user
        TaskID = Convert.ToInt32(TextBoxTaskID.Text);
        //find the record
        Found = AnDMS.Find(TaskID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            TextBoxTaskName.Text = AnDMS.TaskName;

        }
       
    }
    void Add()
    {
        //Create an insstance of the Task
        DmsClasses.clsTaskCollection Task = new DmsClasses.clsTaskCollection();
        //validate the data on the web form
        String Error = Task.ThisTask.Valid(TextBoxTaskName.Text);
        //if the data is ok then add it to the obejct
        if (Error == "")
        {
            //get the data enetred by the user
            Task.ThisTask.TaskName = TextBoxTaskName.Text;
            //add the record
            Task.Add();
        }
        else
        {
            //report an error
            LabelError.Text = " The Data you entred is not correct" + Error;
        }

       
        

    }

    void Update()
    {
        // Create an insstance of the Task
        DmsClasses.clsTaskCollection Task = new DmsClasses.clsTaskCollection();
        //validate the data on the web form
        String Error = Task.ThisTask.Valid(TextBoxTaskName.Text);
        //if the data is ok then add it to the obejct
        if (Error == "")
        {

            //get the data enetred by the user
            Task.ThisTask.TaskName = TextBoxTaskName.Text;
            //add the record
            Task.Update();
        }
        else
        {
            // report an error
            LabelError.Text = " The Data you entred is not correct" + Error;
        }


    }
    void DisplayTask()
    {
        //create an instance of the Task
        clsTaskCollection Task = new clsTaskCollection();
        //find the record to update
        Task.ThisTask.Find(TaskID);
        //display the data for this record
        TextBoxTaskID.Text = Task.ThisTask.TaskName;


    }
}