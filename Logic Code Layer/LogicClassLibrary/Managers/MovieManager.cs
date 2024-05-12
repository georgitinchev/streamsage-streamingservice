﻿using System;
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
        return movies?.Find(m => m.Id == movieId) ?? throw new Exception("Movie not found");
    }

    public List<string> GetAllGenres()
    {
        return movieDAL.GetAllGenres();
    }
}
