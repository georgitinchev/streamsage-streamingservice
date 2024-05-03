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
            groupBox3 = new GroupBox();
            settingsDisplayRecommendationsListBox = new ListBox();
            settingsAlgorithmTypeSelectLabel = new Label();
            selectContentBasedCheckBox = new CheckBox();
            selectBehaviorBasedCheckBox = new CheckBox();
            settingsUserPicker = new ComboBox();
            settingsUserPickerLabel = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox4 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            connectionStringLabel = new Label();
            accountSettingsBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            usernameLabelSettings = new Label();
            passwordLabelSettings = new Label();
            emailLabelSettings = new Label();
            settingsTestAlgorithm = new Button();
            settingsGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            accountSettingsBox1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = Color.FromArgb(192, 255, 255);
            settingsGroupBox.Controls.Add(groupBox3);
            settingsGroupBox.Controls.Add(groupBox2);
            settingsGroupBox.Controls.Add(groupBox1);
            settingsGroupBox.Controls.Add(accountSettingsBox1);
            settingsGroupBox.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsGroupBox.Location = new Point(127, 95);
            settingsGroupBox.Margin = new Padding(3, 4, 3, 4);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Padding = new Padding(3, 4, 3, 4);
            settingsGroupBox.Size = new Size(1917, 1186);
            settingsGroupBox.TabIndex = 0;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(settingsTestAlgorithm);
            groupBox3.Controls.Add(settingsDisplayRecommendationsListBox);
            groupBox3.Controls.Add(settingsAlgorithmTypeSelectLabel);
            groupBox3.Controls.Add(selectContentBasedCheckBox);
            groupBox3.Controls.Add(selectBehaviorBasedCheckBox);
            groupBox3.Controls.Add(settingsUserPicker);
            groupBox3.Controls.Add(settingsUserPickerLabel);
            groupBox3.Location = new Point(39, 646);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1835, 487);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Algorithm Test:";
            // 
            // settingsDisplayRecommendationsListBox
            // 
            settingsDisplayRecommendationsListBox.Font = new Font("Rockwell", 13F);
            settingsDisplayRecommendationsListBox.FormattingEnabled = true;
            settingsDisplayRecommendationsListBox.ItemHeight = 25;
            settingsDisplayRecommendationsListBox.Location = new Point(969, 73);
            settingsDisplayRecommendationsListBox.Name = "settingsDisplayRecommendationsListBox";
            settingsDisplayRecommendationsListBox.Size = new Size(805, 354);
            settingsDisplayRecommendationsListBox.TabIndex = 11;
            // 
            // settingsAlgorithmTypeSelectLabel
            // 
            settingsAlgorithmTypeSelectLabel.AutoSize = true;
            settingsAlgorithmTypeSelectLabel.Font = new Font("Rockwell", 20F);
            settingsAlgorithmTypeSelectLabel.Location = new Point(161, 265);
            settingsAlgorithmTypeSelectLabel.Name = "settingsAlgorithmTypeSelectLabel";
            settingsAlgorithmTypeSelectLabel.Size = new Size(373, 38);
            settingsAlgorithmTypeSelectLabel.TabIndex = 10;
            settingsAlgorithmTypeSelectLabel.Text = "Select Algorithm Type:";
            // 
            // selectContentBasedCheckBox
            // 
            selectContentBasedCheckBox.AutoSize = true;
            selectContentBasedCheckBox.Font = new Font("Rockwell", 20F);
            selectContentBasedCheckBox.Location = new Point(372, 359);
            selectContentBasedCheckBox.Name = "selectContentBasedCheckBox";
            selectContentBasedCheckBox.Size = new Size(267, 42);
            selectContentBasedCheckBox.TabIndex = 9;
            selectContentBasedCheckBox.Text = "Content-Based";
            selectContentBasedCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectBehaviorBasedCheckBox
            // 
            selectBehaviorBasedCheckBox.AutoSize = true;
            selectBehaviorBasedCheckBox.Font = new Font("Rockwell", 20F);
            selectBehaviorBasedCheckBox.Location = new Point(53, 359);
            selectBehaviorBasedCheckBox.Name = "selectBehaviorBasedCheckBox";
            selectBehaviorBasedCheckBox.Size = new Size(282, 42);
            selectBehaviorBasedCheckBox.TabIndex = 8;
            selectBehaviorBasedCheckBox.Text = "Behavior-Based";
            selectBehaviorBasedCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsUserPicker
            // 
            settingsUserPicker.Font = new Font("Rockwell", 20F);
            settingsUserPicker.FormattingEnabled = true;
            settingsUserPicker.Location = new Point(84, 157);
            settingsUserPicker.Margin = new Padding(3, 4, 3, 4);
            settingsUserPicker.Name = "settingsUserPicker";
            settingsUserPicker.Size = new Size(491, 45);
            settingsUserPicker.TabIndex = 7;
            // 
            // settingsUserPickerLabel
            // 
            settingsUserPickerLabel.AutoSize = true;
            settingsUserPickerLabel.Font = new Font("Rockwell", 20F);
            settingsUserPickerLabel.Location = new Point(175, 73);
            settingsUserPickerLabel.Name = "settingsUserPickerLabel";
            settingsUserPickerLabel.Size = new Size(312, 38);
            settingsUserPickerLabel.TabIndex = 0;
            settingsUserPickerLabel.Text = "Select Target User:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(39, 65);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(733, 530);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database Settings";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Rockwell", 20F);
            button3.Location = new Point(223, 269);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(267, 73);
            button3.TabIndex = 6;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Rockwell", 20F);
            textBox4.Location = new Point(77, 165);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(612, 47);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20F);
            label1.Location = new Point(214, 96);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 0;
            label1.Text = "Connection String:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(connectionStringLabel);
            groupBox1.Location = new Point(1352, 65);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(522, 530);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appearance Settings";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Rockwell", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 279);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(466, 45);
            comboBox1.TabIndex = 7;
            // 
            // connectionStringLabel
            // 
            connectionStringLabel.AutoSize = true;
            connectionStringLabel.Font = new Font("Rockwell", 20F);
            connectionStringLabel.Location = new Point(129, 195);
            connectionStringLabel.Name = "connectionStringLabel";
            connectionStringLabel.Size = new Size(263, 38);
            connectionStringLabel.TabIndex = 0;
            connectionStringLabel.Text = "Change Theme:";
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
            accountSettingsBox1.Location = new Point(816, 65);
            accountSettingsBox1.Margin = new Padding(3, 4, 3, 4);
            accountSettingsBox1.Name = "accountSettingsBox1";
            accountSettingsBox1.Padding = new Padding(3, 4, 3, 4);
            accountSettingsBox1.Size = new Size(495, 530);
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
            textBox3.Location = new Point(70, 350);
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
            usernameLabelSettings.Location = new Point(159, 50);
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
            // settingsTestAlgorithm
            // 
            settingsTestAlgorithm.BackColor = Color.FromArgb(0, 192, 192);
            settingsTestAlgorithm.Font = new Font("Rockwell", 24F);
            settingsTestAlgorithm.Location = new Point(711, 216);
            settingsTestAlgorithm.Margin = new Padding(3, 4, 3, 4);
            settingsTestAlgorithm.Name = "settingsTestAlgorithm";
            settingsTestAlgorithm.Size = new Size(150, 87);
            settingsTestAlgorithm.TabIndex = 7;
            settingsTestAlgorithm.Text = "Test";
            settingsTestAlgorithm.UseVisualStyleBackColor = false;
            settingsTestAlgorithm.Click += settingsTestAlgorithm_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2174, 1377);
            Controls.Add(settingsGroupBox);
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(2192, 1424);
            MinimumSize = new Size(2192, 1424);
            Name = "SettingsForm";
            Text = "SettingsForm";
            settingsGroupBox.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox4;
        private Label label1;
        private GroupBox groupBox1;
        private Label connectionStringLabel;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private ComboBox settingsUserPicker;
        private Label settingsUserPickerLabel;
        private CheckBox selectContentBasedCheckBox;
        private CheckBox selectBehaviorBasedCheckBox;
        private Label settingsAlgorithmTypeSelectLabel;
        private ListBox settingsDisplayRecommendationsListBox;
        private Button settingsTestAlgorithm;
    }
}