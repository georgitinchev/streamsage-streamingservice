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
        int GetTotalMovies();
        List<MovieDTO> GetMoviesPage(int pageNum, int pageSize);
        bool MovieExists(int movieId);
        public void AddGenreToMovie(int movieId, string genre);
        public void AddActorToMovie(int movieId, string actor);
        public void AddDirectorToMovie(int movieId, string director);
    }
}
