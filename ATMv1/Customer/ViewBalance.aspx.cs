using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_ViewBalance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hBos"] == null)
            Response.Redirect("~/Index.aspx");

        Bank hBos = (Bank)Session["hBos"];

        lblBalance.Text = hBos.getBalance((string)Session["login"], (string)Session["password"]).ToString();
    }
}