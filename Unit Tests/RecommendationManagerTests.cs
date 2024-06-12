using DTOs;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Managers;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class RecommendationManagerTests
    {
        private RecommendationManager recommendationManager;
        private Mock<IRecommendationStrategy> mockRecommendationStrategy;
        private Mock<IUserManager> mockUserManager;
        private Mock<IMovieManager> mockMovieManager;
        private Mock<RandomPageSelector> mockRandomPageSelector;

        [TestInitialize]
        public void Setup()
        {
            mockRecommendationStrategy = new Mock<IRecommendationStrategy>();
            mockUserManager = new Mock<IUserManager>();
            mockMovieManager = new Mock<IMovieManager>();
            mockRandomPageSelector = new Mock<RandomPageSelector>();

            recommendationManager = new RecommendationManager(mockUserManager.Object, mockMovieManager.Object, mockRandomPageSelector.Object);
        }

        [TestMethod]
        public void RecommendMoviesForUser_ValidUser_CallsRecommendMovies()
        {
            string username = "testUser";
            int numRecommendations = 5;
            List<MovieDTO> allMovieDTOs = new List<MovieDTO>();

            mockRandomPageSelector.Setup(m => m.SelectRandomPage(It.IsAny<int>())).Returns(allMovieDTOs);

            recommendationManager.SetStrategy(mockRecommendationStrategy.Object);
            recommendationManager.RecommendMoviesForUser(username, numRecommendations);

            mockRecommendationStrategy.Verify(m => m.RecommendMovies(username, allMovieDTOs, numRecommendations), Times.Once);
        }

        [TestMethod]
        public void SetStrategy_ValidStrategy_SetsStrategy()
        {
            var strategy = new Mock<IRecommendationStrategy>().Object;
            recommendationManager.SetStrategy(strategy);
            recommendationManager.RecommendMoviesForUser("testUser", 5);
        }

        [TestMethod]
        public void Constructor_ValidParameters_CreatesInstance()
        {
            var userManager = new Mock<IUserManager>().Object;
            var movieManager = new Mock<IMovieManager>().Object;
            var randomPageSelector = new Mock<RandomPageSelector>().Object;
            var manager = new RecommendationManager(userManager, movieManager, randomPageSelector);
            Assert.IsNotNull(manager);
        }

        [TestMethod]
        public void RecommendMoviesForUser_FewerMoviesThanRequested_ReturnsAllMovies()
        {
            string username = "testUser";
            int numRecommendations = 10;
            List<MovieDTO> allMovieDTOs = new List<MovieDTO>
        {
        new MovieDTO(1, "Title1", DateTime.Now, "Description1", "URL1", "TrailerURL1", 120, 8.5m, new List<string>(), new List<string>(), new List<string>()),
        new MovieDTO(2, "Title2", DateTime.Now, "Description2", "URL2", "TrailerURL2", 120, 8.5m, new List<string>(), new List<string>(), new List<string>())
        };

            mockRandomPageSelector.Setup(m => m.SelectRandomPage(It.IsAny<int>())).Returns(allMovieDTOs);
            mockRecommendationStrategy.Setup(m => m.RecommendMovies(username, allMovieDTOs, numRecommendations)).Returns(allMovieDTOs);

            recommendationManager.SetStrategy(mockRecommendationStrategy.Object);
            var recommendedMovies = recommendationManager.RecommendMoviesForUser(username, numRecommendations);

            Assert.AreEqual(allMovieDTOs.Count, recommendedMovies.Count);
        }

    }
}
