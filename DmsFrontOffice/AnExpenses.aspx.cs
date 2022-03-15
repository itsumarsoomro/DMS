using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class AnExpenses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
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
        string Error="";
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
        
    }
}