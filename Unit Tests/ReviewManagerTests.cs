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
    public class ReviewManagerTests
    {
        private IReviewManager reviewManager;
        private Mock<IReviewDAL> mockReviewDAL;

        [TestInitialize]
        public void Setup()
        {
            mockReviewDAL = new Mock<IReviewDAL>();
            reviewManager = new ReviewManager(mockReviewDAL.Object);
        }

        [TestMethod]
        public void Create_ValidReview_CallsCreateReview()
        {
            var review = new ReviewDTO(1, 1, 1, "Test Title", "Test Content", 5, DateTime.Now);
            reviewManager.Create(review);
            mockReviewDAL.Verify(r => r.CreateReview(It.Is<ReviewDTO>(r => r.Id == review.Id)), Times.Once);
        }
        [TestMethod]
        public void Update_ValidReview_CallsUpdateReview()
        {
            var review = new ReviewDTO(1, 1, 1, "Test Title", "Test Content", 5, DateTime.Now);
            reviewManager.Update(review);
            mockReviewDAL.Verify(r => r.UpdateReview(It.Is<ReviewDTO>(r => r.Id == review.Id)), Times.Once);
        }
        [TestMethod]
        public void Delete_ValidReviewId_CallsDeleteReview()
        {
            int reviewId = 1;
            reviewManager.Delete(reviewId);
            mockReviewDAL.Verify(r => r.DeleteReview(reviewId), Times.Once);
        }

        [TestMethod]
        public void Read_ValidReviewId_CallsReadReview()
        {
            int reviewId = 1;
            reviewManager.Read(reviewId);
            mockReviewDAL.Verify(r => r.ReadReview(reviewId), Times.Once);
        }

        [TestMethod]
        public void GetAllReviews_CallsReadAllReviews()
        {
            reviewManager.GetAllReviews();
            mockReviewDAL.Verify(r => r.ReadAllReviews(), Times.Once);
        }

        [TestMethod]
        public void GetTotalReviews_CallsGetTotalReviews()
        {
            reviewManager.GetTotalReviews();
            mockReviewDAL.Verify(r => r.GetTotalReviews(), Times.Once);
        }

        [TestMethod]
        public void GetReviewsByMovieId_ValidMovieId_CallsGetReviewsByMovieId()
        {
            int movieId = 1;
            reviewManager.GetReviewsByMovieId(movieId);
            mockReviewDAL.Verify(r => r.GetReviewsByMovieId(movieId), Times.Once);
        }
    }
}
