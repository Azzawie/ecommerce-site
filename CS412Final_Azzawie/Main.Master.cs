using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userActions();
        }

        public void userActions()
        {
            if (userSignedIn())
            {
                userAds.Visible = true;
                btnLogout.Visible = true;
                loginLink.Visible = false;
                btnSignup.Visible = false;
            }
            else
            {
                userAds.Visible = false;
                btnLogout.Visible = false;
                loginLink.Visible = true;
                btnSignup.Visible = true;
            }
        }

        public bool userSignedIn()
        {
            return (bool)Session["signedIn"] == true ? true : false;
        }
        

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // remove the user from the session
            Session["user"] = null;

            // flag the user as signed out
            Session["signedIn"] = false;

            Response.Redirect("./Home.aspx");
        }
    }
}