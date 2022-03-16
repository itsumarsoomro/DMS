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
}
