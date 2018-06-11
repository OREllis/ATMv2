using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Withdrawal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hBos"] == null)
            Response.Redirect("~/Index.aspx");
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        decimal amount =0;
        Bank withdraw = (Bank)Session["hBos"];

        if (txtAmount.Text != null)
            try
            {
                amount = decimal.Parse(txtAmount.Text);
            }
            catch {
                txtAmount.Text = "Err, invalid entry";
            }
        else if (rbtn10Pounds.Checked)
            amount = 10;
        else if (rbtn20Pounds.Checked)
            amount = 20;
        else if (rbtn30Pounds.Checked)
            amount = 30;
        else if (rbtn40Pounds.Checked)
            amount = 40;
        else if (rbtn50Pounds.Checked)
            amount = 50;
        else if (rbtn100Pounds.Checked)
            amount = 100;
        else if (rbtn150Pounds.Checked)
            amount = 150;
        else if (rbtn250Pounds.Checked)
            amount = 25;

        if (amount % 10 != 0) {
            txtAmount.Text = "Err, amount must be a multiple of 10";
            return;
        }

        if (cbtnAsEuro.Enabled)
            amount /= withdraw.getExchangeRate();

        if (withdraw.withdraw((string)Session["login"], (string)Session["password"], amount))
            txtAmount.Text = "Transaction Completed";
        else
            txtAmount.Text = "Err. Insufficicent funds";

    }

    protected void btnExit_Click(object sender, EventArgs e)
    {
        Session["login"] = Session["password"] = null;
        Response.Redirect("~/Index.aspx");
    }
}