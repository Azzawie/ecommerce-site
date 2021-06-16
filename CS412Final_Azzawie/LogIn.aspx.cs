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
            // Don't show the errors panel when the page load.
            errorsPanel.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // initiale a list which will contain all the errors (if exist).
            List<string> errors = new List<string>();

            // Don't show the errors panel when the page load.
            errorsPanel.Visible = false;

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

            // Display all errors if it's exist.
            if (errors.Count > 0)
            {
                errorsPanel.Visible = true;
                errorsPanel.BorderColor=System.Drawing.Color.Red;
                errorsLbl.Text = string.Join("</br>", errors);
                return;
            }

            // If there are no errors then we redirect to the home page.
            Response.Redirect("./Home.aspx");
        }
    }
}