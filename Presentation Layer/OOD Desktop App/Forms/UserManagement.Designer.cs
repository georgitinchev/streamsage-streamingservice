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
            totalUsersLabel = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
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
            backToDashBtn = new Button();
            userOperationsTabCtrl.SuspendLayout();
            userManagementPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userManagementDataGrid).BeginInit();
            userCreationPage.SuspendLayout();
            createUserBox.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Rockwell", 25F);
            usernameTextBox.Location = new Point(81, 166);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(387, 47);
            usernameTextBox.TabIndex = 0;
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.Font = new Font("Rockwell", 25F);
            userEmailTextBox.Location = new Point(82, 313);
            userEmailTextBox.Margin = new Padding(2);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.Size = new Size(387, 47);
            userEmailTextBox.TabIndex = 1;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Font = new Font("Rockwell", 25F);
            userPasswordTextBox.Location = new Point(82, 457);
            userPasswordTextBox.Margin = new Padding(2);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(387, 47);
            userPasswordTextBox.TabIndex = 2;
            // 
            // userFirstNameTextBox
            // 
            userFirstNameTextBox.Font = new Font("Rockwell", 25F);
            userFirstNameTextBox.Location = new Point(82, 596);
            userFirstNameTextBox.Margin = new Padding(2);
            userFirstNameTextBox.Name = "userFirstNameTextBox";
            userFirstNameTextBox.Size = new Size(387, 47);
            userFirstNameTextBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Rockwell", 25F);
            usernameLabel.Location = new Point(129, 76);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(288, 60);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userOperationsTabCtrl
            // 
            userOperationsTabCtrl.Controls.Add(userManagementPage);
            userOperationsTabCtrl.Controls.Add(userCreationPage);
            userOperationsTabCtrl.Controls.Add(updateUserPage);
            userOperationsTabCtrl.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userOperationsTabCtrl.Location = new Point(8, 27);
            userOperationsTabCtrl.Margin = new Padding(2);
            userOperationsTabCtrl.Name = "userOperationsTabCtrl";
            userOperationsTabCtrl.SelectedIndex = 0;
            userOperationsTabCtrl.Size = new Size(1885, 1003);
            userOperationsTabCtrl.TabIndex = 5;
            // 
            // userManagementPage
            // 
            userManagementPage.BackColor = Color.FromArgb(192, 255, 255);
            userManagementPage.Controls.Add(totalUsersLabel);
            userManagementPage.Controls.Add(comboBox1);
            userManagementPage.Controls.Add(button1);
            userManagementPage.Controls.Add(searchTextBox);
            userManagementPage.Controls.Add(totalUsersLabelIcon);
            userManagementPage.Controls.Add(userManagementDataGrid);
            userManagementPage.Location = new Point(4, 32);
            userManagementPage.Margin = new Padding(2);
            userManagementPage.Name = "userManagementPage";
            userManagementPage.Padding = new Padding(2);
            userManagementPage.Size = new Size(1877, 967);
            userManagementPage.TabIndex = 1;
            userManagementPage.Text = "User Management";
            // 
            // totalUsersLabel
            // 
            totalUsersLabel.Font = new Font("Rockwell", 10F);
            totalUsersLabel.Location = new Point(87, 9);
            totalUsersLabel.Name = "totalUsersLabel";
            totalUsersLabel.Size = new Size(189, 45);
            totalUsersLabel.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Rockwell", 18F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1164, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(388, 35);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 18F);
            button1.Location = new Point(975, 9);
            button1.Name = "button1";
            button1.Size = new Size(160, 36);
            button1.TabIndex = 5;
            button1.Text = "🔍 Search ";
            button1.UseVisualStyleBackColor = true;
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
            totalUsersLabelIcon.Size = new Size(49, 45);
            totalUsersLabelIcon.TabIndex = 3;
            totalUsersLabelIcon.Text = "👤";
            // 
            // userManagementDataGrid
            // 
            userManagementDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            userManagementDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userManagementDataGrid.Location = new Point(4, 61);
            userManagementDataGrid.Margin = new Padding(2);
            userManagementDataGrid.Name = "userManagementDataGrid";
            userManagementDataGrid.RowHeadersWidth = 62;
            userManagementDataGrid.Size = new Size(1869, 904);
            userManagementDataGrid.TabIndex = 0;
            // 
            // userCreationPage
            // 
            userCreationPage.BackColor = Color.FromArgb(192, 255, 255);
            userCreationPage.Controls.Add(errorLabel);
            userCreationPage.Controls.Add(createUserBtn);
            userCreationPage.Controls.Add(createUserBox);
            userCreationPage.Location = new Point(4, 32);
            userCreationPage.Margin = new Padding(2);
            userCreationPage.Name = "userCreationPage";
            userCreationPage.Padding = new Padding(2);
            userCreationPage.Size = new Size(1877, 967);
            userCreationPage.TabIndex = 0;
            userCreationPage.Text = "Creation";
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Rockwell", 24F, FontStyle.Bold);
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
            createUserBox.Size = new Size(551, 851);
            createUserBox.TabIndex = 13;
            createUserBox.TabStop = false;
            createUserBox.Text = "Create User";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Font = new Font("Rockwell", 25F);
            lastNameLabel.Location = new Point(129, 668);
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
            userLastNameTextBox.Location = new Point(82, 728);
            userLastNameTextBox.Margin = new Padding(2);
            userLastNameTextBox.Name = "userLastNameTextBox";
            userLastNameTextBox.Size = new Size(387, 47);
            userLastNameTextBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Font = new Font("Rockwell", 25F);
            firstNameLabel.Location = new Point(129, 534);
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
            passwordLabel.Location = new Point(129, 376);
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
            emailLabel.Location = new Point(129, 241);
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
            updateUserPage.Location = new Point(4, 32);
            updateUserPage.Name = "updateUserPage";
            updateUserPage.Padding = new Padding(3);
            updateUserPage.Size = new Size(1877, 967);
            updateUserPage.TabIndex = 2;
            updateUserPage.Text = "Update";
            // 
            // backToDashBtn
            // 
            backToDashBtn.BackColor = Color.CornflowerBlue;
            backToDashBtn.Font = new Font("Rockwell", 13F, FontStyle.Bold);
            backToDashBtn.Location = new Point(1679, 4);
            backToDashBtn.Margin = new Padding(2);
            backToDashBtn.Name = "backToDashBtn";
            backToDashBtn.Size = new Size(214, 40);
            backToDashBtn.TabIndex = 6;
            backToDashBtn.Text = "Back to Admin Dash";
            backToDashBtn.UseVisualStyleBackColor = false;
            backToDashBtn.Click += backToDashBtn_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(backToDashBtn);
            Controls.Add(userOperationsTabCtrl);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "UserManagement";
            Text = "UserManagement";
            userOperationsTabCtrl.ResumeLayout(false);
            userManagementPage.ResumeLayout(false);
            userManagementPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userManagementDataGrid).EndInit();
            userCreationPage.ResumeLayout(false);
            createUserBox.ResumeLayout(false);
            createUserBox.PerformLayout();
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
        private Label totalUsersLabelIcon;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox searchTextBox;
        private Label totalUsersLabel;
        private TabPage updateUserPage;
        private GroupBox createUserBox;
        private Button backToDashBtn;
    }
}