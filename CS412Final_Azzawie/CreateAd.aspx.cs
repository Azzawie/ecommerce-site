﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class CreateAd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // redirect to login if he is not loged in yet
            if (!(Boolean)Session["signedIn"])
            {
                Response.Redirect("./login.aspx");
            }

            // Don't show the errors panel when the page load.
            errorsPanel.Visible = false;
        }

        protected void btnCreateAd_Click(object sender, EventArgs e)
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
                errorsPanel.Visible = true;
                errorsPanel.BorderColor = System.Drawing.Color.Red;
                errorsLbl.Text = string.Join("</br>", errors);
                return;
            }

            // If there are no errors then we redirect to the home page.
            Response.Redirect("./Home.aspx");
        }
    }
}