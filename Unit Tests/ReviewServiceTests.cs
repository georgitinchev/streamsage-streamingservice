using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Service_Classes;
using Moq;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ReviewServiceTests
    {
        private ReviewService reviewService;
        private Mock<IReviewManager> mockReviewManager;

        [TestInitialize]
        public void Setup()
        {
            mockReviewManager = new Mock<IReviewManager>();
            reviewService = new ReviewService(mockReviewManager.Object);
        }

        [TestMethod]
        public void AddReview_ValidReview_CallsCreate()
        {
            ReviewDTO review = new ReviewDTO { Id = 1, MovieId = 1, UserId = 1, Rating = 5, Content = "Great movie!" };

            reviewService.AddReview(review);

            mockReviewManager.Verify(m => m.Create(It.Is<ReviewDTO>(r => r.Id == review.Id)), Times.Once);
        }

        [TestMethod]
        public void UpdateReview_ValidReview_CallsUpdate()
        {
            ReviewDTO review = new ReviewDTO { Id = 1, MovieId = 1, UserId = 1, Rating = 5, Content = "Great movie!" };

            reviewService.UpdateReview(review);

            mockReviewManager.Verify(m => m.Update(It.Is<ReviewDTO>(r => r.Id == review.Id)), Times.Once);
        }

        [TestMethod]
        public void DeleteReview_ValidReviewId_CallsDelete()
        {
            int reviewId = 1;
            reviewService.DeleteReview(reviewId);
            mockReviewManager.Verify(m => m.Delete(reviewId), Times.Once);
        }

        [TestMethod]
        public void GetReview_ValidReviewId_CallsRead()
        {
            int reviewId = 1;
            reviewService.GetReview(reviewId);
            mockReviewManager.Verify(m => m.Read(reviewId), Times.Once);
        }

        [TestMethod]
        public void GetAllReviews_CallsGetAllReviews()
        {
            reviewService.GetAllReviews();
            mockReviewManager.Verify(m => m.GetAllReviews(), Times.Once);
        }

        [TestMethod]
        public void GetTotalReviews_CallsGetTotalReviews()
        {
            reviewService.GetTotalReviews();
            mockReviewManager.Verify(m => m.GetTotalReviews(), Times.Once);
        }

        [TestMethod]
        public void GetReviewsPage_ValidPageNumberAndSize_CallsGetReviewsPage()
        {
            int pageNumber = 1;
            int pageSize = 10;

            reviewService.GetReviewsPage(pageNumber, pageSize);

            mockReviewManager.Verify(m => m.GetReviewsPage(pageNumber, pageSize), Times.Once);
        }

        [TestMethod]
        public void GetReviewsByMovieId_ValidMovieId_CallsGetReviewsByMovieId()
        {
            int movieId = 1;

            reviewService.GetReviewsByMovieId(movieId);

            mockReviewManager.Verify(m => m.GetReviewsByMovieId(movieId), Times.Once);
        }

    }
}
