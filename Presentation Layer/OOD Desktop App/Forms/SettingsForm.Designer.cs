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
            paginatorSettingsGroup = new GroupBox();
            savePaginatorBtn = new Button();
            itemsPerPageNumeric = new NumericUpDown();
            itemsPerPageLabel = new Label();
            accountSettingsBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            usernameLabelSettings = new Label();
            passwordLabelSettings = new Label();
            emailLabelSettings = new Label();
            settingsErrorLabel = new Label();
            settingsGroupBox.SuspendLayout();
            paginatorSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsPerPageNumeric).BeginInit();
            accountSettingsBox1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = Color.FromArgb(192, 255, 255);
            settingsGroupBox.Controls.Add(paginatorSettingsGroup);
            settingsGroupBox.Controls.Add(accountSettingsBox1);
            settingsGroupBox.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsGroupBox.Location = new Point(127, 95);
            settingsGroupBox.Margin = new Padding(3, 4, 3, 4);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Padding = new Padding(3, 4, 3, 4);
            settingsGroupBox.Size = new Size(1917, 1187);
            settingsGroupBox.TabIndex = 0;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // paginatorSettingsGroup
            // 
            paginatorSettingsGroup.Controls.Add(savePaginatorBtn);
            paginatorSettingsGroup.Controls.Add(itemsPerPageNumeric);
            paginatorSettingsGroup.Controls.Add(itemsPerPageLabel);
            paginatorSettingsGroup.Location = new Point(1056, 446);
            paginatorSettingsGroup.Margin = new Padding(3, 4, 3, 4);
            paginatorSettingsGroup.Name = "paginatorSettingsGroup";
            paginatorSettingsGroup.Padding = new Padding(3, 4, 3, 4);
            paginatorSettingsGroup.Size = new Size(522, 244);
            paginatorSettingsGroup.TabIndex = 8;
            paginatorSettingsGroup.TabStop = false;
            paginatorSettingsGroup.Text = "Paginator Settings";
            // 
            // savePaginatorBtn
            // 
            savePaginatorBtn.BackColor = Color.FromArgb(0, 192, 192);
            savePaginatorBtn.Font = new Font("Rockwell", 20F);
            savePaginatorBtn.Location = new Point(326, 89);
            savePaginatorBtn.Margin = new Padding(3, 4, 3, 4);
            savePaginatorBtn.Name = "savePaginatorBtn";
            savePaginatorBtn.Size = new Size(171, 73);
            savePaginatorBtn.TabIndex = 7;
            savePaginatorBtn.Text = "Save";
            savePaginatorBtn.UseVisualStyleBackColor = false;
            savePaginatorBtn.Click += savePaginatorBtn_Click;
            // 
            // itemsPerPageNumeric
            // 
            itemsPerPageNumeric.Font = new Font("Rockwell", 20F);
            itemsPerPageNumeric.Location = new Point(31, 140);
            itemsPerPageNumeric.Name = "itemsPerPageNumeric";
            itemsPerPageNumeric.Size = new Size(233, 47);
            itemsPerPageNumeric.TabIndex = 8;
            itemsPerPageNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // itemsPerPageLabel
            // 
            itemsPerPageLabel.AutoSize = true;
            itemsPerPageLabel.Font = new Font("Rockwell", 20F);
            itemsPerPageLabel.Location = new Point(31, 63);
            itemsPerPageLabel.Name = "itemsPerPageLabel";
            itemsPerPageLabel.Size = new Size(259, 38);
            itemsPerPageLabel.TabIndex = 0;
            itemsPerPageLabel.Text = "Items Per Page:";
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
            accountSettingsBox1.Location = new Point(364, 310);
            accountSettingsBox1.Margin = new Padding(3, 4, 3, 4);
            accountSettingsBox1.Name = "accountSettingsBox1";
            accountSettingsBox1.Padding = new Padding(3, 4, 3, 4);
            accountSettingsBox1.Size = new Size(495, 531);
            accountSettingsBox1.TabIndex = 3;
            accountSettingsBox1.TabStop = false;
            accountSettingsBox1.Text = "Account Settings";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Rockwell", 20F);
            button1.Location = new Point(117, 427);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(267, 73);
            button1.TabIndex = 6;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Rockwell", 20F);
            textBox3.Location = new Point(70, 349);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(378, 47);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 20F);
            textBox2.Location = new Point(70, 216);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 47);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 20F);
            textBox1.Location = new Point(70, 108);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 47);
            textBox1.TabIndex = 3;
            // 
            // usernameLabelSettings
            // 
            usernameLabelSettings.AutoSize = true;
            usernameLabelSettings.Font = new Font("Rockwell", 20F);
            usernameLabelSettings.Location = new Point(159, 51);
            usernameLabelSettings.Name = "usernameLabelSettings";
            usernameLabelSettings.Size = new Size(184, 38);
            usernameLabelSettings.TabIndex = 0;
            usernameLabelSettings.Text = "Username:";
            // 
            // passwordLabelSettings
            // 
            passwordLabelSettings.AutoSize = true;
            passwordLabelSettings.Font = new Font("Rockwell", 20F);
            passwordLabelSettings.Location = new Point(176, 287);
            passwordLabelSettings.Name = "passwordLabelSettings";
            passwordLabelSettings.Size = new Size(176, 38);
            passwordLabelSettings.TabIndex = 2;
            passwordLabelSettings.Text = "Password:";
            // 
            // emailLabelSettings
            // 
            emailLabelSettings.AutoSize = true;
            emailLabelSettings.Font = new Font("Rockwell", 20F);
            emailLabelSettings.Location = new Point(203, 168);
            emailLabelSettings.Name = "emailLabelSettings";
            emailLabelSettings.Size = new Size(115, 38);
            emailLabelSettings.TabIndex = 1;
            emailLabelSettings.Text = "Email:";
            // 
            // settingsErrorLabel
            // 
            settingsErrorLabel.Font = new Font("Rockwell", 16F);
            settingsErrorLabel.Location = new Point(127, 11);
            settingsErrorLabel.Name = "settingsErrorLabel";
            settingsErrorLabel.Size = new Size(1917, 80);
            settingsErrorLabel.TabIndex = 9;
            settingsErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2174, 1375);
            Controls.Add(settingsErrorLabel);
            Controls.Add(settingsGroupBox);
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(2192, 1422);
            MinimumSize = new Size(2192, 1387);
            Name = "SettingsForm";
            Text = "SettingsForm";
            settingsGroupBox.ResumeLayout(false);
            paginatorSettingsGroup.ResumeLayout(false);
            paginatorSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemsPerPageNumeric).EndInit();
            accountSettingsBox1.ResumeLayout(false);
            accountSettingsBox1.PerformLayout();
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
        private GroupBox paginatorSettingsGroup;
        private Label itemsPerPageLabel;
        private NumericUpDown itemsPerPageNumeric;
        private Button savePaginatorBtn;
        private Label settingsErrorLabel;
    }
}