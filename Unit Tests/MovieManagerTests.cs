using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Managers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class MovieManagerTests
    {
        private IMovieManager movieManager;
        private Mock<IMovieDAL> mockMovieDAL;

        [TestInitialize]
        public void Setup()
        {
            mockMovieDAL = new Mock<IMovieDAL>();
            movieManager = new MovieManager(mockMovieDAL.Object);
        }

        [TestMethod]
        public void Create_ValidMovie_CallsCreateMovie()
        {
            var movie = new MovieDTO(1, "Test Movie", DateTime.Now, "Test Description", "Test Poster URL", "Test Trailer URL", 120, 8.5m, new List<string> { "Action" }, new List<string> { "Test Actor" }, new List<string> { "Test Director" });
            movieManager.Create(movie);
            mockMovieDAL.Verify(m => m.CreateMovie(It.Is<MovieDTO>(m => m.Id == movie.Id)), Times.Once);
        }
        [TestMethod]
        public void Update_ValidMovie_CallsUpdateMovie()
        {
            var movie = new MovieDTO(1, "Test Movie", DateTime.Now, "Test Description", "Test Poster URL", "Test Trailer URL", 120, 8.5m, new List<string> { "Action" }, new List<string> { "Test Actor" }, new List<string> { "Test Director" });
            movieManager.Update(movie);
            mockMovieDAL.Verify(m => m.UpdateMovie(It.Is<MovieDTO>(m => m.Id == movie.Id)), Times.Once);
        }

        [TestMethod]
        public void Delete_ValidMovieId_CallsDeleteMovie()
        {
            int movieId = 1;
            movieManager.Delete(movieId);
            mockMovieDAL.Verify(m => m.DeleteMovie(movieId), Times.Once);
        }

        [TestMethod]
        public void Read_ValidMovieId_CallsGetMovie()
        {
            int movieId = 1;
            movieManager.Read(movieId);
            mockMovieDAL.Verify(m => m.GetMovie(movieId), Times.Once);
        }

        [TestMethod]
        public void GetAllMovies_CallsReadAllMovies()
        {
            var movies = new List<MovieDTO>
        {
        new MovieDTO(1, "Test Movie", DateTime.Now, "Test Description", "Test Poster URL", "Test Trailer URL", 120, 8.5m, new List<string> { "Action" }, new List<string> { "Test Actor" }, new List<string> { "Test Director" })
        };
            mockMovieDAL.Setup(m => m.ReadAllMovies()).Returns(movies);

            movieManager.GetAllMovies();

            mockMovieDAL.Verify(m => m.ReadAllMovies(), Times.Once);
        }


        [TestMethod]
        public void GetTotalMovies_CallsGetTotalMovies()
        {
            movieManager.GetTotalMovies();
            mockMovieDAL.Verify(m => m.GetTotalMovies(), Times.Once);
        }

        [TestMethod]
        public void MovieExists_ValidMovieId_CallsMovieExists()
        {
            int movieId = 1;
            movieManager.MovieExists(movieId);
            mockMovieDAL.Verify(m => m.MovieExists(movieId), Times.Once);
        }
    }
}
