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
    public partial class SignUp : System.Web.UI.Page
    {
        private readonly IUserBLL _userBLL = new UserBLL();

        private readonly INotificationsBLL _notifications = new NotificationsBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["signedIn"] = false;
            Session["user"] = null;

            // Don't show the errors panel when the page load.
            msgPanel.Visible = false;
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            // initiale a list which will contain all the errors (if exist).
            List<string> errors = new List<string>();

            // Check if the first name field is empty
            if (string.IsNullOrEmpty(first.Text))
            {
                errors.Add("First name field can't be empty !");
            }

            // Check if the last name field is empty
            if (string.IsNullOrEmpty(last.Text))
            {
                errors.Add("Last name field can't be empty !");
            }

            // Check if the date of birth field is empty
            if (string.IsNullOrEmpty(dob.Text))
            {
                errors.Add("Date of birth field can't be empty !");
            }

            // Check if the phone field is empty
            if (string.IsNullOrEmpty(phone.Text))
            {
                errors.Add("Phone field can't be empty !");
            }

            // Check if the email field is empty
            if (string.IsNullOrEmpty(email.Text))
            {
                errors.Add("Email field can't be empty !");
            }

            // Check if the password field is empty or less than 8 charecter
            if (string.IsNullOrEmpty(password.Text) || password.Text.Length < 8)
            {
                errors.Add("Password field can't be empty or less than 8 charecter !");
            }

            // Check if the password virification field is empty
            if (string.IsNullOrEmpty(vpassword.Text))
            {
                errors.Add("Password verification field can't be empty !");
            }

            // Check if the password & password verification doesn't match
            if (vpassword.Text != password.Text)
            {
                errors.Add("Password and password verification does not match !");
            }

            bool doesUserAlreadyExist = _userBLL.UserExists(email.Text.Trim());
            if (doesUserAlreadyExist)
            {
                errors.Add("User already exists. Please use a different email.");
            }

            // Display all errors if it's exist.
            if (errors.Count > 0)
            {
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Red;
                msgLbl.Text = string.Join("</br>", errors);
                return;
            }


            User user = new User()
            {
                First = first.Text,
                Last = last.Text,
                Email = email.Text,
                Password = password.Text,
                Phone = phone.Text,
                Dob = DateTime.Parse(dob.Text)
            };

            User newUser = _userBLL.CreateUser(user);

            if (newUser != null)
            {
                Session["user"] = newUser;
                Session["signedIn"] = true;

                // Show welcome message 
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Green;
                msgLbl.Text = $"Welcome {newUser.First}.";
                msgLbl.ForeColor = System.Drawing.Color.Green;

                SendFeedback(newUser.First, newUser.Email, newUser.Phone, $"Welcome {newUser.First} to sell & buy website");
                Response.AddHeader("REFRESH", "3;URL=Home.aspx");
            }
            else
            {
                msgPanel.Visible = true;
                msgPanel.BorderColor = System.Drawing.Color.Red;
                msgLbl.Text = "Unable to create user. Please check your inputs and try again.";
            }
        }

        public void SendFeedback(string userName, string userEmail, string phone, string comment)
        {
            string to = userEmail;
            string subject = "Welcome to sell & buy website";
            string replyTo = to;
            string body = $@"
                            <p>Your Email: {userEmail}</p>
                            <p>Your Name: {userName}</p>
                            <p>Your Phone: {phone}</p>
                            <p>{comment}</p>";

            _notifications.SendEmail(to, subject, body, replyTo);
        }
    }
}