using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class Movie : Entity
    {
        public int Id { get; internal set; }
        public string? Title { get; internal set; }
        public DateTime Year { get; internal set; }
        public string? Description { get; internal set; }
        public string? PosterImageURL { get; internal set; }
        public string? TrailerURL { get; internal set; }
    }
}
