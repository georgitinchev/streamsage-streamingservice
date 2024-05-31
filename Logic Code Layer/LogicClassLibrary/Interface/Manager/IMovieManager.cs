using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IMovieManager : IGeneralManager
    {
        List<Movie>? movies { get; }
        void PopulateMovies();
        List<string> GetAllGenres();
        List<Movie> SearchMovies(string criteria);
    }
}
