using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IMovieManager
    {
        List<Movie> GetAllMovies();
        List<string> GetAllGenres();
        List<Movie> SearchMovies(string criteria);
        MovieDTO Read(int id);
        void Create(MovieDTO dto);
        void Update(MovieDTO dto);
        void Delete(int id);
        int GetNewMovieId(MovieDTO movie);
        int GetTotalMovies();
        List<Movie> GetTopRatedMovies(int limit);
        List<Movie> GetMoviesPage(int pageNumber, int pageSize);
        List<Movie> SearchMovies(string criteria, string genre);
        Movie TransformDTOToEntity(MovieDTO dto);
        MovieDTO TransformEntityToDTO(Movie entity);
        bool MovieExists(int movieId);
        // Genre Specific Methods that can be refactored separately
        void AddGenreToMovie(int movieId, string genre);
        void AddActorToMovie(int movieId, string actor);
        void AddDirectorToMovie(int movieId, string director);
        void UpdateGenreForMovie(int movieId, string oldGenre, string newGenre);
        void UpdateActorForMovie(int movieId, string oldActor, string newActor);
        void UpdateDirectorForMovie(int movieId, string oldDirector, string newDirector);
        void RemoveGenreFromMovie(int movieId, string genre);
        void RemoveActorFromMovie(int movieId, string actor);
        void RemoveDirectorFromMovie(int movieId, string director); 
    }
}
