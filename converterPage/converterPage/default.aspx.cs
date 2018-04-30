using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace converterPage
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedin"].Equals(false))
                Response.Redirect("login.aspx");
        }

        protected void btnConvBin_Click(object sender, EventArgs e)
        {
            int toBin = 0;

            string binOut = "";

            //check if non int number is entered
            try{
                toBin = int.Parse(txtConvHex.Text);
            } catch {
                //display error if non int number is entered
                lblBin.Text = "Err. enter Integer Number.";
                return;
            }

            while (toBin > 0) {
                //AND toBin and 1, if it returns 1, concat 1 to binOut, otherwise concat 0
                binOut += ((toBin & 1) > 0) ? "1" : "0";

                //shift toBin right by 1
                toBin >>= 1;
            }
            
            //set output label 
            lblBin.Text = "0b" + reverseString(binOut);
            
        }

        protected void btnConvHex_Click(object sender, EventArgs e)
        {
            int hexIn = 0,
                remainder = 0;

            string hexOut = "";

            char[] hexArr = new char[] {'A','B','C','D','E','F'};


            //check if non int numbers are entered
            try {
                hexIn = int.Parse(txtConvHex.Text);
            } catch {
                //display errors
                lblHex.Text = "Err. enter Integer Number.";
                return;
            }

            while (hexIn > 0) {
                remainder = hexIn % 16;
                hexIn /= 16;

                hexOut += (remainder> 9) ? hexArr[remainder - 10] : remainder;
            }

            lblHex.Text = "0x" + reverseString(hexOut);

        }

        //reverses passed strings
        private string reverseString(string stringIn) {
            char[] chars = stringIn.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);  
        }

        protected void btnConvOct_Click(object sender, EventArgs e)
        {
            int octIn = int.Parse(txtConvOct.Text),
                remainder = 0;

            string octOut = "";

            while (octIn > 0) {
                remainder = octIn % 8;
                octIn /= 8;

                octOut += remainder;
            }

            

            lblOct.Text = "0c" + reverseString(octOut);
        }

        protected void btnConvUpp_Click(object sender, EventArgs e)
        {

        }

        //public string convOct(int numIn)
        //{
        //    if (numIn <= 0) return "0";
        //    numIn /= 8;
        //    return convOct(numIn / 8);
        //}
    }
}