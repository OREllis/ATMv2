using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tracksRecord
{
    public partial class addTrack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTrack_Click(object sender, EventArgs e)
        {
            if (txtTrackAlbum.Text == null || txtTrackIn.Text == null) {
                txtTrackAlbum.Text = "Err.";
                return;
            }

            Albums newTrack = (Albums)Session["albums"];

            if (!newTrack.searchAlbum(txtTrackAlbum.Text)) {
                txtTrackAlbum.Text = "Err. no album match";
                return;
            }

            newTrack.getAlbums()[txtTrackAlbum.Text].addTrack(txtTrackIn.Text);


            txtTrackAlbum.Text = txtTrackIn.Text = "";
            Session["albums"] = newTrack;
        }

        protected void btnToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}