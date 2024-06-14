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
        List<MovieDTO> SearchMovies(string title, string genre);
        int GetTotalMovies();
        List<MovieDTO> GetMoviesPage(int pageNum, int pageSize);
        bool MovieExists(int movieId);
        List<MovieDTO> GetTopRatedMovies(int limit);
        // Genre Specific Methods that can be refactored separately
        List<string> GetAllGenres();
        public void AddGenreToMovie(int movieId, string genre);
        public void AddActorToMovie(int movieId, string actor);
        public void AddDirectorToMovie(int movieId, string director);
        public void UpdateGenreForMovie(int movieId, string oldGenre, string newGenre);
        public void UpdateActorForMovie(int movieId, string oldActor, string newActor);
        public void UpdateDirectorForMovie(int movieId, string oldDirector, string newDirector);
        public void RemoveGenreFromMovie(int movieId, string genre);
        public void RemoveActorFromMovie(int movieId, string actor);
        public void RemoveDirectorFromMovie(int movieId, string director);
    }
}
