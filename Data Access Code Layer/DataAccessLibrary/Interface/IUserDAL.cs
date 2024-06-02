using DTOs;

namespace DataAccessLibrary
{
    public interface IUserDAL
    {
        List<UserDTO> ReadAllUsers();
        void CreateUser(UserDTO user);
        UserDTO? GetUserByUsername(string username);
        UserDTO? GetUserById(int userId);
        void UpdateUser(UserDTO user);
        void DeleteUser(int userId);
        void ChangePassword(int userId, string newPasswordHash, string newPasswordSalt); 
        void AddMovieToFavorites(int userId, int movieId);  
        void AddMovieToWatchlist(int userId, int movieId);
        void RemoveMovieFromFavorites(int userId, int movieId);
        void RemoveMovieFromWatchlist(int userId, int movieId);
    }
}