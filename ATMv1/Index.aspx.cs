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
        }
        else
        {
            rblChoose.Items[1].Enabled = true;
        }

    }


    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //bank variable to store current or new bank from Session["hBos"] variable
        Bank checkLogin;


        if (Session["hBos"] == null)
        {
            checkLogin = new Bank();
            Session["hBos"] = checkLogin;
        }
        else
        {
            checkLogin = (Bank)Session["hBos"];
        }


        if (rblChoose.Items[0].Enabled)
        {
            if (checkLogin.isValidManagerLogin(Login1.UserName, Login1.Password))
            {
                Session["login"] = Login1.UserName;
                Session["password"] = Login1.Password;

                Response.Redirect("/Manager/ManagerHome.aspx");
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

                Response.Redirect("/Customer/CustomerHome.aspx");
            }
            else {
                Login1.FailureText = "Invalid Login";
            }
        }
    }
}