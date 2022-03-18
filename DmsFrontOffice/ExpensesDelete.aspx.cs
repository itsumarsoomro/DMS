using DmsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExpensesDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ExpensesNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the expenses to be deleted from the session object
        ExpensesNo = Convert.ToInt32(Session["ExpensesNo"]);
    }

    void DeleteExpenses()
    {
        //function to delete the selected record

        //create a new instance of the expenses book
        clsExpensesCollection ExpensesBook = new clsExpensesCollection();
        //find the record to delete
        ExpensesBook.ThisExpenses.Find(ExpensesNo);
        //delete the record
        ExpensesBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delte the record
        DeleteExpenses();
        //redirect back to the main page
        Response.Redirect("ExpensesDefault.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExpensesDefault.aspx");
    }
}