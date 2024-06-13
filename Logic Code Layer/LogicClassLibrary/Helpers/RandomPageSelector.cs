using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Helpers
{
    // Helper class to select a random page of movies from the database.
    public class RandomPageSelector
    {
        private IMovieManager movieManager;
        private Random random;

        public RandomPageSelector(IMovieManager movieManager)
        {
            this.movieManager = movieManager;
            this.random = new Random();
        }

        // Selects a random page of movies.
        public List<MovieDTO> SelectRandomPage(int pageSize)
        {
            int totalMovies = movieManager.GetTotalMovies();
            // Calculate the total number of pages needed.
            int totalPages = (totalMovies + pageSize - 1) / pageSize;
            int randomPageNumber = random.Next(1, totalPages + 1);

            // Get the movies from the selected random page and return them transformed
            List<Movie> randomMovies = movieManager.GetMoviesPage(randomPageNumber, pageSize);
            return randomMovies.Select(movie => movieManager.TransformEntityToDTO(movie)).ToList();
        }
    }
}
