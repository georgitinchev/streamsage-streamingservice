using System;
using System.Collections.Generic;
using DataAccessLibrary.DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Managers;

public class MovieManager : GeneralManager
{
    private MovieDAL movieDAL;
    public List<Movie>? movies { get; private set; }

    public MovieManager(MovieDAL movieDAL)
    {
        this.movieDAL = movieDAL;
        movies = new List<Movie>();
        PopulateMovies();
    }

    public void PopulateMovies()
    {
        movies?.Clear();
        foreach (MovieDTO movie in movieDAL.ReadAllMovies())
        {
            if (TransformDTOtoEntity(movie) is Movie movieEntity)
            {
                movies?.Add(movieEntity);
                continue;
            }
            throw new Exception("Movie could not be created");
        }
    }

    public override Entity TransformDTOtoEntity(object dto)
    {
        if (dto is MovieDTO movieDto)
        {
            return new Movie(
                movieDto.Id,
                movieDto.Title,
                movieDto.ReleaseDate,
                movieDto.Description,
                movieDto.PosterImageURL,
                movieDto.TrailerURL,
                movieDto.RuntimeMinutes,
                movieDto.AverageRating,
                movieDto.Genres
            );
        }
        throw new ArgumentException("dto is not of type MovieDTO");
    }


    public void UpdateMovie(MovieDTO movie)
    {
        try
        {
            if (movie.Genres?.Count > 3 || movie.Genres?.Count <= 0)
            {
                throw new ArgumentException("A movie must have 1 to 3 genres");
            }
            movieDAL.UpdateMovie(movie);
            PopulateMovies();
        }
        catch (Exception ex)
        {
            throw new Exception("Movie could not be updated: " + ex.Message);
        }
    }

    public void DeleteMovie(int movieId)
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

    public void CreateMovie(MovieDTO movie)
    {
        if(movie.Genres?.Count > 3 || movie.Genres?.Count <= 0)
        {
            throw new ArgumentException("A movie must have 1 to 3 genres");
        }
        movieDAL.CreateMovie(movie);
        PopulateMovies();
    }

    public Movie ReadMovie(int movieId)
    {
        PopulateMovies();
        if (movies == null || !movies.Any())
        {
            throw new Exception("The movies list is not populated.");
        }
        var movie = movies.Find(m => m.Id == movieId);
        if (movie == null)
        {
            throw new Exception($"Movie with ID {movieId} not found.");
        }
        return movie;
    }

    public List<string> GetAllGenres()
    {
        return movieDAL.GetAllGenres();
    }


    public List<Movie> SearchMovies(string criteria)
    {
        if (criteria.Length < 5)
        {
            throw new ArgumentException("Search criteria must be at least 5 characters long");
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
}
