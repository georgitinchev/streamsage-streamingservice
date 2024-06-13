namespace DesktopApp.Forms
{
	partial class Analytics
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
            topRatedMoviesLabel = new Label();
            longestMoviesLabel = new Label();
            mostRecentMoviesLabel = new Label();
            mostRecentUsers = new Label();
            longestRunningMoviesList = new ListBox();
            topRatedMoviesList = new ListBox();
            mostRecentMoviesList = new ListBox();
            mostRecentUsersList = new ListBox();
            SuspendLayout();
            // 
            // topRatedMoviesLabel
            // 
            topRatedMoviesLabel.AutoSize = true;
            topRatedMoviesLabel.Font = new Font("Rockwell", 25F);
            topRatedMoviesLabel.Location = new Point(449, 24);
            topRatedMoviesLabel.Name = "topRatedMoviesLabel";
            topRatedMoviesLabel.Size = new Size(295, 38);
            topRatedMoviesLabel.TabIndex = 0;
            topRatedMoviesLabel.Text = "Top Rated Movies";
            // 
            // longestMoviesLabel
            // 
            longestMoviesLabel.AutoSize = true;
            longestMoviesLabel.Font = new Font("Rockwell", 25F);
            longestMoviesLabel.Location = new Point(1159, 24);
            longestMoviesLabel.Name = "longestMoviesLabel";
            longestMoviesLabel.Size = new Size(397, 38);
            longestMoviesLabel.TabIndex = 3;
            longestMoviesLabel.Text = "Longest Running Movies";
            // 
            // mostRecentMoviesLabel
            // 
            mostRecentMoviesLabel.AutoSize = true;
            mostRecentMoviesLabel.Font = new Font("Rockwell", 25F);
            mostRecentMoviesLabel.Location = new Point(1199, 524);
            mostRecentMoviesLabel.Name = "mostRecentMoviesLabel";
            mostRecentMoviesLabel.Size = new Size(328, 38);
            mostRecentMoviesLabel.TabIndex = 5;
            mostRecentMoviesLabel.Text = "Most Recent Movies";
            // 
            // mostRecentUsers
            // 
            mostRecentUsers.AutoSize = true;
            mostRecentUsers.Font = new Font("Rockwell", 25F);
            mostRecentUsers.Location = new Point(449, 524);
            mostRecentUsers.Name = "mostRecentUsers";
            mostRecentUsers.Size = new Size(304, 38);
            mostRecentUsers.TabIndex = 7;
            mostRecentUsers.Text = "Most Recent Users";
            // 
            // longestRunningMoviesList
            // 
            longestRunningMoviesList.Font = new Font("Rockwell", 15F);
            longestRunningMoviesList.FormattingEnabled = true;
            longestRunningMoviesList.ItemHeight = 22;
            longestRunningMoviesList.Location = new Point(1061, 74);
            longestRunningMoviesList.Name = "longestRunningMoviesList";
            longestRunningMoviesList.Size = new Size(586, 400);
            longestRunningMoviesList.TabIndex = 9;
            // 
            // topRatedMoviesList
            // 
            topRatedMoviesList.Font = new Font("Rockwell", 15F);
            topRatedMoviesList.FormattingEnabled = true;
            topRatedMoviesList.ItemHeight = 22;
            topRatedMoviesList.Location = new Point(303, 74);
            topRatedMoviesList.Name = "topRatedMoviesList";
            topRatedMoviesList.Size = new Size(586, 400);
            topRatedMoviesList.TabIndex = 10;
            // 
            // mostRecentMoviesList
            // 
            mostRecentMoviesList.Font = new Font("Rockwell", 15F);
            mostRecentMoviesList.FormattingEnabled = true;
            mostRecentMoviesList.ItemHeight = 22;
            mostRecentMoviesList.Location = new Point(1061, 577);
            mostRecentMoviesList.Name = "mostRecentMoviesList";
            mostRecentMoviesList.Size = new Size(586, 400);
            mostRecentMoviesList.TabIndex = 11;
            // 
            // mostRecentUsersList
            // 
            mostRecentUsersList.Font = new Font("Rockwell", 15F);
            mostRecentUsersList.FormattingEnabled = true;
            mostRecentUsersList.ItemHeight = 22;
            mostRecentUsersList.Location = new Point(303, 577);
            mostRecentUsersList.Name = "mostRecentUsersList";
            mostRecentUsersList.Size = new Size(586, 400);
            mostRecentUsersList.TabIndex = 12;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1904, 1041);
            Controls.Add(mostRecentUsersList);
            Controls.Add(mostRecentMoviesList);
            Controls.Add(topRatedMoviesList);
            Controls.Add(longestRunningMoviesList);
            Controls.Add(mostRecentUsers);
            Controls.Add(mostRecentMoviesLabel);
            Controls.Add(longestMoviesLabel);
            Controls.Add(topRatedMoviesLabel);
            Margin = new Padding(2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "Analytics";
            Text = "Analytics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topRatedMoviesLabel;
        private Label longestMoviesLabel;
        private Label mostRecentMoviesLabel;
        private Label mostRecentUsers;
        private ListBox longestRunningMoviesList;
        private ListBox topRatedMoviesList;
        private ListBox mostRecentMoviesList;
        private ListBox mostRecentUsersList;
    }
}