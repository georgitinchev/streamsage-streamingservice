using System;

namespace LogicClassLibrary.Validation
{
    public static class MovieAdditionalsValidation
    {
        public static string ValidateGenreName(string genreName)
        {
            if (string.IsNullOrWhiteSpace(genreName))
                return "Genre name cannot be empty.";

            if (genreName.Length < 3)
                return "Genre name must be at least 3 characters long.";

            return string.Empty;
        }

        public static string ValidateActorName(string actorName)
        {
            if (string.IsNullOrWhiteSpace(actorName))
                return "Actor name cannot be empty.";

            if (actorName.Length < 3)
                return "Actor name must be at least 3 characters long.";

            return string.Empty;
        }

        public static string ValidateDirectorName(string directorName)
        {
            if (string.IsNullOrWhiteSpace(directorName))
                return "Director name cannot be empty.";

            if (directorName.Length < 3)
                return "Director name must be at least 3 characters long.";

            return string.Empty;
        }
    }
}
