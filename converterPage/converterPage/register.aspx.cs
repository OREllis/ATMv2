using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using converterPage.Models;

namespace converterPage
{
    public partial class register : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }


        protected void btnReg_Click(object sender, EventArgs e)
        {
            Persons reg = (Persons)Session["accounts"];

            if (txtUsername == null || txtPass == null || reg == null)
                return;

            reg.addDetails(txtUsername.Text, txtPass.Text);
            reg.personsToFile();

            Session["accounts"] = reg;

        }
    }
}