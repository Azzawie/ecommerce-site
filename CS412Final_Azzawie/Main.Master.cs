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
            if ((Boolean)Session["signedIn"])
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
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["signedIn"] = false;
            Response.Redirect("./Home.aspx");
        }
    }
}