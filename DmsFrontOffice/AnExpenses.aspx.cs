using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class AnExpenses : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ExpensesNo;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the expenses to be processed
        ExpensesNo = Convert.ToInt32(Session["ExpensesNo"]);
        if (IsPostBack == false)
        {
            //populate the list of utilities
            //DisplayUtilities();
            //if this is not a new record
            if (ExpensesNo != -1)
            {
                //display the current data for the new record
                DisplayExpenses();
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (ExpensesNo == -1)
        {
            //add the new record
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
        //create a instance of new class
        clsExpenses AnExpenses = new clsExpenses();
        //varaible to store the primary key
        Int32 ExpensesNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ExpensesNo = Convert.ToInt32(txtExpensesNo.Text);
        //find the record
        Found = AnExpenses.Find(ExpensesNo);
        //if found true
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AnExpenses.Name;
            txtCategory.Text = AnExpenses.Category;
            txtExpenses.Text = AnExpenses.Expenses.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExpensesDefault.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an insatcne of the expenses book
        DmsClasses.clsExpensesCollection ExpensesBook = new DmsClasses.clsExpensesCollection();
        //validate the data on the web form
        String Error = ExpensesBook.ThisExpenses.Valid(txtName.Text, txtCategory.Text, txtExpenses.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            ExpensesBook.ThisExpenses.Name = txtName.Text;
            ExpensesBook.ThisExpenses.Category = txtCategory.Text;
            ExpensesBook.ThisExpenses.Expenses = Convert.ToInt32(txtExpenses.Text);
            ExpensesBook.ThisExpenses.Active = chkActive.Checked;
            //add the record
            ExpensesBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("ExpensesDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //function for updating new records
    void Update()
    {
        //create an insatcne of the expenses book
        DmsClasses.clsExpensesCollection ExpensesBook = new DmsClasses.clsExpensesCollection();
        //validate the data on the web form
        String Error = ExpensesBook.ThisExpenses.Valid(txtName.Text, txtCategory.Text, txtExpenses.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            ExpensesBook.ThisExpenses.Find(ExpensesNo);
            //get the data entered by the user
            ExpensesBook.ThisExpenses.Name = txtName.Text;
            ExpensesBook.ThisExpenses.Category = txtCategory.Text;
            ExpensesBook.ThisExpenses.Expenses = Convert.ToInt32(txtExpenses.Text);
            ExpensesBook.ThisExpenses.Active = chkActive.Checked;
            //update the record
            ExpensesBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("ExpensesDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayExpenses()
    {
        //create an insatcne of the expenses book
        clsExpensesCollection ExpensesBook = new clsExpensesCollection();
        //find the record to update
        ExpensesBook.ThisExpenses.Find(ExpensesNo);
        //display the data for this record
        txtName.Text = ExpensesBook.ThisExpenses.Name;
        txtCategory.Text = ExpensesBook.ThisExpenses.Category;
        txtExpenses.Text = ExpensesBook.ThisExpenses.Expenses.ToString();
        chkActive.Checked = ExpensesBook.ThisExpenses.Active;
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
            //create a new instance of clsExpenses
            clsExpenses AnExpenses = new clsExpenses();
            //capture the name
            string Name = txtName.Text;
            //capture the category
            string Category = txtCategory.Text;
            //capture the expenses
            string Expenses = txtExpenses.Text;
            //variable to store any error messages
            string Error = "";
            //validate the data
            Error = AnExpenses.Valid(Name, Category, Expenses);
            if (Error == "")
            {
                //capture the name
                AnExpenses.Name = Name;
                //capture the category
                AnExpenses.Category = Category;
                //capture the expenses
                AnExpenses.Expenses = Convert.ToInt32(Expenses);
                //store the expenses in the session object
                Session["AnExpenses"] = AnExpenses;
                //redirect to viewer page
                Response.Redirect("ExpensesViewer.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
    }
}