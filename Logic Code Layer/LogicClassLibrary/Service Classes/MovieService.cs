using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Exceptions;
using System.Diagnostics;
using LogicClassLibrary.Validation;

namespace LogicClassLibrary.Service_Classes
{
    public class MovieService : IMovieService
    {
        private IMovieManager movieManager;
        public MovieService(IMovieManager movieManager)
        {
            this.movieManager = movieManager;
        }

        public List<string> GetAllGenres()
        {
            try
            {
                return movieManager.GetAllGenres();
            }
            catch (Exception ex)
            {
                throw new InvalidGenreException("Error while getting all genres", ex);
            }
        }

        public MovieDTO GetMovie(int id)
        {
            try
            {
                return movieManager.Read(id);
            }
            catch (Exception ex)
            {
                throw new ReadEntityError("Error while getting movie", ex);
            }
        }

        public List<MovieDTO> GetMoviesPage(int pageNumber, int pageSize)
        {
            try
            {
                var movies = movieManager.GetMoviesPage(pageNumber, pageSize);
                return movies.Select(movieManager.TransformEntityToDTO).ToList();
            }
            catch (Exception ex)
            {
                throw new PaginatorException("Error while getting movies page", ex);
            }
        }

        public void AddMovie(string title, DateTime releaseDate, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal averageRating, List<string> genres, List<string> directors, List<string> actors)
        {
            try
            {
                MovieDTO newMovie = new MovieDTO(0, title, releaseDate, description, posterImageURL, trailerURL, runtimeMinutes, averageRating, genres, directors, actors);
                movieManager.Create(newMovie);
                int newMovieId = movieManager.GetNewMovieId(newMovie);
                newMovie.Id = newMovieId;
            }
            catch (Exception ex)
            {
                throw new CreateEntityError("Error while adding movie", ex);
            }
        }

        public void UpdateMovie(int id, string title, DateTime releaseDate, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal averageRating, List<string> genres, List<string> directors, List<string> actors)
        {
            try
            {
                MovieDTO updatedMovie = new MovieDTO(id, title, releaseDate, description, posterImageURL, trailerURL, runtimeMinutes, averageRating, genres, directors, actors);
                movieManager.Update(updatedMovie);
            }
            catch (Exception ex)
            {
                throw new UpdateEntityError("Error while updating movie", ex);
            }
        }

        public void DeleteMovie(int id)
        {
            try
            {
                movieManager.Delete(id);
            }
            catch (Exception ex)
            {
                throw new DeleteEntityError("Error while deleting movie", ex);
            }
        }

        public List<MovieDTO> SearchMovies(string criteria)
        {
            try
            {
                return movieManager.SearchMovies(criteria)
                                   .Select(movieManager.TransformEntityToDTO)
                                   .ToList();
            }
            catch (Exception ex)
            {
                throw new SearchCriteriaError("Error while searching movies", ex);
            }
        }

        public List<MovieDTO> GetAllMovies()
        {
            try
            {
                var movies = movieManager.GetAllMovies();
                return movies.Select(movieManager.TransformEntityToDTO).ToList();
            }
            catch (Exception ex)
            {
                throw new GetAllEntitiesError("Error while getting all movies", ex);
            }
        }

        public int GetTotalMovies()
        {
            try
            {
                return movieManager.GetTotalMovies();
            }
            catch (Exception ex)
            {
                throw new GetTotalEntitiesError("Error while getting total movies", ex);
            }
        }

        public bool MovieExists(int movieId)
        {
            try
            {
                return movieManager.MovieExists(movieId);
            }
            catch (Exception ex)
            {
                throw new NotFoundException("Error while checking if movie exists", ex);
            }
        }

        public void AddGenreToMovie(int movieId, string genreName)
        {
            var validationError = MovieAdditionalsValidation.ValidateGenreName(genreName);
            if (!string.IsNullOrEmpty(validationError))
            {
                throw new ArgumentException(validationError);
            }
            try
            {
                movieManager.AddGenreToMovie(movieId, genreName);
            }
            catch (UpdateMovieError ex)
            {
                throw new UpdateEntityError($"Error adding genre '{genreName}' to movie with ID: {movieId}.", ex);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(movieId);
            }
            catch (GetMovieError ex)
            {
                throw new GetMovieError("Genre already exists for this movie.", ex);
            }
        }


        public void AddActorToMovie(int movieId, string actorName)
        {
            var validationError = MovieAdditionalsValidation.ValidateActorName(actorName);
            if (!string.IsNullOrEmpty(validationError))
            {
                throw new ArgumentException(validationError);
            }
            try
            {
                movieManager.AddActorToMovie(movieId, actorName);
            }
            catch (UpdateMovieError)
            {
                throw new UpdateEntityError($"Error adding actor '{actorName}' to movie with ID: {movieId}.");
            }
            catch (NotFoundException)
            {
                throw new NotFoundException(movieId);
            }
            catch (GetMovieError)
            {
                throw new GetMovieError("Actor already exists for this movie.");
            }
        }

        public void AddDirectorToMovie(int movieId, string directorName)
        {
            var validationError = MovieAdditionalsValidation.ValidateDirectorName(directorName);
            if (!string.IsNullOrEmpty(validationError))
            {
                throw new ArgumentException(validationError);
            }
            try
            {
                movieManager.AddDirectorToMovie(movieId, directorName);
            }
            catch (UpdateMovieError)
            {
                throw new UpdateEntityError($"Error adding director '{directorName}' to movie with ID: {movieId}.");
            }
            catch (NotFoundException)
            {
                throw new NotFoundException(movieId);
            }
            catch (GetMovieError)
            {
                throw new GetMovieError("Director already exists for this movie.");
            }
        }
    }
}
