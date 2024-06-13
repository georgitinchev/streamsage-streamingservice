using DTOs;

namespace StreamSageWAD.Models
{
    public class StreamingViewModel
    {
        public MovieDTO MovieDetails { get; set; }
        public List<ReviewDTO> UserReviews { get; set; }
        public List<ReviewDTO> OtherReviews { get; set; }
        public List<InterpretationDTO> UserInterpretations { get; set; }
        public List<InterpretationDTO> OtherInterpretations { get; set; }

        public List<int> UserWatchList { get; set; }
        public List<int> UserFavorites { get; set; }

        public StreamingViewModel()
        {
            UserReviews = new List<ReviewDTO>();
            OtherReviews = new List<ReviewDTO>();
            UserInterpretations = new List<InterpretationDTO>();
            OtherInterpretations = new List<InterpretationDTO>();
            UserWatchList = new List<int>();
            UserFavorites = new List<int>();
        }
    }

}
