namespace DesktopApp.Forms
{
	partial class ReviewManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewManagement));
            reviewTabCtrl = new TabControl();
            reviewMgmtP1 = new TabPage();
            reviewsDataGrid = new DataGridView();
            reviewUpdateP2 = new TabPage();
            updateReviewBtn = new Button();
            updateReviewGroupBox = new GroupBox();
            reviewRatingNumeric = new NumericUpDown();
            reviewTitleText = new TextBox();
            reviewtitleLabel = new Label();
            movieIdLabel = new Label();
            reviewUserIdLabel = new Label();
            ratingLabel = new Label();
            reviewContentText = new TextBox();
            reviewContentLabel = new Label();
            createReviewTabPage = new TabPage();
            createReviewBtn = new Button();
            createMovieIdNumeric = new NumericUpDown();
            createUserIdNumeric = new NumericUpDown();
            targetMovieId = new Label();
            targetUserId = new Label();
            createContentTextBox = new TextBox();
            createRatingNumeric = new NumericUpDown();
            createRatingLabel = new Label();
            createContentLabel = new Label();
            createTitleTextBox = new TextBox();
            createTitleLabel = new Label();
            searchBarReviews = new TextBox();
            searchBtnReviews = new Button();
            filterBarReviews = new ComboBox();
            addReviewBtn = new Button();
            previousPageBtnReviews = new Button();
            nextPageBtnReviews = new Button();
            reviewsDashHomeBtn = new PictureBox();
            totalReviewsLabel = new Label();
            reviewMgmtErrorLabel = new Label();
            reviewTabCtrl.SuspendLayout();
            reviewMgmtP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reviewsDataGrid).BeginInit();
            reviewUpdateP2.SuspendLayout();
            updateReviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reviewRatingNumeric).BeginInit();
            createReviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)createMovieIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createUserIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createRatingNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reviewsDashHomeBtn).BeginInit();
            SuspendLayout();
            // 
            // reviewTabCtrl
            // 
            reviewTabCtrl.Controls.Add(reviewMgmtP1);
            reviewTabCtrl.Controls.Add(reviewUpdateP2);
            reviewTabCtrl.Controls.Add(createReviewTabPage);
            reviewTabCtrl.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reviewTabCtrl.ItemSize = new Size(0, 1);
            reviewTabCtrl.Location = new Point(3, 88);
            reviewTabCtrl.Name = "reviewTabCtrl";
            reviewTabCtrl.SelectedIndex = 0;
            reviewTabCtrl.Size = new Size(1889, 898);
            reviewTabCtrl.SizeMode = TabSizeMode.Fixed;
            reviewTabCtrl.TabIndex = 0;
            // 
            // reviewMgmtP1
            // 
            reviewMgmtP1.BackColor = Color.FromArgb(192, 255, 255);
            reviewMgmtP1.Controls.Add(reviewsDataGrid);
            reviewMgmtP1.Location = new Point(4, 5);
            reviewMgmtP1.Name = "reviewMgmtP1";
            reviewMgmtP1.Padding = new Padding(3);
            reviewMgmtP1.Size = new Size(1881, 889);
            reviewMgmtP1.TabIndex = 0;
            reviewMgmtP1.Text = "Review Management";
            // 
            // reviewsDataGrid
            // 
            reviewsDataGrid.BackgroundColor = Color.FromArgb(192, 255, 255);
            reviewsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reviewsDataGrid.Location = new Point(6, 6);
            reviewsDataGrid.Name = "reviewsDataGrid";
            reviewsDataGrid.RowHeadersWidth = 51;
            reviewsDataGrid.Size = new Size(1869, 950);
            reviewsDataGrid.TabIndex = 0;
            // 
            // reviewUpdateP2
            // 
            reviewUpdateP2.BackColor = Color.FromArgb(192, 255, 255);
            reviewUpdateP2.Controls.Add(updateReviewBtn);
            reviewUpdateP2.Controls.Add(updateReviewGroupBox);
            reviewUpdateP2.Location = new Point(4, 5);
            reviewUpdateP2.Name = "reviewUpdateP2";
            reviewUpdateP2.Padding = new Padding(3);
            reviewUpdateP2.Size = new Size(1881, 889);
            reviewUpdateP2.TabIndex = 1;
            reviewUpdateP2.Text = "Update";
            // 
            // updateReviewBtn
            // 
            updateReviewBtn.BackColor = Color.MediumTurquoise;
            updateReviewBtn.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            updateReviewBtn.Location = new Point(1615, 347);
            updateReviewBtn.Name = "updateReviewBtn";
            updateReviewBtn.Size = new Size(217, 112);
            updateReviewBtn.TabIndex = 16;
            updateReviewBtn.Text = "Update Review";
            updateReviewBtn.UseVisualStyleBackColor = false;
            updateReviewBtn.Click += updateReviewBtn_Click;
            // 
            // updateReviewGroupBox
            // 
            updateReviewGroupBox.Controls.Add(reviewRatingNumeric);
            updateReviewGroupBox.Controls.Add(reviewTitleText);
            updateReviewGroupBox.Controls.Add(reviewtitleLabel);
            updateReviewGroupBox.Controls.Add(movieIdLabel);
            updateReviewGroupBox.Controls.Add(reviewUserIdLabel);
            updateReviewGroupBox.Controls.Add(ratingLabel);
            updateReviewGroupBox.Controls.Add(reviewContentText);
            updateReviewGroupBox.Controls.Add(reviewContentLabel);
            updateReviewGroupBox.Location = new Point(325, 3);
            updateReviewGroupBox.Name = "updateReviewGroupBox";
            updateReviewGroupBox.Size = new Size(1227, 877);
            updateReviewGroupBox.TabIndex = 2;
            updateReviewGroupBox.TabStop = false;
            updateReviewGroupBox.Text = "Update Review";
            // 
            // reviewRatingNumeric
            // 
            reviewRatingNumeric.Font = new Font("Rockwell", 18F);
            reviewRatingNumeric.Location = new Point(345, 706);
            reviewRatingNumeric.Name = "reviewRatingNumeric";
            reviewRatingNumeric.Size = new Size(560, 36);
            reviewRatingNumeric.TabIndex = 10;
            reviewRatingNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // reviewTitleText
            // 
            reviewTitleText.Font = new Font("Rockwell", 18F);
            reviewTitleText.Location = new Point(345, 362);
            reviewTitleText.Name = "reviewTitleText";
            reviewTitleText.Size = new Size(560, 36);
            reviewTitleText.TabIndex = 7;
            // 
            // reviewtitleLabel
            // 
            reviewtitleLabel.AutoSize = true;
            reviewtitleLabel.Font = new Font("Rockwell", 18F);
            reviewtitleLabel.Location = new Point(569, 318);
            reviewtitleLabel.Name = "reviewtitleLabel";
            reviewtitleLabel.Size = new Size(68, 27);
            reviewtitleLabel.TabIndex = 8;
            reviewtitleLabel.Text = "Title:";
            // 
            // movieIdLabel
            // 
            movieIdLabel.AutoSize = true;
            movieIdLabel.Font = new Font("Rockwell", 18F);
            movieIdLabel.Location = new Point(550, 229);
            movieIdLabel.Name = "movieIdLabel";
            movieIdLabel.Size = new Size(110, 27);
            movieIdLabel.TabIndex = 6;
            movieIdLabel.Text = "MovieId:";
            // 
            // reviewUserIdLabel
            // 
            reviewUserIdLabel.AutoSize = true;
            reviewUserIdLabel.Font = new Font("Rockwell", 18F);
            reviewUserIdLabel.Location = new Point(553, 141);
            reviewUserIdLabel.Name = "reviewUserIdLabel";
            reviewUserIdLabel.Size = new Size(92, 27);
            reviewUserIdLabel.TabIndex = 5;
            reviewUserIdLabel.Text = "UserId:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Rockwell", 18F);
            ratingLabel.Location = new Point(555, 657);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(90, 27);
            ratingLabel.TabIndex = 3;
            ratingLabel.Text = "Rating:";
            // 
            // reviewContentText
            // 
            reviewContentText.Font = new Font("Rockwell", 18F);
            reviewContentText.Location = new Point(345, 472);
            reviewContentText.Multiline = true;
            reviewContentText.Name = "reviewContentText";
            reviewContentText.Size = new Size(560, 148);
            reviewContentText.TabIndex = 0;
            // 
            // reviewContentLabel
            // 
            reviewContentLabel.AutoSize = true;
            reviewContentLabel.Font = new Font("Rockwell", 18F);
            reviewContentLabel.Location = new Point(553, 429);
            reviewContentLabel.Name = "reviewContentLabel";
            reviewContentLabel.Size = new Size(107, 27);
            reviewContentLabel.TabIndex = 1;
            reviewContentLabel.Text = "Content:";
            // 
            // createReviewTabPage
            // 
            createReviewTabPage.BackColor = Color.FromArgb(192, 255, 255);
            createReviewTabPage.Controls.Add(createReviewBtn);
            createReviewTabPage.Controls.Add(createMovieIdNumeric);
            createReviewTabPage.Controls.Add(createUserIdNumeric);
            createReviewTabPage.Controls.Add(targetMovieId);
            createReviewTabPage.Controls.Add(targetUserId);
            createReviewTabPage.Controls.Add(createContentTextBox);
            createReviewTabPage.Controls.Add(createRatingNumeric);
            createReviewTabPage.Controls.Add(createRatingLabel);
            createReviewTabPage.Controls.Add(createContentLabel);
            createReviewTabPage.Controls.Add(createTitleTextBox);
            createReviewTabPage.Controls.Add(createTitleLabel);
            createReviewTabPage.Location = new Point(4, 5);
            createReviewTabPage.Name = "createReviewTabPage";
            createReviewTabPage.Padding = new Padding(3);
            createReviewTabPage.Size = new Size(1881, 889);
            createReviewTabPage.TabIndex = 2;
            createReviewTabPage.Text = "Create";
            // 
            // createReviewBtn
            // 
            createReviewBtn.BackColor = Color.MediumTurquoise;
            createReviewBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            createReviewBtn.Location = new Point(1615, 351);
            createReviewBtn.Name = "createReviewBtn";
            createReviewBtn.Size = new Size(212, 116);
            createReviewBtn.TabIndex = 16;
            createReviewBtn.Text = "Create Review";
            createReviewBtn.UseVisualStyleBackColor = false;
            createReviewBtn.Click += createReviewBtn_Click;
            // 
            // createMovieIdNumeric
            // 
            createMovieIdNumeric.Font = new Font("Rockwell", 18F);
            createMovieIdNumeric.Location = new Point(1113, 157);
            createMovieIdNumeric.Name = "createMovieIdNumeric";
            createMovieIdNumeric.Size = new Size(137, 36);
            createMovieIdNumeric.TabIndex = 20;
            createMovieIdNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // createUserIdNumeric
            // 
            createUserIdNumeric.Font = new Font("Rockwell", 18F);
            createUserIdNumeric.Location = new Point(793, 157);
            createUserIdNumeric.Name = "createUserIdNumeric";
            createUserIdNumeric.Size = new Size(148, 36);
            createUserIdNumeric.TabIndex = 19;
            createUserIdNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // targetMovieId
            // 
            targetMovieId.AutoSize = true;
            targetMovieId.Font = new Font("Rockwell", 18F);
            targetMovieId.Location = new Point(988, 166);
            targetMovieId.Name = "targetMovieId";
            targetMovieId.Size = new Size(110, 27);
            targetMovieId.TabIndex = 18;
            targetMovieId.Text = "MovieId:";
            // 
            // targetUserId
            // 
            targetUserId.AutoSize = true;
            targetUserId.Font = new Font("Rockwell", 18F);
            targetUserId.Location = new Point(683, 166);
            targetUserId.Name = "targetUserId";
            targetUserId.Size = new Size(92, 27);
            targetUserId.TabIndex = 17;
            targetUserId.Text = "UserId:";
            // 
            // createContentTextBox
            // 
            createContentTextBox.Font = new Font("Rockwell", 18F);
            createContentTextBox.Location = new Point(683, 454);
            createContentTextBox.Multiline = true;
            createContentTextBox.Name = "createContentTextBox";
            createContentTextBox.Size = new Size(567, 166);
            createContentTextBox.TabIndex = 16;
            // 
            // createRatingNumeric
            // 
            createRatingNumeric.Font = new Font("Rockwell", 18F);
            createRatingNumeric.Location = new Point(683, 713);
            createRatingNumeric.Name = "createRatingNumeric";
            createRatingNumeric.Size = new Size(567, 36);
            createRatingNumeric.TabIndex = 15;
            createRatingNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // createRatingLabel
            // 
            createRatingLabel.AutoSize = true;
            createRatingLabel.Font = new Font("Rockwell", 18F);
            createRatingLabel.Location = new Point(914, 654);
            createRatingLabel.Name = "createRatingLabel";
            createRatingLabel.Size = new Size(90, 27);
            createRatingLabel.TabIndex = 14;
            createRatingLabel.Text = "Rating:";
            // 
            // createContentLabel
            // 
            createContentLabel.AutoSize = true;
            createContentLabel.Font = new Font("Rockwell", 18F);
            createContentLabel.Location = new Point(914, 400);
            createContentLabel.Name = "createContentLabel";
            createContentLabel.Size = new Size(107, 27);
            createContentLabel.TabIndex = 12;
            createContentLabel.Text = "Content:";
            // 
            // createTitleTextBox
            // 
            createTitleTextBox.Font = new Font("Rockwell", 18F);
            createTitleTextBox.Location = new Point(687, 324);
            createTitleTextBox.Name = "createTitleTextBox";
            createTitleTextBox.Size = new Size(567, 36);
            createTitleTextBox.TabIndex = 9;
            // 
            // createTitleLabel
            // 
            createTitleLabel.AutoSize = true;
            createTitleLabel.Font = new Font("Rockwell", 18F);
            createTitleLabel.Location = new Point(936, 275);
            createTitleLabel.Name = "createTitleLabel";
            createTitleLabel.Size = new Size(68, 27);
            createTitleLabel.TabIndex = 10;
            createTitleLabel.Text = "Title:";
            // 
            // searchBarReviews
            // 
            searchBarReviews.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBarReviews.Location = new Point(307, 13);
            searchBarReviews.Name = "searchBarReviews";
            searchBarReviews.Size = new Size(773, 30);
            searchBarReviews.TabIndex = 3;
            // 
            // searchBtnReviews
            // 
            searchBtnReviews.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtnReviews.Location = new Point(1111, 12);
            searchBtnReviews.Name = "searchBtnReviews";
            searchBtnReviews.Size = new Size(198, 31);
            searchBtnReviews.TabIndex = 7;
            searchBtnReviews.Text = "Search 🔍";
            searchBtnReviews.UseVisualStyleBackColor = true;
            // 
            // filterBarReviews
            // 
            filterBarReviews.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterBarReviews.FormattingEnabled = true;
            filterBarReviews.Location = new Point(1328, 12);
            filterBarReviews.Name = "filterBarReviews";
            filterBarReviews.Size = new Size(319, 31);
            filterBarReviews.TabIndex = 4;
            // 
            // addReviewBtn
            // 
            addReviewBtn.BackColor = Color.MediumTurquoise;
            addReviewBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addReviewBtn.Location = new Point(1727, 13);
            addReviewBtn.Name = "addReviewBtn";
            addReviewBtn.Size = new Size(165, 30);
            addReviewBtn.TabIndex = 4;
            addReviewBtn.Text = "Add Review";
            addReviewBtn.UseVisualStyleBackColor = false;
            addReviewBtn.Click += addReviewBtn_Click;
            // 
            // previousPageBtnReviews
            // 
            previousPageBtnReviews.BackColor = Color.MediumTurquoise;
            previousPageBtnReviews.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            previousPageBtnReviews.Location = new Point(7, 992);
            previousPageBtnReviews.Name = "previousPageBtnReviews";
            previousPageBtnReviews.Size = new Size(197, 36);
            previousPageBtnReviews.TabIndex = 12;
            previousPageBtnReviews.Text = "Previous Page";
            previousPageBtnReviews.UseVisualStyleBackColor = false;
            previousPageBtnReviews.Click += previousPageBtnReviews_Click;
            // 
            // nextPageBtnReviews
            // 
            nextPageBtnReviews.BackColor = Color.MediumTurquoise;
            nextPageBtnReviews.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            nextPageBtnReviews.Location = new Point(1695, 992);
            nextPageBtnReviews.Name = "nextPageBtnReviews";
            nextPageBtnReviews.Size = new Size(197, 36);
            nextPageBtnReviews.TabIndex = 13;
            nextPageBtnReviews.Text = "Next Page";
            nextPageBtnReviews.UseVisualStyleBackColor = false;
            nextPageBtnReviews.Click += nextPageBtnReviews_Click;
            // 
            // reviewsDashHomeBtn
            // 
            reviewsDashHomeBtn.Image = (Image)resources.GetObject("reviewsDashHomeBtn.Image");
            reviewsDashHomeBtn.Location = new Point(13, 13);
            reviewsDashHomeBtn.Margin = new Padding(3, 2, 3, 2);
            reviewsDashHomeBtn.Name = "reviewsDashHomeBtn";
            reviewsDashHomeBtn.Size = new Size(52, 48);
            reviewsDashHomeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            reviewsDashHomeBtn.TabIndex = 14;
            reviewsDashHomeBtn.TabStop = false;
            // 
            // totalReviewsLabel
            // 
            totalReviewsLabel.Font = new Font("Rockwell", 14F, FontStyle.Bold);
            totalReviewsLabel.Location = new Point(100, 13);
            totalReviewsLabel.Name = "totalReviewsLabel";
            totalReviewsLabel.Size = new Size(172, 48);
            totalReviewsLabel.TabIndex = 15;
            totalReviewsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reviewMgmtErrorLabel
            // 
            reviewMgmtErrorLabel.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            reviewMgmtErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            reviewMgmtErrorLabel.Location = new Point(307, 51);
            reviewMgmtErrorLabel.Name = "reviewMgmtErrorLabel";
            reviewMgmtErrorLabel.Size = new Size(1340, 34);
            reviewMgmtErrorLabel.TabIndex = 9;
            reviewMgmtErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReviewManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1033);
            Controls.Add(reviewMgmtErrorLabel);
            Controls.Add(totalReviewsLabel);
            Controls.Add(reviewsDashHomeBtn);
            Controls.Add(nextPageBtnReviews);
            Controls.Add(previousPageBtnReviews);
            Controls.Add(addReviewBtn);
            Controls.Add(filterBarReviews);
            Controls.Add(searchBtnReviews);
            Controls.Add(searchBarReviews);
            Controls.Add(reviewTabCtrl);
            MaximumSize = new Size(1920, 1078);
            MinimumSize = new Size(1920, 1052);
            Name = "ReviewManagement";
            Text = "ReviewManagement";
            reviewTabCtrl.ResumeLayout(false);
            reviewMgmtP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reviewsDataGrid).EndInit();
            reviewUpdateP2.ResumeLayout(false);
            updateReviewGroupBox.ResumeLayout(false);
            updateReviewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reviewRatingNumeric).EndInit();
            createReviewTabPage.ResumeLayout(false);
            createReviewTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)createMovieIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)createUserIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)createRatingNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)reviewsDashHomeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl reviewTabCtrl;
        private TabPage reviewMgmtP1;
        private TabPage reviewUpdateP2;
        private DataGridView reviewsDataGrid;
        private TextBox searchBarReviews;
        private Button searchBtnReviews;
        private ComboBox filterBarReviews;
        private Button addReviewBtn;
        private Button previousPageBtnReviews;
        private Button nextPageBtnReviews;
        private PictureBox reviewsDashHomeBtn;
        private Label totalReviewsLabel;
        private Label reviewMgmtErrorLabel;
        private TabPage createReviewTabPage;
        private GroupBox updateReviewGroupBox;
        private Label ratingLabel;
        private TextBox reviewContentText;
        private Label reviewContentLabel;
        private Label movieIdLabel;
        private Label reviewUserIdLabel;
        private TextBox reviewTitleText;
        private Label reviewtitleLabel;
        private Button updateReviewBtn;
        private NumericUpDown createRatingNumeric;
        private Label createRatingLabel;
        private Label createContentLabel;
        private TextBox createTitleTextBox;
        private Label createTitleLabel;
        private TextBox createContentTextBox;
        private Label targetMovieId;
        private Label targetUserId;
        private NumericUpDown createMovieIdNumeric;
        private NumericUpDown createUserIdNumeric;
        private NumericUpDown reviewRatingNumeric;
        private Button createReviewBtn;
    }
}