using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IMovieDAL
    {
        void CreateMovie(MovieDTO movie);
        MovieDTO GetMovie(int movieId);
        void UpdateMovie(MovieDTO movie);
        void DeleteMovie(int movieId);
        List<MovieDTO> ReadAllMovies();
    }
}
