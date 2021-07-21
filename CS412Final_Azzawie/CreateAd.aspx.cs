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
    public partial class CreateAd : System.Web.UI.Page
    {
        private readonly IAdBLL _adBLL = new AdBLL();

        private readonly INotificationsBLL _notifications = new NotificationsBLL();

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
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Red;
                msgLbl.Text = string.Join("</br>", errors);
                return;
            }

            User user = (User)HttpContext.Current.Session["user"];

            // If there are no errors then we create the ad in the database.
            Ad ad = _adBLL.CreateAd(new Ad()
            {
                Title = title.Text,
                Price = decimal.Parse(price.Text),
                Description = description.Text,
                Condition = condition.Text,
                User = user
            });

            msgPanel.Visible = true;
            msgPanel.BorderColor = System.Drawing.Color.Green;
            msgLbl.Text = "Ad created successfully";
            msgLbl.ForeColor = System.Drawing.Color.Green;

            SendFeedback(user.First, user.Email, user.Phone, "Your ad has been created successfully.");

            // Wait for 3 sec so user can read the message
            // and then redirect to the Show ad page 
            Response.AddHeader("REFRESH", "3;URL=ShowAd.aspx");
        }

        public void SendFeedback(string userName, string userEmail, string phone, string comment)
        {
            string to = userEmail;
            string subject = "New ad has been created successfully";
            string replyTo = to;
            string body = $@"
                            <p>User Email: {userEmail}</p>
                            <p>User Name: {userName}</p>
                            <p>User Phone: {phone}</p>
                            <p>User Comment:<br>{comment}</p>";

            _notifications.SendEmail(to, subject, body, replyTo);
        }
    }
}