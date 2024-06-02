using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;

namespace LogicClassLibrary.Service_Classes
{
    public class MovieService : IMovieService
    {
        private IMovieManager movieManager;

        public MovieService(IMovieManager movieManager)
        {
            this.movieManager = movieManager;
        }

        public List<string> GetAllGenres()
        {
            return movieManager.GetAllGenres();
        }

        public MovieDTO GetMovie(int id)
        {
            return movieManager.Read(id);
        }

        public void AddMovie(MovieDTO movie)
        {
            movieManager.Create(movie);
        }

        public void UpdateMovie(MovieDTO movieDto)
        {
            movieManager.Update(movieDto);
        }

        public void DeleteMovie(int id)
        {
            movieManager.Delete(id);
        }

        public List<MovieDTO> SearchMovies(string criteria)
        {
            return movieManager.SearchMovies(criteria)
                               .Select(movieManager.TransformEntityToDTO)
                               .ToList();
        }

        public List<MovieDTO> GetAllMovies()
        {
            return movieManager.movies?.Select(movieManager.TransformEntityToDTO).ToList() ?? new List<MovieDTO>();
        }

        public List<MovieDTO> GetFeaturedMovies()
        {
            // Implementation depends on your business logic
            throw new NotImplementedException();
        }

        public List<MovieDTO> GetRandomMovies()
        {
            // Implementation depends on your business logic
            throw new NotImplementedException();
        }
    }
}
