using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exceptions;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.NewFolder;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace DesktopApp.Forms
{
    public partial class UserManagement : Form
    {
        private readonly IDesktopController _desktopController;
        private int currentUserId;
        private int currentPage = 1;
        public UserManagement(IDesktopController desktopController)
        {
            InitializeComponent();
            AttachPageHandlers();
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
            string settingsText = createSettingsTextBox.Text;
            bool isAdmin = createIsAdminCheckBox.Checked;
            UserSettingsDTO settingsDTO = new UserSettingsDTO { Role = isAdmin ? "Admin" : "User" };
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
                _desktopController.UserService?.Create(username, email, password, firstName, lastName, settingsDTO);
                errorLabel.ForeColor = Color.Green;
                errorLabel.Text = "User created successfully!";
                ClearInputFields();
            }
            catch (UserServiceException ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = ex.Message;
            }
            catch (System.Exception ex)
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "An error occurred while creating the user.";
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
            // Gather data from the form
            string role = updateIsAdminCheck.Checked ? "Admin" : "User";
            string username = updateUsernameBox.Text;
            string email = updateEmailBox.Text;
            string password = updatePasswordBox.Text;
            string firstName = updateFirstNameBox.Text;
            string lastName = updateLastNameBox.Text;
            UserSettingsDTO settingsDTO = new UserSettingsDTO { Role = role };

            // Validate the input
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
                _desktopController.UserService.Update(currentUserId, username, email, firstName, lastName, settingsDTO);
                _desktopController.UserService.ChangePassword(username, password);
                RefreshUsers();
                updateErrorLabel.ForeColor = Color.Green;
                updateErrorLabel.Text = "User updated successfully!";
            }
            catch (UserServiceException ex)
            {
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Text = ex.Message;
            }
            catch (System.Exception ex)
            {
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Text = "An error occurred while updating the user.";
            }
            finally
            {
                await Task.Delay(5000);
                updateErrorLabel.Text = "";
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
            List<UserDTO> users = _desktopController.GetUserPage(currentPage, _desktopController.GetPageSize());
            userManagementDataGrid.DataSource = null;
            userManagementDataGrid.DataSource = users;
            totalUsersLabel.Text = $"Total Users: {users.Count}";
            userManagementDataGrid.Refresh();
        }

        private async void userManagementDataGrid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender == null) return;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                UserDTO user = (UserDTO)senderGrid.Rows[e.RowIndex].DataBoundItem;
                if (senderGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    userOperationsTabCtrl.SelectedIndex = 2;
                    currentUserId = user.Id;
                    updateUsernameBox.Text = user.Username;
                    updateEmailBox.Text = user.Email;
                    updateFirstNameBox.Text = user.FirstName;
                    updateLastNameBox.Text = user.LastName;
                    updateIsAdminCheck.Checked = user.Settings?.Role == "Admin";
                    UpdateUserSettings(user);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            _desktopController.UserService?.Delete(user.Id);
                            generalErrorLabel.ForeColor = Color.DarkGreen;
                            generalErrorLabel.Text = "User deleted successfully!";
                        }
                        catch (UserServiceException ex)
                        {
                            generalErrorLabel.ForeColor = Color.Red;
                            generalErrorLabel.Text = ex.Message;
                        }
                        catch (System.Exception ex)
                        {
                            generalErrorLabel.ForeColor = Color.Red;
                            generalErrorLabel.Text = "An error occurred while deleting the user.";
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

        private void UpdateUserSettings(UserDTO user)
        {
            if (user.Settings != null)
            {
                updateSettingsTextBox.Text = $"Role: {user.Settings.Role}, Theme: {user.Settings.Theme}";
            }
            else
            {
                updateSettingsTextBox.Text = "";
            }
        }

        private void AttachPageHandlers()
        {
            previousPageBtn.Click += (sender, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    RefreshUsers();
                }
            };
            nextPageBtn.Click += (sender, e) =>
            {
                int totalUsers = _desktopController.GetTotalUsers();
                int pageSize = _desktopController.GetPageSize();
                int totalPages = (int)Math.Ceiling((double)totalUsers / pageSize);
                if (currentPage < totalPages)
                {
                    currentPage++;
                    RefreshUsers();
                }
            };
        }
    }
}
