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
            userCreationPage = new TabPage();
            errorLabel = new Label();
            createUserBtn = new Button();
            lastNameLabel = new Label();
            userLastNameTextBox = new TextBox();
            firstNameLabel = new Label();
            passwordLabel = new Label();
            emailLabel = new Label();
            label1 = new Label();
            userManagementPage = new TabPage();
            backToDashBtn = new Button();
            userOperationsTabCtrl.SuspendLayout();
            userCreationPage.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Rockwell", 14F);
            usernameTextBox.Location = new Point(332, 84);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(411, 40);
            usernameTextBox.TabIndex = 0;
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.Font = new Font("Rockwell", 14F);
            userEmailTextBox.Location = new Point(332, 200);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.Size = new Size(411, 40);
            userEmailTextBox.TabIndex = 1;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Font = new Font("Rockwell", 14F);
            userPasswordTextBox.Location = new Point(332, 333);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(411, 40);
            userPasswordTextBox.TabIndex = 2;
            // 
            // userFirstNameTextBox
            // 
            userFirstNameTextBox.Font = new Font("Rockwell", 14F);
            userFirstNameTextBox.Location = new Point(332, 457);
            userFirstNameTextBox.Name = "userFirstNameTextBox";
            userFirstNameTextBox.Size = new Size(411, 40);
            userFirstNameTextBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Rockwell", 14F);
            usernameLabel.Location = new Point(332, 36);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(411, 45);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userOperationsTabCtrl
            // 
            userOperationsTabCtrl.Controls.Add(userCreationPage);
            userOperationsTabCtrl.Controls.Add(userManagementPage);
            userOperationsTabCtrl.Location = new Point(12, 34);
            userOperationsTabCtrl.Name = "userOperationsTabCtrl";
            userOperationsTabCtrl.SelectedIndex = 0;
            userOperationsTabCtrl.Size = new Size(1147, 957);
            userOperationsTabCtrl.TabIndex = 5;
            // 
            // userCreationPage
            // 
            userCreationPage.BackColor = Color.FromArgb(192, 255, 255);
            userCreationPage.Controls.Add(errorLabel);
            userCreationPage.Controls.Add(createUserBtn);
            userCreationPage.Controls.Add(lastNameLabel);
            userCreationPage.Controls.Add(userLastNameTextBox);
            userCreationPage.Controls.Add(firstNameLabel);
            userCreationPage.Controls.Add(passwordLabel);
            userCreationPage.Controls.Add(emailLabel);
            userCreationPage.Controls.Add(label1);
            userCreationPage.Controls.Add(usernameLabel);
            userCreationPage.Controls.Add(usernameTextBox);
            userCreationPage.Controls.Add(userFirstNameTextBox);
            userCreationPage.Controls.Add(userEmailTextBox);
            userCreationPage.Controls.Add(userPasswordTextBox);
            userCreationPage.Location = new Point(4, 34);
            userCreationPage.Name = "userCreationPage";
            userCreationPage.Padding = new Padding(3);
            userCreationPage.Size = new Size(1139, 919);
            userCreationPage.TabIndex = 0;
            userCreationPage.Text = "Creation";
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(37, 758);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(1062, 152);
            errorLabel.TabIndex = 12;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createUserBtn
            // 
            createUserBtn.BackColor = Color.FromArgb(0, 192, 192);
            createUserBtn.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createUserBtn.Location = new Point(332, 652);
            createUserBtn.Name = "createUserBtn";
            createUserBtn.Size = new Size(411, 75);
            createUserBtn.TabIndex = 11;
            createUserBtn.Text = "Create";
            createUserBtn.UseVisualStyleBackColor = false;
            createUserBtn.Click += createUserBtn_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Font = new Font("Rockwell", 14F);
            lastNameLabel.Location = new Point(332, 537);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(411, 45);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLastNameTextBox
            // 
            userLastNameTextBox.Font = new Font("Rockwell", 14F);
            userLastNameTextBox.Location = new Point(332, 585);
            userLastNameTextBox.Name = "userLastNameTextBox";
            userLastNameTextBox.Size = new Size(411, 40);
            userLastNameTextBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Font = new Font("Rockwell", 14F);
            firstNameLabel.Location = new Point(332, 409);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(411, 45);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Rockwell", 14F);
            passwordLabel.Location = new Point(332, 285);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(411, 45);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Rockwell", 14F);
            emailLabel.Location = new Point(332, 152);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(411, 45);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-4, -15);
            label1.Name = "label1";
            label1.Size = new Size(287, 68);
            label1.TabIndex = 5;
            label1.Text = "Create New User";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userManagementPage
            // 
            userManagementPage.Location = new Point(4, 34);
            userManagementPage.Name = "userManagementPage";
            userManagementPage.Padding = new Padding(3);
            userManagementPage.Size = new Size(1139, 919);
            userManagementPage.TabIndex = 1;
            userManagementPage.Text = "User Management";
            userManagementPage.UseVisualStyleBackColor = true;
            // 
            // backToDashBtn
            // 
            backToDashBtn.BackColor = Color.CornflowerBlue;
            backToDashBtn.Location = new Point(948, 12);
            backToDashBtn.Name = "backToDashBtn";
            backToDashBtn.Size = new Size(211, 41);
            backToDashBtn.TabIndex = 6;
            backToDashBtn.Text = "Back to Admin Dash";
            backToDashBtn.UseVisualStyleBackColor = false;
            backToDashBtn.Click += backToDashBtn_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1176, 1003);
            Controls.Add(backToDashBtn);
            Controls.Add(userOperationsTabCtrl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserManagement";
            Text = "UserManagement";
            userOperationsTabCtrl.ResumeLayout(false);
            userCreationPage.ResumeLayout(false);
            userCreationPage.PerformLayout();
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
        private Label label1;
        private TabPage userManagementPage;
        private Button createUserBtn;
        private Label lastNameLabel;
        private TextBox userLastNameTextBox;
        private Label firstNameLabel;
        private Label passwordLabel;
        private Label emailLabel;
        private Label errorLabel;
        private Button backToDashBtn;
    }
}