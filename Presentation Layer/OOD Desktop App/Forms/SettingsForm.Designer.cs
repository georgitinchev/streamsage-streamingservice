namespace DesktopApp.Forms
{
	partial class SettingsForm
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
            settingsGroupBox = new GroupBox();
            usernameLabelSettings = new Label();
            emailLabelSettings = new Label();
            passwordLabelSettings = new Label();
            accountSettingsBox1 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            backToDashBtn = new Button();
            groupBox1 = new GroupBox();
            connectionStringLabel = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox4 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            settingsGroupBox.SuspendLayout();
            accountSettingsBox1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = Color.FromArgb(192, 255, 255);
            settingsGroupBox.Controls.Add(groupBox2);
            settingsGroupBox.Controls.Add(groupBox1);
            settingsGroupBox.Controls.Add(accountSettingsBox1);
            settingsGroupBox.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsGroupBox.Location = new Point(361, 106);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Size = new Size(1218, 797);
            settingsGroupBox.TabIndex = 0;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // usernameLabelSettings
            // 
            usernameLabelSettings.AutoSize = true;
            usernameLabelSettings.Font = new Font("Rockwell", 20F);
            usernameLabelSettings.Location = new Point(108, 113);
            usernameLabelSettings.Name = "usernameLabelSettings";
            usernameLabelSettings.Size = new Size(145, 31);
            usernameLabelSettings.TabIndex = 0;
            usernameLabelSettings.Text = "Username:";
            // 
            // emailLabelSettings
            // 
            emailLabelSettings.AutoSize = true;
            emailLabelSettings.Font = new Font("Rockwell", 20F);
            emailLabelSettings.Location = new Point(129, 258);
            emailLabelSettings.Name = "emailLabelSettings";
            emailLabelSettings.Size = new Size(92, 31);
            emailLabelSettings.TabIndex = 1;
            emailLabelSettings.Text = "Email:";
            // 
            // passwordLabelSettings
            // 
            passwordLabelSettings.AutoSize = true;
            passwordLabelSettings.Font = new Font("Rockwell", 20F);
            passwordLabelSettings.Location = new Point(108, 390);
            passwordLabelSettings.Name = "passwordLabelSettings";
            passwordLabelSettings.Size = new Size(139, 31);
            passwordLabelSettings.TabIndex = 2;
            passwordLabelSettings.Text = "Password:";
            // 
            // accountSettingsBox1
            // 
            accountSettingsBox1.Controls.Add(button1);
            accountSettingsBox1.Controls.Add(textBox3);
            accountSettingsBox1.Controls.Add(textBox2);
            accountSettingsBox1.Controls.Add(textBox1);
            accountSettingsBox1.Controls.Add(usernameLabelSettings);
            accountSettingsBox1.Controls.Add(passwordLabelSettings);
            accountSettingsBox1.Controls.Add(emailLabelSettings);
            accountSettingsBox1.Location = new Point(806, 65);
            accountSettingsBox1.Name = "accountSettingsBox1";
            accountSettingsBox1.Size = new Size(371, 688);
            accountSettingsBox1.TabIndex = 3;
            accountSettingsBox1.TabStop = false;
            accountSettingsBox1.Text = "Account Settings";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 20F);
            textBox1.Location = new Point(70, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 20F);
            textBox2.Location = new Point(70, 292);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Rockwell", 20F);
            textBox3.Location = new Point(70, 437);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 39);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Rockwell", 20F);
            button1.Location = new Point(67, 572);
            button1.Name = "button1";
            button1.Size = new Size(234, 55);
            button1.TabIndex = 6;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            // 
            // backToDashBtn
            // 
            backToDashBtn.BackColor = Color.CornflowerBlue;
            backToDashBtn.Font = new Font("Rockwell", 13F, FontStyle.Bold);
            backToDashBtn.Location = new Point(1679, 11);
            backToDashBtn.Margin = new Padding(2);
            backToDashBtn.Name = "backToDashBtn";
            backToDashBtn.Size = new Size(214, 40);
            backToDashBtn.TabIndex = 7;
            backToDashBtn.Text = "Back to Admin Dash";
            backToDashBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(connectionStringLabel);
            groupBox1.Location = new Point(90, 458);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 295);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appearance Settings";
            // 
            // connectionStringLabel
            // 
            connectionStringLabel.AutoSize = true;
            connectionStringLabel.Font = new Font("Rockwell", 20F);
            connectionStringLabel.Location = new Point(221, 115);
            connectionStringLabel.Name = "connectionStringLabel";
            connectionStringLabel.Size = new Size(209, 31);
            connectionStringLabel.TabIndex = 0;
            connectionStringLabel.Text = "Change Theme:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(90, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 353);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database Settings";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Rockwell", 20F);
            button3.Location = new Point(196, 215);
            button3.Name = "button3";
            button3.Size = new Size(234, 55);
            button3.TabIndex = 6;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Rockwell", 20F);
            textBox4.Location = new Point(67, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(536, 39);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20F);
            label1.Location = new Point(187, 72);
            label1.Name = "label1";
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "Connection String:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Rockwell", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(383, 39);
            comboBox1.TabIndex = 7;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(backToDashBtn);
            Controls.Add(settingsGroupBox);
            Margin = new Padding(2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "SettingsForm";
            Text = "SettingsForm";
            settingsGroupBox.ResumeLayout(false);
            accountSettingsBox1.ResumeLayout(false);
            accountSettingsBox1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox settingsGroupBox;
        private Label passwordLabelSettings;
        private Label emailLabelSettings;
        private Label usernameLabelSettings;
        private GroupBox accountSettingsBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button backToDashBtn;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox4;
        private Label label1;
        private GroupBox groupBox1;
        private Label connectionStringLabel;
        private ComboBox comboBox1;
    }
}