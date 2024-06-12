using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Service_Classes;
using Moq;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicClassLibrary.Entities;

namespace UnitTests
{
    [TestClass]
    public class MovieServiceTests
    {
        private MovieService movieService;
        private Mock<IMovieManager> mockMovieManager;

        [TestInitialize]
        public void Setup()
        {
            mockMovieManager = new Mock<IMovieManager>();
            movieService = new MovieService(mockMovieManager.Object);
        }

        [TestMethod]
        public void AddMovie_ValidMovie_CallsCreate()
        {
            string title = "Test Movie";
            DateTime releaseDate = DateTime.Now;
            string description = "Test Description";
            string posterImageURL = "Test URL";
            string trailerURL = "Test Trailer URL";
            int runtimeMinutes = 120;
            decimal averageRating = 7.5m;
            List<string> genres = new List<string> { "Action", "Adventure" };
            List<string> directors = new List<string> { "Test Director" };
            List<string> actors = new List<string> { "Test Actor" };

            movieService.AddMovie(title, releaseDate, description, posterImageURL, trailerURL, runtimeMinutes, averageRating, genres, directors, actors);

            mockMovieManager.Verify(m => m.Create(It.Is<MovieDTO>(m => m.Title == title)), Times.Once);
        }

        [TestMethod]
        public void UpdateMovie_ValidMovie_CallsUpdate()
        {
            int id = 1;
            string title = "Updated Movie";
            DateTime releaseDate = DateTime.Now;
            string description = "Updated Description";
            string posterImageURL = "Updated URL";
            string trailerURL = "Updated Trailer URL";
            int runtimeMinutes = 120;
            decimal averageRating = 7.5m;
            List<string> genres = new List<string> { "Action", "Adventure" };
            List<string> directors = new List<string> { "Updated Director" };
            List<string> actors = new List<string> { "Updated Actor" };

            movieService.UpdateMovie(id, title, releaseDate, description, posterImageURL, trailerURL, runtimeMinutes, averageRating, genres, directors, actors);

            mockMovieManager.Verify(m => m.Update(It.Is<MovieDTO>(m => m.Id == id && m.Title == title)), Times.Once);
        }

        [TestMethod]
        public void DeleteMovie_ValidMovieId_CallsDelete()
        {
            int movieId = 1;
            movieService.DeleteMovie(movieId);
            mockMovieManager.Verify(m => m.Delete(movieId), Times.Once);
        }

        [TestMethod]
        public void GetMovie_ValidMovieId_CallsRead()
        {
            int movieId = 1;
            movieService.GetMovie(movieId);
            mockMovieManager.Verify(m => m.Read(movieId), Times.Once);
        }

        [TestMethod]
        public void GetAllMovies_CallsGetAllMovies()
        {
            var movies = new List<Movie>
        {
        new Movie(1, "Test Movie", DateTime.Now, "Test Description", "Test URL", "Test Trailer URL", 120, 7.5m, new List<string> { "Action", "Adventure" }, new List<string> { "Test Director" }, new List<string> { "Test Actor" })
        };
            mockMovieManager.Setup(m => m.GetAllMovies()).Returns(movies);

            movieService.GetAllMovies();

            mockMovieManager.Verify(m => m.GetAllMovies(), Times.Once);
        }


        [TestMethod]
        public void GetTotalMovies_CallsGetTotalMovies()
        {
            movieService.GetTotalMovies();
            mockMovieManager.Verify(m => m.GetTotalMovies(), Times.Once);
        }

        [TestMethod]
        public void MovieExists_ValidMovieId_CallsMovieExists()
        {
            int movieId = 1;
            movieService.MovieExists(movieId);
            mockMovieManager.Verify(m => m.MovieExists(movieId), Times.Once);
        }
    }
}
