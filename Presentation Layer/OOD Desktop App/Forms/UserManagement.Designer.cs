namespace DesktopApp.Forms
{
	partial class UserManagement
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            userEmailTextBox = new TextBox();
            userPasswordTextBox = new TextBox();
            userFirstNameTextBox = new TextBox();
            usernameLabel = new Label();
            userOperationsTabCtrl = new TabControl();
            userManagementPage = new TabPage();
            createUserNavigationBtn = new Button();
            totalUsersLabel = new Label();
            filterBox = new ComboBox();
            searchBtn = new Button();
            searchTextBox = new TextBox();
            totalUsersLabelIcon = new Label();
            userManagementDataGrid = new DataGridView();
            userCreationPage = new TabPage();
            errorLabel = new Label();
            createUserBtn = new Button();
            createUserBox = new GroupBox();
            lastNameLabel = new Label();
            userLastNameTextBox = new TextBox();
            firstNameLabel = new Label();
            passwordLabel = new Label();
            emailLabel = new Label();
            updateUserPage = new TabPage();
            updateUserBtn = new Button();
            userPfpPictureBox = new PictureBox();
            updateErrorLabel = new Label();
            updateUserGroupBox = new GroupBox();
            updateIsAdminCheck = new CheckBox();
            updateLastNameBox = new TextBox();
            updateLastNameLabel = new Label();
            updateFirstNameBox = new TextBox();
            updateFirstNameLabel = new Label();
            updatePasswordBox = new TextBox();
            updatePasswordLabel = new Label();
            updateEmailBox = new TextBox();
            updateEmailLabel = new Label();
            updateUsernameLabel = new Label();
            updateUsernameBox = new TextBox();
            backToHomeBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            generalErrorLabel = new Label();
            userOperationsTabCtrl.SuspendLayout();
            userManagementPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userManagementDataGrid).BeginInit();
            userCreationPage.SuspendLayout();
            createUserBox.SuspendLayout();
            updateUserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPfpPictureBox).BeginInit();
            updateUserGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Rockwell", 25F);
            usernameTextBox.Location = new Point(93, 221);
            usernameTextBox.Margin = new Padding(2, 3, 2, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(442, 56);
            usernameTextBox.TabIndex = 0;
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.Font = new Font("Rockwell", 25F);
            userEmailTextBox.Location = new Point(94, 417);
            userEmailTextBox.Margin = new Padding(2, 3, 2, 3);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.Size = new Size(442, 56);
            userEmailTextBox.TabIndex = 1;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Font = new Font("Rockwell", 25F);
            userPasswordTextBox.Location = new Point(94, 609);
            userPasswordTextBox.Margin = new Padding(2, 3, 2, 3);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(442, 56);
            userPasswordTextBox.TabIndex = 2;
            // 
            // userFirstNameTextBox
            // 
            userFirstNameTextBox.Font = new Font("Rockwell", 25F);
            userFirstNameTextBox.Location = new Point(94, 795);
            userFirstNameTextBox.Margin = new Padding(2, 3, 2, 3);
            userFirstNameTextBox.Name = "userFirstNameTextBox";
            userFirstNameTextBox.Size = new Size(442, 56);
            userFirstNameTextBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Rockwell", 25F);
            usernameLabel.Location = new Point(147, 101);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(329, 80);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userOperationsTabCtrl
            // 
            userOperationsTabCtrl.Appearance = TabAppearance.FlatButtons;
            userOperationsTabCtrl.Controls.Add(userManagementPage);
            userOperationsTabCtrl.Controls.Add(userCreationPage);
            userOperationsTabCtrl.Controls.Add(updateUserPage);
            userOperationsTabCtrl.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userOperationsTabCtrl.ItemSize = new Size(0, 1);
            userOperationsTabCtrl.Location = new Point(9, 59);
            userOperationsTabCtrl.Margin = new Padding(2, 3, 2, 3);
            userOperationsTabCtrl.Name = "userOperationsTabCtrl";
            userOperationsTabCtrl.SelectedIndex = 0;
            userOperationsTabCtrl.Size = new Size(2154, 1306);
            userOperationsTabCtrl.SizeMode = TabSizeMode.Fixed;
            userOperationsTabCtrl.TabIndex = 5;
            // 
            // userManagementPage
            // 
            userManagementPage.BackColor = Color.FromArgb(192, 255, 255);
            userManagementPage.Controls.Add(createUserNavigationBtn);
            userManagementPage.Controls.Add(totalUsersLabel);
            userManagementPage.Controls.Add(filterBox);
            userManagementPage.Controls.Add(searchBtn);
            userManagementPage.Controls.Add(searchTextBox);
            userManagementPage.Controls.Add(totalUsersLabelIcon);
            userManagementPage.Controls.Add(userManagementDataGrid);
            userManagementPage.Location = new Point(4, 5);
            userManagementPage.Margin = new Padding(2, 3, 2, 3);
            userManagementPage.Name = "userManagementPage";
            userManagementPage.Padding = new Padding(2, 3, 2, 3);
            userManagementPage.Size = new Size(2146, 1297);
            userManagementPage.TabIndex = 1;
            userManagementPage.Text = "User Management";
            // 
            // createUserNavigationBtn
            // 
            createUserNavigationBtn.BackColor = Color.FromArgb(0, 192, 192);
            createUserNavigationBtn.Location = new Point(1826, 12);
            createUserNavigationBtn.Name = "createUserNavigationBtn";
            createUserNavigationBtn.Size = new Size(285, 60);
            createUserNavigationBtn.TabIndex = 8;
            createUserNavigationBtn.Text = "Create User 👤";
            createUserNavigationBtn.UseVisualStyleBackColor = false;
            createUserNavigationBtn.Click += createUserNavigationBtn_Click;
            // 
            // totalUsersLabel
            // 
            totalUsersLabel.Font = new Font("Rockwell", 14F);
            totalUsersLabel.Location = new Point(99, 12);
            totalUsersLabel.Name = "totalUsersLabel";
            totalUsersLabel.Size = new Size(216, 60);
            totalUsersLabel.TabIndex = 7;
            totalUsersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterBox
            // 
            filterBox.Font = new Font("Rockwell", 18F);
            filterBox.FormattingEnabled = true;
            filterBox.Location = new Point(1330, 15);
            filterBox.Margin = new Padding(3, 4, 3, 4);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(443, 43);
            filterBox.TabIndex = 6;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Rockwell", 18F);
            searchBtn.Location = new Point(1114, 12);
            searchBtn.Margin = new Padding(3, 4, 3, 4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(183, 48);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "🔍 Search ";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(322, 15);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(764, 43);
            searchTextBox.TabIndex = 4;
            // 
            // totalUsersLabelIcon
            // 
            totalUsersLabelIcon.Font = new Font("Rockwell", 30F);
            totalUsersLabelIcon.Location = new Point(17, 12);
            totalUsersLabelIcon.Margin = new Padding(2, 0, 2, 0);
            totalUsersLabelIcon.Name = "totalUsersLabelIcon";
            totalUsersLabelIcon.Size = new Size(50, 60);
            totalUsersLabelIcon.TabIndex = 3;
            totalUsersLabelIcon.Text = "👤";
            totalUsersLabelIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userManagementDataGrid
            // 
            userManagementDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            userManagementDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userManagementDataGrid.Location = new Point(5, 81);
            userManagementDataGrid.Margin = new Padding(2, 3, 2, 3);
            userManagementDataGrid.Name = "userManagementDataGrid";
            userManagementDataGrid.RowHeadersWidth = 62;
            userManagementDataGrid.Size = new Size(2136, 1241);
            userManagementDataGrid.TabIndex = 0;
            // 
            // userCreationPage
            // 
            userCreationPage.BackColor = Color.FromArgb(192, 255, 255);
            userCreationPage.Controls.Add(errorLabel);
            userCreationPage.Controls.Add(createUserBtn);
            userCreationPage.Controls.Add(createUserBox);
            userCreationPage.Location = new Point(4, 5);
            userCreationPage.Margin = new Padding(2, 3, 2, 3);
            userCreationPage.Name = "userCreationPage";
            userCreationPage.Padding = new Padding(2, 3, 2, 3);
            userCreationPage.Size = new Size(2146, 1297);
            userCreationPage.TabIndex = 0;
            userCreationPage.Text = "Creation";
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(1282, 903);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(829, 313);
            errorLabel.TabIndex = 12;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createUserBtn
            // 
            createUserBtn.BackColor = Color.FromArgb(0, 192, 192);
            createUserBtn.Font = new Font("Rockwell", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserBtn.Location = new Point(1461, 499);
            createUserBtn.Margin = new Padding(2, 3, 2, 3);
            createUserBtn.Name = "createUserBtn";
            createUserBtn.Size = new Size(497, 171);
            createUserBtn.TabIndex = 11;
            createUserBtn.Text = "Create User";
            createUserBtn.UseVisualStyleBackColor = false;
            createUserBtn.Click += createUserBtn_Click;
            // 
            // createUserBox
            // 
            createUserBox.Controls.Add(usernameLabel);
            createUserBox.Controls.Add(userPasswordTextBox);
            createUserBox.Controls.Add(lastNameLabel);
            createUserBox.Controls.Add(userEmailTextBox);
            createUserBox.Controls.Add(userLastNameTextBox);
            createUserBox.Controls.Add(userFirstNameTextBox);
            createUserBox.Controls.Add(firstNameLabel);
            createUserBox.Controls.Add(usernameTextBox);
            createUserBox.Controls.Add(passwordLabel);
            createUserBox.Controls.Add(emailLabel);
            createUserBox.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserBox.Location = new Point(614, 81);
            createUserBox.Margin = new Padding(3, 4, 3, 4);
            createUserBox.Name = "createUserBox";
            createUserBox.Padding = new Padding(3, 4, 3, 4);
            createUserBox.Size = new Size(630, 1135);
            createUserBox.TabIndex = 13;
            createUserBox.TabStop = false;
            createUserBox.Text = "Create User";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Font = new Font("Rockwell", 25F);
            lastNameLabel.Location = new Point(147, 891);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(329, 63);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLastNameTextBox
            // 
            userLastNameTextBox.Font = new Font("Rockwell", 25F);
            userLastNameTextBox.Location = new Point(94, 971);
            userLastNameTextBox.Margin = new Padding(2, 3, 2, 3);
            userLastNameTextBox.Name = "userLastNameTextBox";
            userLastNameTextBox.Size = new Size(442, 56);
            userLastNameTextBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Font = new Font("Rockwell", 25F);
            firstNameLabel.Location = new Point(147, 712);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(329, 63);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Rockwell", 25F);
            passwordLabel.Location = new Point(147, 501);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(329, 81);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Rockwell", 25F);
            emailLabel.Location = new Point(147, 321);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(329, 75);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateUserPage
            // 
            updateUserPage.BackColor = Color.FromArgb(192, 255, 255);
            updateUserPage.Controls.Add(updateUserBtn);
            updateUserPage.Controls.Add(userPfpPictureBox);
            updateUserPage.Controls.Add(updateErrorLabel);
            updateUserPage.Controls.Add(updateUserGroupBox);
            updateUserPage.Location = new Point(4, 5);
            updateUserPage.Margin = new Padding(3, 4, 3, 4);
            updateUserPage.Name = "updateUserPage";
            updateUserPage.Padding = new Padding(3, 4, 3, 4);
            updateUserPage.Size = new Size(2146, 1297);
            updateUserPage.TabIndex = 2;
            updateUserPage.Text = "Update";
            // 
            // updateUserBtn
            // 
            updateUserBtn.BackColor = Color.FromArgb(0, 192, 192);
            updateUserBtn.Font = new Font("Rockwell", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateUserBtn.Location = new Point(1571, 536);
            updateUserBtn.Margin = new Padding(2, 3, 2, 3);
            updateUserBtn.Name = "updateUserBtn";
            updateUserBtn.Size = new Size(445, 138);
            updateUserBtn.TabIndex = 12;
            updateUserBtn.Text = "Update User";
            updateUserBtn.UseVisualStyleBackColor = false;
            updateUserBtn.Click += updateUserBtn_Click;
            // 
            // userPfpPictureBox
            // 
            userPfpPictureBox.InitialImage = Properties.Resources.sage_transparent;
            userPfpPictureBox.Location = new Point(129, 83);
            userPfpPictureBox.Name = "userPfpPictureBox";
            userPfpPictureBox.Size = new Size(403, 397);
            userPfpPictureBox.TabIndex = 2;
            userPfpPictureBox.TabStop = false;
            // 
            // updateErrorLabel
            // 
            updateErrorLabel.Location = new Point(30, 707);
            updateErrorLabel.Name = "updateErrorLabel";
            updateErrorLabel.Size = new Size(611, 509);
            updateErrorLabel.TabIndex = 1;
            updateErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateUserGroupBox
            // 
            updateUserGroupBox.Controls.Add(updateIsAdminCheck);
            updateUserGroupBox.Controls.Add(updateLastNameBox);
            updateUserGroupBox.Controls.Add(updateLastNameLabel);
            updateUserGroupBox.Controls.Add(updateFirstNameBox);
            updateUserGroupBox.Controls.Add(updateFirstNameLabel);
            updateUserGroupBox.Controls.Add(updatePasswordBox);
            updateUserGroupBox.Controls.Add(updatePasswordLabel);
            updateUserGroupBox.Controls.Add(updateEmailBox);
            updateUserGroupBox.Controls.Add(updateEmailLabel);
            updateUserGroupBox.Controls.Add(updateUsernameLabel);
            updateUserGroupBox.Controls.Add(updateUsernameBox);
            updateUserGroupBox.Font = new Font("Rockwell", 16F);
            updateUserGroupBox.Location = new Point(661, 83);
            updateUserGroupBox.Name = "updateUserGroupBox";
            updateUserGroupBox.Size = new Size(728, 1133);
            updateUserGroupBox.TabIndex = 0;
            updateUserGroupBox.TabStop = false;
            updateUserGroupBox.Text = "Update User";
            // 
            // updateIsAdminCheck
            // 
            updateIsAdminCheck.AutoSize = true;
            updateIsAdminCheck.BackColor = Color.FromArgb(1, 255, 255);
            updateIsAdminCheck.Font = new Font("Rockwell", 25F);
            updateIsAdminCheck.Location = new Point(195, 1005);
            updateIsAdminCheck.Name = "updateIsAdminCheck";
            updateIsAdminCheck.Size = new Size(308, 51);
            updateIsAdminCheck.TabIndex = 10;
            updateIsAdminCheck.Text = "Administrator";
            updateIsAdminCheck.UseVisualStyleBackColor = false;
            // 
            // updateLastNameBox
            // 
            updateLastNameBox.Font = new Font("Rockwell", 25F);
            updateLastNameBox.Location = new Point(132, 877);
            updateLastNameBox.Name = "updateLastNameBox";
            updateLastNameBox.Size = new Size(465, 56);
            updateLastNameBox.TabIndex = 9;
            // 
            // updateLastNameLabel
            // 
            updateLastNameLabel.AutoSize = true;
            updateLastNameLabel.Font = new Font("Rockwell", 25F);
            updateLastNameLabel.Location = new Point(236, 801);
            updateLastNameLabel.Name = "updateLastNameLabel";
            updateLastNameLabel.Size = new Size(231, 47);
            updateLastNameLabel.TabIndex = 8;
            updateLastNameLabel.Text = "Last Name:";
            // 
            // updateFirstNameBox
            // 
            updateFirstNameBox.Font = new Font("Rockwell", 25F);
            updateFirstNameBox.Location = new Point(132, 706);
            updateFirstNameBox.Name = "updateFirstNameBox";
            updateFirstNameBox.Size = new Size(465, 56);
            updateFirstNameBox.TabIndex = 7;
            // 
            // updateFirstNameLabel
            // 
            updateFirstNameLabel.AutoSize = true;
            updateFirstNameLabel.Font = new Font("Rockwell", 25F);
            updateFirstNameLabel.Location = new Point(236, 624);
            updateFirstNameLabel.Name = "updateFirstNameLabel";
            updateFirstNameLabel.Size = new Size(240, 47);
            updateFirstNameLabel.TabIndex = 6;
            updateFirstNameLabel.Text = "First Name:";
            // 
            // updatePasswordBox
            // 
            updatePasswordBox.Font = new Font("Rockwell", 25F);
            updatePasswordBox.Location = new Point(132, 535);
            updatePasswordBox.Name = "updatePasswordBox";
            updatePasswordBox.PlaceholderText = "   Input new password";
            updatePasswordBox.Size = new Size(465, 56);
            updatePasswordBox.TabIndex = 5;
            // 
            // updatePasswordLabel
            // 
            updatePasswordLabel.AutoSize = true;
            updatePasswordLabel.Font = new Font("Rockwell", 25F);
            updatePasswordLabel.Location = new Point(247, 453);
            updatePasswordLabel.Name = "updatePasswordLabel";
            updatePasswordLabel.Size = new Size(216, 47);
            updatePasswordLabel.TabIndex = 4;
            updatePasswordLabel.Text = "Password:";
            // 
            // updateEmailBox
            // 
            updateEmailBox.Font = new Font("Rockwell", 25F);
            updateEmailBox.Location = new Point(132, 341);
            updateEmailBox.Name = "updateEmailBox";
            updateEmailBox.Size = new Size(465, 56);
            updateEmailBox.TabIndex = 3;
            // 
            // updateEmailLabel
            // 
            updateEmailLabel.AutoSize = true;
            updateEmailLabel.Font = new Font("Rockwell", 25F);
            updateEmailLabel.Location = new Point(275, 261);
            updateEmailLabel.Name = "updateEmailLabel";
            updateEmailLabel.Size = new Size(140, 47);
            updateEmailLabel.TabIndex = 2;
            updateEmailLabel.Text = "Email:";
            // 
            // updateUsernameLabel
            // 
            updateUsernameLabel.AutoSize = true;
            updateUsernameLabel.Font = new Font("Rockwell", 25F);
            updateUsernameLabel.Location = new Point(236, 77);
            updateUsernameLabel.Name = "updateUsernameLabel";
            updateUsernameLabel.Size = new Size(227, 47);
            updateUsernameLabel.TabIndex = 1;
            updateUsernameLabel.Text = "Username:";
            // 
            // updateUsernameBox
            // 
            updateUsernameBox.Font = new Font("Rockwell", 25F);
            updateUsernameBox.Location = new Point(132, 145);
            updateUsernameBox.Name = "updateUsernameBox";
            updateUsernameBox.Size = new Size(465, 56);
            updateUsernameBox.TabIndex = 0;
            // 
            // backToHomeBtn
            // 
            backToHomeBtn.BackColor = Color.FromArgb(192, 255, 255);
            backToHomeBtn.Font = new Font("Segoe UI", 15F);
            backToHomeBtn.Location = new Point(9, 12);
            backToHomeBtn.Name = "backToHomeBtn";
            backToHomeBtn.Size = new Size(79, 41);
            backToHomeBtn.TabIndex = 14;
            backToHomeBtn.Text = "🏠";
            backToHomeBtn.UseVisualStyleBackColor = false;
            backToHomeBtn.Click += backToHomeBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // generalErrorLabel
            // 
            generalErrorLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generalErrorLabel.Location = new Point(278, 9);
            generalErrorLabel.Name = "generalErrorLabel";
            generalErrorLabel.Size = new Size(1508, 41);
            generalErrorLabel.TabIndex = 15;
            generalErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2174, 1377);
            Controls.Add(generalErrorLabel);
            Controls.Add(backToHomeBtn);
            Controls.Add(userOperationsTabCtrl);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2192, 1424);
            MinimumSize = new Size(2192, 1424);
            Name = "UserManagement";
            Text = "UserManagement";
            userOperationsTabCtrl.ResumeLayout(false);
            userManagementPage.ResumeLayout(false);
            userManagementPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userManagementDataGrid).EndInit();
            userCreationPage.ResumeLayout(false);
            createUserBox.ResumeLayout(false);
            createUserBox.PerformLayout();
            updateUserPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPfpPictureBox).EndInit();
            updateUserGroupBox.ResumeLayout(false);
            updateUserGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox userEmailTextBox;
        private TextBox userPasswordTextBox;
        private TextBox userFirstNameTextBox;
        private Label usernameLabel;
        private TabControl userOperationsTabCtrl;
        private TabPage userCreationPage;
        private TabPage userManagementPage;
        private Button createUserBtn;
        private Label lastNameLabel;
        private TextBox userLastNameTextBox;
        private Label firstNameLabel;
        private Label passwordLabel;
        private Label emailLabel;
        private Label errorLabel;
        private DataGridView userManagementDataGrid;
        private ComboBox filterBox;
        private Button searchBtn;
        private TextBox searchTextBox;
        private Label totalUsersLabel;
        private TabPage updateUserPage;
        private GroupBox createUserBox;
        private Label totalUsersLabelIcon;
        private Button backToHomeBtn;
        private Button createUserNavigationBtn;
        private GroupBox updateUserGroupBox;
        private Label updateUsernameLabel;
        private TextBox updateUsernameBox;
        private TextBox updateEmailBox;
        private Label updateEmailLabel;
        private TextBox updatePasswordBox;
        private Label updatePasswordLabel;
        private TextBox updateLastNameBox;
        private Label updateLastNameLabel;
        private TextBox updateFirstNameBox;
        private Label updateFirstNameLabel;
        private CheckBox updateIsAdminCheck;
        private Label updateErrorLabel;
        private PictureBox userPfpPictureBox;
        private OpenFileDialog openFileDialog1;
        private Button updateUserBtn;
        private Label generalErrorLabel;
    }
}