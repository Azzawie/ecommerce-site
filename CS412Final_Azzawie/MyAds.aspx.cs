using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class MyAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // redirect to login if he is not loged in yet
            if (!(Boolean)Session["signedIn"])
            {
                Response.Redirect("./login.aspx");
            }
        }
    }
}