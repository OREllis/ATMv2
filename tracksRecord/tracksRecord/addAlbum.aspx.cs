using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tracksRecord
{
    public partial class addAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTrack_Click(object sender, EventArgs e)
        {
            if (txtTrackAlbum == null) {
                txtTrackAlbum.Text = "Err.";
                return;
            }

            Albums addNewAlbum = (Albums)Session["albums"];

            if (addNewAlbum.addAlbum(txtTrackAlbum.Text) == false) {
                txtTrackAlbum.Text = "Add Err.";
                return;
            }

            txtTrackAlbum.Text = "";
            Session["albums"] = addNewAlbum;
        }

        protected void btnToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}