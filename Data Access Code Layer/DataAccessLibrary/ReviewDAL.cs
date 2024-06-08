using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using DTOs;

namespace DataAccessLibrary
{
    public class ReviewDAL : BaseDAL, IReviewDAL
    {
        public void CreateReview(ReviewDTO review)
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

        public ReviewDTO ReadReview(int reviewId)
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
                        null, // Title is not available in the database schema
                        (string)reader["Content"],
                        (int)reader["Rating"],
                        (DateTime)reader["ReviewDate"]
                    );
                }
            }

            return review;
        }

        public void UpdateReview(ReviewDTO review)
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
        }

        public void DeleteReview(int reviewId)
        {
            string query = "DELETE FROM Review WHERE ReviewID = @ReviewID";

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReviewID", reviewId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize)
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
        }

        public List<ReviewDTO> ReadAllReviews()
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
        }

        public int GetTotalReviews()
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
        }
    }
}
