using DTOs;

namespace DataAccessLibrary
{
    public interface IMovieDAL
    {
        void CreateMovie(MovieDTO movie);
        MovieDTO GetMovie(int movieId);
        void UpdateMovie(MovieDTO movie);
        void DeleteMovie(int movieId);
        List<MovieDTO> ReadAllMovies();
        List<string> GetAllGenres();
    }
}
