using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Validation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class ReviewManagement : Form
    {
        private readonly IDesktopController desktopController;
        private int currentReviewId;
        private int currentPage = 1;

        public ReviewManagement(IDesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            InitializeReviewsGrid();
            LoadReviewsPage();
            reviewsDashHomeBtn.Click += reviewsDashHomeBtn_Click; 
            reviewsDataGrid.CellContentClick += reviewsDataGrid_CellContentClick;
        }

        private void InitializeReviewsGrid()
        {
            reviewsDataGrid.AutoGenerateColumns = false;
            reviewsDataGrid.Columns.Clear();
            reviewsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            reviewsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Content", HeaderText = "Content", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            reviewsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Rating", HeaderText = "Rating", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            reviewsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReviewDate", HeaderText = "Review Date", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            UIStyler.StyleDataGridView(reviewsDataGrid);
            UIStyler.AddButtonColumn(reviewsDataGrid, "Edit", "Edit");
            UIStyler.AddButtonColumn(reviewsDataGrid, "Delete", "Delete");
            previousPageBtnReviews.Click += (sender, e) => { currentPage--; LoadReviewsPage(); };
            nextPageBtnReviews.Click += (sender, e) => { currentPage++; LoadReviewsPage(); };
        }

        private async void reviewsDataGrid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var senderGrid = (DataGridView)sender;
            ReviewDTO review = (ReviewDTO)senderGrid.Rows[e.RowIndex].DataBoundItem;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
            {
                if (buttonColumn.Name == "Edit")
                {
                    reviewTabCtrl.SelectedIndex = 1;
                    currentReviewId = review.Id;
                    LoadReviewDetails(review);
                }
                else if (buttonColumn.Name == "Delete")
                {
                    try
                    {
                        await DeleteReviewAsync(review.Id);
                        LoadReviewsPage();
                        reviewMgmtErrorLabel.Text = "Review deleted successfully!";
                    }
                    catch (System.Exception ex)
                    {
                        reviewMgmtErrorLabel.Text = $"An error occurred while deleting the review: {ex.Message}";
                    }
                    finally
                    {
                        await Task.Delay(3000);
                        reviewMgmtErrorLabel.Text = "";
                    }
                }
            }
            senderGrid.CurrentCell = null;
        }


        private void LoadReviewsPage()
        {
            var reviews = desktopController.ReviewService.GetReviewsPage(currentPage, desktopController.GetPageSize());
            if (reviews.Count == 0 && currentPage > 1)
            {
                currentPage--;
                LoadReviewsPage();
                return;
            }
            reviewsDataGrid.DataSource = reviews;
            totalReviewsLabel.Text = $"Total Reviews: {desktopController.ReviewService.GetAllReviews().Count}";
            reviewsDataGrid.Refresh();
        }

        private void LoadReviewDetails(ReviewDTO reviewDto)
        {
            reviewUserIdLabel.Text = $"UserId: {reviewDto.UserId}";
            movieIdLabel.Text = $"MovieId: {reviewDto.MovieId}";
            reviewTitleText.Text = reviewDto.Title;
            reviewContentText.Text = reviewDto.Content;
            reviewRatingNumeric.Value = reviewDto.Rating;
        }

        private async Task DeleteReviewAsync(int reviewId)
        {
            try
            {
                desktopController.ReviewService.DeleteReview(reviewId);
                LoadReviewsPage();
                reviewMgmtErrorLabel.Text = "Review deleted successfully!";
            }
            catch (System.Exception ex)
            {
                reviewMgmtErrorLabel.Text = $"An error occurred while deleting the review: {ex.Message}";
            }
            finally
            {
                await Task.Delay(3000);
                reviewMgmtErrorLabel.Text = "";
            }
        }

        private async void updateReviewBtn_Click(object sender, EventArgs e)
        {
            var review = new ReviewDTO(currentReviewId, int.Parse(reviewUserIdLabel.Text.Split(':')[1]), int.Parse(movieIdLabel.Text.Split(':')[1]), reviewTitleText.Text, reviewContentText.Text, (int)reviewRatingNumeric.Value, DateTime.Now);

            if (!ReviewValidation.IsValidReview(review))
            {
                throw new DesktopApp.Exception.InvalidReviewException("Invalid review data.");
            }
            desktopController.ReviewService.UpdateReview(review);
            await DisplayErrorAsync(reviewMgmtErrorLabel, "Review updated successfully!");
            LoadReviewsPage();
        }

        private async void createReviewBtn_Click(object sender, EventArgs e)
        {
            int userId = (int)createUserIdNumeric.Value;
            int movieId = (int)createMovieIdNumeric.Value;

            // Validate the user ID
            UserDTO user = desktopController.UserService.Read(userId);
            if (user == null)
            {
                await DisplayErrorAsync(reviewMgmtErrorLabel, "Invalid user ID.");
                return;
            }

            // Validate the movie ID
            if (!desktopController.MovieService.MovieExists(movieId))
            {
                await DisplayErrorAsync(reviewMgmtErrorLabel, $"Movie with ID: {movieId} was not found.");
                return;
            }

            var review = new ReviewDTO(0, userId, (int)createMovieIdNumeric.Value, createTitleTextBox.Text, createContentTextBox.Text, (int)createRatingNumeric.Value, DateTime.Now);

            if (!ReviewValidation.IsValidReview(review))
            {
                throw new DesktopApp.Exception.InvalidReviewException("Invalid review data.");
            }

            desktopController.ReviewService.AddReview(review);
            await DisplayErrorAsync(reviewMgmtErrorLabel, "Review created successfully!");
            LoadReviewsPage();
        }


        private void addReviewBtn_Click(object sender, EventArgs e)
        {
            reviewTabCtrl.SelectedIndex = 2;
        }

        private void reviewsDashHomeBtn_Click(object sender, EventArgs e)
        {
            reviewTabCtrl.SelectedIndex = 0; 
        }

        private void previousPageBtnReviews_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadReviewsPage();
        }

        private void nextPageBtnReviews_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadReviewsPage();
        }

        private async Task DisplayErrorAsync(Label label, string message)
        {
            label.Text = message;
            await Task.Delay(3000);
            label.Text = "";
        }
    }
}