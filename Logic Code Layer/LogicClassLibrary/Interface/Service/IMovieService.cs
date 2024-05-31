using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Service
{
    public interface IMovieService
    {
        List<string> GetAllGenres();
        Movie GetMovie(int id);
        void AddMovie(MovieDTO movie);
        void UpdateMovie(MovieDTO movieDto);
        void DeleteMovie(int id);
        List<MovieDTO> SearchMovies(string criteria);
        List<MovieDTO> GetAllMovies();
        List<MovieDTO> GetFeaturedMovies();
        List<MovieDTO> GetRandomMovies();
    }
}
