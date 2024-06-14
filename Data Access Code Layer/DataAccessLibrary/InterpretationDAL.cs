using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using DTOs;
using System.Linq.Expressions;
using DataAccessLibrary.Exception;

namespace DataAccessLibrary
{
    public class InterpretationDAL : BaseDAL, IInterpretationDAL
    {
        public InterpretationDAL(string connectionString) : base(connectionString)
        {
        }
        public List<InterpretationDTO> ReadAllInterpretations()
        {
            try
            {
                var interpretations = new List<InterpretationDTO>();
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Interpretation", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                interpretations.Add(new InterpretationDTO(
                                    (int)reader["InterpretationID"],
                                    (int)reader["UserID"],
                                    (int)reader["MovieID"],
                                    reader["InterpretationText"] as string,
                                    (DateTime)reader["InterpretationDate"]
                                ));
                            }
                        }
                    }
                }
                return interpretations;
            }
            catch (SqlException)
            {
                return new List<InterpretationDTO>();
            }
            catch (InvalidOperationException)
            {
                return new List<InterpretationDTO>();
            }
            catch (System.Exception)
            {
                return new List<InterpretationDTO>();
            }
        }

        public InterpretationDTO GetInterpretationById(int interpretationId)
        {
            try
            {
                InterpretationDTO interpretation = null;
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Interpretation WHERE InterpretationID = @InterpretationID", connection))
                    {
                        command.Parameters.AddWithValue("@InterpretationID", interpretationId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                interpretation = new InterpretationDTO(
                                (int)reader["InterpretationID"],
                                (int)reader["UserID"],
                                (int)reader["MovieID"],
                                reader["InterpretationText"] as string,
                                (DateTime)reader["InterpretationDate"]);
                            }
                        }
                    }
                }
                return interpretation;
            }
            catch (SqlException)
            {
                return null;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public List<InterpretationDTO> GetInterpretationsByMovieId(int movieId)
        {
            try
            {
                var interpretations = new List<InterpretationDTO>();
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Interpretation WHERE MovieID = @MovieID", connection))
                    {
                        command.Parameters.AddWithValue("@MovieID", movieId);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                interpretations.Add(new InterpretationDTO(
                                (int)reader["InterpretationID"],
                                (int)reader["UserID"],
                                (int)reader["MovieID"],
                                reader["InterpretationText"] as string,
                                (DateTime)reader["InterpretationDate"]));
                            }
                        }
                    }
                }
                return interpretations;
            }
            catch (SqlException)
            {
                return new List<InterpretationDTO>();
            }
            catch (InvalidOperationException)
            {
                return new List<InterpretationDTO>();
            }
            catch (System.Exception)
            {
                return new List<InterpretationDTO>();
            }
        }

        public void CreateInterpretation(InterpretationDTO interpretation)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO Interpretation (MovieID, UserID, InterpretationText, InterpretationDate) VALUES (@MovieID, @UserID, @InterpretationText, @InterpretationDate)", connection))
                    {
                        command.Parameters.AddWithValue("@MovieID", interpretation.MovieId);
                        command.Parameters.AddWithValue("@UserID", interpretation.UserId);
                        command.Parameters.AddWithValue("@InterpretationText", interpretation.InterpretationText);
                        command.Parameters.AddWithValue("@InterpretationDate", interpretation.InterpretationDate);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw new DataAccessException("Error creating interpretation");
            }
            catch (InvalidOperationException)
            {
                throw new DataAccessException("Error creating interpretation");
            }
            catch (System.Exception)
            {
                throw new DataAccessException("Error creating interpretation");
            }

        }

        public InterpretationDTO ReadInterpretation(int interpretationId)
        {
            try
            {
                InterpretationDTO interpretation = null;
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Interpretation WHERE InterpretationID = @InterpretationID", connection))
                    {
                        command.Parameters.AddWithValue("@InterpretationID", interpretationId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                interpretation = new InterpretationDTO(
                                    (int)reader["InterpretationID"],
                                    (int)reader["UserID"],
                                    (int)reader["MovieID"],
                                    reader["InterpretationText"] as string,
                                    (DateTime)reader["InterpretationDate"]
                                );
                            }
                        }
                    }
                }
                return interpretation;
            }
            catch (SqlException)
            {
                throw new DataAccessException("Error reading interpretation");
            }
            catch (InvalidOperationException)
            {
                throw new DataAccessException("Error reading interpretation");
            }
            catch (System.Exception)
            {
                throw new DataAccessException("Error reading interpretation");
            }
        }

        public void UpdateInterpretation(InterpretationDTO interpretation)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("UPDATE Interpretation SET MovieID = @MovieID, UserID = @UserID, InterpretationText = @InterpretationText, InterpretationDate = @InterpretationDate WHERE InterpretationID = @InterpretationID", connection))
                    {
                        command.Parameters.AddWithValue("@InterpretationID", interpretation.Id);
                        command.Parameters.AddWithValue("@MovieID", interpretation.MovieId);
                        command.Parameters.AddWithValue("@UserID", interpretation.UserId);
                        command.Parameters.AddWithValue("@InterpretationText", interpretation.InterpretationText);
                        command.Parameters.AddWithValue("@InterpretationDate", interpretation.InterpretationDate);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw new DataAccessException("Error updating interpretation");
            }
            catch (InvalidOperationException)
            {
                throw new DataAccessException("Error updating interpretation");
            }
            catch (System.Exception)
            {
                throw new DataAccessException("Error updating interpretation");
            }
        }

        public void DeleteInterpretation(int interpretationId)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("DELETE FROM Interpretation WHERE InterpretationID = @InterpretationID", connection))
                    {
                        command.Parameters.AddWithValue("@InterpretationID", interpretationId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw new DataAccessException("Error deleting interpretation");
            }
            catch (InvalidOperationException)
            {
                throw new DataAccessException("Error deleting interpretation");
            }
            catch (System.Exception)
            {
                throw new DataAccessException("Error deleting interpretation");
            }
        }

        public List<InterpretationDTO> GetPaginatedInterpretations(int pageNumber, int pageSize)
        {
            try
            {
                var interpretations = new List<InterpretationDTO>();
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Interpretation ORDER BY InterpretationID OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY", connection))
                    {
                        command.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                        command.Parameters.AddWithValue("@PageSize", pageSize);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                interpretations.Add(new InterpretationDTO(
                                (int)reader["InterpretationID"],
                                (int)reader["UserID"],
                                (int)reader["MovieID"],
                                reader["InterpretationText"] as string,
                                (DateTime)reader["InterpretationDate"]));
                            }
                        }
                    }
                }
                return interpretations;
            }
            catch (SqlException)
            {
                return new List<InterpretationDTO>();
            }
            catch (InvalidOperationException)
            {
                return new List<InterpretationDTO>();
            }
            catch (System.Exception)
            {
                return new List<InterpretationDTO>();
            }
        }

        public int GetTotalInterpretationsCount()
        {
            try
            {
                int totalInterpretations = 0;
                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT COUNT(*) FROM Interpretation", connection))
                    {
                        totalInterpretations = (int)command.ExecuteScalar();
                    }
                }
                return totalInterpretations;
            }
            catch (SqlException)
            {
                return 0;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }
}
