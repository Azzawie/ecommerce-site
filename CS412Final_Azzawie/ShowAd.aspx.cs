using CS412Final_Azzawie.BLL;
using CS412Final_Azzawie.BLL.Interfaces;
using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class ShowAd : System.Web.UI.Page
    {
        private readonly IAdBLL _AdBLL = new AdBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Letthe user edit or delet the ad if he is logedin and he is the owner of the ad 
            // something like if ((Login.userSignedIn()) && (Login.currentUser().id == ad.user.id))
            if (Login.userSignedIn())
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }

            // Don't show the errors panel when the page load.
            msgPanel.Visible = false;

            // Getting the id frem the page params
            int id = int.Parse(Request["id"]);

            // Getting the user ad from the database
            Ad ad = _AdBLL.GetUserAd(id);

            title.Text = ad.Title;
            price.Text = ad.Price.ToString();
            condition.Text = ad.Condition;
            description.Text = ad.Description;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // This should delete this ad and then redirect to the user ads 

            Response.Redirect("UserAds.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("editAd.aspx");
        }
    }
}