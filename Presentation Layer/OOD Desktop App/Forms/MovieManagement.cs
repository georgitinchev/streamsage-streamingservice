using DTOs;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void moviesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        // Removes the success message after 3 seconds
                        Task.Delay(3000).ContinueWith(t => movieMgmtErrorLabel.Text = "");
                    }
                    catch (Exception ex)
                    {
                        movieMgmtErrorLabel.Text = $"Error deleting movie: {ex.Message}";
                    }
                }
            }
        }

        private void InitializeMoviesGrid()
        {
            // adding data columns
            moviesDataGrid.AutoGenerateColumns = false;
            moviesDataGrid.Columns.Clear();

            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title" });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Year", HeaderText = "Year" });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Description" });
            moviesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RuntimeMinutes", HeaderText = "Runtime" });

            // edit button dgrid view
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Width = 125;
            editButtonColumn.MinimumWidth = 125;

            // delete button dgrid view
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 125;
            deleteButtonColumn.MinimumWidth = 125;

            //adding them to columns
            moviesDataGrid.Columns.Add(editButtonColumn);
            moviesDataGrid.Columns.Add(deleteButtonColumn);

            // cell styling
            moviesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            moviesDataGrid.BackgroundColor = Color.LightGray;
            moviesDataGrid.BorderStyle = BorderStyle.None;
            moviesDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            moviesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            moviesDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            moviesDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            moviesDataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            moviesDataGrid.EnableHeadersVisualStyles = false;
            moviesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            moviesDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            moviesDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            moviesDataGrid.RowTemplate.Height = 50;
        }

        private void RefreshMovies()
        {
            List<Movie> movies = desktopController.displayMoviePage();
            moviesDataGrid.DataSource = movies;
            totalMoviesLabel.Text = $"Total Movies: {movies.Count}";
        }

        private async void updateMovieBtn_Click(object sender, EventArgs e)
        {
            string validationError = ValidateMovieFields();
            if (validationError != null)
            {
                updateStatusLabel.Text = validationError;
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
                RuntimeMinutes = int.Parse(runTimeTextBox.Text)
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
            await Task.Delay(3000);
            updateStatusLabel.Text = "";
        }

        private void movieDashTabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
        moviesDataGrid.Refresh();
        }

        private string ValidateMovieFields()
        {
            if (string.IsNullOrWhiteSpace(movieTitleBox.Text))
            {
                return "Title cannot be empty!";
            }

            if (movieYearPicker.Value > DateTime.Now)
            {
                return "Year cannot be in the future!";
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                return "Description cannot be empty!";
            }

            Uri uriResult;
            if (!Uri.TryCreate(posterUrlTextBox.Text, UriKind.Absolute, out uriResult) || !(uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                return "Poster URL is not a valid URL!";
            }

            if (!Uri.TryCreate(trailerUrlTextBox.Text, UriKind.Absolute, out uriResult) || !(uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                return "Trailer URL is not a valid URL!";
            }

            if (!int.TryParse(runTimeTextBox.Text, out int runtime) || runtime <= 0)
            {
                return "Runtime must be a positive integer!";
            }
            return null;
        }
    }
}
