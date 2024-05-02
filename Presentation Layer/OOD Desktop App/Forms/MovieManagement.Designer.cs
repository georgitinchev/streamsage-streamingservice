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
            updateMovieGenresLabel = new Label();
            updateMovieCheckListBox = new CheckedListBox();
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
            createMovieTabCtrl = new TabControl();
            createMovieDetailsGroup = new TabPage();
            createMovieErrorLabel = new Label();
            createMovieBtn = new Button();
            createMovieDialogueBox = new GroupBox();
            createMovieGenreLabel = new Label();
            createMovieGenresCheckList = new CheckedListBox();
            createMovieRunTimeLabel = new Label();
            createMovieRunTimeBox = new TextBox();
            createTrailerUrlLabel = new Label();
            createMovieUrlBox = new TextBox();
            createPosterUrlLabel = new Label();
            createMoviePosterBox = new TextBox();
            createMovieDescriptionBox = new RichTextBox();
            createMovieDescriptionLabel = new Label();
            createMovieDatePicker = new DateTimePicker();
            createMovieYearLabel = new Label();
            createMovieTitleLabel = new Label();
            createMovieTitleBox = new TextBox();
            movieMgmtErrorLabel = new Label();
            addMovieBtn = new Button();
            moviesDashHomeBtn = new PictureBox();
            updateMoviePictureBox = new PictureBox();
            movieDashTabCtrl.SuspendLayout();
            movieDashPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            editMoviePage.SuspendLayout();
            movieEditTabControl.SuspendLayout();
            editMovieDetailsPage.SuspendLayout();
            editMovieGroup.SuspendLayout();
            createMoviePage.SuspendLayout();
            createMovieTabCtrl.SuspendLayout();
            createMovieDetailsGroup.SuspendLayout();
            createMovieDialogueBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviesDashHomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateMoviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // searchBarMovies
            // 
            searchBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBarMovies.Location = new Point(329, 14);
            searchBarMovies.Margin = new Padding(3, 4, 3, 4);
            searchBarMovies.Name = "searchBarMovies";
            searchBarMovies.Size = new Size(883, 35);
            searchBarMovies.TabIndex = 2;
            // 
            // filterBarMovies
            // 
            filterBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterBarMovies.FormattingEnabled = true;
            filterBarMovies.Location = new Point(1542, 13);
            filterBarMovies.Margin = new Padding(3, 4, 3, 4);
            filterBarMovies.Name = "filterBarMovies";
            filterBarMovies.Size = new Size(364, 37);
            filterBarMovies.TabIndex = 3;
            // 
            // totalMoviesLabel
            // 
            totalMoviesLabel.Font = new Font("Rockwell", 14F, FontStyle.Bold);
            totalMoviesLabel.Location = new Point(110, 9);
            totalMoviesLabel.Name = "totalMoviesLabel";
            totalMoviesLabel.Size = new Size(196, 79);
            totalMoviesLabel.TabIndex = 5;
            totalMoviesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(1264, 13);
            searchBtn.Margin = new Padding(3, 4, 3, 4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(226, 41);
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
            movieDashTabCtrl.ItemSize = new Size(0, 1);
            movieDashTabCtrl.Location = new Point(9, 111);
            movieDashTabCtrl.Margin = new Padding(2, 3, 2, 3);
            movieDashTabCtrl.Name = "movieDashTabCtrl";
            movieDashTabCtrl.SelectedIndex = 0;
            movieDashTabCtrl.Size = new Size(2154, 1263);
            movieDashTabCtrl.SizeMode = TabSizeMode.Fixed;
            movieDashTabCtrl.TabIndex = 7;
            // 
            // movieDashPage
            // 
            movieDashPage.BackColor = Color.MediumTurquoise;
            movieDashPage.Controls.Add(moviesDataGrid);
            movieDashPage.Location = new Point(4, 5);
            movieDashPage.Margin = new Padding(2, 3, 2, 3);
            movieDashPage.Name = "movieDashPage";
            movieDashPage.Padding = new Padding(2, 3, 2, 3);
            movieDashPage.Size = new Size(2146, 1254);
            movieDashPage.TabIndex = 0;
            movieDashPage.Text = "Movie Dashboard";
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Location = new Point(6, 7);
            moviesDataGrid.Margin = new Padding(3, 4, 3, 4);
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.RowHeadersWidth = 62;
            moviesDataGrid.Size = new Size(2134, 1241);
            moviesDataGrid.TabIndex = 5;
            // 
            // editMoviePage
            // 
            editMoviePage.BackColor = Color.MediumTurquoise;
            editMoviePage.Controls.Add(movieEditTabControl);
            editMoviePage.Location = new Point(4, 5);
            editMoviePage.Margin = new Padding(2, 3, 2, 3);
            editMoviePage.Name = "editMoviePage";
            editMoviePage.Padding = new Padding(2, 3, 2, 3);
            editMoviePage.Size = new Size(2146, 1254);
            editMoviePage.TabIndex = 1;
            editMoviePage.Text = "Edit Movie";
            // 
            // movieEditTabControl
            // 
            movieEditTabControl.Controls.Add(editMovieDetailsPage);
            movieEditTabControl.Location = new Point(32, 24);
            movieEditTabControl.Margin = new Padding(3, 4, 3, 4);
            movieEditTabControl.Name = "movieEditTabControl";
            movieEditTabControl.SelectedIndex = 0;
            movieEditTabControl.Size = new Size(2082, 1213);
            movieEditTabControl.TabIndex = 1;
            // 
            // editMovieDetailsPage
            // 
            editMovieDetailsPage.Controls.Add(updateMoviePictureBox);
            editMovieDetailsPage.Controls.Add(updateStatusLabel);
            editMovieDetailsPage.Controls.Add(updateMovieBtn);
            editMovieDetailsPage.Controls.Add(editMovieGroup);
            editMovieDetailsPage.Location = new Point(4, 41);
            editMovieDetailsPage.Margin = new Padding(3, 4, 3, 4);
            editMovieDetailsPage.Name = "editMovieDetailsPage";
            editMovieDetailsPage.Padding = new Padding(3, 4, 3, 4);
            editMovieDetailsPage.Size = new Size(2074, 1168);
            editMovieDetailsPage.TabIndex = 0;
            editMovieDetailsPage.Text = "Edit Movie Details";
            editMovieDetailsPage.UseVisualStyleBackColor = true;
            // 
            // updateStatusLabel
            // 
            updateStatusLabel.Font = new Font("Rockwell", 20F);
            updateStatusLabel.ForeColor = Color.FromArgb(0, 192, 0);
            updateStatusLabel.Location = new Point(31, 667);
            updateStatusLabel.Name = "updateStatusLabel";
            updateStatusLabel.Size = new Size(429, 465);
            updateStatusLabel.TabIndex = 2;
            updateStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateMovieBtn
            // 
            updateMovieBtn.BackColor = Color.MediumTurquoise;
            updateMovieBtn.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            updateMovieBtn.Location = new Point(1649, 411);
            updateMovieBtn.Margin = new Padding(3, 4, 3, 4);
            updateMovieBtn.Name = "updateMovieBtn";
            updateMovieBtn.Size = new Size(319, 224);
            updateMovieBtn.TabIndex = 1;
            updateMovieBtn.Text = "Update Movie";
            updateMovieBtn.UseVisualStyleBackColor = false;
            updateMovieBtn.Click += updateMovieBtn_Click;
            // 
            // editMovieGroup
            // 
            editMovieGroup.BackColor = Color.MintCream;
            editMovieGroup.Controls.Add(updateMovieGenresLabel);
            editMovieGroup.Controls.Add(updateMovieCheckListBox);
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
            editMovieGroup.Location = new Point(485, 36);
            editMovieGroup.Margin = new Padding(3, 4, 3, 4);
            editMovieGroup.Name = "editMovieGroup";
            editMovieGroup.Padding = new Padding(3, 4, 3, 4);
            editMovieGroup.Size = new Size(1008, 1096);
            editMovieGroup.TabIndex = 0;
            editMovieGroup.TabStop = false;
            editMovieGroup.Text = "Movie Dialogue:";
            // 
            // updateMovieGenresLabel
            // 
            updateMovieGenresLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateMovieGenresLabel.Location = new Point(690, 781);
            updateMovieGenresLabel.Name = "updateMovieGenresLabel";
            updateMovieGenresLabel.Size = new Size(149, 43);
            updateMovieGenresLabel.TabIndex = 16;
            updateMovieGenresLabel.Text = "Genres";
            // 
            // updateMovieCheckListBox
            // 
            updateMovieCheckListBox.Font = new Font("Rockwell", 13F);
            updateMovieCheckListBox.FormattingEnabled = true;
            updateMovieCheckListBox.Location = new Point(562, 831);
            updateMovieCheckListBox.Name = "updateMovieCheckListBox";
            updateMovieCheckListBox.Size = new Size(410, 228);
            updateMovieCheckListBox.TabIndex = 15;
            // 
            // runTimeLabel
            // 
            runTimeLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            runTimeLabel.Location = new Point(189, 941);
            runTimeLabel.Name = "runTimeLabel";
            runTimeLabel.Size = new Size(162, 43);
            runTimeLabel.TabIndex = 12;
            runTimeLabel.Text = "Run Time ";
            // 
            // runTimeTextBox
            // 
            runTimeTextBox.Font = new Font("Rockwell", 20F);
            runTimeTextBox.Location = new Point(40, 998);
            runTimeTextBox.Margin = new Padding(3, 4, 3, 4);
            runTimeTextBox.Name = "runTimeTextBox";
            runTimeTextBox.Size = new Size(471, 47);
            runTimeTextBox.TabIndex = 11;
            // 
            // trailerURLlabel
            // 
            trailerURLlabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trailerURLlabel.Location = new Point(189, 781);
            trailerURLlabel.Name = "trailerURLlabel";
            trailerURLlabel.Size = new Size(185, 43);
            trailerURLlabel.TabIndex = 10;
            trailerURLlabel.Text = "TrailerURL";
            // 
            // trailerUrlTextBox
            // 
            trailerUrlTextBox.Font = new Font("Rockwell", 20F);
            trailerUrlTextBox.Location = new Point(40, 841);
            trailerUrlTextBox.Margin = new Padding(3, 4, 3, 4);
            trailerUrlTextBox.Name = "trailerUrlTextBox";
            trailerUrlTextBox.Size = new Size(471, 47);
            trailerUrlTextBox.TabIndex = 9;
            // 
            // posterUrl
            // 
            posterUrl.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posterUrl.Location = new Point(413, 619);
            posterUrl.Name = "posterUrl";
            posterUrl.Size = new Size(185, 43);
            posterUrl.TabIndex = 8;
            posterUrl.Text = "Poster URL";
            // 
            // posterUrlTextBox
            // 
            posterUrlTextBox.Font = new Font("Rockwell", 20F);
            posterUrlTextBox.Location = new Point(264, 685);
            posterUrlTextBox.Margin = new Padding(3, 4, 3, 4);
            posterUrlTextBox.Name = "posterUrlTextBox";
            posterUrlTextBox.Size = new Size(471, 47);
            posterUrlTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 15F);
            descriptionTextBox.Location = new Point(264, 439);
            descriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(471, 159);
            descriptionTextBox.TabIndex = 6;
            descriptionTextBox.Text = "";
            // 
            // movieDescriptionLabel
            // 
            movieDescriptionLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieDescriptionLabel.Location = new Point(355, 375);
            movieDescriptionLabel.Name = "movieDescriptionLabel";
            movieDescriptionLabel.Size = new Size(309, 43);
            movieDescriptionLabel.TabIndex = 5;
            movieDescriptionLabel.Text = "Movie Description";
            // 
            // movieYearPicker
            // 
            movieYearPicker.Font = new Font("Segoe UI", 20F);
            movieYearPicker.Location = new Point(264, 272);
            movieYearPicker.Margin = new Padding(3, 4, 3, 4);
            movieYearPicker.Name = "movieYearPicker";
            movieYearPicker.Size = new Size(471, 52);
            movieYearPicker.TabIndex = 3;
            // 
            // movieYearLabel
            // 
            movieYearLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieYearLabel.Location = new Point(400, 203);
            movieYearLabel.Name = "movieYearLabel";
            movieYearLabel.Size = new Size(218, 43);
            movieYearLabel.TabIndex = 2;
            movieYearLabel.Text = "Movie Year";
            // 
            // movieTitleLabel
            // 
            movieTitleLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTitleLabel.Location = new Point(400, 52);
            movieTitleLabel.Name = "movieTitleLabel";
            movieTitleLabel.Size = new Size(198, 43);
            movieTitleLabel.TabIndex = 1;
            movieTitleLabel.Text = "Movie Title";
            // 
            // movieTitleBox
            // 
            movieTitleBox.Font = new Font("Rockwell", 20F);
            movieTitleBox.Location = new Point(264, 115);
            movieTitleBox.Margin = new Padding(3, 4, 3, 4);
            movieTitleBox.Name = "movieTitleBox";
            movieTitleBox.Size = new Size(471, 47);
            movieTitleBox.TabIndex = 0;
            // 
            // createMoviePage
            // 
            createMoviePage.BackColor = Color.MediumTurquoise;
            createMoviePage.Controls.Add(createMovieTabCtrl);
            createMoviePage.Location = new Point(4, 5);
            createMoviePage.Margin = new Padding(3, 4, 3, 4);
            createMoviePage.Name = "createMoviePage";
            createMoviePage.Padding = new Padding(3, 4, 3, 4);
            createMoviePage.Size = new Size(2146, 1254);
            createMoviePage.TabIndex = 2;
            createMoviePage.Text = "Create Movie";
            // 
            // createMovieTabCtrl
            // 
            createMovieTabCtrl.Controls.Add(createMovieDetailsGroup);
            createMovieTabCtrl.Location = new Point(31, 29);
            createMovieTabCtrl.Margin = new Padding(3, 4, 3, 4);
            createMovieTabCtrl.Name = "createMovieTabCtrl";
            createMovieTabCtrl.SelectedIndex = 0;
            createMovieTabCtrl.Size = new Size(2082, 1207);
            createMovieTabCtrl.TabIndex = 2;
            // 
            // createMovieDetailsGroup
            // 
            createMovieDetailsGroup.Controls.Add(createMovieErrorLabel);
            createMovieDetailsGroup.Controls.Add(createMovieBtn);
            createMovieDetailsGroup.Controls.Add(createMovieDialogueBox);
            createMovieDetailsGroup.Location = new Point(4, 41);
            createMovieDetailsGroup.Margin = new Padding(3, 4, 3, 4);
            createMovieDetailsGroup.Name = "createMovieDetailsGroup";
            createMovieDetailsGroup.Padding = new Padding(3, 4, 3, 4);
            createMovieDetailsGroup.Size = new Size(2074, 1162);
            createMovieDetailsGroup.TabIndex = 0;
            createMovieDetailsGroup.Text = "Create Movie Details";
            createMovieDetailsGroup.UseVisualStyleBackColor = true;
            // 
            // createMovieErrorLabel
            // 
            createMovieErrorLabel.Font = new Font("Rockwell", 20F);
            createMovieErrorLabel.ForeColor = Color.FromArgb(0, 192, 0);
            createMovieErrorLabel.Location = new Point(31, 308);
            createMovieErrorLabel.Name = "createMovieErrorLabel";
            createMovieErrorLabel.Size = new Size(429, 465);
            createMovieErrorLabel.TabIndex = 2;
            createMovieErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createMovieBtn
            // 
            createMovieBtn.BackColor = Color.MediumTurquoise;
            createMovieBtn.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            createMovieBtn.Location = new Point(1626, 475);
            createMovieBtn.Margin = new Padding(3, 4, 3, 4);
            createMovieBtn.Name = "createMovieBtn";
            createMovieBtn.Size = new Size(319, 223);
            createMovieBtn.TabIndex = 1;
            createMovieBtn.Text = "Create Movie";
            createMovieBtn.UseVisualStyleBackColor = false;
            createMovieBtn.Click += createMovieBtn_Click;
            // 
            // createMovieDialogueBox
            // 
            createMovieDialogueBox.BackColor = Color.MintCream;
            createMovieDialogueBox.Controls.Add(createMovieGenreLabel);
            createMovieDialogueBox.Controls.Add(createMovieGenresCheckList);
            createMovieDialogueBox.Controls.Add(createMovieRunTimeLabel);
            createMovieDialogueBox.Controls.Add(createMovieRunTimeBox);
            createMovieDialogueBox.Controls.Add(createTrailerUrlLabel);
            createMovieDialogueBox.Controls.Add(createMovieUrlBox);
            createMovieDialogueBox.Controls.Add(createPosterUrlLabel);
            createMovieDialogueBox.Controls.Add(createMoviePosterBox);
            createMovieDialogueBox.Controls.Add(createMovieDescriptionBox);
            createMovieDialogueBox.Controls.Add(createMovieDescriptionLabel);
            createMovieDialogueBox.Controls.Add(createMovieDatePicker);
            createMovieDialogueBox.Controls.Add(createMovieYearLabel);
            createMovieDialogueBox.Controls.Add(createMovieTitleLabel);
            createMovieDialogueBox.Controls.Add(createMovieTitleBox);
            createMovieDialogueBox.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieDialogueBox.Location = new Point(485, 36);
            createMovieDialogueBox.Margin = new Padding(3, 4, 3, 4);
            createMovieDialogueBox.Name = "createMovieDialogueBox";
            createMovieDialogueBox.Padding = new Padding(3, 4, 3, 4);
            createMovieDialogueBox.Size = new Size(1008, 1091);
            createMovieDialogueBox.TabIndex = 0;
            createMovieDialogueBox.TabStop = false;
            createMovieDialogueBox.Text = "Movie Dialogue:";
            // 
            // createMovieGenreLabel
            // 
            createMovieGenreLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieGenreLabel.Location = new Point(695, 802);
            createMovieGenreLabel.Name = "createMovieGenreLabel";
            createMovieGenreLabel.Size = new Size(149, 43);
            createMovieGenreLabel.TabIndex = 14;
            createMovieGenreLabel.Text = "Genres";
            // 
            // createMovieGenresCheckList
            // 
            createMovieGenresCheckList.Font = new Font("Rockwell", 13F);
            createMovieGenresCheckList.FormattingEnabled = true;
            createMovieGenresCheckList.Location = new Point(567, 852);
            createMovieGenresCheckList.Name = "createMovieGenresCheckList";
            createMovieGenresCheckList.Size = new Size(410, 200);
            createMovieGenresCheckList.TabIndex = 13;
            // 
            // createMovieRunTimeLabel
            // 
            createMovieRunTimeLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieRunTimeLabel.Location = new Point(414, 619);
            createMovieRunTimeLabel.Name = "createMovieRunTimeLabel";
            createMovieRunTimeLabel.Size = new Size(162, 43);
            createMovieRunTimeLabel.TabIndex = 12;
            createMovieRunTimeLabel.Text = "Run Time ";
            // 
            // createMovieRunTimeBox
            // 
            createMovieRunTimeBox.Font = new Font("Rockwell", 20F);
            createMovieRunTimeBox.Location = new Point(264, 687);
            createMovieRunTimeBox.Margin = new Padding(3, 4, 3, 4);
            createMovieRunTimeBox.Name = "createMovieRunTimeBox";
            createMovieRunTimeBox.Size = new Size(471, 47);
            createMovieRunTimeBox.TabIndex = 11;
            // 
            // createTrailerUrlLabel
            // 
            createTrailerUrlLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTrailerUrlLabel.Location = new Point(196, 947);
            createTrailerUrlLabel.Name = "createTrailerUrlLabel";
            createTrailerUrlLabel.Size = new Size(185, 43);
            createTrailerUrlLabel.TabIndex = 10;
            createTrailerUrlLabel.Text = "TrailerURL";
            // 
            // createMovieUrlBox
            // 
            createMovieUrlBox.Font = new Font("Rockwell", 20F);
            createMovieUrlBox.Location = new Point(47, 1007);
            createMovieUrlBox.Margin = new Padding(3, 4, 3, 4);
            createMovieUrlBox.Name = "createMovieUrlBox";
            createMovieUrlBox.Size = new Size(471, 47);
            createMovieUrlBox.TabIndex = 9;
            // 
            // createPosterUrlLabel
            // 
            createPosterUrlLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPosterUrlLabel.Location = new Point(196, 802);
            createPosterUrlLabel.Name = "createPosterUrlLabel";
            createPosterUrlLabel.Size = new Size(185, 43);
            createPosterUrlLabel.TabIndex = 8;
            createPosterUrlLabel.Text = "Poster URL";
            // 
            // createMoviePosterBox
            // 
            createMoviePosterBox.Font = new Font("Rockwell", 20F);
            createMoviePosterBox.Location = new Point(47, 868);
            createMoviePosterBox.Margin = new Padding(3, 4, 3, 4);
            createMoviePosterBox.Name = "createMoviePosterBox";
            createMoviePosterBox.Size = new Size(471, 47);
            createMoviePosterBox.TabIndex = 7;
            // 
            // createMovieDescriptionBox
            // 
            createMovieDescriptionBox.Font = new Font("Segoe UI", 15F);
            createMovieDescriptionBox.Location = new Point(264, 439);
            createMovieDescriptionBox.Margin = new Padding(3, 4, 3, 4);
            createMovieDescriptionBox.Name = "createMovieDescriptionBox";
            createMovieDescriptionBox.Size = new Size(471, 159);
            createMovieDescriptionBox.TabIndex = 6;
            createMovieDescriptionBox.Text = "";
            // 
            // createMovieDescriptionLabel
            // 
            createMovieDescriptionLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieDescriptionLabel.Location = new Point(355, 375);
            createMovieDescriptionLabel.Name = "createMovieDescriptionLabel";
            createMovieDescriptionLabel.Size = new Size(311, 43);
            createMovieDescriptionLabel.TabIndex = 5;
            createMovieDescriptionLabel.Text = "Movie Description";
            // 
            // createMovieDatePicker
            // 
            createMovieDatePicker.Font = new Font("Segoe UI", 20F);
            createMovieDatePicker.Location = new Point(264, 272);
            createMovieDatePicker.Margin = new Padding(3, 4, 3, 4);
            createMovieDatePicker.Name = "createMovieDatePicker";
            createMovieDatePicker.Size = new Size(471, 52);
            createMovieDatePicker.TabIndex = 3;
            // 
            // createMovieYearLabel
            // 
            createMovieYearLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieYearLabel.Location = new Point(400, 203);
            createMovieYearLabel.Name = "createMovieYearLabel";
            createMovieYearLabel.Size = new Size(219, 43);
            createMovieYearLabel.TabIndex = 2;
            createMovieYearLabel.Text = "Movie Year";
            // 
            // createMovieTitleLabel
            // 
            createMovieTitleLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieTitleLabel.Location = new Point(400, 52);
            createMovieTitleLabel.Name = "createMovieTitleLabel";
            createMovieTitleLabel.Size = new Size(219, 43);
            createMovieTitleLabel.TabIndex = 1;
            createMovieTitleLabel.Text = "Movie Title";
            // 
            // createMovieTitleBox
            // 
            createMovieTitleBox.Font = new Font("Rockwell", 20F);
            createMovieTitleBox.Location = new Point(264, 115);
            createMovieTitleBox.Margin = new Padding(3, 4, 3, 4);
            createMovieTitleBox.Name = "createMovieTitleBox";
            createMovieTitleBox.Size = new Size(471, 47);
            createMovieTitleBox.TabIndex = 0;
            // 
            // movieMgmtErrorLabel
            // 
            movieMgmtErrorLabel.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            movieMgmtErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            movieMgmtErrorLabel.Location = new Point(329, 63);
            movieMgmtErrorLabel.Name = "movieMgmtErrorLabel";
            movieMgmtErrorLabel.Size = new Size(1577, 45);
            movieMgmtErrorLabel.TabIndex = 8;
            movieMgmtErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addMovieBtn
            // 
            addMovieBtn.BackColor = Color.MediumTurquoise;
            addMovieBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addMovieBtn.Location = new Point(1970, 13);
            addMovieBtn.Margin = new Padding(3, 4, 3, 4);
            addMovieBtn.Name = "addMovieBtn";
            addMovieBtn.Size = new Size(189, 89);
            addMovieBtn.TabIndex = 3;
            addMovieBtn.Text = "Add Movie";
            addMovieBtn.UseVisualStyleBackColor = false;
            addMovieBtn.Click += addMovieBtn_Click;
            // 
            // moviesDashHomeBtn
            // 
            moviesDashHomeBtn.Image = (Image)resources.GetObject("moviesDashHomeBtn.Image");
            moviesDashHomeBtn.Location = new Point(19, 9);
            moviesDashHomeBtn.Name = "moviesDashHomeBtn";
            moviesDashHomeBtn.Size = new Size(73, 79);
            moviesDashHomeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            moviesDashHomeBtn.TabIndex = 9;
            moviesDashHomeBtn.TabStop = false;
            moviesDashHomeBtn.Click += moviesDashHomeBtn_Click;
            // 
            // updateMoviePictureBox
            // 
            updateMoviePictureBox.Location = new Point(31, 36);
            updateMoviePictureBox.Name = "updateMoviePictureBox";
            updateMoviePictureBox.Size = new Size(437, 537);
            updateMoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            updateMoviePictureBox.TabIndex = 3;
            updateMoviePictureBox.TabStop = false;
            // 
            // MovieDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(2174, 1377);
            Controls.Add(moviesDashHomeBtn);
            Controls.Add(addMovieBtn);
            Controls.Add(movieMgmtErrorLabel);
            Controls.Add(movieDashTabCtrl);
            Controls.Add(searchBtn);
            Controls.Add(totalMoviesLabel);
            Controls.Add(filterBarMovies);
            Controls.Add(searchBarMovies);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2192, 1424);
            MinimumSize = new Size(2192, 1424);
            Name = "MovieDashboard";
            Text = "MovieDashboard";
            movieDashTabCtrl.ResumeLayout(false);
            movieDashPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            editMoviePage.ResumeLayout(false);
            movieEditTabControl.ResumeLayout(false);
            editMovieDetailsPage.ResumeLayout(false);
            editMovieGroup.ResumeLayout(false);
            editMovieGroup.PerformLayout();
            createMoviePage.ResumeLayout(false);
            createMovieTabCtrl.ResumeLayout(false);
            createMovieDetailsGroup.ResumeLayout(false);
            createMovieDialogueBox.ResumeLayout(false);
            createMovieDialogueBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)moviesDashHomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateMoviePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TabControl createMovieTabCtrl;
        private TabPage createMovieDetailsGroup;
        private Label createMovieErrorLabel;
        private Button createMovieBtn;
        private GroupBox createMovieDialogueBox;
        private Label createMovieRunTimeLabel;
        private TextBox createMovieRunTimeBox;
        private Label createTrailerUrlLabel;
        private TextBox createMovieUrlBox;
        private Label createPosterUrlLabel;
        private TextBox createMoviePosterBox;
        private RichTextBox createMovieDescriptionBox;
        private Label createMovieDescriptionLabel;
        private DateTimePicker createMovieDatePicker;
        private Label createMovieYearLabel;
        private Label createMovieTitleLabel;
        private TextBox createMovieTitleBox;
        private Label movieMgmtErrorLabel;
        private Button addMovieBtn;
        private PictureBox moviesDashHomeBtn;
        private CheckedListBox createMovieGenresCheckList;
        private Label createMovieGenreLabel;
        private Label updateMovieGenresLabel;
        private CheckedListBox updateMovieCheckListBox;
        private PictureBox updateMoviePictureBox;
    }
}