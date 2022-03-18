using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DmsClasses;

public partial class ExpensesViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsExpenses
        clsExpenses AnExpenses = new clsExpenses();
        //get the data from the session object
        AnExpenses = (clsExpenses)Session["AnExpenses"];
        //display the name for this entry
        Response.Write(AnExpenses.Name);
        Response.Write(AnExpenses.Category);
        Response.Write(AnExpenses.Expenses);
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnExpenses.aspx");
    }
}