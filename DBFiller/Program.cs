using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Movie_DB_Filler_API
{
    class Program
    {
        private static string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=e9999619;TrustServerCertificate=true";
        private static string apiKey = "43b92bf2ae2a36cf8fb6c397beba7647";

        static async Task Main(string[] args)
        {
            try
            {
                List<int> movieIds = await FetchMovieIdsAsync();
                Console.WriteLine($"Fetched {movieIds.Count} movie IDs.");

                var tasks = new List<Task>();
                foreach (int movieId in movieIds)
                {
                    tasks.Add(ProcessMovieAsync(movieId));
                }
                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task ProcessMovieAsync(int movieId)
        {
            var movie = await FetchMovieDetailsAsync(movieId);
            Console.WriteLine($"Fetched details for movie ID: {movieId}");
            InsertMovieIntoDatabase(movie);
        }

        private static async Task<List<int>> FetchMovieIdsAsync()
        {
            List<int> movieIds = new List<int>(10000); 
            using (HttpClient client = new HttpClient())
            {
                for (int i = 0; i < 50; i++)
                {
                    var tasks = new List<Task>();
                    for (int j = 0; j < 10; j++)
                    {
                        int page = i * 10 + j + 1;
                        tasks.Add(FetchMovieIdsForPageAsync(client, page, movieIds));
                        await Task.Delay(10);
                        if (movieIds.Count >= 10000)
                        {
                            break;
                        }
                    }
                    await Task.WhenAll(tasks);
                    if (movieIds.Count >= 10000) 
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Fetched {movieIds.Count} movie IDs.");
            return movieIds;
        }


        private static async Task FetchMovieIdsForPageAsync(HttpClient client, int page, List<int> movieIds)
        {
            string url = $"https://api.themoviedb.org/3/movie/popular?api_key={apiKey}&page={page}";
            string response = await client.GetStringAsync(url);
            JObject jsonResponse = JObject.Parse(response);
            JArray? results = (JArray?)jsonResponse["results"];
            if (results == null)
            {
                Console.WriteLine($"Warning: Page {page} contains no items.");
                return;
            }
            foreach (var result in results)
            {
                if (movieIds.Count >= movieIds.Capacity)
                {
                    // The list is full
                    Console.WriteLine($"Warning: Movie ID list is full. Skipping movie ID {(int)(result["id"] ?? 0)}.");
                    break;
                }
                movieIds.Add((int)(result["id"] ?? 0));
            }
        }


        private static async Task<JObject> FetchMovieDetailsAsync(int movieId)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://api.themoviedb.org/3/movie/{movieId}?api_key={apiKey}&append_to_response=videos,credits";
                string response = await client.GetStringAsync(url);
                return JObject.Parse(response);
            }
        }

        private static void InsertMovieIntoDatabase(JObject movie)
        {
            Console.WriteLine($"Inserting movie: {movie["title"] ?? "Unknown"}");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Check if Movie already exists
                string checkMovieQuery = "SELECT COUNT(*) FROM Movie WHERE Title = @Title";
                SqlCommand checkMovieCmd = new SqlCommand(checkMovieQuery, conn);
                checkMovieCmd.Parameters.AddWithValue("@Title", (string)(movie["title"] ?? string.Empty));
                int movieExists = (int)checkMovieCmd.ExecuteScalar();

                if (movieExists > 0)
                {
                    Console.WriteLine("Movie already exists in the database.");
                    return;
                }

                // Insert Movie
                string insertMovieQuery = "INSERT INTO Movie (Title, ReleaseDate, Description, PosterImageURL, TrailerURL, RuntimeMinutes, AverageRating) OUTPUT INSERTED.ID VALUES (@Title, @ReleaseDate, @Description, @PosterImageURL, @TrailerURL, @RuntimeMinutes, @AverageRating)";
                SqlCommand insertMovieCmd = new SqlCommand(insertMovieQuery, conn);
                insertMovieCmd.Parameters.AddWithValue("@Title", (string)(movie["title"] ?? string.Empty));
                insertMovieCmd.Parameters.AddWithValue("@ReleaseDate", (DateTime?)(movie["release_date"] ?? DateTime.MinValue));
                insertMovieCmd.Parameters.AddWithValue("@Description", (string)(movie["overview"] ?? string.Empty));
                insertMovieCmd.Parameters.AddWithValue("@PosterImageURL", $"https://image.tmdb.org/t/p/original{(string)(movie["poster_path"] ?? string.Empty)}");
                insertMovieCmd.Parameters.AddWithValue("@TrailerURL", GetTrailerURL(movie) ?? string.Empty);
                insertMovieCmd.Parameters.AddWithValue("@RuntimeMinutes", (int?)(movie["runtime"] ?? 0));
                insertMovieCmd.Parameters.AddWithValue("@AverageRating", (decimal?)(movie["vote_average"] ?? 0m));

                int movieId = (int)insertMovieCmd.ExecuteScalar();
                Console.WriteLine($"Inserted movie ID: {movieId}");

                // Insert Actors
                JArray? cast = (JArray?)movie["credits"]["cast"];
                if (cast != null)
                {
                    foreach (var actor in cast)
                    {
                        int actorId = GetOrInsertActor(conn, (string)(actor["name"] ?? string.Empty));
                        InsertMovieActor(conn, movieId, actorId);
                    }
                }

                // Insert Directors
                JArray? crew = (JArray?)movie["credits"]["crew"];
                if (crew != null)
                {
                    foreach (var crewMember in crew)
                    {
                        if ((string)(crewMember["job"] ?? string.Empty) == "Director")
                        {
                            int directorId = GetOrInsertDirector(conn, (string)(crewMember["name"] ?? string.Empty));
                            InsertMovieDirector(conn, movieId, directorId);
                        }
                    }
                }

                // Insert Genres
                JArray? genres = (JArray?)movie["genres"];
                if (genres != null)
                {
                    foreach (var genre in genres)
                    {
                        int genreId = GetOrInsertGenre(conn, (string)(genre["name"] ?? string.Empty));
                        InsertMovieGenre(conn, movieId, genreId);
                    }
                }
            }
        }
        private static string? GetTrailerURL(JObject movie)
        {
            JArray? videos = (JArray?)movie["videos"]["results"];
            if (videos != null)
            {
                foreach (var video in videos)
                {
                    if ((string)(video["type"] ?? string.Empty) == "Trailer" && (string)(video["site"] ?? string.Empty) == "YouTube")
                    {
                        return $"https://www.youtube.com/watch?v={video["key"]}";
                    }
                }
            }
            return null;
        }

        private static int GetOrInsertActor(SqlConnection conn, string actorName)
        {
            string selectQuery = "SELECT ID FROM Actor WHERE Name = @Name";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@Name", actorName);
            object result = selectCmd.ExecuteScalar();

            if (result != null)
            {
                return (int)result;
            }

            string insertQuery = "INSERT INTO Actor (Name) OUTPUT INSERTED.ID VALUES (@Name)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@Name", actorName);
            try
            {
                return (int)insertCmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint error numbers
                {
                    // If insertion failed due to unique constraint violation, fetch the existing record
                    return (int)selectCmd.ExecuteScalar();
                }
                else
                {
                    throw; // If it's another kind of SqlException, rethrow it
                }
            }
        }

        private static int GetOrInsertDirector(SqlConnection conn, string directorName)
        {
            string selectQuery = "SELECT ID FROM Director WHERE Name = @Name";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@Name", directorName);
            object result = selectCmd.ExecuteScalar();

            if (result != null)
            {
                return (int)result;
            }

            string insertQuery = "INSERT INTO Director (Name) OUTPUT INSERTED.ID VALUES (@Name)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@Name", directorName);
            try
            {
                return (int)insertCmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint error numbers
                {
                    // If insertion failed due to unique constraint violation, fetch the existing record
                    return (int)selectCmd.ExecuteScalar();
                }
                else
                {
                    throw; // If it's another kind of SqlException, rethrow it
                }
            }
        }

        private static void InsertMovieActor(SqlConnection conn, int movieId, int actorId)
        {
            string query = "INSERT INTO MovieActor (MovieID, ActorID) VALUES (@MovieID, @ActorID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MovieID", movieId);
            cmd.Parameters.AddWithValue("@ActorID", actorId);
            cmd.ExecuteNonQuery();
        }

        private static void InsertMovieDirector(SqlConnection conn, int movieId, int directorId)
        {
            string query = "INSERT INTO MovieDirector (MovieID, DirectorID) VALUES (@MovieID, @DirectorID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MovieID", movieId);
            cmd.Parameters.AddWithValue("@DirectorID", directorId);
            cmd.ExecuteNonQuery();
        }
        private static void InsertMovieGenre(SqlConnection conn, int movieId, int genreId)
        {
            string query = "INSERT INTO MovieGenre (MovieID, GenreID) VALUES (@MovieID, @GenreID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MovieID", movieId);
            cmd.Parameters.AddWithValue("@GenreID", genreId);
            cmd.ExecuteNonQuery();
        }

        private static int GetOrInsertGenre(SqlConnection conn, string genreName)
        {
            string selectQuery = "SELECT ID FROM Genre WHERE Name = @Name";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@Name", genreName);
            object result = selectCmd.ExecuteScalar();

            if (result != null)
            {
                return (int)result;
            }

            string insertQuery = "INSERT INTO Genre (Name) OUTPUT INSERTED.ID VALUES (@Name)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@Name", genreName);
            try
            {
                return (int)insertCmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint error numbers
                {
                    // If insertion failed due to unique constraint violation, fetch the existing record
                    return (int)selectCmd.ExecuteScalar();
                }
                else
                {
                    throw; // If it's another kind of SqlException, rethrow it
                }
            }
        }
    }
}

