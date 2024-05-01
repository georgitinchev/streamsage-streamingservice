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
            userOperationsTabCtrl.Controls.Add(userManagementPage);
            userOperationsTabCtrl.Controls.Add(userCreationPage);
            userOperationsTabCtrl.Controls.Add(updateUserPage);
            userOperationsTabCtrl.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userOperationsTabCtrl.Location = new Point(9, 36);
            userOperationsTabCtrl.Margin = new Padding(2, 3, 2, 3);
            userOperationsTabCtrl.Name = "userOperationsTabCtrl";
            userOperationsTabCtrl.SelectedIndex = 0;
            userOperationsTabCtrl.Size = new Size(2154, 1337);
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
            userManagementPage.Location = new Point(4, 39);
            userManagementPage.Margin = new Padding(2, 3, 2, 3);
            userManagementPage.Name = "userManagementPage";
            userManagementPage.Padding = new Padding(2, 3, 2, 3);
            userManagementPage.Size = new Size(2146, 1294);
            userManagementPage.TabIndex = 1;
            userManagementPage.Text = "User Management";
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Rockwell", 18F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1330, 15);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(443, 43);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 18F);
            button1.Location = new Point(1114, 12);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(183, 48);
            button1.TabIndex = 5;
            button1.Text = "🔍 Search ";
            button1.UseVisualStyleBackColor = true;
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
            userManagementDataGrid.Size = new Size(2136, 1205);
            userManagementDataGrid.TabIndex = 0;
            // 
            // userCreationPage
            // 
            userCreationPage.BackColor = Color.FromArgb(192, 255, 255);
            userCreationPage.Controls.Add(errorLabel);
            userCreationPage.Controls.Add(createUserBtn);
            userCreationPage.Controls.Add(createUserBox);
            userCreationPage.Location = new Point(4, 39);
            userCreationPage.Margin = new Padding(2, 3, 2, 3);
            userCreationPage.Name = "userCreationPage";
            userCreationPage.Padding = new Padding(2, 3, 2, 3);
            userCreationPage.Size = new Size(2146, 1294);
            userCreationPage.TabIndex = 0;
            userCreationPage.Text = "Creation";
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Rockwell", 24F, FontStyle.Bold);
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
            updateUserPage.Location = new Point(4, 39);
            updateUserPage.Margin = new Padding(3, 4, 3, 4);
            updateUserPage.Name = "updateUserPage";
            updateUserPage.Padding = new Padding(3, 4, 3, 4);
            updateUserPage.Size = new Size(2146, 1294);
            updateUserPage.TabIndex = 2;
            updateUserPage.Text = "Update";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2174, 1377);
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
        private ComboBox comboBox1;
        private Button button1;
        private TextBox searchTextBox;
        private Label totalUsersLabel;
        private TabPage updateUserPage;
        private GroupBox createUserBox;
        private Label totalUsersLabelIcon;
    }
}