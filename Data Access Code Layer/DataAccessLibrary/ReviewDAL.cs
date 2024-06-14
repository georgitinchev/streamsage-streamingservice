using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using DataAccessLibrary.Exception;
using DTOs;

namespace DataAccessLibrary
{
    public class ReviewDAL : BaseDAL, IReviewDAL
    {
        public ReviewDAL(string connectionString) : base(connectionString) { }
        public void CreateReview(ReviewDTO review)
        {
            try
            {
                string query = "INSERT INTO Review (MovieID, UserID, Title, Content, Rating, ReviewDate) VALUES (@MovieID, @UserID, @Title, @Content, @Rating, @ReviewDate)";

                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MovieID", review.MovieId);
                    command.Parameters.AddWithValue("@UserID", review.UserId);
                    command.Parameters.AddWithValue("@Title", review.Title ?? string.Empty);
                    command.Parameters.AddWithValue("@Content", review.Content);
                    command.Parameters.AddWithValue("@Rating", review.Rating);
                    command.Parameters.AddWithValue("@ReviewDate", review.ReviewDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while creating a review", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while creating a review", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while creating a review", ex);
            }
        }

        public ReviewDTO ReadReview(int reviewId)
        {
            try
            {
                ReviewDTO review = null;
                string query = "SELECT * FROM Review WHERE ReviewID = @ReviewID";

                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ReviewID", reviewId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        review = new ReviewDTO(
                            (int)reader["ReviewID"],
                            (int)reader["UserID"],
                            (int)reader["MovieID"],
                            (string)reader["Title"],
                            (string)reader["Content"],
                            (int)reader["Rating"],
                            (DateTime)reader["ReviewDate"]
                        );
                    }
                }
                return review;
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while reading a review", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while reading a review", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while reading a review", ex);
            }
        }

        public void UpdateReview(ReviewDTO review)
        {
            try
            {
                string query = "UPDATE Review SET MovieID = @MovieID, UserID = @UserID, Title = @Title, Content = @Content, Rating = @Rating, ReviewDate = @ReviewDate WHERE ReviewID = @ReviewID";

                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MovieID", review.MovieId);
                    command.Parameters.AddWithValue("@UserID", review.UserId);
                    command.Parameters.AddWithValue("@Title", review.Title ?? string.Empty);
                    command.Parameters.AddWithValue("@Content", review.Content);
                    command.Parameters.AddWithValue("@Rating", review.Rating);
                    command.Parameters.AddWithValue("@ReviewDate", review.ReviewDate);
                    command.Parameters.AddWithValue("@ReviewID", review.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while updating a review", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while updating a review", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while updating a review", ex);
            }
        }

        public void DeleteReview(int reviewId)
        {
            try
            {
                string query = "DELETE FROM Review WHERE ReviewID = @ReviewID";

                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ReviewID", reviewId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while deleting a review", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while deleting a review", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while deleting a review", ex);
            }
        }

        public List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize)
        {
            try
            {
                List<ReviewDTO> reviews = new List<ReviewDTO>();
                int offset = (pageNumber - 1) * pageSize;
                string query = "SELECT * FROM Review ORDER BY ReviewID OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Offset", offset);
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ReviewDTO review = new ReviewDTO(
                            (int)reader["ReviewID"],
                            (int)reader["UserID"],
                            (int)reader["MovieID"],
                            (string)reader["Title"],
                            (string)reader["Content"],
                            (int)reader["Rating"],
                            (DateTime)reader["ReviewDate"]
                        );
                        reviews.Add(review);
                    }
                }
                return reviews;
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while getting reviews page", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while getting reviews page", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while getting reviews page", ex);
            }
        }

        public List<ReviewDTO> ReadAllReviews()
        {
            try
            {
                List<ReviewDTO> reviews = new List<ReviewDTO>();
                string query = "SELECT * FROM Review";
                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ReviewDTO review = new ReviewDTO(
                            (int)reader["ReviewID"],
                            (int)reader["UserID"],
                            (int)reader["MovieID"],
                            (string)reader["Title"],
                            (string)reader["Content"],
                            (int)reader["Rating"],
                            (DateTime)reader["ReviewDate"]
                        );
                        reviews.Add(review);
                    }
                }
                return reviews;
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while reading all reviews", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while reading all reviews", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while reading all reviews", ex);
            }
        }
		public List<ReviewDTO> GetReviewsByMovieId(int movieId)
		{
            try
            {
                List<ReviewDTO> reviews = new List<ReviewDTO>();
                string query = "SELECT * FROM Review WHERE MovieID = @MovieID";

                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ReviewDTO review = new ReviewDTO(
                            (int)reader["ReviewID"],
                            (int)reader["UserID"],
                            (int)reader["MovieID"],
                            (string)reader["Title"],
                            (string)reader["Content"],
                            (int)reader["Rating"],
                            (DateTime)reader["ReviewDate"]
                        );
                        reviews.Add(review);
                    }
                }
                return reviews;
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while getting reviews by movie ID", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while getting reviews by movie ID", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while getting reviews by movie ID", ex);
            }
		}

		public int GetTotalReviews()
        {
            try
            {
                int totalReviews = 0;
                string query = "SELECT COUNT(*) FROM Review";

                using (SqlConnection connection = CreateConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    totalReviews = (int)command.ExecuteScalar();
                }
                return totalReviews;
            } catch(SqlException ex)
            {
                throw new DataAccessException("An error occurred while getting total reviews", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while getting total reviews", ex);
            }
            catch(System.Exception ex)
            {
                throw new DataAccessException("An error occurred while getting total reviews", ex);
            }
        }
    }
}
