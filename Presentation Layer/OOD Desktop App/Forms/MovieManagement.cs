using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exceptions;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Validation;


namespace DesktopApp.Forms
{
    public partial class MovieDashboard : Form
    {
        private readonly IDesktopController desktopController;
        private int currentMovieId;
        private int currentPage = 1;
        public MovieDashboard(IDesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            moviesDataGrid.CellContentClick += moviesDataGrid_CellContentClick;
            InitializeMoviesGrid();
            PopulateGenreCheckListBoxes();
            LoadMoviesPage();
        }

        private async void moviesDataGrid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var senderGrid = (DataGridView)sender;
            MovieDTO movie = (MovieDTO)senderGrid.Rows[e.RowIndex].DataBoundItem;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
            {

                if (buttonColumn.Name == "Edit")
                {
                    movieDashTabCtrl.SelectedIndex = 1;
                    currentMovieId = movie.Id;
                    LoadMovieDetails(movie);
                }
                else if (buttonColumn.Name == "Delete")
                {
                    await DeleteMovieAsync(movie.Id);
                }
            }
            senderGrid.CurrentCell = null;
        }

        private void LoadMovieDetails(MovieDTO movieDto)
        {
            movieTitleBox.Text = movieDto.Title;
            movieYearPicker.Value = movieDto.ReleaseDate.Date;
            descriptionTextBox.Text = movieDto.Description;
            posterUrlTextBox.Text = movieDto.PosterImageURL;
            trailerUrlTextBox.Text = movieDto.TrailerURL;
            runTimeTextBox.Text = movieDto.RuntimeMinutes.ToString();
            updateAverageRatingTextBox.Text = movieDto.AverageRating?.ToString() ?? "N/A";
            SetSelectedMovieGenres(movieDto);
            UIStyler.LoadImageIntoPictureBox(movieDto.PosterImageURL, updateMoviePictureBox);
        }

        private void RefreshMovieGenAcDirDetails()
        {
            var movie = desktopController.MovieService.GetMovie(currentMovieId);
            UIStyler.PopulateListOrPlaceholder(currentGenresListbox, movie.Genres, "No genres found");
            UIStyler.PopulateListOrPlaceholder(currentActorsListbox, movie.Actors, "No actors found");
            UIStyler.PopulateListOrPlaceholder(currentDirectorsListbox, movie.Directors, "No directors found");
        }


        private async Task DeleteMovieAsync(int movieId)
        {
            try
            {
                desktopController.MovieService.DeleteMovie(movieId);
                LoadMoviesPage();
                movieMgmtErrorLabel.Text = "Movie deleted successfully!";
            }
            catch (DeleteEntityError ex)
            {
                movieMgmtErrorLabel.Text = ex.Message;
            }
            finally
            {
                await Task.Delay(3000);
                movieMgmtErrorLabel.Text = "";
            }
        }


        private void InitializeMoviesGrid()
        {
            moviesDataGrid.AutoGenerateColumns = false;
            moviesDataGrid.Columns.Clear();
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Year", HeaderText = "Year", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Description", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RuntimeMinutes", HeaderText = "Runtime", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            UIStyler.StyleDataGridView(moviesDataGrid);
            UIStyler.AddButtonColumn(moviesDataGrid, "Edit", "Edit");
            UIStyler.AddButtonColumn(moviesDataGrid, "Delete", "Delete");
            previousPageBtnMovie.Click += (sender, e) => { currentPage--; LoadMoviesPage(); };
            nextPageBtnMovie.Click += (sender, e) => { currentPage++; LoadMoviesPage(); };
        }

        private void LoadMoviesPage()
        {
            try
            {
                var movies = desktopController.MovieService.GetMoviesPage(currentPage, desktopController.GetPageSize());
                if (movies.Count == 0 && currentPage > 1)
                {
                    currentPage--;
                    LoadMoviesPage();
                    return;
                }
                moviesDataGrid.DataSource = movies;
                totalMoviesLabel.Text = $"Total Movies: {desktopController.MovieService.GetTotalMovies()}";
                moviesDataGrid.Refresh();
            }
            catch (PaginatorException ex)
            {
                movieMgmtErrorLabel.Text = ex.Message;
            }
        }


        private async void updateMovieBtn_Click(object sender, EventArgs e)
        {
            var validationError = ValidateMovieFields(movieTitleBox.Text, movieYearPicker.Value.Date, descriptionTextBox.Text, posterUrlTextBox.Text, trailerUrlTextBox.Text, runTimeTextBox.Text, out int runtime);
            if (!string.IsNullOrEmpty(validationError))
            {
                await DisplayErrorAsync(updateStatusLabel, validationError);
                return;
            }
            var averageRatingError = MovieValidation.ValidateAverageRating(averageRatingTextBox.Text, out decimal averageRating);
            if (!string.IsNullOrEmpty(averageRatingError))
            {
                await DisplayErrorAsync(updateStatusLabel, averageRatingError);
                return;
            }
            try
            {
                desktopController.MovieService.UpdateMovie(currentMovieId, movieTitleBox.Text, movieYearPicker.Value, descriptionTextBox.Text, posterUrlTextBox.Text, trailerUrlTextBox.Text, runtime, decimal.Parse(averageRatingTextBox.Text), GetSelectedGenres(updateMovieCheckListBox), new List<string>(), new List<string>());
                await DisplayErrorAsync(updateStatusLabel, "Movie updated successfully!");
                LoadMoviesPage();
                UIStyler.LoadImageIntoPictureBox(posterUrlTextBox.Text, updateMoviePictureBox);
            }
            catch (UpdateEntityError ex)
            {
                await DisplayErrorAsync(updateStatusLabel, ex.Message);
            }
        }


