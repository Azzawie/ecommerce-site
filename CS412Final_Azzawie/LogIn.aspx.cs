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

    public partial class LogIn : System.Web.UI.Page
    {
        private readonly IUserBLL _userBLL = new UserBLL();


        protected void Page_Load(object sender, EventArgs e)
        {
            Session["signedIn"] = false;
            Session["user"] = null;

            // Don't show the errors panel when the page load.
            msgPanel.Visible = false;
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
                User user = _userBLL.GetUser(email.Text.Trim().ToLower(), password.Text);

                if (user != null)
                {
                    // upload the user object to the session 
                    Session["user"] = user;

                    // flag the user signed in
                    Session["signedIn"] = true;

                    // Show welcome message 
                    msgPanel.Visible = true;
                    msgPanel.BorderColor = System.Drawing.Color.Green;
                    msgLbl.Text = $"Welcome back {user.First}.";
                    msgLbl.ForeColor = System.Drawing.Color.Green;

                    // Wait for 3 sec so user can read the message
                    // and then redirect to the home page 
                    Response.AddHeader("REFRESH", "3;URL=Home.aspx");
                }
                else
                {
                    errors.Add("Unable to find the user, please check your email or passeord !");
                }
            }

            // Display all errors if it's exist.
            if (errors.Count > 0)
            {
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Red;
                msgLbl.Text = string.Join("</br>", errors);
                return;
            }
        }
    }
}