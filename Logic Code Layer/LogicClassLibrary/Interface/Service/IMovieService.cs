using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Service
{
    public interface IMovieService
    {
        List<string> GetAllGenres();
        List<MovieDTO> GetAllMovies();
        MovieDTO GetMovie(int id);
        void AddMovie(string title, DateTime releaseDate, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal averageRating, List<string> genres, List<string> directors, List<string> actors); // Add averageRating here
        void UpdateMovie(int id, string title, DateTime releaseDate, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal averageRating, List<string> genres, List<string> directors, List<string> actors);
        void DeleteMovie(int id);
        List<MovieDTO> GetMoviesPage(int pageNumber, int pageSize);
        List<MovieDTO> SearchMovies(string criteria);
        int GetTotalMovies();
        List<MovieDTO> SearchMovies(string criteria, string genre);
        bool MovieExists(int movieId);
        List<MovieDTO> GetTopRatedMovies(int limit);
        // Genre Specific Methods that can be refactored separately
        void AddGenreToMovie(int movieId, string genre);
        void AddActorToMovie(int movieId, string actor);
        void AddDirectorToMovie(int movieId, string director);
        void UpdateGenreForMovie(int movieId, string oldGenreName, string newGenreName);
        void UpdateActorForMovie(int movieId, string oldActorName, string newActorName);
        void UpdateDirectorForMovie(int movieId, string oldDirectorName, string newDirectorName);
        void RemoveGenreFromMovie(int movieId, string genre);
        void RemoveActorFromMovie(int movieId, string actor);
        void RemoveDirectorFromMovie(int movieId, string director);
    }
}
