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
    public partial class EditAd : System.Web.UI.Page
    {
        private readonly IAdBLL _adBLL = new AdBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // redirect to login if he is not loged in yet
            if (!Login.userSignedIn())
            {
                Response.Redirect("./login.aspx");
            }

            // Don't show the errors panel when the page load.
            msgPanel.Visible = false;
        }
        protected void btnEditAd_Click(object sender, EventArgs e)
        {
            // initiale a list which will contain all the errors (if exist).
            List<string> errors = new List<string>();

            // Check if the title field is empty
            if (string.IsNullOrEmpty(title.Text))
            {
                errors.Add("Title field can't be empty !");
            }

            // Check if the price field is empty
            if (string.IsNullOrEmpty(price.Text))
            {
                errors.Add("Price field can't be empty !");
            }

            // Check if the descritiom field is empty
            if (string.IsNullOrEmpty(description.Text))
            {
                errors.Add("Description field can't be empty !");
            }

            // Display all errors if it's exist.
            if (errors.Count > 0)
            {
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Red;
                msgLbl.Text = string.Join("</br>", errors);
                return;
            }

            // If there are no errors then we update the ad
            Ad ad = _adBLL.UpdateAd(new Ad()
            {
                Title = title.Text,
                Price = decimal.Parse(price.Text),
                Description = description.Text,
                Condition = condition.Text
            }
            );

            msgPanel.Visible = true;
            msgPanel.BorderColor = System.Drawing.Color.Green;
            msgLbl.Text = "Ad created successfully";
            msgLbl.ForeColor = System.Drawing.Color.Green;

            // Wait for 3 sec so user can read the message
            // and then redirect to the Show ad page 
            Response.AddHeader("REFRESH", "3;URL=ShowAd.aspx");
        }
    }
}