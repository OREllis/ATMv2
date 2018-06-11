using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_CloseDown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hBos"] == null)
            Response.Redirect("~/Index.aspx");
    }

    protected void btnCloseDown_Click(object sender, EventArgs e)
    {
        Session["hBos"] = Session["login"] = Session["password"] = null;
        Response.Redirect("~/Index.aspx");
    }
}