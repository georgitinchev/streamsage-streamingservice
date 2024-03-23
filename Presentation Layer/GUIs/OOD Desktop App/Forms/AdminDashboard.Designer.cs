namespace DesktopApp
{
	partial class AdminDashboard
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
			quickStatsGroupBox = new GroupBox();
			label4 = new Label();
			totalReviewsLabel = new Label();
			totalUsersLabel = new Label();
			totalMoviesLabel = new Label();
			buttonGroupBox = new GroupBox();
			label3 = new Label();
			analyticsLabel = new Label();
			label2 = new Label();
			interpretationsLabel = new Label();
			usersLabel = new Label();
			reviewsLabel = new Label();
			moviesLabel = new Label();
			settingsBtnPic = new PictureBox();
			usersBtnPic = new PictureBox();
			analyticsBtnPic = new PictureBox();
			interpretationsBtnPic = new PictureBox();
			reviewsBtnPic = new PictureBox();
			moviesBtnPicture = new PictureBox();
			logoutBtn = new Button();
			greetingsLabel = new Label();
			label1 = new Label();
			pictureBox7 = new PictureBox();
			pictureBox8 = new PictureBox();
			quickStatsGroupBox.SuspendLayout();
			buttonGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)settingsBtnPic).BeginInit();
			((System.ComponentModel.ISupportInitialize)usersBtnPic).BeginInit();
			((System.ComponentModel.ISupportInitialize)analyticsBtnPic).BeginInit();
			((System.ComponentModel.ISupportInitialize)interpretationsBtnPic).BeginInit();
			((System.ComponentModel.ISupportInitialize)reviewsBtnPic).BeginInit();
			((System.ComponentModel.ISupportInitialize)moviesBtnPicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
			SuspendLayout();
			// 
			// quickStatsGroupBox
			// 
			quickStatsGroupBox.BackColor = Color.FromArgb(128, 255, 255);
			quickStatsGroupBox.Controls.Add(label4);
			quickStatsGroupBox.Controls.Add(totalReviewsLabel);
			quickStatsGroupBox.Controls.Add(totalUsersLabel);
			quickStatsGroupBox.Controls.Add(totalMoviesLabel);
			quickStatsGroupBox.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			quickStatsGroupBox.ForeColor = SystemColors.ActiveCaptionText;
			quickStatsGroupBox.Location = new Point(23, 176);
			quickStatsGroupBox.Name = "quickStatsGroupBox";
			quickStatsGroupBox.Size = new Size(171, 269);
			quickStatsGroupBox.TabIndex = 0;
			quickStatsGroupBox.TabStop = false;
			quickStatsGroupBox.Text = "Quick Stats";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Rockwell", 11.25F);
			label4.Location = new Point(6, 214);
			label4.Name = "label4";
			label4.Size = new Size(154, 17);
			label4.TabIndex = 2;
			label4.Text = "Total Interpretations";
			// 
			// totalReviewsLabel
			// 
			totalReviewsLabel.AutoSize = true;
			totalReviewsLabel.Font = new Font("Rockwell", 11.25F);
			totalReviewsLabel.Location = new Point(31, 163);
			totalReviewsLabel.Name = "totalReviewsLabel";
			totalReviewsLabel.Size = new Size(107, 17);
			totalReviewsLabel.TabIndex = 1;
			totalReviewsLabel.Text = "Total Reviews";
			// 
			// totalUsersLabel
			// 
			totalUsersLabel.AutoSize = true;
			totalUsersLabel.Font = new Font("Rockwell", 11.25F);
			totalUsersLabel.Location = new Point(31, 105);
			totalUsersLabel.Name = "totalUsersLabel";
			totalUsersLabel.Size = new Size(87, 17);
			totalUsersLabel.TabIndex = 1;
			totalUsersLabel.Text = "Total Users";
			// 
			// totalMoviesLabel
			// 
			totalMoviesLabel.AutoSize = true;
			totalMoviesLabel.Font = new Font("Rockwell", 11.25F);
			totalMoviesLabel.Location = new Point(31, 45);
			totalMoviesLabel.Name = "totalMoviesLabel";
			totalMoviesLabel.Size = new Size(99, 17);
			totalMoviesLabel.TabIndex = 0;
			totalMoviesLabel.Text = "Total Movies";
			// 
			// buttonGroupBox
			// 
			buttonGroupBox.BackColor = Color.FromArgb(0, 192, 192);
			buttonGroupBox.Controls.Add(label3);
			buttonGroupBox.Controls.Add(analyticsLabel);
			buttonGroupBox.Controls.Add(label2);
			buttonGroupBox.Controls.Add(interpretationsLabel);
			buttonGroupBox.Controls.Add(usersLabel);
			buttonGroupBox.Controls.Add(reviewsLabel);
			buttonGroupBox.Controls.Add(moviesLabel);
			buttonGroupBox.Controls.Add(settingsBtnPic);
			buttonGroupBox.Controls.Add(usersBtnPic);
			buttonGroupBox.Controls.Add(analyticsBtnPic);
			buttonGroupBox.Controls.Add(interpretationsBtnPic);
			buttonGroupBox.Controls.Add(reviewsBtnPic);
			buttonGroupBox.Controls.Add(moviesBtnPicture);
			buttonGroupBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			buttonGroupBox.Location = new Point(211, 102);
			buttonGroupBox.Name = "buttonGroupBox";
			buttonGroupBox.Size = new Size(739, 439);
			buttonGroupBox.TabIndex = 1;
			buttonGroupBox.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.LightGray;
			label3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(115, 0);
			label3.Name = "label3";
			label3.Size = new Size(550, 23);
			label3.TabIndex = 7;
			label3.Text = "Only movies is implemented to draw from DB as of today";
			// 
			// analyticsLabel
			// 
			analyticsLabel.AutoSize = true;
			analyticsLabel.Font = new Font("Rockwell", 12F, FontStyle.Bold);
			analyticsLabel.Location = new Point(320, 385);
			analyticsLabel.Name = "analyticsLabel";
			analyticsLabel.Size = new Size(84, 19);
			analyticsLabel.TabIndex = 11;
			analyticsLabel.Text = "Analytics";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(538, 385);
			label2.Name = "label2";
			label2.Size = new Size(73, 19);
			label2.TabIndex = 10;
			label2.Text = "Settings";
			// 
			// interpretationsLabel
			// 
			interpretationsLabel.AutoSize = true;
			interpretationsLabel.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			interpretationsLabel.Location = new Point(85, 385);
			interpretationsLabel.Name = "interpretationsLabel";
			interpretationsLabel.Size = new Size(131, 19);
			interpretationsLabel.TabIndex = 9;
			interpretationsLabel.Text = "Interpretations ";
			// 
			// usersLabel
			// 
			usersLabel.AutoSize = true;
			usersLabel.Font = new Font("Rockwell", 12F, FontStyle.Bold);
			usersLabel.Location = new Point(551, 185);
			usersLabel.Name = "usersLabel";
			usersLabel.Size = new Size(52, 19);
			usersLabel.TabIndex = 8;
			usersLabel.Text = "Users";
			// 
			// reviewsLabel
			// 
			reviewsLabel.AutoSize = true;
			reviewsLabel.Font = new Font("Rockwell", 12F, FontStyle.Bold);
			reviewsLabel.Location = new Point(320, 185);
			reviewsLabel.Name = "reviewsLabel";
			reviewsLabel.Size = new Size(79, 19);
			reviewsLabel.TabIndex = 7;
			reviewsLabel.Text = "Reviews ";
			// 
			// moviesLabel
			// 
			moviesLabel.AutoSize = true;
			moviesLabel.Font = new Font("Rockwell", 12F, FontStyle.Bold);
			moviesLabel.Location = new Point(105, 185);
			moviesLabel.Name = "moviesLabel";
			moviesLabel.Size = new Size(67, 19);
			moviesLabel.TabIndex = 6;
			moviesLabel.Text = "Movies";
			// 
			// settingsBtnPic
			// 
			settingsBtnPic.Image = (Image)resources.GetObject("settingsBtnPic.Image");
			settingsBtnPic.Location = new Point(517, 248);
			settingsBtnPic.Name = "settingsBtnPic";
			settingsBtnPic.Size = new Size(126, 122);
			settingsBtnPic.SizeMode = PictureBoxSizeMode.StretchImage;
			settingsBtnPic.TabIndex = 5;
			settingsBtnPic.TabStop = false;
			// 
			// usersBtnPic
			// 
			usersBtnPic.Image = (Image)resources.GetObject("usersBtnPic.Image");
			usersBtnPic.Location = new Point(517, 47);
			usersBtnPic.Name = "usersBtnPic";
			usersBtnPic.Size = new Size(126, 122);
			usersBtnPic.SizeMode = PictureBoxSizeMode.StretchImage;
			usersBtnPic.TabIndex = 4;
			usersBtnPic.TabStop = false;
			// 
			// analyticsBtnPic
			// 
			analyticsBtnPic.Image = (Image)resources.GetObject("analyticsBtnPic.Image");
			analyticsBtnPic.Location = new Point(299, 248);
			analyticsBtnPic.Name = "analyticsBtnPic";
			analyticsBtnPic.Size = new Size(126, 122);
			analyticsBtnPic.SizeMode = PictureBoxSizeMode.StretchImage;
			analyticsBtnPic.TabIndex = 3;
			analyticsBtnPic.TabStop = false;
			// 
			// interpretationsBtnPic
			// 
			interpretationsBtnPic.Image = (Image)resources.GetObject("interpretationsBtnPic.Image");
			interpretationsBtnPic.Location = new Point(81, 248);
			interpretationsBtnPic.Name = "interpretationsBtnPic";
			interpretationsBtnPic.Size = new Size(126, 122);
			interpretationsBtnPic.SizeMode = PictureBoxSizeMode.StretchImage;
			interpretationsBtnPic.TabIndex = 2;
			interpretationsBtnPic.TabStop = false;
			// 
			// reviewsBtnPic
			// 
			reviewsBtnPic.Image = (Image)resources.GetObject("reviewsBtnPic.Image");
			reviewsBtnPic.Location = new Point(299, 47);
			reviewsBtnPic.Name = "reviewsBtnPic";
			reviewsBtnPic.Size = new Size(126, 122);
			reviewsBtnPic.SizeMode = PictureBoxSizeMode.StretchImage;
			reviewsBtnPic.TabIndex = 1;
			reviewsBtnPic.TabStop = false;
			// 
			// moviesBtnPicture
			// 
			moviesBtnPicture.Image = (Image)resources.GetObject("moviesBtnPicture.Image");
			moviesBtnPicture.Location = new Point(81, 47);
			moviesBtnPicture.Name = "moviesBtnPicture";
			moviesBtnPicture.Size = new Size(126, 122);
			moviesBtnPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			moviesBtnPicture.TabIndex = 0;
			moviesBtnPicture.TabStop = false;
			moviesBtnPicture.Click += moviesBtnPicture_Click;
			// 
			// logoutBtn
			// 
			logoutBtn.BackColor = Color.FromArgb(0, 192, 192);
			logoutBtn.Font = new Font("Rockwell", 12F, FontStyle.Bold);
			logoutBtn.Location = new Point(1026, 537);
			logoutBtn.Name = "logoutBtn";
			logoutBtn.Size = new Size(105, 63);
			logoutBtn.TabIndex = 2;
			logoutBtn.Text = "↪️ Logout";
			logoutBtn.UseVisualStyleBackColor = false;
			logoutBtn.Click += logoutBtn_Click;
			// 
			// greetingsLabel
			// 
			greetingsLabel.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			greetingsLabel.Location = new Point(326, 9);
			greetingsLabel.Name = "greetingsLabel";
			greetingsLabel.Size = new Size(496, 31);
			greetingsLabel.TabIndex = 3;
			greetingsLabel.Text = "Welcome back Admin";
			greetingsLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(394, 54);
			label1.Name = "label1";
			label1.Size = new Size(374, 23);
			label1.TabIndex = 4;
			label1.Text = "What would you like to manage today?";
			// 
			// pictureBox7
			// 
			pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new Point(39, 31);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new Size(134, 85);
			pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox7.TabIndex = 5;
			pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
			pictureBox8.Location = new Point(978, 31);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new Size(134, 85);
			pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox8.TabIndex = 6;
			pictureBox8.TabStop = false;
			// 
			// AdminDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 255);
			ClientSize = new Size(1133, 602);
			Controls.Add(pictureBox8);
			Controls.Add(pictureBox7);
			Controls.Add(label1);
			Controls.Add(greetingsLabel);
			Controls.Add(logoutBtn);
			Controls.Add(buttonGroupBox);
			Controls.Add(quickStatsGroupBox);
			Margin = new Padding(2);
			Name = "AdminDashboard";
			Text = "Admin Dashboard";
			quickStatsGroupBox.ResumeLayout(false);
			quickStatsGroupBox.PerformLayout();
			buttonGroupBox.ResumeLayout(false);
			buttonGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)settingsBtnPic).EndInit();
			((System.ComponentModel.ISupportInitialize)usersBtnPic).EndInit();
			((System.ComponentModel.ISupportInitialize)analyticsBtnPic).EndInit();
			((System.ComponentModel.ISupportInitialize)interpretationsBtnPic).EndInit();
			((System.ComponentModel.ISupportInitialize)reviewsBtnPic).EndInit();
			((System.ComponentModel.ISupportInitialize)moviesBtnPicture).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox quickStatsGroupBox;
		private Label label4;
		private Label totalReviewsLabel;
		private Label totalUsersLabel;
		private Label totalMoviesLabel;
		private GroupBox buttonGroupBox;
		private Button logoutBtn;
		private Label greetingsLabel;
		private Label label1;
		private Label moviesLabel;
		private PictureBox settingsBtnPic;
		private PictureBox usersBtnPic;
		private PictureBox analyticsBtnPic;
		private PictureBox interpretationsBtnPic;
		private PictureBox reviewsBtnPic;
		private PictureBox moviesBtnPicture;
		private Label interpretationsLabel;
		private Label usersLabel;
		private Label reviewsLabel;
		private PictureBox pictureBox7;
		private PictureBox pictureBox8;
		private Label label2;
		private Label analyticsLabel;
		private Label label3;
	}
}
