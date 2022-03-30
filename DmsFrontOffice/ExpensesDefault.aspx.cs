using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExpensesDefault : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first timethe page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayExpenses();
        }
    }

    void DisplayExpenses()
    {
    //create an instance of the expenses collection
    DmsClasses.clsExpensesCollection Expenses = new DmsClasses.clsExpensesCollection();
    //set the data source to the list of utilities in the collection
    lstCategory.DataSource = Expenses.ExpensesList;
    //set the name of the primary key
    lstCategory.DataValueField = "ExpensesNo";
    //set the data field to display
    lstCategory.DataTextField = "Category";
    //bind the data to the list
    lstCategory.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ExpensesNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnExpenses.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ExpensesNo;
        //if a record has been selected from the list
        if (lstCategory.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ExpensesNo = Convert.ToInt32(lstCategory.SelectedValue);
            //store the data in the session object
            Session["ExpensesNo"] = ExpensesNo;
            //redirect to the delete page
            Response.Redirect("ExpensesDelete.aspx");
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
        Int32 ExpensesNo;
        //if a record has been selected from the list
        if (lstCategory.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ExpensesNo = Convert.ToInt32(lstCategory.SelectedValue);
            //store the data in the session object
            Session["AddressNo"] = ExpensesNo;
            //redirect to the edit page
            Response.Redirect("AnExpenses.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}