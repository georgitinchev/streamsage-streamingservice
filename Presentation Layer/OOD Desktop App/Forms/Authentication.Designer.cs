namespace DesktopApp.Forms
{
	partial class Authentication
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
            textBoxGroupBox = new GroupBox();
            passwordLoginTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            userNameLoginTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginBtn = new Button();
            noCredentialsBtn = new Button();
            textBoxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBoxGroupBox
            // 
            textBoxGroupBox.BackColor = Color.RoyalBlue;
            textBoxGroupBox.Controls.Add(passwordLoginTextBox);
            textBoxGroupBox.Controls.Add(label2);
            textBoxGroupBox.Controls.Add(label1);
            textBoxGroupBox.Controls.Add(userNameLoginTextBox);
            textBoxGroupBox.Location = new Point(543, 302);
            textBoxGroupBox.Name = "textBoxGroupBox";
            textBoxGroupBox.Size = new Size(829, 463);
            textBoxGroupBox.TabIndex = 0;
            textBoxGroupBox.TabStop = false;
            // 
            // passwordLoginTextBox
            // 
            passwordLoginTextBox.Font = new Font("Rockwell", 20F);
            passwordLoginTextBox.Location = new Point(201, 326);
            passwordLoginTextBox.Margin = new Padding(2, 2, 2, 2);
            passwordLoginTextBox.Name = "passwordLoginTextBox";
            passwordLoginTextBox.PasswordChar = '*';
            passwordLoginTextBox.Size = new Size(414, 39);
            passwordLoginTextBox.TabIndex = 4;
            passwordLoginTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell", 24F, FontStyle.Bold);
            label2.Location = new Point(201, 251);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(430, 43);
            label2.TabIndex = 3;
            label2.Text = "🔑 Enter your password:";
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold);
            label1.Location = new Point(201, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(430, 50);
            label1.TabIndex = 2;
            label1.Text = "👤 Enter your username:";
            // 
            // userNameLoginTextBox
            // 
            userNameLoginTextBox.Font = new Font("Rockwell", 20F);
            userNameLoginTextBox.Location = new Point(201, 152);
            userNameLoginTextBox.Name = "userNameLoginTextBox";
            userNameLoginTextBox.Size = new Size(414, 37);
            userNameLoginTextBox.TabIndex = 0;
            userNameLoginTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sage_transparent;
            pictureBox1.Location = new Point(836, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.japanese_cloud_transparent;
            pictureBox2.Location = new Point(1196, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.movie;
            pictureBox3.Location = new Point(543, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(173, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Rockwell", 30F);
            loginBtn.Location = new Point(744, 847);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(414, 100);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // noCredentialsBtn
            // 
            noCredentialsBtn.BackColor = Color.LightGreen;
            noCredentialsBtn.FlatAppearance.BorderColor = Color.Black;
            noCredentialsBtn.FlatAppearance.BorderSize = 2;
            noCredentialsBtn.Font = new Font("Rockwell", 20F);
            noCredentialsBtn.Location = new Point(1573, 919);
            noCredentialsBtn.Name = "noCredentialsBtn";
            noCredentialsBtn.Size = new Size(319, 110);
            noCredentialsBtn.TabIndex = 5;
            noCredentialsBtn.Text = "Don't have credentials? Contact administrator";
            noCredentialsBtn.UseVisualStyleBackColor = false;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1904, 1041);
            Controls.Add(noCredentialsBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxGroupBox);
            ForeColor = Color.Black;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "Authentication";
            Text = "Authentication";
            textBoxGroupBox.ResumeLayout(false);
            textBoxGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox textBoxGroupBox;
		private RichTextBox userNameLoginTextBox;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Button loginBtn;
		private Button noCredentialsBtn;
		private Label label1;
		private Label label2;
        private TextBox passwordLoginTextBox;
    }
}