using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.NewFolder;

namespace DesktopApp.Forms
{
    public partial class UserManagement : Form
    {
        private readonly DesktopController _desktopController;
        private int currentUserId;
        public UserManagement(DesktopController desktopController)
        {
            InitializeComponent();
            this._desktopController = desktopController;
            userManagementDataGrid.CellContentClick += userManagementDataGrid_CellContentClick;
            InitializeDataGridView();
            RefreshUsers();
        }

        private async void createUserBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = userEmailTextBox.Text;
            string password = userPasswordTextBox.Text;
            string firstName = userFirstNameTextBox.Text;
            string lastName = userLastNameTextBox.Text;

            string errorMessage = UserValidation.ValidateCreateInput(username, email, password, firstName, lastName);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = errorMessage;
                await Task.Delay(3000);
                errorLabel.Text = "";
                return;
            }

            try
            {
                _desktopController.registerUser(username, email, password, firstName, lastName, "", "");
                errorLabel.ForeColor = Color.Green;
                errorLabel.Text = "User created successfully!";
                ClearInputFields();
            }
            catch (Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.Message;
            }
            finally
            {
                RefreshUsers();
                await Task.Delay(3000);
                errorLabel.Text = "";
            }
        }

        private async void updateUserBtn_Click(object sender, EventArgs e)
        {
            string username = updateUsernameBox.Text;
            string email = updateEmailBox.Text;
            string password = updatePasswordBox.Text;
            string firstName = updateFirstNameBox.Text;
            string lastName = updateLastNameBox.Text;
            string errorMessage = UserValidation.ValidateUpdateInput(username, email, password, firstName, lastName);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                updateErrorLabel.Text = errorMessage;
                await Task.Delay(5000);
                updateErrorLabel.Text = "";
                return;
            }
            try
            {
                User currentUser = _desktopController.backendService.GetUser(currentUserId);
                bool detailsUnchanged = username == currentUser.Username &&
                                        email == currentUser.Email &&
                                        firstName == currentUser.FirstName &&
                                        lastName == currentUser.LastName;

                if (detailsUnchanged && !string.IsNullOrEmpty(password))
                {
                    _desktopController.backendService?.ChangePassword(username, password);
                    updateErrorLabel.ForeColor = Color.Green;
                    updateErrorLabel.Text = "Password updated successfully!";
                    return;
                }
                else
                {
                    UserDTO userToUpdate = new UserDTO(currentUserId, username, email, firstName, lastName, "", "");
                    _desktopController.backendService?.UpdateUser(userToUpdate);
                    if (!string.IsNullOrEmpty(password))
                    {
                        _desktopController.backendService?.ChangePassword(username, password);
                    }
                    updateErrorLabel.ForeColor = Color.Green;
                    updateErrorLabel.Text = "User details updated successfully!";
                }
            }
            catch (Exception ex)
            {
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Text = ex.Message;
            }
            finally
            {
                RefreshUsers();
                await Task.Delay(5000);
                updateErrorLabel.Text = "";
                updatePasswordBox.Text = "";
            }
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            userOperationsTabCtrl.SelectedIndex = 0;
        }

        private void createUserNavigationBtn_Click(object sender, EventArgs e)
        {
            userOperationsTabCtrl.SelectedIndex = 1;
        }

        private void InitializeDataGridView()
        {
            // Initialization logic remains the same
            userManagementDataGrid.AutoGenerateColumns = false;
            userManagementDataGrid.Columns.Clear();
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Username", HeaderText = "Username", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            userManagementDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            UIStyler.AddButtonColumn(userManagementDataGrid, "Edit", "Edit");
            UIStyler.AddButtonColumn(userManagementDataGrid, "Delete", "Delete");
            UIStyler.StyleDataGridView(userManagementDataGrid);
            UIStyler.StyleButtonColumns(userManagementDataGrid);
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            List<User> users = _desktopController.displayUserPage();
            userManagementDataGrid.DataSource = null;
            userManagementDataGrid.DataSource = users;
            totalUsersLabel.Text = $"Total Users: {users.Count}";
            userManagementDataGrid.Refresh();
        }

        private async void userManagementDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                User user = (User)senderGrid.Rows[e.RowIndex].DataBoundItem;
                if (senderGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    userOperationsTabCtrl.SelectedIndex = 2;
                    currentUserId = user.Id;
                    updateUsernameBox.Text = user.Username;
                    updateEmailBox.Text = user.Email;
                    updateFirstNameBox.Text = user.FirstName;
                    updateLastNameBox.Text = user.LastName;
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            _desktopController.backendService?.DeleteUser(user.Id);
                            generalErrorLabel.ForeColor = Color.DarkGreen;
                            generalErrorLabel.Text = "User deleted successfully!";
                        }
                        catch (Exception ex)
                        {
                            generalErrorLabel.ForeColor = Color.Red;
                            generalErrorLabel.Text = ex.Message;
                        }
                        finally
                        {
                            RefreshUsers();
                            senderGrid.CurrentCell = null;
                            await Task.Delay(3000);
                            generalErrorLabel.Text = "";
                        }
                    }
                }
            }
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
