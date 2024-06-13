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
            previousPageBtn = new Button();
            nextPageBtn = new Button();
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
            createSettingsTextBox = new TextBox();
            settingsLabel = new Label();
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
            updateSettingsTextBox = new TextBox();
            updateSettingsLabel = new Label();
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
            createIsAdminCheckBox = new CheckBox();
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
            usernameTextBox.Location = new Point(32, 101);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(489, 47);
            usernameTextBox.TabIndex = 0;
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.Font = new Font("Rockwell", 25F);
            userEmailTextBox.Location = new Point(32, 208);
            userEmailTextBox.Margin = new Padding(2);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.Size = new Size(489, 47);
            userEmailTextBox.TabIndex = 1;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Font = new Font("Rockwell", 25F);
            userPasswordTextBox.Location = new Point(32, 320);
            userPasswordTextBox.Margin = new Padding(2);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(489, 47);
            userPasswordTextBox.TabIndex = 2;
            // 
            // userFirstNameTextBox
            // 
            userFirstNameTextBox.Font = new Font("Rockwell", 25F);
            userFirstNameTextBox.Location = new Point(32, 425);
            userFirstNameTextBox.Margin = new Padding(2);
            userFirstNameTextBox.Name = "userFirstNameTextBox";
            userFirstNameTextBox.Size = new Size(489, 47);
            userFirstNameTextBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Rockwell", 25F);
            usernameLabel.Location = new Point(129, 39);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(288, 60);
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
            userOperationsTabCtrl.Location = new Point(8, 44);
            userOperationsTabCtrl.Margin = new Padding(2);
            userOperationsTabCtrl.Name = "userOperationsTabCtrl";
            userOperationsTabCtrl.SelectedIndex = 0;
            userOperationsTabCtrl.Size = new Size(1885, 978);
            userOperationsTabCtrl.SizeMode = TabSizeMode.Fixed;
            userOperationsTabCtrl.TabIndex = 5;
            // 
            // userManagementPage
            // 
            userManagementPage.BackColor = Color.FromArgb(192, 255, 255);
            userManagementPage.Controls.Add(previousPageBtn);
            userManagementPage.Controls.Add(nextPageBtn);
            userManagementPage.Controls.Add(createUserNavigationBtn);
            userManagementPage.Controls.Add(totalUsersLabel);
            userManagementPage.Controls.Add(filterBox);
            userManagementPage.Controls.Add(searchBtn);
            userManagementPage.Controls.Add(searchTextBox);
            userManagementPage.Controls.Add(totalUsersLabelIcon);
            userManagementPage.Controls.Add(userManagementDataGrid);
            userManagementPage.Location = new Point(4, 5);
            userManagementPage.Margin = new Padding(2);
            userManagementPage.Name = "userManagementPage";
            userManagementPage.Padding = new Padding(2);
            userManagementPage.Size = new Size(1877, 969);
            userManagementPage.TabIndex = 1;
            userManagementPage.Text = "User Management";
            // 
            // previousPageBtn
            // 
            previousPageBtn.BackColor = Color.FromArgb(0, 192, 192);
            previousPageBtn.Location = new Point(5, 935);
            previousPageBtn.Margin = new Padding(3, 2, 3, 2);
            previousPageBtn.Name = "previousPageBtn";
            previousPageBtn.Size = new Size(188, 30);
            previousPageBtn.TabIndex = 10;
            previousPageBtn.Text = "◀️ Previous Page";
            previousPageBtn.UseVisualStyleBackColor = false;
            // 
            // nextPageBtn
            // 
            nextPageBtn.BackColor = Color.FromArgb(0, 192, 192);
            nextPageBtn.Location = new Point(1684, 935);
            nextPageBtn.Margin = new Padding(3, 2, 3, 2);
            nextPageBtn.Name = "nextPageBtn";
            nextPageBtn.Size = new Size(188, 30);
            nextPageBtn.TabIndex = 9;
            nextPageBtn.Text = "Next Page ▶️";
            nextPageBtn.UseVisualStyleBackColor = false;
            // 
            // createUserNavigationBtn
            // 
            createUserNavigationBtn.BackColor = Color.FromArgb(0, 192, 192);
            createUserNavigationBtn.Location = new Point(1598, 9);
            createUserNavigationBtn.Margin = new Padding(3, 2, 3, 2);
            createUserNavigationBtn.Name = "createUserNavigationBtn";
            createUserNavigationBtn.Size = new Size(249, 45);
            createUserNavigationBtn.TabIndex = 8;
            createUserNavigationBtn.Text = "Create User 👤";
            createUserNavigationBtn.UseVisualStyleBackColor = false;
            createUserNavigationBtn.Click += createUserNavigationBtn_Click;
            // 
            // totalUsersLabel
            // 
            totalUsersLabel.Font = new Font("Rockwell", 14F);
            totalUsersLabel.Location = new Point(87, 9);
            totalUsersLabel.Name = "totalUsersLabel";
            totalUsersLabel.Size = new Size(189, 45);
            totalUsersLabel.TabIndex = 7;
            totalUsersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterBox
            // 
            filterBox.Font = new Font("Rockwell", 18F);
            filterBox.FormattingEnabled = true;
            filterBox.Location = new Point(1164, 11);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(388, 35);
            filterBox.TabIndex = 6;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Rockwell", 18F);
            searchBtn.Location = new Point(975, 9);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(160, 36);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "🔍 Search ";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(282, 11);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(669, 36);
            searchTextBox.TabIndex = 4;
            // 
            // totalUsersLabelIcon
            // 
            totalUsersLabelIcon.Font = new Font("Rockwell", 30F);
            totalUsersLabelIcon.Location = new Point(15, 9);
            totalUsersLabelIcon.Margin = new Padding(2, 0, 2, 0);
            totalUsersLabelIcon.Name = "totalUsersLabelIcon";
            totalUsersLabelIcon.Size = new Size(44, 45);
            totalUsersLabelIcon.TabIndex = 3;
            totalUsersLabelIcon.Text = "👤";
            totalUsersLabelIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userManagementDataGrid
            // 
            userManagementDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            userManagementDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userManagementDataGrid.Location = new Point(4, 61);
            userManagementDataGrid.Margin = new Padding(2);
            userManagementDataGrid.Name = "userManagementDataGrid";
            userManagementDataGrid.RowHeadersWidth = 62;
            userManagementDataGrid.Size = new Size(1869, 870);
            userManagementDataGrid.TabIndex = 0;
            // 
            // userCreationPage
            // 
            userCreationPage.BackColor = Color.FromArgb(192, 255, 255);
            userCreationPage.Controls.Add(errorLabel);
            userCreationPage.Controls.Add(createUserBtn);
            userCreationPage.Controls.Add(createUserBox);
            userCreationPage.Location = new Point(4, 5);
            userCreationPage.Margin = new Padding(2);
            userCreationPage.Name = "userCreationPage";
            userCreationPage.Padding = new Padding(2);
            userCreationPage.Size = new Size(1877, 969);
            userCreationPage.TabIndex = 0;
            userCreationPage.Text = "Creation";
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(1122, 677);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(725, 235);
            errorLabel.TabIndex = 12;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createUserBtn
            // 
            createUserBtn.BackColor = Color.FromArgb(0, 192, 192);
            createUserBtn.Font = new Font("Rockwell", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserBtn.Location = new Point(1278, 374);
            createUserBtn.Margin = new Padding(2);
            createUserBtn.Name = "createUserBtn";
            createUserBtn.Size = new Size(435, 128);
            createUserBtn.TabIndex = 11;
            createUserBtn.Text = "Create User";
            createUserBtn.UseVisualStyleBackColor = false;
            createUserBtn.Click += createUserBtn_Click;
            // 
            // createUserBox
            // 
            createUserBox.Controls.Add(createIsAdminCheckBox);
            createUserBox.Controls.Add(createSettingsTextBox);
            createUserBox.Controls.Add(settingsLabel);
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
            createUserBox.Location = new Point(537, 61);
            createUserBox.Name = "createUserBox";
            createUserBox.Size = new Size(551, 882);
            createUserBox.TabIndex = 13;
            createUserBox.TabStop = false;
            createUserBox.Text = "Create User";
            // 
            // createSettingsTextBox
            // 
            createSettingsTextBox.Font = new Font("Rockwell", 25F);
            createSettingsTextBox.Location = new Point(32, 656);
            createSettingsTextBox.Margin = new Padding(2);
            createSettingsTextBox.Name = "createSettingsTextBox";
            createSettingsTextBox.Size = new Size(489, 47);
            createSettingsTextBox.TabIndex = 12;
            // 
            // settingsLabel
            // 
            settingsLabel.Font = new Font("Rockwell", 25F);
            settingsLabel.Location = new Point(129, 607);
            settingsLabel.Margin = new Padding(2, 0, 2, 0);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(288, 47);
            settingsLabel.TabIndex = 11;
            settingsLabel.Text = "Settings:";
            settingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Font = new Font("Rockwell", 25F);
            lastNameLabel.Location = new Point(129, 484);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(288, 47);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLastNameTextBox
            // 
            userLastNameTextBox.Font = new Font("Rockwell", 25F);
            userLastNameTextBox.Location = new Point(32, 544);
            userLastNameTextBox.Margin = new Padding(2);
            userLastNameTextBox.Name = "userLastNameTextBox";
            userLastNameTextBox.Size = new Size(489, 47);
            userLastNameTextBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Font = new Font("Rockwell", 25F);
            firstNameLabel.Location = new Point(129, 376);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(288, 47);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Rockwell", 25F);
            passwordLabel.Location = new Point(129, 257);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(288, 61);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Rockwell", 25F);
            emailLabel.Location = new Point(129, 150);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(288, 56);
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
            updateUserPage.Name = "updateUserPage";
            updateUserPage.Padding = new Padding(3);
            updateUserPage.Size = new Size(1877, 969);
            updateUserPage.TabIndex = 2;
            updateUserPage.Text = "Update";
            // 
            // updateUserBtn
            // 
            updateUserBtn.BackColor = Color.FromArgb(0, 192, 192);
            updateUserBtn.Font = new Font("Rockwell", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateUserBtn.Location = new Point(1375, 402);
            updateUserBtn.Margin = new Padding(2);
            updateUserBtn.Name = "updateUserBtn";
            updateUserBtn.Size = new Size(389, 104);
            updateUserBtn.TabIndex = 12;
            updateUserBtn.Text = "Update User";
            updateUserBtn.UseVisualStyleBackColor = false;
            updateUserBtn.Click += updateUserBtn_Click;
            // 
            // userPfpPictureBox
            // 
            userPfpPictureBox.InitialImage = Properties.Resources.sage_transparent;
            userPfpPictureBox.Location = new Point(101, 62);
            userPfpPictureBox.Margin = new Padding(3, 2, 3, 2);
            userPfpPictureBox.Name = "userPfpPictureBox";
            userPfpPictureBox.Size = new Size(372, 298);
            userPfpPictureBox.TabIndex = 2;
            userPfpPictureBox.TabStop = false;
            // 
            // updateErrorLabel
            // 
            updateErrorLabel.Location = new Point(26, 530);
            updateErrorLabel.Name = "updateErrorLabel";
            updateErrorLabel.Size = new Size(535, 382);
            updateErrorLabel.TabIndex = 1;
            updateErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateUserGroupBox
            // 
            updateUserGroupBox.Controls.Add(updateSettingsTextBox);
            updateUserGroupBox.Controls.Add(updateSettingsLabel);
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
            updateUserGroupBox.Location = new Point(578, 62);
            updateUserGroupBox.Margin = new Padding(3, 2, 3, 2);
            updateUserGroupBox.Name = "updateUserGroupBox";
            updateUserGroupBox.Padding = new Padding(3, 2, 3, 2);
            updateUserGroupBox.Size = new Size(637, 850);
            updateUserGroupBox.TabIndex = 0;
            updateUserGroupBox.TabStop = false;
            updateUserGroupBox.Text = "Update User";
            // 
            // updateSettingsTextBox
            // 
            updateSettingsTextBox.Font = new Font("Rockwell", 25F);
            updateSettingsTextBox.Location = new Point(38, 663);
            updateSettingsTextBox.Margin = new Padding(3, 2, 3, 2);
            updateSettingsTextBox.Name = "updateSettingsTextBox";
            updateSettingsTextBox.Size = new Size(560, 47);
            updateSettingsTextBox.TabIndex = 12;
            // 
            // updateSettingsLabel
            // 
            updateSettingsLabel.AutoSize = true;
            updateSettingsLabel.Font = new Font("Rockwell", 25F);
            updateSettingsLabel.Location = new Point(216, 613);
            updateSettingsLabel.Name = "updateSettingsLabel";
            updateSettingsLabel.Size = new Size(150, 38);
            updateSettingsLabel.TabIndex = 11;
            updateSettingsLabel.Text = "Settings:";
            // 
            // updateIsAdminCheck
            // 
            updateIsAdminCheck.BackColor = Color.FromArgb(1, 255, 255);
            updateIsAdminCheck.Font = new Font("Rockwell", 25F);
            updateIsAdminCheck.Location = new Point(38, 759);
            updateIsAdminCheck.Margin = new Padding(3, 2, 3, 2);
            updateIsAdminCheck.Name = "updateIsAdminCheck";
            updateIsAdminCheck.Size = new Size(560, 38);
            updateIsAdminCheck.TabIndex = 10;
            updateIsAdminCheck.Text = "Administrator";
            updateIsAdminCheck.TextAlign = ContentAlignment.MiddleCenter;
            updateIsAdminCheck.UseVisualStyleBackColor = false;
            // 
            // updateLastNameBox
            // 
            updateLastNameBox.Font = new Font("Rockwell", 25F);
            updateLastNameBox.Location = new Point(38, 539);
            updateLastNameBox.Margin = new Padding(3, 2, 3, 2);
            updateLastNameBox.Name = "updateLastNameBox";
            updateLastNameBox.Size = new Size(560, 47);
            updateLastNameBox.TabIndex = 9;
            // 
            // updateLastNameLabel
            // 
            updateLastNameLabel.AutoSize = true;
            updateLastNameLabel.Font = new Font("Rockwell", 25F);
            updateLastNameLabel.Location = new Point(203, 490);
            updateLastNameLabel.Name = "updateLastNameLabel";
            updateLastNameLabel.Size = new Size(188, 38);
            updateLastNameLabel.TabIndex = 8;
            updateLastNameLabel.Text = "Last Name:";
            // 
            // updateFirstNameBox
            // 
            updateFirstNameBox.Font = new Font("Rockwell", 25F);
            updateFirstNameBox.Location = new Point(38, 424);
            updateFirstNameBox.Margin = new Padding(3, 2, 3, 2);
            updateFirstNameBox.Name = "updateFirstNameBox";
            updateFirstNameBox.Size = new Size(560, 47);
            updateFirstNameBox.TabIndex = 7;
            // 
            // updateFirstNameLabel
            // 
            updateFirstNameLabel.AutoSize = true;
            updateFirstNameLabel.Font = new Font("Rockwell", 25F);
            updateFirstNameLabel.Location = new Point(206, 374);
            updateFirstNameLabel.Name = "updateFirstNameLabel";
            updateFirstNameLabel.Size = new Size(195, 38);
            updateFirstNameLabel.TabIndex = 6;
            updateFirstNameLabel.Text = "First Name:";
            // 
            // updatePasswordBox
            // 
            updatePasswordBox.Font = new Font("Rockwell", 25F);
            updatePasswordBox.Location = new Point(38, 311);
            updatePasswordBox.Margin = new Padding(3, 2, 3, 2);
            updatePasswordBox.Name = "updatePasswordBox";
            updatePasswordBox.PlaceholderText = "Input new password";
            updatePasswordBox.Size = new Size(560, 47);
            updatePasswordBox.TabIndex = 5;
            updatePasswordBox.TextAlign = HorizontalAlignment.Center;
            // 
            // updatePasswordLabel
            // 
            updatePasswordLabel.AutoSize = true;
            updatePasswordLabel.Font = new Font("Rockwell", 25F);
            updatePasswordLabel.Location = new Point(216, 262);
            updatePasswordLabel.Name = "updatePasswordLabel";
            updatePasswordLabel.Size = new Size(176, 38);
            updatePasswordLabel.TabIndex = 4;
            updatePasswordLabel.Text = "Password:";
            // 
            // updateEmailBox
            // 
            updateEmailBox.Font = new Font("Rockwell", 25F);
            updateEmailBox.Location = new Point(38, 200);
            updateEmailBox.Margin = new Padding(3, 2, 3, 2);
            updateEmailBox.Name = "updateEmailBox";
            updateEmailBox.Size = new Size(560, 47);
            updateEmailBox.TabIndex = 3;
            // 
            // updateEmailLabel
            // 
            updateEmailLabel.AutoSize = true;
            updateEmailLabel.Font = new Font("Rockwell", 25F);
            updateEmailLabel.Location = new Point(241, 152);
            updateEmailLabel.Name = "updateEmailLabel";
            updateEmailLabel.Size = new Size(115, 38);
            updateEmailLabel.TabIndex = 2;
            updateEmailLabel.Text = "Email:";
            // 
            // updateUsernameLabel
            // 
            updateUsernameLabel.AutoSize = true;
            updateUsernameLabel.Font = new Font("Rockwell", 25F);
            updateUsernameLabel.Location = new Point(206, 39);
            updateUsernameLabel.Name = "updateUsernameLabel";
            updateUsernameLabel.Size = new Size(184, 38);
            updateUsernameLabel.TabIndex = 1;
            updateUsernameLabel.Text = "Username:";
            // 
            // updateUsernameBox
            // 
            updateUsernameBox.Font = new Font("Rockwell", 25F);
            updateUsernameBox.Location = new Point(38, 90);
            updateUsernameBox.Margin = new Padding(3, 2, 3, 2);
            updateUsernameBox.Name = "updateUsernameBox";
            updateUsernameBox.Size = new Size(560, 47);
            updateUsernameBox.TabIndex = 0;
            // 
            // backToHomeBtn
            // 
            backToHomeBtn.BackColor = Color.FromArgb(192, 255, 255);
            backToHomeBtn.Font = new Font("Segoe UI", 15F);
            backToHomeBtn.Location = new Point(8, 9);
            backToHomeBtn.Margin = new Padding(3, 2, 3, 2);
            backToHomeBtn.Name = "backToHomeBtn";
            backToHomeBtn.Size = new Size(69, 31);
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
            generalErrorLabel.Location = new Point(243, 7);
            generalErrorLabel.Name = "generalErrorLabel";
            generalErrorLabel.Size = new Size(1320, 31);
            generalErrorLabel.TabIndex = 15;
            generalErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createIsAdminCheckBox
            // 
            createIsAdminCheckBox.BackColor = Color.FromArgb(1, 255, 255);
            createIsAdminCheckBox.Font = new Font("Rockwell", 25F);
            createIsAdminCheckBox.Location = new Point(32, 772);
            createIsAdminCheckBox.Margin = new Padding(3, 2, 3, 2);
            createIsAdminCheckBox.Name = "createIsAdminCheckBox";
            createIsAdminCheckBox.Size = new Size(489, 38);
            createIsAdminCheckBox.TabIndex = 13;
            createIsAdminCheckBox.Text = "Administrator";
            createIsAdminCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            createIsAdminCheckBox.UseVisualStyleBackColor = false;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1033);
            Controls.Add(generalErrorLabel);
            Controls.Add(backToHomeBtn);
            Controls.Add(userOperationsTabCtrl);
            MaximumSize = new Size(1920, 1078);
            MinimumSize = new Size(1920, 1052);
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
        private TextBox createSettingsTextBox;
        private Label settingsLabel;
        private TextBox updateSettingsTextBox;
        private Label updateSettingsLabel;
        private Button previousPageBtn;
        private Button nextPageBtn;
        private CheckBox createIsAdminCheckBox;
    }
}