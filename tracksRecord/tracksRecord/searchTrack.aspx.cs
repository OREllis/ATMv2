using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tracksRecord
{
    public partial class searchTrack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtTrackName.Text == null || txtAlbum.Text == null) {
                txtTrackName.Text = "Err. Empty TextBox";
                return;
            } 

            Albums albumsToSearch = (Albums)Session["albums"];

            if (albumsToSearch.searchAlbum(txtAlbum.Text)) {
                if (albumsToSearch.getAlbums()[txtAlbum.Text].findTrack(txtTrackName.Text)) {
                    lblResult.Text = "Track " + txtTrackName.Text + " was found in the album: " + txtAlbum.Text;
                    return;
                }
                else {
                    lblResult.Text = "Track " + txtTrackName.Text + " wasn't found in the album: " + txtAlbum.Text;
                }
            }
            else {
                lblResult.Text = txtAlbum.Text + " was not found.";
            }
        }

        protected void btnToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}