using System.Text;
using System.Text.RegularExpressions;

namespace LogicClassLibrary.Validation
{
    public static class MovieValidation
    {
        public static string ValidateCreateMovieFields(string title, DateTime releaseDate, string description, string posterUrl, string trailerUrl, int runtimeMinutes)
        {
            var errorMessage = new StringBuilder();
            if (string.IsNullOrWhiteSpace(title))
            {
                errorMessage.AppendLine("Title is required.");
            }
            if (releaseDate > DateTime.Now)
            {
                errorMessage.AppendLine("Release date cannot be in the future.");
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                errorMessage.AppendLine("Description is required.");
            }
            if (!IsValidUrl(posterUrl))
            {
                errorMessage.AppendLine("Poster URL is invalid.");
            }
            if (!IsValidUrl(trailerUrl))
            {
                errorMessage.AppendLine("Trailer URL is invalid.");
            }
            if (runtimeMinutes <= 0)
            {
                errorMessage.AppendLine("Runtime must be greater than 0.");
            }
            return errorMessage.ToString();
        }
        public static bool IsValidUrl(string url)
        {
            string pattern = @"^(http|https):\/\/[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$";
            return Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase);
        }

        public static string ValidateAverageRating(string averageRatingText, out decimal averageRating)
        {
            averageRating = 0;
            if (string.IsNullOrWhiteSpace(averageRatingText))
            {
                return "Average rating is required.";
            }
            if (!decimal.TryParse(averageRatingText, out averageRating))
            {
                return "Average rating must be a valid decimal number.";
            }
            if (averageRating < 0 || averageRating > 10)
            {
                return "Average rating must be between 0 and 10.";
            }
            return string.Empty;
        }

    }
}

