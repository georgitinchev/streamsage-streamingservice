using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DTOs;
using DataAccessLibrary;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class MovieDALtests
    {
        [TestMethod]
        public void CreateMovie_ValidMovie_CreatesMovie()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movie = new MovieDTO(1, "title", DateTime.Now, "description", "posterImageURL", "trailerURL", 120, 8.5m, new List<string>(), new List<string>(), new List<string>());

            mockMovieDAL.Setup(m => m.CreateMovie(movie));

            var movieDAL = mockMovieDAL.Object;

            movieDAL.CreateMovie(movie);

            mockMovieDAL.Verify(m => m.CreateMovie(movie), Times.Once);
        }

        [TestMethod]
        public void GetMovie_ValidId_ReturnsMovie()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movie = new MovieDTO(1, "title", DateTime.Now, "description", "posterImageURL", "trailerURL", 120, 8.5m, new List<string>(), new List<string>(), new List<string>());

            mockMovieDAL.Setup(m => m.GetMovie(1)).Returns(movie);

            var movieDAL = mockMovieDAL.Object;

            var result = movieDAL.GetMovie(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(movie, result);
        }

        [TestMethod]
        public void UpdateMovie_ValidMovie_UpdatesMovie()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movie = new MovieDTO(1, "title", DateTime.Now, "description", "posterImageURL", "trailerURL", 120, 8.5m, new List<string>(), new List<string>(), new List<string>());

            mockMovieDAL.Setup(m => m.UpdateMovie(movie));

            var movieDAL = mockMovieDAL.Object;

            movieDAL.UpdateMovie(movie);

            mockMovieDAL.Verify(m => m.UpdateMovie(movie), Times.Once);
        }

        [TestMethod]
        public void DeleteMovie_ValidId_DeletesMovie()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movieId = 1;

            mockMovieDAL.Setup(m => m.DeleteMovie(movieId));

            var movieDAL = mockMovieDAL.Object;

            movieDAL.DeleteMovie(movieId);
            mockMovieDAL.Verify(m => m.DeleteMovie(movieId), Times.Once);
        }

        [TestMethod]
        public void ReadAllMovies_ReturnsAllMovies()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movies = new List<MovieDTO>
            {
                new MovieDTO(1, "title1", DateTime.Now, "description1", "posterImageURL1", "trailerURL1", 120, 8.5m, new List<string>(), new List<string>(), new List<string>()),
                new MovieDTO(2, "title2", DateTime.Now, "description2", "posterImageURL2", "trailerURL2", 120, 8.5m, new List<string>(), new List<string>(), new List<string>())
            };

            mockMovieDAL.Setup(m => m.ReadAllMovies()).Returns(movies);

            var movieDAL = mockMovieDAL.Object;

            var result = movieDAL.ReadAllMovies();

            Assert.IsNotNull(result);
            Assert.AreEqual(movies, result);
        }

        [TestMethod]
        public void GetAllGenres_ReturnsAllGenres()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var genres = new List<string> { "genre1", "genre2" };

            mockMovieDAL.Setup(m => m.GetAllGenres()).Returns(genres);

            var movieDAL = mockMovieDAL.Object;

            var result = movieDAL.GetAllGenres();

            Assert.IsNotNull(result);
            Assert.AreEqual(genres, result);
        }

        [TestMethod]
        public void GetTotalMovies_ReturnsTotalMovies()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();

            mockMovieDAL.Setup(m => m.GetTotalMovies()).Returns(10);

            var movieDAL = mockMovieDAL.Object;

            var result = movieDAL.GetTotalMovies();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void GetMoviesPage_ValidPageNumberAndSize_ReturnsMovies()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movies = new List<MovieDTO>
            {
                new MovieDTO(1, "title1", DateTime.Now, "description1", "posterImageURL1", "trailerURL1", 120, 8.5m, new List<string>(), new List<string>(), new List<string>()),
                new MovieDTO(2, "title2", DateTime.Now, "description2", "posterImageURL2", "trailerURL2", 120, 8.5m, new List<string>(), new List<string>(), new List<string>())
            };

            mockMovieDAL.Setup(m => m.GetMoviesPage(1, 2)).Returns(movies);

            var movieDAL = mockMovieDAL.Object;

            var result = movieDAL.GetMoviesPage(1, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(movies, result);
        }

        [TestMethod]
        public void MovieExists_ValidId_ReturnsTrue()
        {
            var mockMovieDAL = new Mock<IMovieDAL>();
            var movieId = 1;

            mockMovieDAL.Setup(m => m.MovieExists(movieId)).Returns(true);

            var movieDAL = mockMovieDAL.Object;

            var result = movieDAL.MovieExists(movieId);

            Assert.IsTrue(result);
        }
    }
}
