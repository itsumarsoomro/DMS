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
        AnExpenses.Name = txtName.Text;
        //store the expenses in the session object
        Session["AnExpenses"] = AnExpenses;
        //redirect to the viewer page
        Response.Redirect("ExpensesViewer.aspx");
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
        else
        {
            //display error message
            txtName.Text = "";
            txtCategory.Text = "";
            txtExpenses.Text = "";
            lblError.Text = "Invalid record";
        }
    }
}