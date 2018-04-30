using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using converterPage.Models;

namespace converterPage
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loggedin"] = false;

            if (Session["accounts"] == null)
            {
                Session["accounts"] = new Persons();
            }
        }


        protected void login_btn_Click(object sender, EventArgs e)
        {
            //return if invalid details
            if (username_txt.Text == null || password_txt.Text == null || Session["accounts"] == null)
                return;

            //declare myAccount, set to Session["accounts"]
            Persons myAccount = (Persons)Session["accounts"];
            
            //check if returned value == entered password
            if (myAccount.getPass(username_txt.Text) == password_txt.Text) {
                Session["loggedin"] = true;
                Response.Redirect("default.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //opens register page
            Response.Redirect("register.aspx");
        }
    }
}