namespace DesktopApp.Forms
{
	partial class MovieDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDashboard));
            homeBtnMovies = new PictureBox();
            searchBarMovies = new TextBox();
            filterBarMovies = new ComboBox();
            totalMoviesLabel = new Label();
            searchBtn = new Button();
            movieDashTabCtrl = new TabControl();
            movieDashPage = new TabPage();
            moviesDataGrid = new DataGridView();
            editMoviePage = new TabPage();
            movieEditTabControl = new TabControl();
            editMovieDetailsPage = new TabPage();
            updateStatusLabel = new Label();
            updateMovieBtn = new Button();
            editMovieGroup = new GroupBox();
            runTimeLabel = new Label();
            runTimeTextBox = new TextBox();
            trailerURLlabel = new Label();
            trailerUrlTextBox = new TextBox();
            posterUrl = new Label();
            posterUrlTextBox = new TextBox();
            descriptionTextBox = new RichTextBox();
            movieDescriptionLabel = new Label();
            movieYearPicker = new DateTimePicker();
            movieYearLabel = new Label();
            movieTitleLabel = new Label();
            movieTitleBox = new TextBox();
            createMoviePage = new TabPage();
            createMovieDetailsGroup = new TabPage();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            createMovieBtn = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)homeBtnMovies).BeginInit();
            movieDashTabCtrl.SuspendLayout();
            movieDashPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            editMoviePage.SuspendLayout();
            movieEditTabControl.SuspendLayout();
            editMovieDetailsPage.SuspendLayout();
            editMovieGroup.SuspendLayout();
            createMoviePage.SuspendLayout();
            createMovieDetailsGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // homeBtnMovies
            // 
            homeBtnMovies.BackColor = Color.RoyalBlue;
            homeBtnMovies.Image = (Image)resources.GetObject("homeBtnMovies.Image");
            homeBtnMovies.Location = new Point(3, 2);
            homeBtnMovies.Name = "homeBtnMovies";
            homeBtnMovies.Size = new Size(86, 71);
            homeBtnMovies.SizeMode = PictureBoxSizeMode.StretchImage;
            homeBtnMovies.TabIndex = 1;
            homeBtnMovies.TabStop = false;
            // 
            // searchBarMovies
            // 
            searchBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBarMovies.Location = new Point(288, 36);
            searchBarMovies.Name = "searchBarMovies";
            searchBarMovies.Size = new Size(773, 30);
            searchBarMovies.TabIndex = 2;
            // 
            // filterBarMovies
            // 
            filterBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterBarMovies.FormattingEnabled = true;
            filterBarMovies.Location = new Point(1349, 35);
            filterBarMovies.Name = "filterBarMovies";
            filterBarMovies.Size = new Size(319, 31);
            filterBarMovies.TabIndex = 3;
            // 
            // totalMoviesLabel
            // 
            totalMoviesLabel.Font = new Font("Rockwell", 14F, FontStyle.Bold);
            totalMoviesLabel.Location = new Point(121, 20);
            totalMoviesLabel.Name = "totalMoviesLabel";
            totalMoviesLabel.Size = new Size(135, 46);
            totalMoviesLabel.TabIndex = 5;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(1106, 35);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(198, 31);
            searchBtn.TabIndex = 6;
            searchBtn.Text = "Search 🔍";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // movieDashTabCtrl
            // 
            movieDashTabCtrl.Controls.Add(movieDashPage);
            movieDashTabCtrl.Controls.Add(editMoviePage);
            movieDashTabCtrl.Controls.Add(createMoviePage);
            movieDashTabCtrl.Font = new Font("Rockwell", 17.5F);
            movieDashTabCtrl.Location = new Point(8, 83);
            movieDashTabCtrl.Margin = new Padding(2);
            movieDashTabCtrl.Name = "movieDashTabCtrl";
            movieDashTabCtrl.SelectedIndex = 0;
            movieDashTabCtrl.Size = new Size(1885, 947);
            movieDashTabCtrl.TabIndex = 7;
            // 
            // movieDashPage
            // 
            movieDashPage.BackColor = Color.MediumTurquoise;
            movieDashPage.Controls.Add(moviesDataGrid);
            movieDashPage.Location = new Point(4, 35);
            movieDashPage.Margin = new Padding(2);
            movieDashPage.Name = "movieDashPage";
            movieDashPage.Padding = new Padding(2);
            movieDashPage.Size = new Size(1877, 908);
            movieDashPage.TabIndex = 0;
            movieDashPage.Text = "Movie Dashboard";
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Location = new Point(5, 5);
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.RowHeadersWidth = 62;
            moviesDataGrid.Size = new Size(1867, 898);
            moviesDataGrid.TabIndex = 5;
            // 
            // editMoviePage
            // 
            editMoviePage.BackColor = Color.MediumTurquoise;
            editMoviePage.Controls.Add(movieEditTabControl);
            editMoviePage.Location = new Point(4, 35);
            editMoviePage.Margin = new Padding(2);
            editMoviePage.Name = "editMoviePage";
            editMoviePage.Padding = new Padding(2);
            editMoviePage.Size = new Size(1877, 908);
            editMoviePage.TabIndex = 1;
            editMoviePage.Text = "Edit Movie";
            // 
            // movieEditTabControl
            // 
            movieEditTabControl.Controls.Add(editMovieDetailsPage);
            movieEditTabControl.Location = new Point(28, 18);
            movieEditTabControl.Name = "movieEditTabControl";
            movieEditTabControl.SelectedIndex = 0;
            movieEditTabControl.Size = new Size(1822, 865);
            movieEditTabControl.TabIndex = 1;
            // 
            // editMovieDetailsPage
            // 
            editMovieDetailsPage.Controls.Add(updateStatusLabel);
            editMovieDetailsPage.Controls.Add(updateMovieBtn);
            editMovieDetailsPage.Controls.Add(editMovieGroup);
            editMovieDetailsPage.Location = new Point(4, 35);
            editMovieDetailsPage.Name = "editMovieDetailsPage";
            editMovieDetailsPage.Padding = new Padding(3);
            editMovieDetailsPage.Size = new Size(1814, 826);
            editMovieDetailsPage.TabIndex = 0;
            editMovieDetailsPage.Text = "Edit Movie Details";
            editMovieDetailsPage.UseVisualStyleBackColor = true;
            // 
            // updateStatusLabel
            // 
            updateStatusLabel.Font = new Font("Rockwell", 20F);
            updateStatusLabel.ForeColor = Color.FromArgb(0, 192, 0);
            updateStatusLabel.Location = new Point(27, 231);
            updateStatusLabel.Name = "updateStatusLabel";
            updateStatusLabel.Size = new Size(375, 349);
            updateStatusLabel.TabIndex = 2;
            updateStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateMovieBtn
            // 
            updateMovieBtn.BackColor = Color.MediumTurquoise;
            updateMovieBtn.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            updateMovieBtn.Location = new Point(1443, 308);
            updateMovieBtn.Name = "updateMovieBtn";
            updateMovieBtn.Size = new Size(279, 168);
            updateMovieBtn.TabIndex = 1;
            updateMovieBtn.Text = "Update Movie";
            updateMovieBtn.UseVisualStyleBackColor = false;
            updateMovieBtn.Click += updateMovieBtn_Click;
            // 
            // editMovieGroup
            // 
            editMovieGroup.BackColor = Color.MintCream;
            editMovieGroup.Controls.Add(runTimeLabel);
            editMovieGroup.Controls.Add(runTimeTextBox);
            editMovieGroup.Controls.Add(trailerURLlabel);
            editMovieGroup.Controls.Add(trailerUrlTextBox);
            editMovieGroup.Controls.Add(posterUrl);
            editMovieGroup.Controls.Add(posterUrlTextBox);
            editMovieGroup.Controls.Add(descriptionTextBox);
            editMovieGroup.Controls.Add(movieDescriptionLabel);
            editMovieGroup.Controls.Add(movieYearPicker);
            editMovieGroup.Controls.Add(movieYearLabel);
            editMovieGroup.Controls.Add(movieTitleLabel);
            editMovieGroup.Controls.Add(movieTitleBox);
            editMovieGroup.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editMovieGroup.Location = new Point(424, 27);
            editMovieGroup.Name = "editMovieGroup";
            editMovieGroup.Size = new Size(882, 768);
            editMovieGroup.TabIndex = 0;
            editMovieGroup.TabStop = false;
            editMovieGroup.Text = "Movie Dialogue:";
            // 
            // runTimeLabel
            // 
            runTimeLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            runTimeLabel.Location = new Point(370, 663);
            runTimeLabel.Name = "runTimeLabel";
            runTimeLabel.Size = new Size(142, 32);
            runTimeLabel.TabIndex = 12;
            runTimeLabel.Text = "Run Time ";
            // 
            // runTimeTextBox
            // 
            runTimeTextBox.Font = new Font("Rockwell", 20F);
            runTimeTextBox.Location = new Point(231, 698);
            runTimeTextBox.Name = "runTimeTextBox";
            runTimeTextBox.Size = new Size(413, 39);
            runTimeTextBox.TabIndex = 11;
            // 
            // trailerURLlabel
            // 
            trailerURLlabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trailerURLlabel.Location = new Point(361, 567);
            trailerURLlabel.Name = "trailerURLlabel";
            trailerURLlabel.Size = new Size(162, 32);
            trailerURLlabel.TabIndex = 10;
            trailerURLlabel.Text = "TrailerURL";
            // 
            // trailerUrlTextBox
            // 
            trailerUrlTextBox.Font = new Font("Rockwell", 20F);
            trailerUrlTextBox.Location = new Point(231, 612);
            trailerUrlTextBox.Name = "trailerUrlTextBox";
            trailerUrlTextBox.Size = new Size(413, 39);
            trailerUrlTextBox.TabIndex = 9;
            // 
            // posterUrl
            // 
            posterUrl.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posterUrl.Location = new Point(361, 464);
            posterUrl.Name = "posterUrl";
            posterUrl.Size = new Size(162, 32);
            posterUrl.TabIndex = 8;
            posterUrl.Text = "Poster URL";
            // 
            // posterUrlTextBox
            // 
            posterUrlTextBox.Font = new Font("Rockwell", 20F);
            posterUrlTextBox.Location = new Point(231, 514);
            posterUrlTextBox.Name = "posterUrlTextBox";
            posterUrlTextBox.Size = new Size(413, 39);
            posterUrlTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 15F);
            descriptionTextBox.Location = new Point(231, 329);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(413, 120);
            descriptionTextBox.TabIndex = 6;
            descriptionTextBox.Text = "";
            // 
            // movieDescriptionLabel
            // 
            movieDescriptionLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieDescriptionLabel.Location = new Point(311, 281);
            movieDescriptionLabel.Name = "movieDescriptionLabel";
            movieDescriptionLabel.Size = new Size(247, 32);
            movieDescriptionLabel.TabIndex = 5;
            movieDescriptionLabel.Text = "Movie Description";
            // 
            // movieYearPicker
            // 
            movieYearPicker.Font = new Font("Segoe UI", 20F);
            movieYearPicker.Location = new Point(231, 204);
            movieYearPicker.Name = "movieYearPicker";
            movieYearPicker.Size = new Size(413, 43);
            movieYearPicker.TabIndex = 3;
            // 
            // movieYearLabel
            // 
            movieYearLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieYearLabel.Location = new Point(350, 152);
            movieYearLabel.Name = "movieYearLabel";
            movieYearLabel.Size = new Size(162, 32);
            movieYearLabel.TabIndex = 2;
            movieYearLabel.Text = "Movie Year";
            // 
            // movieTitleLabel
            // 
            movieTitleLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTitleLabel.Location = new Point(350, 39);
            movieTitleLabel.Name = "movieTitleLabel";
            movieTitleLabel.Size = new Size(162, 32);
            movieTitleLabel.TabIndex = 1;
            movieTitleLabel.Text = "Movie Title";
            // 
            // movieTitleBox
            // 
            movieTitleBox.Font = new Font("Rockwell", 20F);
            movieTitleBox.Location = new Point(231, 86);
            movieTitleBox.Name = "movieTitleBox";
            movieTitleBox.Size = new Size(413, 39);
            movieTitleBox.TabIndex = 0;
            // 
            // createMoviePage
            // 
            createMoviePage.BackColor = Color.MediumTurquoise;
            createMoviePage.Controls.Add(tabControl1);
            createMoviePage.Location = new Point(4, 35);
            createMoviePage.Name = "createMoviePage";
            createMoviePage.Padding = new Padding(3);
            createMoviePage.Size = new Size(1877, 908);
            createMoviePage.TabIndex = 2;
            createMoviePage.Text = "Create Movie";
            // 
            // createMovieDetailsGroup
            // 
            createMovieDetailsGroup.Controls.Add(label1);
            createMovieDetailsGroup.Controls.Add(createMovieBtn);
            createMovieDetailsGroup.Controls.Add(groupBox1);
            createMovieDetailsGroup.Location = new Point(4, 35);
            createMovieDetailsGroup.Name = "createMovieDetailsGroup";
            createMovieDetailsGroup.Padding = new Padding(3);
            createMovieDetailsGroup.Size = new Size(1814, 826);
            createMovieDetailsGroup.TabIndex = 0;
            createMovieDetailsGroup.Text = "Create Movie Details";
            createMovieDetailsGroup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MintCream;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(424, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 768);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Dialogue:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Rockwell", 20F);
            textBox4.Location = new Point(231, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(413, 39);
            textBox4.TabIndex = 0;
            // 
            // label7
            // 
            label7.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(350, 39);
            label7.Name = "label7";
            label7.Size = new Size(162, 32);
            label7.TabIndex = 1;
            label7.Text = "Movie Title";
            // 
            // label6
            // 
            label6.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(350, 152);
            label6.Name = "label6";
            label6.Size = new Size(162, 32);
            label6.TabIndex = 2;
            label6.Text = "Movie Year";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 20F);
            dateTimePicker1.Location = new Point(231, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(413, 43);
            dateTimePicker1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(311, 281);
            label5.Name = "label5";
            label5.Size = new Size(247, 32);
            label5.TabIndex = 5;
            label5.Text = "Movie Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 15F);
            richTextBox1.Location = new Point(231, 329);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(413, 120);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Rockwell", 20F);
            textBox3.Location = new Point(231, 514);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 39);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(361, 464);
            label4.Name = "label4";
            label4.Size = new Size(162, 32);
            label4.TabIndex = 8;
            label4.Text = "Poster URL";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 20F);
            textBox2.Location = new Point(231, 612);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 39);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 567);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 10;
            label3.Text = "TrailerURL";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 20F);
            textBox1.Location = new Point(231, 698);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 39);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 663);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 12;
            label2.Text = "Run Time ";
            // 
            // createMovieBtn
            // 
            createMovieBtn.BackColor = Color.MediumTurquoise;
            createMovieBtn.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            createMovieBtn.Location = new Point(1443, 308);
            createMovieBtn.Name = "createMovieBtn";
            createMovieBtn.Size = new Size(279, 168);
            createMovieBtn.TabIndex = 1;
            createMovieBtn.Text = "Create Movie";
            createMovieBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell", 20F);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(27, 231);
            label1.Name = "label1";
            label1.Size = new Size(375, 349);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(createMovieDetailsGroup);
            tabControl1.Location = new Point(27, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1822, 865);
            tabControl1.TabIndex = 2;
            // 
            // MovieDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1904, 1041);
            Controls.Add(movieDashTabCtrl);
            Controls.Add(searchBtn);
            Controls.Add(totalMoviesLabel);
            Controls.Add(filterBarMovies);
            Controls.Add(searchBarMovies);
            Controls.Add(homeBtnMovies);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "MovieDashboard";
            Text = "MovieDashboard";
            ((System.ComponentModel.ISupportInitialize)homeBtnMovies).EndInit();
            movieDashTabCtrl.ResumeLayout(false);
            movieDashPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            editMoviePage.ResumeLayout(false);
            movieEditTabControl.ResumeLayout(false);
            editMovieDetailsPage.ResumeLayout(false);
            editMovieGroup.ResumeLayout(false);
            editMovieGroup.PerformLayout();
            createMoviePage.ResumeLayout(false);
            createMovieDetailsGroup.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox homeBtnMovies;
		private TextBox searchBarMovies;
		private ComboBox filterBarMovies;
		private Label totalMoviesLabel;
		private Button searchBtn;
        private TabControl movieDashTabCtrl;
        private TabPage movieDashPage;
        private DataGridView moviesDataGrid;
        private TabPage editMoviePage;
        private TabControl movieEditTabControl;
        private TabPage editMovieDetailsPage;
        private GroupBox editMovieGroup;
        private Label runTimeLabel;
        private TextBox runTimeTextBox;
        private Label trailerURLlabel;
        private TextBox trailerUrlTextBox;
        private Label posterUrl;
        private TextBox posterUrlTextBox;
        private RichTextBox descriptionTextBox;
        private Label movieDescriptionLabel;
        private DateTimePicker movieYearPicker;
        private Label movieYearLabel;
        private Label movieTitleLabel;
        private TextBox movieTitleBox;
        private Button updateMovieBtn;
        private Label updateStatusLabel;
        private TabPage createMoviePage;
        private TabControl tabControl1;
        private TabPage createMovieDetailsGroup;
        private Label label1;
        private Button createMovieBtn;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
    }
}