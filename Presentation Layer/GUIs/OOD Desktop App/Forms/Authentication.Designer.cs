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
			groupBox1 = new GroupBox();
			passwordLoginTextBox = new RichTextBox();
			userNameLoginTextBox = new RichTextBox();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			loginBtn = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.RoyalBlue;
			groupBox1.Controls.Add(passwordLoginTextBox);
			groupBox1.Controls.Add(userNameLoginTextBox);
			groupBox1.Location = new Point(335, 200);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(531, 311);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// passwordLoginTextBox
			// 
			passwordLoginTextBox.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			passwordLoginTextBox.Location = new Point(132, 203);
			passwordLoginTextBox.Name = "passwordLoginTextBox";
			passwordLoginTextBox.Size = new Size(259, 37);
			passwordLoginTextBox.TabIndex = 1;
			passwordLoginTextBox.Text = "";
			// 
			// userNameLoginTextBox
			// 
			userNameLoginTextBox.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			userNameLoginTextBox.Location = new Point(132, 75);
			userNameLoginTextBox.Name = "userNameLoginTextBox";
			userNameLoginTextBox.Size = new Size(259, 37);
			userNameLoginTextBox.TabIndex = 0;
			userNameLoginTextBox.Text = "";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.sage_transparent;
			pictureBox1.Location = new Point(487, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(231, 194);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.japanese_cloud_transparent;
			pictureBox2.Location = new Point(724, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(121, 91);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.movie;
			pictureBox3.Location = new Point(362, 12);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(119, 91);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 3;
			pictureBox3.TabStop = false;
			// 
			// loginBtn
			// 
			loginBtn.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			loginBtn.Location = new Point(476, 534);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(242, 57);
			loginBtn.TabIndex = 4;
			loginBtn.Text = "Login";
			loginBtn.UseVisualStyleBackColor = true;
			// 
			// Authentication
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 255);
			ClientSize = new Size(1219, 622);
			Controls.Add(loginBtn);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox1);
			ForeColor = Color.Black;
			Name = "Authentication";
			Text = "Authentication";
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private RichTextBox userNameLoginTextBox;
		private RichTextBox passwordLoginTextBox;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Button loginBtn;
	}
}