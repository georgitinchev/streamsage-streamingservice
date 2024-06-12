using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DTOs;
using DataAccessLibrary;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ReviewDALtests
    {
        [TestMethod]
        public void ReadAllReviews_ReturnsAllReviews()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var reviews = new List<ReviewDTO>
            {
                new ReviewDTO(1, 1, 1, "title1", "content1", 5, DateTime.Now),
                new ReviewDTO(2, 2, 2, "title2", "content2", 4, DateTime.Now)
            };

            mockReviewDAL.Setup(m => m.ReadAllReviews()).Returns(reviews);

            var reviewDAL = mockReviewDAL.Object;

            var result = reviewDAL.ReadAllReviews();

            Assert.IsNotNull(result);
            Assert.AreEqual(reviews, result);
        }

        [TestMethod]
        public void GetReviewsByMovieId_ValidMovieId_ReturnsReviews()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var reviews = new List<ReviewDTO>
            {
                new ReviewDTO(1, 1, 1, "title1", "content1", 5, DateTime.Now),
                new ReviewDTO(2, 2, 1, "title2", "content2", 4, DateTime.Now)
            };

            mockReviewDAL.Setup(m => m.GetReviewsByMovieId(1)).Returns(reviews);

            var reviewDAL = mockReviewDAL.Object;

            var result = reviewDAL.GetReviewsByMovieId(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(reviews, result);
        }

        [TestMethod]
        public void GetReviewsPage_ValidPageNumberAndSize_ReturnsReviews()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var reviews = new List<ReviewDTO>
            {
                new ReviewDTO(1, 1, 1, "title1", "content1", 5, DateTime.Now),
                new ReviewDTO(2, 2, 2, "title2", "content2", 4, DateTime.Now)
            };

            mockReviewDAL.Setup(m => m.GetReviewsPage(1, 2)).Returns(reviews);

            var reviewDAL = mockReviewDAL.Object;

            var result = reviewDAL.GetReviewsPage(1, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(reviews, result);
        }

        [TestMethod]
        public void GetTotalReviews_ReturnsTotalReviews()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();

            mockReviewDAL.Setup(m => m.GetTotalReviews()).Returns(10);

            var reviewDAL = mockReviewDAL.Object;

            var result = reviewDAL.GetTotalReviews();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CreateReview_ValidReview_CreatesReview()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var review = new ReviewDTO(1, 1, 1, "title", "content", 5, DateTime.Now);

            mockReviewDAL.Setup(m => m.CreateReview(review));

            var reviewDAL = mockReviewDAL.Object;

            reviewDAL.CreateReview(review);

            mockReviewDAL.Verify(m => m.CreateReview(review), Times.Once);
        }

        [TestMethod]
        public void ReadReview_ValidId_ReturnsReview()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var review = new ReviewDTO(1, 1, 1, "title", "content", 5, DateTime.Now);

            mockReviewDAL.Setup(m => m.ReadReview(1)).Returns(review);

            var reviewDAL = mockReviewDAL.Object;

            var result = reviewDAL.ReadReview(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(review, result);
        }

        [TestMethod]
        public void UpdateReview_ValidReview_UpdatesReview()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var review = new ReviewDTO(1, 1, 1, "title", "content", 5, DateTime.Now);

            mockReviewDAL.Setup(m => m.UpdateReview(review));

            var reviewDAL = mockReviewDAL.Object;

            reviewDAL.UpdateReview(review);

            mockReviewDAL.Verify(m => m.UpdateReview(review), Times.Once);
        }

        [TestMethod]
        public void DeleteReview_ValidId_DeletesReview()
        {
            var mockReviewDAL = new Mock<IReviewDAL>();
            var reviewId = 1;

            mockReviewDAL.Setup(m => m.DeleteReview(reviewId));

            var reviewDAL = mockReviewDAL.Object;

            reviewDAL.DeleteReview(reviewId);

            mockReviewDAL.Verify(m => m.DeleteReview(reviewId), Times.Once);
        }
    }
}
