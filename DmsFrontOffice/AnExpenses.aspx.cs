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
}