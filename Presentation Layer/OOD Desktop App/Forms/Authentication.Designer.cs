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
            label2 = new Label();
            label1 = new Label();
            userNameLoginTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginBtn = new Button();
            noCredentialsBtn = new Button();
            passwordLoginTextBox = new TextBox();
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
            textBoxGroupBox.Location = new Point(479, 333);
            textBoxGroupBox.Margin = new Padding(4, 5, 4, 5);
            textBoxGroupBox.Name = "textBoxGroupBox";
            textBoxGroupBox.Padding = new Padding(4, 5, 4, 5);
            textBoxGroupBox.Size = new Size(759, 518);
            textBoxGroupBox.TabIndex = 0;
            textBoxGroupBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 300);
            label2.Name = "label2";
            label2.Size = new Size(351, 33);
            label2.TabIndex = 3;
            label2.Text = "🔑 Enter your password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 87);
            label1.Name = "label1";
            label1.Size = new Size(358, 33);
            label1.TabIndex = 2;
            label1.Text = "👤 Enter your username:";
            // 
            // userNameLoginTextBox
            // 
            userNameLoginTextBox.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLoginTextBox.Location = new Point(189, 125);
            userNameLoginTextBox.Margin = new Padding(4, 5, 4, 5);
            userNameLoginTextBox.Name = "userNameLoginTextBox";
            userNameLoginTextBox.Size = new Size(368, 59);
            userNameLoginTextBox.TabIndex = 0;
            userNameLoginTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sage_transparent;
            pictureBox1.Location = new Point(696, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.japanese_cloud_transparent;
            pictureBox2.Location = new Point(1034, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.movie;
            pictureBox3.Location = new Point(517, 20);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(170, 152);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(680, 890);
            loginBtn.Margin = new Padding(4, 5, 4, 5);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(346, 95);
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
            noCredentialsBtn.Font = new Font("Rockwell", 9.25F);
            noCredentialsBtn.Location = new Point(1481, 948);
            noCredentialsBtn.Margin = new Padding(4, 5, 4, 5);
            noCredentialsBtn.Name = "noCredentialsBtn";
            noCredentialsBtn.Size = new Size(247, 75);
            noCredentialsBtn.TabIndex = 5;
            noCredentialsBtn.Text = "Don't have credentials? Contact administrator";
            noCredentialsBtn.UseVisualStyleBackColor = false;
            // 
            // passwordLoginTextBox
            // 
            passwordLoginTextBox.Font = new Font("Rockwell", 21F);
            passwordLoginTextBox.Location = new Point(189, 349);
            passwordLoginTextBox.Name = "passwordLoginTextBox";
            passwordLoginTextBox.PasswordChar = '*';
            passwordLoginTextBox.Size = new Size(368, 57);
            passwordLoginTextBox.TabIndex = 4;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1734, 1030);
            Controls.Add(noCredentialsBtn);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxGroupBox);
            ForeColor = Color.Black;
            Margin = new Padding(4, 5, 4, 5);
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