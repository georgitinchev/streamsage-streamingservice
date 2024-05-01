using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class MovieDashboard : Form
    {
        private DesktopController desktopController;
        private int currentMovieId;
        public MovieDashboard(DesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            moviesDataGrid.CellContentClick += moviesDataGrid_CellContentClick;
            InitializeMoviesGrid();
            RefreshMovies();
        }

        private async void moviesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Movie movie = (Movie)senderGrid.Rows[e.RowIndex].DataBoundItem;
                MovieDTO movieDto = new MovieDTO
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    ReleaseDate = movie.Year,
                    Description = movie.Description,
                    PosterImageURL = movie.PosterImageURL,
                    TrailerURL = movie.TrailerURL,
                    RuntimeMinutes = movie.RuntimeMinutes
                };
                if (senderGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    movieDashTabCtrl.SelectedIndex = 1;
                    currentMovieId = movieDto.Id;
                    movieTitleBox.Text = movieDto.Title;
                    movieYearPicker.Value = movieDto.ReleaseDate;
                    descriptionTextBox.Text = movieDto.Description;
                    posterUrlTextBox.Text = movieDto.PosterImageURL;
                    trailerUrlTextBox.Text = movieDto.TrailerURL;
                    runTimeTextBox.Text = movieDto.RuntimeMinutes.ToString();
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        desktopController.backendService?.DeleteMovie(movieDto.Id);
                        RefreshMovies();
                        movieMgmtErrorLabel.Text = "Movie deleted successfully!";
                    }
                    catch (Exception ex)
                    {
                        movieMgmtErrorLabel.Text = ex.Message;
                    }
                    finally
                    {
                        await Task.Delay(3000); 
                        movieMgmtErrorLabel.Text = "";
                        senderGrid.CurrentCell = null;
                    }
                }
                senderGrid.CurrentCell = null;
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
        }

        private void RefreshMovies()
        {
            List<Movie> movies = desktopController.displayMoviePage();
            moviesDataGrid.DataSource = null;
            moviesDataGrid.DataSource = movies;
            totalMoviesLabel.Text = $"Total Movies: {movies.Count}";
            moviesDataGrid.Refresh();
        }

        private async void updateMovieBtn_Click(object sender, EventArgs e)
        {
            string validationError = MovieValidation.ValidateCreateMovieFields(
                movieTitleBox.Text,
                movieYearPicker.Value,
                descriptionTextBox.Text,
                posterUrlTextBox.Text,
                trailerUrlTextBox.Text,
                int.TryParse(runTimeTextBox.Text, out int runtime) ? runtime : 0
            );

            if (!string.IsNullOrEmpty(validationError))
            {
                updateStatusLabel.Text = validationError;
                await Task.Delay(3000);
                updateStatusLabel.Text = "";
                return;
            }

            MovieDTO movieDto = new MovieDTO
            {
                Id = currentMovieId,
                Title = movieTitleBox.Text,
                ReleaseDate = movieYearPicker.Value,
                Description = descriptionTextBox.Text,
                PosterImageURL = posterUrlTextBox.Text,
                TrailerURL = trailerUrlTextBox.Text,
                RuntimeMinutes = runtime
            };

            try
            {
                desktopController.backendService?.UpdateMovie(movieDto);
                updateStatusLabel.Text = "Update successful!";
                RefreshMovies();
            }
            catch (Exception ex)
            {
                updateStatusLabel.Text = ex.Message;
            }
            finally
            {
                await Task.Delay(3000);
                updateStatusLabel.Text = "";
            }
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
            string validationError = MovieValidation.ValidateCreateMovieFields(
                createMovieTitleBox.Text,
                createMovieDatePicker.Value,
                createMovieDescriptionBox.Text,
                createMoviePosterBox.Text,
                createMovieUrlBox.Text,
                int.TryParse(createMovieRunTimeBox.Text, out int runtime) ? runtime : 0
            );

            if (!string.IsNullOrEmpty(validationError))
            {
                createMovieErrorLabel.Text = validationError;
                await Task.Delay(3000);
                createMovieErrorLabel.Text = "";
                return;
            }

            MovieDTO newMovie = new MovieDTO
            {
                Title = createMovieTitleBox.Text,
                ReleaseDate = createMovieDatePicker.Value,
                Description = createMovieDescriptionBox.Text,
                PosterImageURL = createMoviePosterBox.Text,
                TrailerURL = createMovieUrlBox.Text,
                RuntimeMinutes = runtime
            };

            try
            {
                desktopController.backendService?.AddMovie(newMovie);
                createMovieErrorLabel.Text = "Movie created successfully!";
                ClearCreateMovieFields();
                RefreshMovies();
            }
            catch (Exception ex)
            {
                createMovieErrorLabel.Text = $"Failed to create movie: {ex.Message}";
            }
            finally
            {
                await Task.Delay(3000);
                createMovieErrorLabel.Text = "";
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
        }
    }
}
