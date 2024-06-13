using DTOs;

namespace DataAccessLibrary
{
    public interface IUserDAL
    {
        List<UserDTO> ReadAllUsers();
        List<UserDTO> GetUsersPage(int pageNumber, int pageSize);
        int CreateUser(UserDTO user);
        UserDTO? GetUserByUsername(string username);
        UserDTO? GetUserById(int userId);
        List<UserDTO> SearchUsers(string searchQuery, string searchParameter);
        List<UserDTO> SearchUsersAcrossAllFields(string searchQuery);
        void UpdateUser(UserDTO user);
        void UpdateUserWithoutPassword(UserDTO user);
        void DeleteUser(int userId);
        int GetTotalUsers();
        void ChangePassword(int userId, string newPasswordHash, string newPasswordSalt);
        void AddMovieToFavorites(int userId, int movieId);
        void AddMovieToWatchlist(int userId, int movieId);
        void RemoveMovieFromFavorites(int userId, int movieId);
        void RemoveMovieFromWatchlist(int userId, int movieId);
        void AddMovieToRecentlyWatched(int userId, int movieId);
        void RemoveMovieFromRecentlyWatched(int userId, int movieId);
        List<int> GetRecentlyWatchedMoviesForUser(int userId);
    }
}