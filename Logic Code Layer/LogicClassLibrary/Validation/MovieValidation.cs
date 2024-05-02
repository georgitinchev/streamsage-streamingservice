﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
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
        private static bool IsValidUrl(string url)
        {
            string pattern = @"^(http|https):\/\/[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$";
            return Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase);
        }
    }
}
