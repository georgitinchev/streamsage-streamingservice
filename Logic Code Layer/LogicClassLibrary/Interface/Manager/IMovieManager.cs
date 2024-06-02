using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IMovieManager
    {
        List<Movie>? movies { get; }
        List<Movie> GetAllMovies();
        List<string> GetAllGenres();
        List<Movie> SearchMovies(string criteria);
        MovieDTO Read(int id);
        void Create(MovieDTO dto);
        void Update(MovieDTO dto);
        void Delete(int id);
        MovieDTO TransformEntityToDTO(Movie movie);
    }
}