        private static async Task DisplayErrorAsync(Label label, string message)
        {
            label.Text = message;
            await Task.Delay(3000);
            label.Text = "";
        }

        private static string ValidateMovieFields(string title, DateTime releaseDate, string description, string posterUrl, string trailerUrl, string runtimeText, out int runtime)
        {
            runtime = int.TryParse(runtimeText, out int parsedRuntime) ? parsedRuntime : 0;
            return MovieValidation.ValidateCreateMovieFields(title, releaseDate, description, posterUrl, trailerUrl, runtime);
        }

        private void movieDashTabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            moviesDataGrid.Refresh();
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            movieDashTabCtrl.SelectedIndex = 2;
        }

        private void moviesDashHomeBtn_Click(object sender, EventArgs e)
        {
            movieDashTabCtrl.SelectedIndex = 0;
        }

        private async void createMovieBtn_Click(object sender, EventArgs e)
        {
            var validationError = ValidateMovieFields(createMovieTitleBox.Text, createMovieDatePicker.Value, createMovieDescriptionBox.Text, createMoviePosterBox.Text, createMovieUrlBox.Text, createMovieRunTimeBox.Text, out int runtime);
            if (!string.IsNullOrEmpty(validationError))
            {
                await DisplayErrorAsync(createMovieErrorLabel, validationError);
                return;
            }
            var averageRatingError = MovieValidation.ValidateAverageRating(averageRatingTextBox.Text, out decimal averageRating);
            if (!string.IsNullOrEmpty(averageRatingError))
            {
                await DisplayErrorAsync(createMovieErrorLabel, averageRatingError);
                return;
            }
            try
            {
                desktopController.MovieService.AddMovie(createMovieTitleBox.Text, createMovieDatePicker.Value, createMovieDescriptionBox.Text, createMoviePosterBox.Text, createMovieUrlBox.Text, runtime, averageRating, GetSelectedGenres(createMovieGenresCheckList), new List<string>(), new List<string>());
                await DisplayErrorAsync(createMovieErrorLabel, "Movie created successfully!");
                ClearCreateMovieFields();
                LoadMoviesPage();
            }
            catch (CreateEntityError ex)
            {
                await DisplayErrorAsync(createMovieErrorLabel, ex.Message);
            }
        }

        private void ClearCreateMovieFields()
        {
            createMovieTitleBox.Text = string.Empty;
            createMovieDatePicker.Value = DateTime.Now;
            createMovieDescriptionBox.Text = string.Empty;
            createMoviePosterBox.Text = string.Empty;
            createMovieUrlBox.Text = string.Empty;
            createMovieRunTimeBox.Text = string.Empty;
            UIStyler.UncheckAllItemsInCheckListBox(createMovieGenresCheckList);
        }

        private void PopulateGenreCheckListBoxes()
        {
            var genres = desktopController.MovieService?.GetAllGenres();
            UIStyler.PopulateCheckListBox(createMovieGenresCheckList, genres);
            UIStyler.PopulateCheckListBox(updateMovieCheckListBox, genres);
        }

        private static List<string> GetSelectedGenres(CheckedListBox box)
        {
            return UIStyler.GetSelectedItemsFromCheckListBox(box);
        }

        private void SetSelectedMovieGenres(MovieDTO movieDto)
        {
            if (movieDto.Genres == null) return;
            UIStyler.SetSelectedItemsInCheckListBox(updateMovieCheckListBox, movieDto.Genres);
        }

        private void addDirGenAc_Click(object sender, EventArgs e)
        {
            // Switch to tab number 3
            movieDashTabCtrl.SelectedIndex = 3;
            // Update the target movie label with the current movie's title
            var movie = desktopController.MovieService.GetMovie(currentMovieId);
            targetMovieLabel.Text = $"Target Movie: {movie.Title}";
            // Populate or display placeholders for genres, actors and directors in boxes
            UIStyler.PopulateListOrPlaceholder(currentGenresListbox, movie.Genres ?? Enumerable.Empty<string>(), "No genres found");
            UIStyler.PopulateListOrPlaceholder(currentActorsListbox, movie.Actors ?? Enumerable.Empty<string>(), "No actors found");
            UIStyler.PopulateListOrPlaceholder(currentDirectorsListbox, movie.Directors ?? Enumerable.Empty<string>(), "No directors found");
        }

        private async void addNewGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                desktopController.MovieService.AddGenreToMovie(currentMovieId, addNewGenreTextbox.Text);
                await DisplayErrorAsync(movieMgmtErrorLabel, "Genre added successfully!");
                RefreshMovieGenAcDirDetails();
                addNewGenreTextbox.Text = "";
            }
            catch (ArgumentException ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (UpdateEntityError ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (NotFoundException ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            } 
            catch (GetMovieError ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
        }

        private async void addActorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                desktopController.MovieService.AddGenreToMovie(currentMovieId, addNewActorTextbox.Text);
                await DisplayErrorAsync(movieMgmtErrorLabel, "Actor added successfully!");
                RefreshMovieGenAcDirDetails();
                addNewActorTextbox.Text = "";
            }
            catch (ArgumentException ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (UpdateEntityError ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (NotFoundException ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (GetMovieError ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
        }
        private async void addDirectorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                desktopController.MovieService.AddGenreToMovie(currentMovieId, addNewDirectorTextbox.Text);
                await DisplayErrorAsync(movieMgmtErrorLabel, "Director added successfully!");
                RefreshMovieGenAcDirDetails();
                addNewDirectorTextbox.Text = "";
            }
            catch (ArgumentException ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (UpdateEntityError ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (NotFoundException ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
            catch (GetMovieError ex)
            {
                await DisplayErrorAsync(movieMgmtErrorLabel, ex.Message);
            }
        }

        private void updateGenBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateAcBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateDirBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
