using DataAccessLibrary.DataAccessLibrary;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
    public class ReviewManager : GeneralManager
    {
        private List<Review>? reviews;
        private ReviewDAL? reviewDAL;
        public ReviewManager(ReviewDAL _reviewDAL)
        {
            reviews = new List<Review>();
			reviewDAL = _reviewDAL;
		}
        internal void getMovieReviews(int movieId)
        {
            throw new NotImplementedException();
        }

        public void CreateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Review ReadReview(int reviewId)
        {
            throw new NotImplementedException();
        }

        public void UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(int reviewId)
        {
            throw new NotImplementedException();
        }
    }
}
