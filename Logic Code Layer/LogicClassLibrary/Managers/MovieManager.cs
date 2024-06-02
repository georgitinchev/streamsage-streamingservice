using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exception;
using LogicClassLibrary.Interface.Manager;
using System.ComponentModel;

namespace LogicClassLibrary.Managers;

public class MovieManager : GeneralManager<MovieDTO, Movie>, IMovieManager
{
    private IMovieDAL movieDAL;
    public List<Movie>? movies { get; private set; } = new List<Movie>();

    public MovieManager(IMovieDAL movieDAL)
    {
        this.movieDAL = movieDAL;
        PopulateMovies();
    }

    public void PopulateMovies()
    {
        try
        {
            movies?.Clear();
            foreach (MovieDTO movie in movieDAL.ReadAllMovies())
            {
                movies?.Add(TransformDTOToEntity(movie));
            }
        }
        catch (System.Exception)
        {
            throw new PopulatingMoviesError();
        }
    }

    public List<Movie> GetAllMovies()
    {
        return movies;
    }

    public override void Update(MovieDTO dto)
    {
        try
        {
            if (dto.Genres?.Count > 3 || dto.Genres?.Count <= 0)
            {
                throw new InvalidGenreException();
            }
            movieDAL.UpdateMovie(dto);
            var movie = movies.Find(m => m.Id == dto.Id);
            if (movie != null)
            {
                movie.Update(dto.Title, dto.ReleaseDate, dto.Description, dto.PosterImageURL, dto.TrailerURL, dto.RuntimeMinutes, dto.AverageRating, dto.Genres, dto.Actors, dto.Directors);
            }
        }
        catch (System.Exception)
        {
            throw new UpdateMovieError();
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
        catch (System.Exception)
        {
            throw new DeleteMovieError(movieId);
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
            movieDAL.CreateMovie(movie);
            movies.Add(TransformDTOToEntity(movie));
        }
        catch (System.Exception)
        {
            throw new CreateMovieError();
        }
    }

    public override MovieDTO Read(int movieId)
    {
        try
        {
            GetAllMovies();
            if (movies == null || !movies.Any())
            {
                throw new PopulatingMoviesError();
            }
            var movie = movies.Find(m => m.Id == movieId);
            if (movie == null)
            {
                throw new MovieNotFoundException(movieId);
            }
            return TransformEntityToDTO(movie);
        }
        catch (System.Exception)
        {
            throw new MovieNotFoundException(movieId);
        }
    }

    public List<string> GetAllGenres()
    {
        return movieDAL.GetAllGenres();
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
        catch (System.Exception)
        {
            throw new SearchCriteriaError();
        }
    }

    // 2 over ridden methods specific to transforming DTO to Entity and Entity to DTO
    public override Movie? TransformDTOToEntity(MovieDTO dto)
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
    public override MovieDTO? TransformEntityToDTO(Movie movie)
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
}
