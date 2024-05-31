using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exception;

namespace LogicClassLibrary.Managers;

public class MovieManager : GeneralManager<MovieDTO, Movie>
{
    private IMovieDAL movieDAL;
    public List<Movie>? movies { get; private set; }

    public MovieManager(IMovieDAL movieDAL)
    {
        this.movieDAL = movieDAL;
        movies = new List<Movie>();
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

    public override void Update(MovieDTO dto)
    {
        // Genre validation (must have atleast 1 and not more than 3)
        try
        {
            if (dto.Genres?.Count > 3 || dto.Genres?.Count <= 0)
            {
                throw new InvalidGenreException();
            }
            movieDAL.UpdateMovie(dto);
            PopulateMovies();
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
            if (movies != null)
            {
                Movie? movie = movies.FirstOrDefault(m => m.Id == movieId);
                if (movie != null)
                {
                    movies.Remove(movie);
                }
            }
        }
        catch (System.Exception)
        {
            throw new DeleteMovieError(movieId);
        }
    }

    public override void Create(Movie movie)
    {
        try
        {
            if (movie.Genres?.Count > 3 || movie.Genres?.Count <= 0)
            {
                throw new InvalidGenreException();
            }
            movieDAL.CreateMovie(TransformEntityToDTO(movie));
            PopulateMovies();
        }
        catch (System.Exception)
        {
            throw new CreateMovieError();
        }
    }

    public override Movie Read(int movieId)
    {
        try
        {
            PopulateMovies();
            if (movies == null || !movies.Any())
            {
                throw new PopulatingMoviesError();
            }
            var movie = movies.Find(m => m.Id == movieId);
            if (movie == null)
            {
                throw new MovieNotFoundException(movieId);
            }
            return movie;
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
            dto.Genres
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
       movie.Genres
       );
    }
}
