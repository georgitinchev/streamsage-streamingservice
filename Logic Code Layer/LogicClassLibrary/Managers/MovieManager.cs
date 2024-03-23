using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
	public class MovieManager : GeneralManager<Movie>
	{
		private BackendService backendService = new BackendService();
		public override void Add(Movie movie)
		{
			movie.GenerateId();
			base.Add(movie);
		}

		public List<Movie> GetMovies()
		{
			return backendService.GetMovies();
		}

		public void EditMovieDetails(Movie movie, string newDetails)
		{
			//edit movie logic
		}

		public void DeleteMovie(Movie movie)
		{
			//delete movie logic
		}
	}
}