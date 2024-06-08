using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Validation
{
    public static class ReviewValidation
    {
        private static readonly int MaxTitleLength = 100;
        private static readonly int MaxContentLength = 1000;

        public static bool IsValidReview(ReviewDTO review)
        {
            return review != null &&
                   IsValidUserId(review.UserId) &&
                   IsValidMovieId(review.MovieId) &&
                   IsValidTitle(review.Title) &&
                   IsValidContent(review.Content) &&
                   IsValidRating(review.Rating);
        }

        private static bool IsValidUserId(int userId)
        {
            // Add your validation logic for user ID here.
            return userId > 0;
        }

        private static bool IsValidMovieId(int movieId)
        {
            // Add your validation logic for movie ID here.
            return movieId > 0;
        }

        private static bool IsValidTitle(string title)
        {
            return !string.IsNullOrEmpty(title) &&
                   title.Length <= MaxTitleLength &&
                   !ContainsOffensiveLanguage(title);
        }

        private static bool IsValidContent(string content)
        {
            return !string.IsNullOrEmpty(content) &&
                   content.Length <= MaxContentLength &&
                   !ContainsOffensiveLanguage(content);
        }

        private static bool IsValidRating(int rating)
        {
            return rating >= 1 && rating <= 10;
        }

        private static bool ContainsOffensiveLanguage(string text)
        {
            string[] offensiveWords = {
    "racist",
    "sexist",
    "homophobic",
    "transphobic",
    "xenophobic",
    "vulgar",
    "profanity",
    "hate speech",
    "insult",
    "harassment",
    "sexual slang",
    "explicit",
    "threat",
    "derogatory",
    "discriminatory",
    "offensive slang",
};
            foreach (string word in offensiveWords)
            {
                if (text.Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
