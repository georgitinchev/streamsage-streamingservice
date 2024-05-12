using LogicClassLibrary.Entities;

namespace StreamSageWAD
{
    public interface IBackendService
    {
        bool AuthenticateUser(string username, string password);
        User GetUser(string username);
        void RegisterUser(string username, string email, string password, string firstName, string lastName, string profilePic, string settings);
        List<Movie> SearchMovies(string criteria);
        List<Movie> GetAllMovies();
        List<Movie> GetFeaturedMovies();
        List<Movie> GetRandomMovies();
    }
}