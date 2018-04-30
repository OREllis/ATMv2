using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace tracksRecord
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //made for the init load, makes new Albums to store in Session
            if (Session["albums"] == null){
                Session["albums"] = new Albums();
            }
            
        }


        //btn page redirects for user selection
        protected void btnFindTrack_Click(object sender, EventArgs e)
        {
            Response.Redirect("searchTrack.aspx");
        }

        protected void findAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("searchAlbum.aspx");
        }

        protected void btnTrackAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("addTrack.aspx");
        }

        protected void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("addAlbum.aspx");
        }

        protected void btnDelTrack_Click(object sender, EventArgs e)
        {
            Response.Redirect("delTrack.aspx");
        }

        protected void btnDelAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("delAlbum.aspx");
        }
    }
}