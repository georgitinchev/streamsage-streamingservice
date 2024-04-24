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
		public MovieDashboard(DesktopController _desktopController)
		{
			InitializeComponent();
			this.desktopController = _desktopController;
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
                    Year = movie.Year,
                    Description = movie.Description,
                    PosterImageURL = movie.PosterImageURL,
                    TrailerURL = movie.TrailerURL,
                    RuntimeMinutes = movie.RuntimeMinutes,
                    AverageRating = movie.AverageRating
                };
                if (senderGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                   
					desktopController.backendService?.UpdateMovie(movieDto);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
					desktopController.backendService?.DeleteMovie(movieDto.Id);
                }
            }
        }


        private void RefreshMovies()
		{
			List<Movie> movies = desktopController.displayMoviePage();
			moviesDataGrid.DataSource = movies;
			moviesDataGrid.AutoResizeColumns();
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

			DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
			editButtonColumn.Name = "Edit";
			editButtonColumn.Text = "Edit";
			editButtonColumn.UseColumnTextForButtonValue = true;

			DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
			deleteButtonColumn.Name = "Delete";
			deleteButtonColumn.Text = "Delete";
			deleteButtonColumn.UseColumnTextForButtonValue = true;

			moviesDataGrid.Columns.Add(editButtonColumn);
			moviesDataGrid.Columns.Add(deleteButtonColumn);
		}
	}
}
