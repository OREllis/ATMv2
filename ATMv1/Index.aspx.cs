using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hBos"] == null)
        {
            rblChoose.Items[1].Enabled = false;
            Session["hBos"] = new Bank();
        }

    }


    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Bank checkLogin = (Bank)Session["hBos"];

        if (rblChoose.Items[0].Enabled)
        {
            if (checkLogin.isValidAccountLogin(Login1.UserName, Login1.Password))
            {
                Session["login"] = Login1.UserName;
                Session["password"] = Login1.Password;

                Response.Redirect("ManagerHome.aspx");
            }
            else {
                Login1.FailureText = "Invalid Login";
            }
        }
        else if (rblChoose.Items[1].Enabled)
        {
            if (checkLogin.isValidAccountLogin(Login1.UserName, Login1.Password))
            {
                checkLogin.setTimesUsed(checkLogin.getTimesUsed() + 1);
                Session["login"] = Login1.UserName;
                Session["password"] = Login1.Password;

                Response.Redirect("CustomerHome.aspx");
            }
            else {
                Login1.FailureText = "Invalid Login";
            }
        }
    }
}