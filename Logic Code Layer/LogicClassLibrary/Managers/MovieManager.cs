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
			this.movies = new List<Movie>();
			PopulateMovies();
		}

		public void PopulateMovies()
		{
			foreach (MovieDTO movie in movieDAL.ReadAllMovies())
			{
				Movie movieEntity = TransformDTOtoEntity(movie) as Movie;
				if (movieEntity != null)
				{
					movies?.Add(movieEntity);
				}
				else
				{
					throw new Exception("Movie could not be created");
				}
			}
		}
        public override Entity TransformDTOtoEntity(object dto)
        {
            MovieDTO movieDto = dto as MovieDTO;
            if (movieDto != null)
            {
                return new Movie(movieDto.Id, movieDto.Title, movieDto.Year, movieDto.Description, movieDto.PosterImageURL, movieDto.TrailerURL, movieDto.RuntimeMinutes, movieDto.AverageRating);
            }
            else
            {
                throw new ArgumentException("dto is not of type MovieDTO");
            }
        }
		public void UpdateMovie(MovieDTO movie)
		{
			try
			{
				movieDAL.UpdateMovie(movie);
			}
            catch (Exception ex)
			{
                throw new Exception("Movie could not be updated: " + ex.Message);
            }
		}

        public void CreateMovie(Movie movie)
		{
			throw new NotImplementedException();
		}

		public Movie ReadMovie(int movieId)
		{
			throw new NotImplementedException();
		}

		public void DeleteMovie(int movieId)
		{
			throw new NotImplementedException();
		}
	}
}
