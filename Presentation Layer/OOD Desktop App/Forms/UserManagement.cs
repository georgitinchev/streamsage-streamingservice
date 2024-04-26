using LogicClassLibrary.Entities;
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
            RefreshUsers();
        }
        private async void createUserBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = userEmailTextBox.Text;
            string password = userPasswordTextBox.Text;
            string firstName = userFirstNameTextBox.Text;
            string lastName = userLastNameTextBox.Text;
            if (string.IsNullOrEmpty(username)) usernameLabel.Text += "*";
            if (string.IsNullOrEmpty(email)) emailLabel.Text += "*";
            if (string.IsNullOrEmpty(password)) passwordLabel.Text += "*";
            if (string.IsNullOrEmpty(firstName)) firstNameLabel.Text += "*";
            if (string.IsNullOrEmpty(lastName)) lastNameLabel.Text += "*";
            string errorMessage = ValidateInput(username, email, password, firstName, lastName);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorLabel.Text = errorMessage;
                await Task.Delay(3000);
                errorLabel.Text = "";
                return;
            }
            try
            {
                _desktopController.registerUser(username, email, password, firstName, lastName, "");
                errorLabel.ForeColor = Color.Green;
                errorLabel.Text = "User created successfully!";
                ClearInputFields();
                await Task.Delay(3000);
                errorLabel.Text = "";
            }
            catch (Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.Message;
                await Task.Delay(3000);
                errorLabel.Text = "";
            }
        }
        private void RefreshUsers()
        {
            List<User> users = _desktopController.displayUserPage();
            userManagementDataGrid.AutoGenerateColumns = false;
            userManagementDataGrid.Columns.Clear();
            // Add columns for the properties of the Movie class that you want to display
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Username", HeaderText = "Username" });
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" });
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "FirstName" });
            userManagementDataGrid.CellContentClick += userManagementDataGrid_CellContentClick;
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Width = 100;
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 100;
            userManagementDataGrid.Columns.Add(editButtonColumn);
            userManagementDataGrid.Columns.Add(deleteButtonColumn);
            userManagementDataGrid.DataSource = users;
            userManagementDataGrid.AutoResizeColumns();
            userManagementDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userManagementDataGrid.BackgroundColor = Color.LightGray;
            userManagementDataGrid.BorderStyle = BorderStyle.None;
            userManagementDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            userManagementDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userManagementDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            userManagementDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            userManagementDataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            userManagementDataGrid.EnableHeadersVisualStyles = false;
            userManagementDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            userManagementDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            userManagementDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userManagementDataGrid.RowTemplate.Height = 50;
            totalUsersLabelIcon.Text = $"Total Users:\n{users.Count}";
        }

        private void userManagementDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                User user = (User)senderGrid.Rows[e.RowIndex].DataBoundItem;
                // Below write logic for updating the user
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
            Program.SwitchToForm(new AdminDashboard(_desktopController));
            this.Dispose();
        }
        private void ClearInputFields()
        {
            usernameTextBox.Text = "";
            userEmailTextBox.Text = "";
            userPasswordTextBox.Text = "";
            userFirstNameTextBox.Text = "";
            userLastNameTextBox.Text = "";
        }
    }
}
