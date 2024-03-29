using LogicClassLibrary.Entities;
using DataAccessLibrary;
using System.Data;

namespace LogicClassLibrary
{
    public class BackendService
    {
        private DatabaseOperations databaseOperations = new DatabaseOperations();
        public List<Movie> GetMovies()
        {
            var dataTable = databaseOperations.GetMovies();
            var movies = new List<Movie>();

            foreach (DataRow row in dataTable.Rows)
            {
                var movie = new Movie
                {
                    Id = (int)row["MovieID"],
                    Title = row["Title"].ToString(),
                    Year = (DateTime)row["ReleaseDate"],
                    Description = row["Description"].ToString(),
                    PosterImageURL = row["PosterImageURL"].ToString(),
                    TrailerURL = row["TrailerURL"].ToString(),
                };
                movies.Add(movie);
            }
            return movies;
        }

        // method that gathers all users
        //public List<User> GetUsers()
        //{
        //    var dataTable = databaseOperations.GetUsers();
        //    var users = new List<User>();

        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        var user = new User
        //        {
        //            UserID = (int)row["UserID"],
        //            Username = row["Username"].ToString(),
        //            Email = row["Email"].ToString(),
        //            PasswordHash = row["PasswordHash"].ToString(),
        //            FirstName = row["FirstName"].ToString(),
        //            LastName = row["LastName"].ToString(),
        //            Settings = row["Settings"].ToString()
        //        };
        //        users.Add(user);
        //    }
        //    return users;
        //}
    }
}
