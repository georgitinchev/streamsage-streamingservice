using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class UserManagement : Form
    {
        private DesktopController _desktopController;
        public UserManagement(DesktopController desktopController)
        {
            InitializeComponent();
            _desktopController = desktopController;
        }
        private void createUserBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = userEmailTextBox.Text;
            string password = userPasswordTextBox.Text;
            string firstName = userFirstNameTextBox.Text;
            string lastName = userLastNameTextBox.Text;
            ResetLabels();
            if (string.IsNullOrEmpty(username)) usernameLabel.Text += "*";
            if (string.IsNullOrEmpty(email)) emailLabel.Text += "*";
            if (string.IsNullOrEmpty(password)) passwordLabel.Text += "*";
            if (string.IsNullOrEmpty(firstName)) firstNameLabel.Text += "*";
            if (string.IsNullOrEmpty(lastName)) lastNameLabel.Text += "*";
            string errorMessage = ValidateInput(username, email, password, firstName, lastName);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorLabel.Text = errorMessage;
                return;
            }
            try
            {
                _desktopController.registerUser(username, email, password, firstName, lastName, "");
                errorLabel.ForeColor = Color.Green;
                errorLabel.Text = "User created successfully!";
                ResetLabels();
            }
            catch (Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.Message;
            }
        }

        private string ValidateInput(string username, string email, string password, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 6 || username.All(char.IsDigit))
            {
                return "Username should be at least 6 characters long and should not contain only numbers.";
            }
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                return "Please enter a valid email.";
            }
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return "Password should be at least 8 characters long.";
            }
            if (string.IsNullOrEmpty(firstName) || !Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]*$"))
            {
                return "First name should start with a capital letter and should only contain letters.";
            }
            if (string.IsNullOrEmpty(lastName) || !Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]*$"))
            {
                return "Last name should start with a capital letter and should only contain letters.";
            }
            return "";
        }

        private void backToDashBtn_Click(object sender, EventArgs e)
        {
            Program.SwitchToForm(this, new AdminDashboard(_desktopController));
            this.Dispose();
        }

        private void ResetLabels()
        {
            usernameLabel.Text = usernameLabel.Text.Replace("*", "");
            emailLabel.Text = emailLabel.Text.Replace("*", "");
            passwordLabel.Text = passwordLabel.Text.Replace("*", "");
            firstNameLabel.Text = firstNameLabel.Text.Replace("*", "");
            lastNameLabel.Text = lastNameLabel.Text.Replace("*", "");
        }
    }
}
