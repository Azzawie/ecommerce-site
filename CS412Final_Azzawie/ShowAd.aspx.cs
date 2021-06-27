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

            Ad ad = new Ad()
            {
                User = new User()
                {
                    Id = 1,
                    First = "Mustafa",
                    Last = "Azzawie",
                    Email = "mmakialazzaw@neiu.edu",
                    Phone = "1234567898"
                },
                Id = 1,
                Title = "Iphone for sell",
                Price = "120.5",
                Description = "This is a brand new Iphone for sell, looking for good deal",
                Condition = "New"
            };

            title.Text = ad.Title;
            price.Text = ad.Price;
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