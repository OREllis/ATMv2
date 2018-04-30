using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tracksRecord
{
    public partial class delTrack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelTrack_Click(object sender, EventArgs e)
        {
            //error checking for blank textboxes
            if (txtTrackAlbum.Text == "" || txtTrackToDel.Text == "") {
                txtTrackAlbum.Text = "Err. empty txt boxes";
                return;
            }

            //store Albums in session as local var
            Albums albumOfTrack = (Albums)Session["albums"];
            
            //search dictionary for key, if false, display error and stop method
            if (albumOfTrack.searchAlbum(txtTrackAlbum.Text) == false){
                txtTrackAlbum.Text = "err. no existing album";
                return;
            }

            //store albums' dictionary to modify
            Dictionary<string, Tracks> newAlbums = albumOfTrack.getAlbums();

            //run delTrack function on value contained in the searched key, display error if false is returned
            if (newAlbums[txtTrackAlbum.Text].delTrack(txtTrackToDel.Text) == false) {
                txtTrackAlbum.Text = "err. no track";
                return;
            }

            //set albumOfTrack's dictionary to newAlbums
            albumOfTrack.setAlbums(newAlbums);
            txtTrackAlbum.Text = txtTrackToDel.Text = "";

            //store modified Albums object in Session["albums"]
            Session["albums"] = albumOfTrack;
        }
    }
}