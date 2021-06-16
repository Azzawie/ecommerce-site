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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            // initiale a list which will contain all the errors (if exist).
            List<string> errors = new List<string>();

            // Don't show the errors panel when the page load.
            errorsPanel.Visible = false;

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

            // Check if the city field is empty
            if (string.IsNullOrEmpty(city.Text))
            {
                errors.Add("City field can't be empty !");
            }

            // Check if the state field is empty
            if (string.IsNullOrEmpty(state.Text))
            {
                errors.Add("State field can't be empty !");
            }

            // Check if the zipcode field is empty
            if (string.IsNullOrEmpty(zipCode.Text))
            {
                errors.Add("Zip code field can't be empty !");
            }

            // Check if the street1 field is empty
            if (string.IsNullOrEmpty(street1.Text))
            {
                errors.Add("street 1 field can't be empty !");
            }

            // Check if the unit number field is empty
            if (string.IsNullOrEmpty(unitNumber.Text))
            {
                errors.Add("Unit number field can't be empty !");
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