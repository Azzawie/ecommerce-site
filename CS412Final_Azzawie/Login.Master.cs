using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class Login : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Session["is_logedin"] = true;
            //HttpContext.Current.Request.Cookies["user_name"] = "john";
            //loginLink.Visible = false;

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["signedIn"] = false;
            Response.Redirect("./Home.aspx");
        }
    }
}