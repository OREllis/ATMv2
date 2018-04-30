using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tracksRecord
{
    public partial class searchAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtAlbumName.Text == null) {
                txtAlbumName.Text = "err.";
                return;
            }

            Albums albumsToSearch = (Albums)Session["albums"];

            if (!albumsToSearch.searchAlbum(txtAlbumName.Text)){ 
                lblAlbumName.Text = "err";
            }
            else {
                lblAlbumName.Text = "Found " + txtAlbumName.Text;
                lstAlbumTracks.DataSource = albumsToSearch.getAlbums()[txtAlbumName.Text].getTracks();
                lstAlbumTracks.DataBind();
            }

        }

        protected void lstAlbumTracks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}