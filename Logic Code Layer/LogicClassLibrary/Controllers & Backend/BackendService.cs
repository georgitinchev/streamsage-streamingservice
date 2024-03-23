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

			var movies = dataTable.AsEnumerable().Select(row => new Movie
			{
				Id = row.Field<int>("MovieId"),
				Title = row.Field<string>("Title"),
				Year = row.Field<int>("Year")
			}).ToList();
			return movies;
		}
	}
}
