using CS412Final_Azzawie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{

    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["signedIn"] = false;

            // Don't show the errors panel when the page load.
            errorsPanel.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // initiale a list which will contain all the errors (if exist).
            List<string> errors = new List<string>();

            // Check if the email field is empty
            if (string.IsNullOrEmpty(email.Text))
            {
                errors.Add("Email field can't be empty !");
            }

            // Check if the password field is empty
            if (string.IsNullOrEmpty(password.Text))
            {
                errors.Add("Password field can't be empty !");
            }


            if (errors.Count == 0)
            {
                // will do something like 
                // user = SELECT * FROM User WHERE Email= email.text AND Password = password.text;
                bool foundInDatabase = false;

                if (email.Text.ToLower() == "mmakialazzaw@neiu.edu" && password.Text == "123456789")
                {
                    foundInDatabase = true;
                }
                if (foundInDatabase)
                {
                    User user = new User()
                    {
                        First = "Mustafa",
                        Last = "Azzawie",
                        Email = "Mmakialazzaw@neiu.edu",
                        Password = "12345678"
                    };

                    Session["signedIn"] = true;
                    // If there are no errors then we redirect to the home page.
                    Response.Redirect("./Home.aspx");
                }
                else
                {
                    errors.Add("Unable to find the user, please check your email or passeord !");
                }
            }

            // Display all errors if it's exist.
            if (errors.Count > 0)
            {
                errorsPanel.Visible = true;
                errorsPanel.BorderColor = System.Drawing.Color.Red;
                errorsLbl.Text = string.Join("</br>", errors);
                return;
            }
        }
    }
}