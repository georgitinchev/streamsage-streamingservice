using DTOs;
using LogicClassLibrary.Interface.Algorhitmic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Algorithmic
{
    public class BehaviorBasedRecommendation : IRecommendationStrategy
    {
        public List<MovieDTO> RecommendMovies(string username, List<MovieDTO> allMovies)
        {
            throw new NotImplementedException();
        }
    }
}
