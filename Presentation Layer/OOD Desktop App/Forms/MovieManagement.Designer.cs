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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDashboard));
            searchBarMovies = new TextBox();
            filterBarMovies = new ComboBox();
            totalMoviesLabel = new Label();
            searchBtn = new Button();
            movieDashTabCtrl = new TabControl();
            movieDashPage = new TabPage();
            previousPageBtnMovie = new Button();
            nextPageBtnMovie = new Button();
            moviesDataGrid = new DataGridView();
            editMoviePage = new TabPage();
            movieEditTabControl = new TabControl();
            editMovieDetailsPage = new TabPage();
            addDirGenAc = new Button();
            updateMoviePictureBox = new PictureBox();
            updateStatusLabel = new Label();
            updateMovieBtn = new Button();
            editMovieGroup = new GroupBox();
            updateAverageRatingLabel = new Label();
            updateAverageRatingTextBox = new TextBox();
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
            averageRatingLabel = new Label();
            averageRatingTextBox = new TextBox();
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
            categoryManagementTab = new TabPage();
            categoryMgmtGroup = new GroupBox();
            editCreateAcGenDirTabCtrl = new TabControl();
            createNewAcGenDirPage = new TabPage();
            addActorBtn = new Button();
            addDirectorBtn = new Button();
            addGenreLabel = new Label();
            addNewGenreTextbox = new TextBox();
            addNewGenreButton = new Button();
            addActorLabel = new Label();
            addNewDirectorTextbox = new TextBox();
            addNewActorTextbox = new TextBox();
            addNewDirectorLabel = new Label();
            updateNewAcGenDirPage = new TabPage();
            updateDirBtn = new Button();
            updateAcBtn = new Button();
            updateGenBtn = new Button();
            updateDirectorText = new TextBox();
            updateActorText = new TextBox();
            updateGenreText = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            selectDirNumeric = new NumericUpDown();
            selectActNumeric = new NumericUpDown();
            selectGenNumeric = new NumericUpDown();
            currentDirectorsLabel = new Label();
            currentDirectorsListbox = new ListBox();
            currentActorsListbox = new ListBox();
            currentActorsLabel = new Label();
            currentGenresLabel = new Label();
            currentGenresListbox = new ListBox();
            targetMovieLabel = new Label();
            movieMgmtErrorLabel = new Label();
            addMovieBtn = new Button();
            moviesDashHomeBtn = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            movieDashTabCtrl.SuspendLayout();
            movieDashPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            editMoviePage.SuspendLayout();
            movieEditTabControl.SuspendLayout();
            editMovieDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateMoviePictureBox).BeginInit();
            editMovieGroup.SuspendLayout();
            createMoviePage.SuspendLayout();
            createMovieTabCtrl.SuspendLayout();
            createMovieDetailsGroup.SuspendLayout();
            createMovieDialogueBox.SuspendLayout();
            categoryManagementTab.SuspendLayout();
            categoryMgmtGroup.SuspendLayout();
            editCreateAcGenDirTabCtrl.SuspendLayout();
            createNewAcGenDirPage.SuspendLayout();
            updateNewAcGenDirPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectDirNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectActNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectGenNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesDashHomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // searchBarMovies
            // 
            searchBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBarMovies.Location = new Point(288, 10);
            searchBarMovies.Name = "searchBarMovies";
            searchBarMovies.Size = new Size(773, 30);
            searchBarMovies.TabIndex = 2;
            // 
            // filterBarMovies
            // 
            filterBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterBarMovies.FormattingEnabled = true;
            filterBarMovies.Location = new Point(1349, 10);
            filterBarMovies.Name = "filterBarMovies";
            filterBarMovies.Size = new Size(319, 31);
            filterBarMovies.TabIndex = 3;
            // 
            // totalMoviesLabel
            // 
            totalMoviesLabel.Font = new Font("Rockwell", 14F, FontStyle.Bold);
            totalMoviesLabel.Location = new Point(96, 7);
            totalMoviesLabel.Name = "totalMoviesLabel";
            totalMoviesLabel.Size = new Size(172, 59);
            totalMoviesLabel.TabIndex = 5;
            totalMoviesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(1106, 10);
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
            movieDashTabCtrl.Controls.Add(categoryManagementTab);
            movieDashTabCtrl.Font = new Font("Rockwell", 17.5F);
            movieDashTabCtrl.ItemSize = new Size(0, 1);
            movieDashTabCtrl.Location = new Point(8, 83);
            movieDashTabCtrl.Margin = new Padding(2);
            movieDashTabCtrl.Name = "movieDashTabCtrl";
            movieDashTabCtrl.SelectedIndex = 0;
            movieDashTabCtrl.Size = new Size(1885, 947);
            movieDashTabCtrl.SizeMode = TabSizeMode.Fixed;
            movieDashTabCtrl.TabIndex = 7;
            // 
            // movieDashPage
            // 
            movieDashPage.BackColor = Color.MediumTurquoise;
            movieDashPage.Controls.Add(previousPageBtnMovie);
            movieDashPage.Controls.Add(nextPageBtnMovie);
            movieDashPage.Controls.Add(moviesDataGrid);
            movieDashPage.Location = new Point(4, 5);
            movieDashPage.Margin = new Padding(2);
            movieDashPage.Name = "movieDashPage";
            movieDashPage.Padding = new Padding(2);
            movieDashPage.Size = new Size(1877, 938);
            movieDashPage.TabIndex = 0;
            movieDashPage.Text = "Movie Dashboard";
            // 
            // previousPageBtnMovie
            // 
            previousPageBtnMovie.BackColor = Color.MediumTurquoise;
            previousPageBtnMovie.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            previousPageBtnMovie.Location = new Point(4, 899);
            previousPageBtnMovie.Name = "previousPageBtnMovie";
            previousPageBtnMovie.Size = new Size(197, 36);
            previousPageBtnMovie.TabIndex = 11;
            previousPageBtnMovie.Text = "Previous Page";
            previousPageBtnMovie.UseVisualStyleBackColor = false;
            // 
            // nextPageBtnMovie
            // 
            nextPageBtnMovie.BackColor = Color.MediumTurquoise;
            nextPageBtnMovie.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            nextPageBtnMovie.Location = new Point(1676, 899);
            nextPageBtnMovie.Name = "nextPageBtnMovie";
            nextPageBtnMovie.Size = new Size(197, 36);
            nextPageBtnMovie.TabIndex = 10;
            nextPageBtnMovie.Text = "Next Page";
            nextPageBtnMovie.UseVisualStyleBackColor = false;
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Location = new Point(5, 5);
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.RowHeadersWidth = 62;
            moviesDataGrid.Size = new Size(1867, 888);
            moviesDataGrid.TabIndex = 5;
            // 
            // editMoviePage
            // 
            editMoviePage.BackColor = Color.MediumTurquoise;
            editMoviePage.Controls.Add(movieEditTabControl);
            editMoviePage.Location = new Point(4, 5);
            editMoviePage.Margin = new Padding(2);
            editMoviePage.Name = "editMoviePage";
            editMoviePage.Padding = new Padding(2);
            editMoviePage.Size = new Size(1877, 938);
            editMoviePage.TabIndex = 1;
            editMoviePage.Text = "Edit Movie";
            // 
            // movieEditTabControl
            // 
            movieEditTabControl.Controls.Add(editMovieDetailsPage);
            movieEditTabControl.Location = new Point(30, 5);
            movieEditTabControl.Name = "movieEditTabControl";
            movieEditTabControl.SelectedIndex = 0;
            movieEditTabControl.Size = new Size(1822, 879);
            movieEditTabControl.TabIndex = 1;
            // 
            // editMovieDetailsPage
            // 
            editMovieDetailsPage.Controls.Add(addDirGenAc);
            editMovieDetailsPage.Controls.Add(updateMoviePictureBox);
            editMovieDetailsPage.Controls.Add(updateStatusLabel);
            editMovieDetailsPage.Controls.Add(updateMovieBtn);
            editMovieDetailsPage.Controls.Add(editMovieGroup);
            editMovieDetailsPage.Location = new Point(4, 35);
            editMovieDetailsPage.Name = "editMovieDetailsPage";
            editMovieDetailsPage.Padding = new Padding(3);
            editMovieDetailsPage.Size = new Size(1814, 840);
            editMovieDetailsPage.TabIndex = 0;
            editMovieDetailsPage.Text = "Edit Movie Details";
            editMovieDetailsPage.UseVisualStyleBackColor = true;
            // 
            // addDirGenAc
            // 
            addDirGenAc.BackColor = Color.MediumTurquoise;
            addDirGenAc.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addDirGenAc.Location = new Point(1433, 678);
            addDirGenAc.Name = "addDirGenAc";
            addDirGenAc.Size = new Size(279, 73);
            addDirGenAc.TabIndex = 10;
            addDirGenAc.Text = "Add Actors/Directors/Genres";
            addDirGenAc.UseVisualStyleBackColor = false;
            addDirGenAc.Click += addDirGenAc_Click;
            // 
            // updateMoviePictureBox
            // 
            updateMoviePictureBox.Location = new Point(27, 27);
            updateMoviePictureBox.Margin = new Padding(3, 2, 3, 2);
            updateMoviePictureBox.Name = "updateMoviePictureBox";
            updateMoviePictureBox.Size = new Size(382, 403);
            updateMoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            updateMoviePictureBox.TabIndex = 3;
            updateMoviePictureBox.TabStop = false;
            // 
            // updateStatusLabel
            // 
            updateStatusLabel.Font = new Font("Rockwell", 20F);
            updateStatusLabel.ForeColor = Color.FromArgb(0, 192, 0);
            updateStatusLabel.Location = new Point(27, 482);
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
            editMovieGroup.Controls.Add(updateAverageRatingLabel);
            editMovieGroup.Controls.Add(updateAverageRatingTextBox);
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
            editMovieGroup.Location = new Point(415, 9);
            editMovieGroup.Name = "editMovieGroup";
            editMovieGroup.Size = new Size(882, 822);
            editMovieGroup.TabIndex = 0;
            editMovieGroup.TabStop = false;
            editMovieGroup.Text = "Movie Dialogue:";
            // 
            // updateAverageRatingLabel
            // 
            updateAverageRatingLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateAverageRatingLabel.Location = new Point(569, 571);
            updateAverageRatingLabel.Name = "updateAverageRatingLabel";
            updateAverageRatingLabel.Size = new Size(209, 32);
            updateAverageRatingLabel.TabIndex = 18;
            updateAverageRatingLabel.Text = "Average Rating";
            // 
            // updateAverageRatingTextBox
            // 
            updateAverageRatingTextBox.Font = new Font("Rockwell", 20F);
            updateAverageRatingTextBox.Location = new Point(492, 616);
            updateAverageRatingTextBox.Name = "updateAverageRatingTextBox";
            updateAverageRatingTextBox.Size = new Size(359, 39);
            updateAverageRatingTextBox.TabIndex = 17;
            // 
            // updateMovieGenresLabel
            // 
            updateMovieGenresLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateMovieGenresLabel.Location = new Point(615, 669);
            updateMovieGenresLabel.Name = "updateMovieGenresLabel";
            updateMovieGenresLabel.Size = new Size(130, 32);
            updateMovieGenresLabel.TabIndex = 16;
            updateMovieGenresLabel.Text = "Genres";
            // 
            // updateMovieCheckListBox
            // 
            updateMovieCheckListBox.Font = new Font("Rockwell", 13F);
            updateMovieCheckListBox.FormattingEnabled = true;
            updateMovieCheckListBox.Location = new Point(492, 714);
            updateMovieCheckListBox.Margin = new Padding(3, 2, 3, 2);
            updateMovieCheckListBox.Name = "updateMovieCheckListBox";
            updateMovieCheckListBox.Size = new Size(359, 73);
            updateMovieCheckListBox.TabIndex = 15;
            // 
            // runTimeLabel
            // 
            runTimeLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            runTimeLabel.Location = new Point(165, 706);
            runTimeLabel.Name = "runTimeLabel";
            runTimeLabel.Size = new Size(142, 32);
            runTimeLabel.TabIndex = 12;
            runTimeLabel.Text = "Run Time ";
            // 
            // runTimeTextBox
            // 
            runTimeTextBox.Font = new Font("Rockwell", 20F);
            runTimeTextBox.Location = new Point(35, 748);
            runTimeTextBox.Name = "runTimeTextBox";
            runTimeTextBox.Size = new Size(413, 39);
            runTimeTextBox.TabIndex = 11;
            // 
            // trailerURLlabel
            // 
            trailerURLlabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trailerURLlabel.Location = new Point(165, 586);
            trailerURLlabel.Name = "trailerURLlabel";
            trailerURLlabel.Size = new Size(162, 32);
            trailerURLlabel.TabIndex = 10;
            trailerURLlabel.Text = "TrailerURL";
            // 
            // trailerUrlTextBox
            // 
            trailerUrlTextBox.Font = new Font("Rockwell", 20F);
            trailerUrlTextBox.Location = new Point(35, 631);
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
            posterUrlTextBox.Location = new Point(35, 514);
            posterUrlTextBox.Name = "posterUrlTextBox";
            posterUrlTextBox.Size = new Size(816, 39);
            posterUrlTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 15F);
            descriptionTextBox.Location = new Point(35, 329);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(816, 120);
            descriptionTextBox.TabIndex = 6;
            descriptionTextBox.Text = "";
            // 
            // movieDescriptionLabel
            // 
            movieDescriptionLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieDescriptionLabel.Location = new Point(311, 281);
            movieDescriptionLabel.Name = "movieDescriptionLabel";
            movieDescriptionLabel.Size = new Size(270, 32);
            movieDescriptionLabel.TabIndex = 5;
            movieDescriptionLabel.Text = "Movie Description";
            // 
            // movieYearPicker
            // 
            movieYearPicker.Font = new Font("Segoe UI", 20F);
            movieYearPicker.Location = new Point(35, 204);
            movieYearPicker.Name = "movieYearPicker";
            movieYearPicker.Size = new Size(816, 43);
            movieYearPicker.TabIndex = 3;
            // 
            // movieYearLabel
            // 
            movieYearLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieYearLabel.Location = new Point(350, 152);
            movieYearLabel.Name = "movieYearLabel";
            movieYearLabel.Size = new Size(191, 32);
            movieYearLabel.TabIndex = 2;
            movieYearLabel.Text = "Movie Year";
            // 
            // movieTitleLabel
            // 
            movieTitleLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTitleLabel.Location = new Point(350, 39);
            movieTitleLabel.Name = "movieTitleLabel";
            movieTitleLabel.Size = new Size(173, 32);
            movieTitleLabel.TabIndex = 1;
            movieTitleLabel.Text = "Movie Title";
            // 
            // movieTitleBox
            // 
            movieTitleBox.Font = new Font("Rockwell", 20F);
            movieTitleBox.Location = new Point(35, 86);
            movieTitleBox.Name = "movieTitleBox";
            movieTitleBox.Size = new Size(816, 39);
            movieTitleBox.TabIndex = 0;
            // 
            // createMoviePage
            // 
            createMoviePage.BackColor = Color.MediumTurquoise;
            createMoviePage.Controls.Add(createMovieTabCtrl);
            createMoviePage.Location = new Point(4, 5);
            createMoviePage.Name = "createMoviePage";
            createMoviePage.Padding = new Padding(3);
            createMoviePage.Size = new Size(1877, 938);
            createMoviePage.TabIndex = 2;
            createMoviePage.Text = "Create Movie";
            // 
            // createMovieTabCtrl
            // 
            createMovieTabCtrl.Controls.Add(createMovieDetailsGroup);
            createMovieTabCtrl.Location = new Point(27, 22);
            createMovieTabCtrl.Name = "createMovieTabCtrl";
            createMovieTabCtrl.SelectedIndex = 0;
            createMovieTabCtrl.Size = new Size(1822, 905);
            createMovieTabCtrl.TabIndex = 2;
            // 
            // createMovieDetailsGroup
            // 
            createMovieDetailsGroup.Controls.Add(createMovieErrorLabel);
            createMovieDetailsGroup.Controls.Add(createMovieBtn);
            createMovieDetailsGroup.Controls.Add(createMovieDialogueBox);
            createMovieDetailsGroup.Location = new Point(4, 35);
            createMovieDetailsGroup.Name = "createMovieDetailsGroup";
            createMovieDetailsGroup.Padding = new Padding(3);
            createMovieDetailsGroup.Size = new Size(1814, 866);
            createMovieDetailsGroup.TabIndex = 0;
            createMovieDetailsGroup.Text = "Create Movie Details";
            createMovieDetailsGroup.UseVisualStyleBackColor = true;
            // 
            // createMovieErrorLabel
            // 
            createMovieErrorLabel.Font = new Font("Rockwell", 20F);
            createMovieErrorLabel.ForeColor = Color.FromArgb(0, 192, 0);
            createMovieErrorLabel.Location = new Point(27, 231);
            createMovieErrorLabel.Name = "createMovieErrorLabel";
            createMovieErrorLabel.Size = new Size(375, 349);
            createMovieErrorLabel.TabIndex = 2;
            createMovieErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createMovieBtn
            // 
            createMovieBtn.BackColor = Color.MediumTurquoise;
            createMovieBtn.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            createMovieBtn.Location = new Point(1423, 356);
            createMovieBtn.Name = "createMovieBtn";
            createMovieBtn.Size = new Size(279, 167);
            createMovieBtn.TabIndex = 1;
            createMovieBtn.Text = "Create Movie";
            createMovieBtn.UseVisualStyleBackColor = false;
            createMovieBtn.Click += createMovieBtn_Click;
            // 
            // createMovieDialogueBox
            // 
            createMovieDialogueBox.BackColor = Color.MintCream;
            createMovieDialogueBox.Controls.Add(averageRatingLabel);
            createMovieDialogueBox.Controls.Add(averageRatingTextBox);
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
            createMovieDialogueBox.Location = new Point(424, 27);
            createMovieDialogueBox.Name = "createMovieDialogueBox";
            createMovieDialogueBox.Size = new Size(882, 818);
            createMovieDialogueBox.TabIndex = 0;
            createMovieDialogueBox.TabStop = false;
            createMovieDialogueBox.Text = "Movie Dialogue:";
            // 
            // averageRatingLabel
            // 
            averageRatingLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            averageRatingLabel.Location = new Point(568, 575);
            averageRatingLabel.Name = "averageRatingLabel";
            averageRatingLabel.Size = new Size(206, 32);
            averageRatingLabel.TabIndex = 16;
            averageRatingLabel.Text = "Average Rating";
            // 
            // averageRatingTextBox
            // 
            averageRatingTextBox.Font = new Font("Rockwell", 20F);
            averageRatingTextBox.Location = new Point(496, 622);
            averageRatingTextBox.Name = "averageRatingTextBox";
            averageRatingTextBox.Size = new Size(359, 39);
            averageRatingTextBox.TabIndex = 15;
            // 
            // createMovieGenreLabel
            // 
            createMovieGenreLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieGenreLabel.Location = new Point(607, 674);
            createMovieGenreLabel.Name = "createMovieGenreLabel";
            createMovieGenreLabel.Size = new Size(111, 32);
            createMovieGenreLabel.TabIndex = 14;
            createMovieGenreLabel.Text = "Genres";
            // 
            // createMovieGenresCheckList
            // 
            createMovieGenresCheckList.Font = new Font("Rockwell", 13F);
            createMovieGenresCheckList.FormattingEnabled = true;
            createMovieGenresCheckList.Location = new Point(496, 721);
            createMovieGenresCheckList.Margin = new Padding(3, 2, 3, 2);
            createMovieGenresCheckList.Name = "createMovieGenresCheckList";
            createMovieGenresCheckList.Size = new Size(359, 73);
            createMovieGenresCheckList.TabIndex = 13;
            // 
            // createMovieRunTimeLabel
            // 
            createMovieRunTimeLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieRunTimeLabel.Location = new Point(362, 464);
            createMovieRunTimeLabel.Name = "createMovieRunTimeLabel";
            createMovieRunTimeLabel.Size = new Size(142, 32);
            createMovieRunTimeLabel.TabIndex = 12;
            createMovieRunTimeLabel.Text = "Run Time ";
            // 
            // createMovieRunTimeBox
            // 
            createMovieRunTimeBox.Font = new Font("Rockwell", 20F);
            createMovieRunTimeBox.Location = new Point(41, 515);
            createMovieRunTimeBox.Name = "createMovieRunTimeBox";
            createMovieRunTimeBox.Size = new Size(814, 39);
            createMovieRunTimeBox.TabIndex = 11;
            // 
            // createTrailerUrlLabel
            // 
            createTrailerUrlLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTrailerUrlLabel.Location = new Point(172, 710);
            createTrailerUrlLabel.Name = "createTrailerUrlLabel";
            createTrailerUrlLabel.Size = new Size(162, 32);
            createTrailerUrlLabel.TabIndex = 10;
            createTrailerUrlLabel.Text = "TrailerURL";
            // 
            // createMovieUrlBox
            // 
            createMovieUrlBox.Font = new Font("Rockwell", 20F);
            createMovieUrlBox.Location = new Point(41, 755);
            createMovieUrlBox.Name = "createMovieUrlBox";
            createMovieUrlBox.Size = new Size(413, 39);
            createMovieUrlBox.TabIndex = 9;
            // 
            // createPosterUrlLabel
            // 
            createPosterUrlLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPosterUrlLabel.Location = new Point(172, 602);
            createPosterUrlLabel.Name = "createPosterUrlLabel";
            createPosterUrlLabel.Size = new Size(162, 32);
            createPosterUrlLabel.TabIndex = 8;
            createPosterUrlLabel.Text = "Poster URL";
            // 
            // createMoviePosterBox
            // 
            createMoviePosterBox.Font = new Font("Rockwell", 20F);
            createMoviePosterBox.Location = new Point(41, 651);
            createMoviePosterBox.Name = "createMoviePosterBox";
            createMoviePosterBox.Size = new Size(413, 39);
            createMoviePosterBox.TabIndex = 7;
            // 
            // createMovieDescriptionBox
            // 
            createMovieDescriptionBox.Font = new Font("Segoe UI", 15F);
            createMovieDescriptionBox.Location = new Point(41, 329);
            createMovieDescriptionBox.Name = "createMovieDescriptionBox";
            createMovieDescriptionBox.Size = new Size(814, 120);
            createMovieDescriptionBox.TabIndex = 6;
            createMovieDescriptionBox.Text = "";
            // 
            // createMovieDescriptionLabel
            // 
            createMovieDescriptionLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieDescriptionLabel.Location = new Point(311, 281);
            createMovieDescriptionLabel.Name = "createMovieDescriptionLabel";
            createMovieDescriptionLabel.Size = new Size(272, 32);
            createMovieDescriptionLabel.TabIndex = 5;
            createMovieDescriptionLabel.Text = "Movie Description";
            // 
            // createMovieDatePicker
            // 
            createMovieDatePicker.Font = new Font("Segoe UI", 20F);
            createMovieDatePicker.Location = new Point(41, 204);
            createMovieDatePicker.Name = "createMovieDatePicker";
            createMovieDatePicker.Size = new Size(814, 43);
            createMovieDatePicker.TabIndex = 3;
            // 
            // createMovieYearLabel
            // 
            createMovieYearLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieYearLabel.Location = new Point(350, 152);
            createMovieYearLabel.Name = "createMovieYearLabel";
            createMovieYearLabel.Size = new Size(192, 32);
            createMovieYearLabel.TabIndex = 2;
            createMovieYearLabel.Text = "Movie Year";
            // 
            // createMovieTitleLabel
            // 
            createMovieTitleLabel.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMovieTitleLabel.Location = new Point(350, 39);
            createMovieTitleLabel.Name = "createMovieTitleLabel";
            createMovieTitleLabel.Size = new Size(192, 32);
            createMovieTitleLabel.TabIndex = 1;
            createMovieTitleLabel.Text = "Movie Title";
            // 
            // createMovieTitleBox
            // 
            createMovieTitleBox.Font = new Font("Rockwell", 20F);
            createMovieTitleBox.Location = new Point(41, 86);
            createMovieTitleBox.Name = "createMovieTitleBox";
            createMovieTitleBox.Size = new Size(814, 39);
            createMovieTitleBox.TabIndex = 0;
            // 
            // categoryManagementTab
            // 
            categoryManagementTab.BackColor = Color.MediumTurquoise;
            categoryManagementTab.Controls.Add(categoryMgmtGroup);
            categoryManagementTab.Location = new Point(4, 5);
            categoryManagementTab.Name = "categoryManagementTab";
            categoryManagementTab.Padding = new Padding(3);
            categoryManagementTab.Size = new Size(1877, 938);
            categoryManagementTab.TabIndex = 3;
            categoryManagementTab.Text = "Category Management";
            // 
            // categoryMgmtGroup
            // 
            categoryMgmtGroup.BackColor = Color.WhiteSmoke;
            categoryMgmtGroup.Controls.Add(editCreateAcGenDirTabCtrl);
            categoryMgmtGroup.Controls.Add(currentDirectorsLabel);
            categoryMgmtGroup.Controls.Add(currentDirectorsListbox);
            categoryMgmtGroup.Controls.Add(currentActorsListbox);
            categoryMgmtGroup.Controls.Add(currentActorsLabel);
            categoryMgmtGroup.Controls.Add(currentGenresLabel);
            categoryMgmtGroup.Controls.Add(currentGenresListbox);
            categoryMgmtGroup.Controls.Add(targetMovieLabel);
            categoryMgmtGroup.Location = new Point(212, 6);
            categoryMgmtGroup.Name = "categoryMgmtGroup";
            categoryMgmtGroup.Size = new Size(1444, 877);
            categoryMgmtGroup.TabIndex = 0;
            categoryMgmtGroup.TabStop = false;
            categoryMgmtGroup.Text = "Category Mangement";
            // 
            // editCreateAcGenDirTabCtrl
            // 
            editCreateAcGenDirTabCtrl.Controls.Add(createNewAcGenDirPage);
            editCreateAcGenDirTabCtrl.Controls.Add(updateNewAcGenDirPage);
            editCreateAcGenDirTabCtrl.Location = new Point(637, 197);
            editCreateAcGenDirTabCtrl.Name = "editCreateAcGenDirTabCtrl";
            editCreateAcGenDirTabCtrl.SelectedIndex = 0;
            editCreateAcGenDirTabCtrl.Size = new Size(734, 629);
            editCreateAcGenDirTabCtrl.TabIndex = 19;
            // 
            // createNewAcGenDirPage
            // 
            createNewAcGenDirPage.Controls.Add(addActorBtn);
            createNewAcGenDirPage.Controls.Add(addDirectorBtn);
            createNewAcGenDirPage.Controls.Add(addGenreLabel);
            createNewAcGenDirPage.Controls.Add(addNewGenreTextbox);
            createNewAcGenDirPage.Controls.Add(addNewGenreButton);
            createNewAcGenDirPage.Controls.Add(addActorLabel);
            createNewAcGenDirPage.Controls.Add(addNewDirectorTextbox);
            createNewAcGenDirPage.Controls.Add(addNewActorTextbox);
            createNewAcGenDirPage.Controls.Add(addNewDirectorLabel);
            createNewAcGenDirPage.Location = new Point(4, 35);
            createNewAcGenDirPage.Name = "createNewAcGenDirPage";
            createNewAcGenDirPage.Padding = new Padding(3);
            createNewAcGenDirPage.Size = new Size(726, 590);
            createNewAcGenDirPage.TabIndex = 0;
            createNewAcGenDirPage.Text = "Create";
            createNewAcGenDirPage.UseVisualStyleBackColor = true;
            // 
            // addActorBtn
            // 
            addActorBtn.BackColor = Color.MediumTurquoise;
            addActorBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addActorBtn.Location = new Point(408, 296);
            addActorBtn.Name = "addActorBtn";
            addActorBtn.Size = new Size(182, 67);
            addActorBtn.TabIndex = 17;
            addActorBtn.Text = "Add Actor";
            addActorBtn.UseVisualStyleBackColor = false;
            addActorBtn.Click += addActorBtn_Click;
            // 
            // addDirectorBtn
            // 
            addDirectorBtn.BackColor = Color.MediumTurquoise;
            addDirectorBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addDirectorBtn.Location = new Point(408, 503);
            addDirectorBtn.Name = "addDirectorBtn";
            addDirectorBtn.Size = new Size(182, 67);
            addDirectorBtn.TabIndex = 18;
            addDirectorBtn.Text = "Add Director";
            addDirectorBtn.UseVisualStyleBackColor = false;
            addDirectorBtn.Click += addDirectorBtn_Click;
            // 
            // addGenreLabel
            // 
            addGenreLabel.AutoSize = true;
            addGenreLabel.Font = new Font("Rockwell", 20F);
            addGenreLabel.Location = new Point(51, 37);
            addGenreLabel.Name = "addGenreLabel";
            addGenreLabel.Size = new Size(222, 31);
            addGenreLabel.TabIndex = 1;
            addGenreLabel.Text = "Add New Genre:";
            // 
            // addNewGenreTextbox
            // 
            addNewGenreTextbox.Font = new Font("Rockwell", 20F);
            addNewGenreTextbox.Location = new Point(296, 30);
            addNewGenreTextbox.Name = "addNewGenreTextbox";
            addNewGenreTextbox.PlaceholderText = "Genre";
            addNewGenreTextbox.Size = new Size(350, 39);
            addNewGenreTextbox.TabIndex = 4;
            // 
            // addNewGenreButton
            // 
            addNewGenreButton.BackColor = Color.MediumTurquoise;
            addNewGenreButton.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addNewGenreButton.Location = new Point(408, 109);
            addNewGenreButton.Name = "addNewGenreButton";
            addNewGenreButton.Size = new Size(182, 67);
            addNewGenreButton.TabIndex = 10;
            addNewGenreButton.Text = "Add Genre";
            addNewGenreButton.UseVisualStyleBackColor = false;
            addNewGenreButton.Click += addNewGenreButton_Click;
            // 
            // addActorLabel
            // 
            addActorLabel.AutoSize = true;
            addActorLabel.Font = new Font("Rockwell", 20F);
            addActorLabel.Location = new Point(51, 229);
            addActorLabel.Name = "addActorLabel";
            addActorLabel.Size = new Size(211, 31);
            addActorLabel.TabIndex = 13;
            addActorLabel.Text = "Add New Actor:";
            // 
            // addNewDirectorTextbox
            // 
            addNewDirectorTextbox.Font = new Font("Rockwell", 20F);
            addNewDirectorTextbox.Location = new Point(296, 424);
            addNewDirectorTextbox.Name = "addNewDirectorTextbox";
            addNewDirectorTextbox.PlaceholderText = "Director Name";
            addNewDirectorTextbox.Size = new Size(350, 39);
            addNewDirectorTextbox.TabIndex = 16;
            // 
            // addNewActorTextbox
            // 
            addNewActorTextbox.Font = new Font("Rockwell", 20F);
            addNewActorTextbox.Location = new Point(296, 221);
            addNewActorTextbox.Name = "addNewActorTextbox";
            addNewActorTextbox.PlaceholderText = "Actor Name";
            addNewActorTextbox.Size = new Size(350, 39);
            addNewActorTextbox.TabIndex = 14;
            // 
            // addNewDirectorLabel
            // 
            addNewDirectorLabel.AutoSize = true;
            addNewDirectorLabel.Font = new Font("Rockwell", 20F);
            addNewDirectorLabel.Location = new Point(27, 432);
            addNewDirectorLabel.Name = "addNewDirectorLabel";
            addNewDirectorLabel.Size = new Size(246, 31);
            addNewDirectorLabel.TabIndex = 15;
            addNewDirectorLabel.Text = "Add New Director:";
            // 
            // updateNewAcGenDirPage
            // 
            updateNewAcGenDirPage.Controls.Add(updateDirBtn);
            updateNewAcGenDirPage.Controls.Add(updateAcBtn);
            updateNewAcGenDirPage.Controls.Add(updateGenBtn);
            updateNewAcGenDirPage.Controls.Add(updateDirectorText);
            updateNewAcGenDirPage.Controls.Add(updateActorText);
            updateNewAcGenDirPage.Controls.Add(updateGenreText);
            updateNewAcGenDirPage.Controls.Add(label3);
            updateNewAcGenDirPage.Controls.Add(label2);
            updateNewAcGenDirPage.Controls.Add(label1);
            updateNewAcGenDirPage.Controls.Add(selectDirNumeric);
            updateNewAcGenDirPage.Controls.Add(selectActNumeric);
            updateNewAcGenDirPage.Controls.Add(selectGenNumeric);
            updateNewAcGenDirPage.Location = new Point(4, 24);
            updateNewAcGenDirPage.Name = "updateNewAcGenDirPage";
            updateNewAcGenDirPage.Padding = new Padding(3);
            updateNewAcGenDirPage.Size = new Size(726, 601);
            updateNewAcGenDirPage.TabIndex = 1;
            updateNewAcGenDirPage.Text = "Update";
            updateNewAcGenDirPage.UseVisualStyleBackColor = true;
            // 
            // updateDirBtn
            // 
            updateDirBtn.BackColor = Color.MediumTurquoise;
            updateDirBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            updateDirBtn.Location = new Point(581, 462);
            updateDirBtn.Name = "updateDirBtn";
            updateDirBtn.Size = new Size(126, 40);
            updateDirBtn.TabIndex = 13;
            updateDirBtn.Text = "Update";
            updateDirBtn.UseVisualStyleBackColor = false;
            updateDirBtn.Click += updateDirBtn_Click;
            // 
            // updateAcBtn
            // 
            updateAcBtn.BackColor = Color.MediumTurquoise;
            updateAcBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            updateAcBtn.Location = new Point(581, 268);
            updateAcBtn.Name = "updateAcBtn";
            updateAcBtn.Size = new Size(126, 40);
            updateAcBtn.TabIndex = 12;
            updateAcBtn.Text = "Update";
            updateAcBtn.UseVisualStyleBackColor = false;
            updateAcBtn.Click += updateAcBtn_Click;
            // 
            // updateGenBtn
            // 
            updateGenBtn.BackColor = Color.MediumTurquoise;
            updateGenBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            updateGenBtn.Location = new Point(581, 69);
            updateGenBtn.Name = "updateGenBtn";
            updateGenBtn.Size = new Size(126, 40);
            updateGenBtn.TabIndex = 11;
            updateGenBtn.Text = "Update";
            updateGenBtn.UseVisualStyleBackColor = false;
            updateGenBtn.Click += updateGenBtn_Click;
            // 
            // updateDirectorText
            // 
            updateDirectorText.Font = new Font("Rockwell", 20F);
            updateDirectorText.Location = new Point(271, 463);
            updateDirectorText.Name = "updateDirectorText";
            updateDirectorText.Size = new Size(274, 39);
            updateDirectorText.TabIndex = 8;
            // 
            // updateActorText
            // 
            updateActorText.Font = new Font("Rockwell", 20F);
            updateActorText.Location = new Point(271, 269);
            updateActorText.Name = "updateActorText";
            updateActorText.Size = new Size(274, 39);
            updateActorText.TabIndex = 7;
            // 
            // updateGenreText
            // 
            updateGenreText.Font = new Font("Rockwell", 20F);
            updateGenreText.Location = new Point(271, 69);
            updateGenreText.Name = "updateGenreText";
            updateGenreText.Size = new Size(274, 39);
            updateGenreText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 417);
            label3.Name = "label3";
            label3.Size = new Size(186, 27);
            label3.TabIndex = 5;
            label3.Text = "Select Director:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 227);
            label2.Name = "label2";
            label2.Size = new Size(154, 27);
            label2.TabIndex = 4;
            label2.Text = "Select Actor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 27);
            label1.TabIndex = 3;
            label1.Text = "Select Genre:";
            // 
            // selectDirNumeric
            // 
            selectDirNumeric.Font = new Font("Rockwell", 20F);
            selectDirNumeric.Location = new Point(89, 464);
            selectDirNumeric.Name = "selectDirNumeric";
            selectDirNumeric.Size = new Size(87, 39);
            selectDirNumeric.TabIndex = 2;
            selectDirNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // selectActNumeric
            // 
            selectActNumeric.Font = new Font("Rockwell", 20F);
            selectActNumeric.Location = new Point(89, 270);
            selectActNumeric.Name = "selectActNumeric";
            selectActNumeric.Size = new Size(87, 39);
            selectActNumeric.TabIndex = 1;
            selectActNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // selectGenNumeric
            // 
            selectGenNumeric.Font = new Font("Rockwell", 20F);
            selectGenNumeric.Location = new Point(89, 70);
            selectGenNumeric.Name = "selectGenNumeric";
            selectGenNumeric.Size = new Size(87, 39);
            selectGenNumeric.TabIndex = 0;
            selectGenNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // currentDirectorsLabel
            // 
            currentDirectorsLabel.AutoSize = true;
            currentDirectorsLabel.Location = new Point(153, 603);
            currentDirectorsLabel.Name = "currentDirectorsLabel";
            currentDirectorsLabel.Size = new Size(216, 27);
            currentDirectorsLabel.TabIndex = 12;
            currentDirectorsLabel.Text = "Current Directors:";
            // 
            // currentDirectorsListbox
            // 
            currentDirectorsListbox.Font = new Font("Rockwell", 13F);
            currentDirectorsListbox.FormattingEnabled = true;
            currentDirectorsListbox.ItemHeight = 20;
            currentDirectorsListbox.Location = new Point(32, 649);
            currentDirectorsListbox.Name = "currentDirectorsListbox";
            currentDirectorsListbox.Size = new Size(444, 124);
            currentDirectorsListbox.TabIndex = 11;
            // 
            // currentActorsListbox
            // 
            currentActorsListbox.Font = new Font("Rockwell", 13F);
            currentActorsListbox.FormattingEnabled = true;
            currentActorsListbox.ItemHeight = 20;
            currentActorsListbox.Location = new Point(32, 459);
            currentActorsListbox.Name = "currentActorsListbox";
            currentActorsListbox.Size = new Size(444, 124);
            currentActorsListbox.TabIndex = 10;
            // 
            // currentActorsLabel
            // 
            currentActorsLabel.AutoSize = true;
            currentActorsLabel.Location = new Point(168, 412);
            currentActorsLabel.Name = "currentActorsLabel";
            currentActorsLabel.Size = new Size(184, 27);
            currentActorsLabel.TabIndex = 9;
            currentActorsLabel.Text = "Current Actors:";
            // 
            // currentGenresLabel
            // 
            currentGenresLabel.AutoSize = true;
            currentGenresLabel.Location = new Point(168, 209);
            currentGenresLabel.Name = "currentGenresLabel";
            currentGenresLabel.Size = new Size(194, 27);
            currentGenresLabel.TabIndex = 8;
            currentGenresLabel.Text = "Current Genres:";
            // 
            // currentGenresListbox
            // 
            currentGenresListbox.Font = new Font("Rockwell", 13F);
            currentGenresListbox.FormattingEnabled = true;
            currentGenresListbox.ItemHeight = 20;
            currentGenresListbox.Location = new Point(32, 255);
            currentGenresListbox.Name = "currentGenresListbox";
            currentGenresListbox.Size = new Size(444, 124);
            currentGenresListbox.TabIndex = 7;
            // 
            // targetMovieLabel
            // 
            targetMovieLabel.BackColor = Color.Gainsboro;
            targetMovieLabel.Location = new Point(312, 76);
            targetMovieLabel.Name = "targetMovieLabel";
            targetMovieLabel.Size = new Size(812, 59);
            targetMovieLabel.TabIndex = 0;
            targetMovieLabel.Text = "Target Movie:";
            targetMovieLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieMgmtErrorLabel
            // 
            movieMgmtErrorLabel.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            movieMgmtErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            movieMgmtErrorLabel.Location = new Point(288, 47);
            movieMgmtErrorLabel.Name = "movieMgmtErrorLabel";
            movieMgmtErrorLabel.Size = new Size(1380, 34);
            movieMgmtErrorLabel.TabIndex = 8;
            movieMgmtErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addMovieBtn
            // 
            addMovieBtn.BackColor = Color.MediumTurquoise;
            addMovieBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addMovieBtn.Location = new Point(1724, 10);
            addMovieBtn.Name = "addMovieBtn";
            addMovieBtn.Size = new Size(165, 67);
            addMovieBtn.TabIndex = 3;
            addMovieBtn.Text = "Add Movie";
            addMovieBtn.UseVisualStyleBackColor = false;
            addMovieBtn.Click += addMovieBtn_Click;
            // 
            // moviesDashHomeBtn
            // 
            moviesDashHomeBtn.Image = (Image)resources.GetObject("moviesDashHomeBtn.Image");
            moviesDashHomeBtn.Location = new Point(17, 7);
            moviesDashHomeBtn.Margin = new Padding(3, 2, 3, 2);
            moviesDashHomeBtn.Name = "moviesDashHomeBtn";
            moviesDashHomeBtn.Size = new Size(64, 59);
            moviesDashHomeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            moviesDashHomeBtn.TabIndex = 9;
            moviesDashHomeBtn.TabStop = false;
            moviesDashHomeBtn.Click += moviesDashHomeBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MovieDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1904, 1039);
            Controls.Add(moviesDashHomeBtn);
            Controls.Add(addMovieBtn);
            Controls.Add(movieMgmtErrorLabel);
            Controls.Add(movieDashTabCtrl);
            Controls.Add(searchBtn);
            Controls.Add(totalMoviesLabel);
            Controls.Add(filterBarMovies);
            Controls.Add(searchBarMovies);
            MaximumSize = new Size(1920, 1078);
            MinimumSize = new Size(1920, 1052);
            Name = "MovieDashboard";
            Text = "MovieDashboard";
            movieDashTabCtrl.ResumeLayout(false);
            movieDashPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            editMoviePage.ResumeLayout(false);
            movieEditTabControl.ResumeLayout(false);
            editMovieDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updateMoviePictureBox).EndInit();
            editMovieGroup.ResumeLayout(false);
            editMovieGroup.PerformLayout();
            createMoviePage.ResumeLayout(false);
            createMovieTabCtrl.ResumeLayout(false);
            createMovieDetailsGroup.ResumeLayout(false);
            createMovieDialogueBox.ResumeLayout(false);
            createMovieDialogueBox.PerformLayout();
            categoryManagementTab.ResumeLayout(false);
            categoryMgmtGroup.ResumeLayout(false);
            categoryMgmtGroup.PerformLayout();
            editCreateAcGenDirTabCtrl.ResumeLayout(false);
            createNewAcGenDirPage.ResumeLayout(false);
            createNewAcGenDirPage.PerformLayout();
            updateNewAcGenDirPage.ResumeLayout(false);
            updateNewAcGenDirPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectDirNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectActNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectGenNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesDashHomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Button nextPageBtnMovie;
        private Button previousPageBtnMovie;
        private Label targetMovieLabel;
        private TextBox addNewGenreTextbox;
        private Label averageRatingLabel;
        private TextBox averageRatingTextBox;
        private Label updateAverageRatingLabel;
        private TextBox updateAverageRatingTextBox;
        private ErrorProvider errorProvider1;
        private TabPage categoryManagementTab;
        private GroupBox categoryMgmtGroup;
        private Button addDirGenAc;
        private Label currentGenresLabel;
        private ListBox currentGenresListbox;
        private Label addGenreLabel;
        private Label currentDirectorsLabel;
        private ListBox currentDirectorsListbox;
        private ListBox currentActorsListbox;
        private Label currentActorsLabel;
        private Label addActorLabel;
        private TextBox addNewActorTextbox;
        private Label addNewDirectorLabel;
        private TextBox addNewDirectorTextbox;
        private Button addNewGenreButton;
        private Button addActorBtn;
        private Button addDirectorBtn;
        private TabControl editCreateAcGenDirTabCtrl;
        private TabPage createNewAcGenDirPage;
        private TabPage updateNewAcGenDirPage;
        private NumericUpDown selectGenNumeric;
        private NumericUpDown selectDirNumeric;
        private NumericUpDown selectActNumeric;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button updateGenBtn;
        private TextBox updateDirectorText;
        private TextBox updateActorText;
        private TextBox updateGenreText;
        private Button updateAcBtn;
        private Button updateDirBtn;
    }
}