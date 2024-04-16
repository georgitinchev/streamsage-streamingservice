using DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    namespace DataAccessLibrary
    {
        public class MovieDAL : BaseDAL
        {
            public MovieDAL(string connectionString) : base(connectionString)
            {
            }

            public void CreateMovie(MovieDTO movie)
            {
                throw new NotImplementedException();
            }

            public MovieDTO ReadMovie(int movieId)
            {
                throw new NotImplementedException();
            }

            public void UpdateMovie(MovieDTO movie)
            {
                throw new NotImplementedException();
            }

            public void DeleteMovie(int movieId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
