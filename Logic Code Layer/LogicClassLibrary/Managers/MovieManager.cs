using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exceptions;
using LogicClassLibrary.Interface.Manager;
using System.ComponentModel;
using System.Diagnostics;
using System;
using DataAccessLibrary.Exception;

namespace LogicClassLibrary.Managers
{
    public class MovieManager : GeneralManager<MovieDTO, Movie>, IMovieManager
    {
        private IMovieDAL movieDAL;
        public List<Movie>? movies { get; private set; } = new List<Movie>();

        public MovieManager(IMovieDAL movieDAL)
        {
            this.movieDAL = movieDAL;
        }

        public List<Movie> GetMoviesPage(int pageNumber, int pageSize)
        {
            try
            {
                var movieDTOs = movieDAL.GetMoviesPage(pageNumber, pageSize);
                return movieDTOs.Select(TransformDTOToEntity).ToList();
            }
            catch (Exception ex)
            {
                throw new PaginatorException(ex.Message, ex);
            }
        }

        public void PopulateMovies()
        {
            try
            {
                movies?.Clear();
                var movieDTOs = movieDAL.ReadAllMovies();
                movies = movieDTOs.Select(TransformDTOToEntity).ToList();
            }
            catch (Exception ex)
            {
                throw new PopulatingEntityError(ex.Message, ex);
            }
        }

        public List<Movie> GetAllMovies()
        {
            try
            {
                PopulateMovies();
                return movies;
            }
            catch (Exception ex)
            {
                throw new GetAllEntitiesError(ex.Message, ex);
            }
        }

        public int GetTotalMovies()
        {
            try
            {
                return movieDAL.GetTotalMovies();
            }
            catch (Exception ex)
            {
                throw new GetTotalEntitiesError(ex.Message, ex);
            }
        }

        public override void Update(MovieDTO dto)
        {
            try
            {
                if (dto.Genres?.Count > 3 || dto.Genres?.Count <= 0)
                {
                    throw new InvalidGenreException();
                }
                Movie movieEntity = TransformDTOToEntity(dto);
                movieDAL.UpdateMovie(TransformEntityToDTO(movieEntity));
                var movie = movies.Find(m => m.Id == dto.Id);
                if (movie != null)
                {
                    movie.Update(dto.Title, dto.ReleaseDate, dto.Description, dto.PosterImageURL, dto.TrailerURL, dto.RuntimeMinutes, dto.AverageRating, dto.Genres, dto.Actors, dto.Directors);
                }
            }
            catch (Exception ex)
            {
                throw new UpdateEntityError(ex.Message, ex);
            }
        }

        public override void Delete(int movieId)
        {
            try
            {
                movieDAL.DeleteMovie(movieId);
                var movie = movies.Find(m => m.Id == movieId);
                if (movie != null)
                {
                    movies.Remove(movie);
                }
            }
            catch (Exception ex)
            {
                throw new DeleteEntityError(ex.Message, ex);
            }
        }

        public override void Create(MovieDTO movie)
        {
            try
            {
                if (movie.Genres?.Count > 3 || movie.Genres?.Count <= 0)
                {
                    throw new InvalidGenreException();
                }
                Movie movieEntity = TransformDTOToEntity(movie);
                movieDAL.CreateMovie(TransformEntityToDTO(movieEntity));
                movies.Add(movieEntity);
            }
            catch (Exception ex)
            {
                throw new CreateEntityError(ex.Message, ex);
            }
        }

        public override MovieDTO Read(int movieId)
        {
            try
            {
                var movie = movieDAL.GetMovie(movieId);
                if (movie != null && movie.Actors.Count > 4)
                {
                    movie.Actors = movie.Actors.Take(4).ToList();
                }
                return movie;
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public List<string> GetAllGenres()
        {
            try
            {
                return movieDAL.GetAllGenres();
            }
            catch (Exception ex)
            {
                throw new GetAllEntitiesError(ex.Message, ex);
            }
        }

        public List<Movie> SearchMovies(string criteria)
        {
            try
            {
                if (criteria.Length < 5)
                {
                    throw new SearchCriteriaError();
                }
                List<Movie> searchResults = new List<Movie>();
                foreach (Movie movie in movies)
                {
                    if (movie.Title.ToLower().Contains(criteria.ToLower()))
                    {
                        searchResults.Add(movie);
                    }
                }
                return searchResults;
            }
            catch (Exception ex)
            {
                throw new SearchCriteriaError(ex.Message, ex);
            }
        }

        public int GetNewMovieId(MovieDTO movie)
        {
            try
            {
                var movieEntity = movies.Find(m => m.Title == movie.Title && m.Year == movie.ReleaseDate);
                return movieEntity?.Id ?? 0;
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public bool MovieExists(int movieId)
        {
            try
            {
                return movieDAL.MovieExists(movieId);
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public void AddGenreToMovie(int movieId, string genreName)
        {
            try
            {
                if (!MovieExists(movieId))
                {
                    throw new NotFoundException(movieId);
                }
                var movie = Read(movieId);
                if (movie != null && movie.Genres.Contains(genreName))
                {
                    throw new GetMovieError("Genre already exists for this movie.");
                }
                movieDAL.AddGenreToMovie(movieId, genreName);
            }
            catch (DataAccessException)
            {
                throw new UpdateMovieError("Error adding genre to movie.");
            }
        }

        public void AddActorToMovie(int movieId, string actorName)
        {
            try
            {
                if (!MovieExists(movieId))
                {
                    throw new NotFoundException(movieId);
                }
                var movie = Read(movieId);
                if (movie != null && movie.Actors.Contains(actorName))
                {
                    throw new GetMovieError("Actor already exists for this movie.");
                }
                movieDAL.AddActorToMovie(movieId, actorName);
            }
            catch (DataAccessException)
            {
                throw new UpdateMovieError("Error adding actor to movie.");
            }
        }

        public void AddDirectorToMovie(int movieId, string directorName)
        {
            try
            {
                if (!MovieExists(movieId))
                {
                    throw new NotFoundException(movieId);
                }
                var movie = Read(movieId);
                if (movie != null && movie.Directors.Contains(directorName))
                {
                    throw new GetMovieError("Director already exists for this movie.");
                }
                movieDAL.AddDirectorToMovie(movieId, directorName);
            }
            catch (DataAccessException)
            {
                throw new UpdateMovieError("Error adding director to movie.");
            }
        }

        public override Movie? TransformDTOToEntity(MovieDTO dto)
        {
            try
            {
                return new Movie(
                    dto.Id,
                    dto.Title,
                    dto.ReleaseDate,
                    dto.Description,
                    dto.PosterImageURL,
                    dto.TrailerURL,
                    dto.RuntimeMinutes,
                    dto.AverageRating,
                    dto.Genres,
                    dto.Directors,
                    dto.Actors
                );
            }
            catch (Exception ex)
            {
                throw new TransformationException(ex.Message, ex);
            }
        }

        public override MovieDTO? TransformEntityToDTO(Movie movie)
        {
            try
            {
                return new MovieDTO(
                    movie.Id,
                    movie.Title,
                    movie.Year,
                    movie.Description,
                    movie.PosterImageURL,
                    movie.TrailerURL,
                    movie.RuntimeMinutes,
                    movie.AverageRating,
                    movie.Genres,
                    movie.Directors,
                    movie.Actors
                );
            }
            catch (Exception ex)
            {
                throw new TransformationException(ex.Message, ex);
            }
        }
    }
}
