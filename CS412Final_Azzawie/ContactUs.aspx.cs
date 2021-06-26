using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Azzawie
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Don't show the errors panel when the page load.
            msgPanel.Visible = false;
        }

        protected void btnContactUs_Click(object sender, EventArgs e)
        {

            // initiale a list which will contain all the errors (if exist).
            List<string> errors = new List<string>();

            // Check if the name field is empty
            if (string.IsNullOrEmpty(name.Text))
            {
                errors.Add("Please enter your name !");
            }

            // Check if the email field is empty
            if (string.IsNullOrEmpty(email.Text))
            {
                errors.Add("Please enter a valid email !");
            }

            // Check if the phone field is empty
            if (string.IsNullOrEmpty(phone.Text))
            {
                errors.Add("Please enter a valid phone number !");
            }

            // Check if the comment field is empty
            if (string.IsNullOrEmpty(comment.Text))
            {
                errors.Add("Please enter a brief message !");
            }

            // Display all errors if it's exist.
            if (errors.Count > 0)
            {
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Red;
                msgLbl.Text = string.Join("</br>", errors);
                return;
            }

            // If there are no errors then we send an email to the admin.
            msgPanel.Visible = true;
            msgPanel.BorderColor = System.Drawing.Color.Green;
            msgLbl.Text = "Thank you for your message, Someone from our team will contact you soon.";
            msgLbl.ForeColor = System.Drawing.Color.Green;
            
            // Wait for 3 sec so user can read the message
            // and then redirect to the home page 
            Response.AddHeader("REFRESH", "3;URL=Home.aspx");
        }
    }
}