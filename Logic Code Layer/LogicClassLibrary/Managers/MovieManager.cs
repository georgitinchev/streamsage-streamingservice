using DataAccessLibrary.DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
	public class MovieManager : GeneralManager
	{
		private MovieDAL movieDAL;
		public List<Movie>? movies { get; private set; }

		public MovieManager(MovieDAL movieDAL)
		{
			this.movieDAL = movieDAL;
			PopulateMovies();
		}

		public void PopulateMovies()
		{
			foreach(MovieDTO movie in movieDAL.ReadAllMovies())
			{
				Movie movieEntity = TransformDTOtoEntity(movie) as Movie;
				if (movieEntity != null)
				{
					movies?.Add(movieEntity);
				} else
				{
					throw new Exception("Movie could not be created");
				}
			}
		}

		public override Entity? TransformDTOtoEntity(object dto)
		{
			MovieDTO? movie = dto as MovieDTO;
            if (movie != null)
            {
            return new Movie(movie.Id, movie.Title, movie.Year, movie.Description, movie.PosterImageURL, movie.TrailerURL, movie.RuntimeMinutes, movie.AverageRating);
            }
			return null;
		}
		public void CreateMovie(Movie movie)
		{
			throw new NotImplementedException();
		}

		public Movie ReadMovie(int movieId)
		{
			throw new NotImplementedException();
		}
		public void UpdateMovie(Movie movie)
		{
			throw new NotImplementedException();
		}

		public void DeleteMovie(int movieId)
		{
			throw new NotImplementedException();
		}
	}
}
