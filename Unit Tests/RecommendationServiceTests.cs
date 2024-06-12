using DTOs;
using LogicClassLibrary.Algorithmic;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Service_Classes;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LogicClassLibrary.Managers;

namespace UnitTests
{
    [TestClass]
    public class RecommendationServiceTests
    {
        private RecommendationService recommendationService;
        private Mock<IRecommendationManager> mockRecommendationManager;
        private Mock<ContentBasedRecommendation> mockContentBasedRecommendation;
        private Mock<BehaviorBasedRecommendation> mockBehaviorBasedRecommendation;

        [TestInitialize]
        public void Setup()
        {
            mockRecommendationManager = new Mock<IRecommendationManager>();
            mockContentBasedRecommendation = new Mock<ContentBasedRecommendation>();
            mockBehaviorBasedRecommendation = new Mock<BehaviorBasedRecommendation>();

            recommendationService = new RecommendationService(mockRecommendationManager.Object, mockContentBasedRecommendation.Object, mockBehaviorBasedRecommendation.Object);
        }

        [TestMethod]
        public void RecommendMoviesForUser_BehaviorBased_CallsSetStrategyAndRecommendMoviesForUser()
        {
            string username = "testUser";
            int numRecommendations = 5;

            recommendationService.RecommendMoviesForUser(username, numRecommendations, RecommendationType.BehaviorBased);

            mockRecommendationManager.Verify(m => m.SetStrategy(mockBehaviorBasedRecommendation.Object), Times.Once);
            mockRecommendationManager.Verify(m => m.RecommendMoviesForUser(username, numRecommendations), Times.Once);
        }

        [TestMethod]
        public void RecommendMoviesForUser_ContentBased_CallsSetStrategyAndRecommendMoviesForUser()
        {
            string username = "testUser";
            int numRecommendations = 5;

            recommendationService.RecommendMoviesForUser(username, numRecommendations, RecommendationType.ContentBased);

            mockRecommendationManager.Verify(m => m.SetStrategy(mockContentBasedRecommendation.Object), Times.Once);
            mockRecommendationManager.Verify(m => m.RecommendMoviesForUser(username, numRecommendations), Times.Once);
        }
    }
}
