using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_Maintenance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hBos"] == null)
            Response.Redirect("~/Index.aspx");

        Bank maintenanceDetails = (Bank)Session["hBos"];

        txtExchangeRate.Text = maintenanceDetails.getExchangeRate().ToString();
        lblTimesUsed.Text = maintenanceDetails.getTimesUsed().ToString();
        lblWithdrawals.Text = maintenanceDetails.getWithdrawals().ToString();
        lblTotalBalance.Text = maintenanceDetails.getTotalBalance().ToString();
        lblFailedLogins.Text = maintenanceDetails.getFailedLogins().ToString();
        lblCardsRetained.Text = maintenanceDetails.getCardsRetained().ToString();
    }

    protected void btnExchangeSet_Click(object sender, EventArgs e)
    {
        Bank setExchange = (Bank)Session["hBos"];

        try
        {
            setExchange.setExchangeRate(decimal.Parse(txtExchangeRate.Text));
            Session["hBos"] = setExchange;
        }
        catch {
            txtExchangeRate.Text = "Error.";
        }
    }
}