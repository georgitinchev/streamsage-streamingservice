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
        List<Movie> GetMoviesPage(int pageNumber, int pageSize);    
        Movie TransformDTOToEntity(MovieDTO dto);
        MovieDTO TransformEntityToDTO(Movie entity);
        bool MovieExists(int movieId);
        void AddGenreToMovie(int movieId, string genre);
        void AddActorToMovie(int movieId, string actor);
        void AddDirectorToMovie(int movieId, string director);
    }
}
