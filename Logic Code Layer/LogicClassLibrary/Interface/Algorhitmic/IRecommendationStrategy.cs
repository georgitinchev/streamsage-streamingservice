using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Interface.Algorhitmic
{
    public interface IRecommendationStrategy
    {
        List<MovieDTO> RecommendMovies(string username, List<MovieDTO> allMovies);
    }
}
