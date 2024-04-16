using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    namespace DataAccessLibrary
    {
        public class ReviewDAL : BaseDAL
        {
            public ReviewDAL(string connectionString) : base(connectionString)
            {

            }

            public void CreateReview(ReviewDTO review)
            {
                throw new NotImplementedException();
            }

            public ReviewDTO ReadReview(int reviewId)
            {
                throw new NotImplementedException();
            }

            public void UpdateReview(ReviewDTO review)
            {
                throw new NotImplementedException();
            }

            public void DeleteReview(int reviewId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
