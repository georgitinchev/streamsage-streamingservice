using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Manager;

namespace LogicClassLibrary.Managers
{
    public class UserManager : GeneralManager<UserDTO, User>, IUserManager
    {
        public IUserDAL? userDAL { get; private set; }
        public IMovieManager movieManager { get; private set; }
        public List<User>? users { get; private set; }

        public UserManager(IUserDAL userDAL, IMovieManager movieManager)
        {
            users = new List<User>();
            this.userDAL = userDAL;
            this.movieManager = movieManager;
        }

        public override void Create(UserDTO userDTO)
        {
            var user = TransformDTOToEntity(userDTO);
            users.Add(user);
            userDAL.CreateUser(userDTO);
        }

        public override void Delete(int id)
        {
            var user = users.Find(x => x.Id == id);
            if (user != null)
            {
                users.Remove(user);
                userDAL.DeleteUser(id);
            }
        }

        public override void Update(UserDTO dto)
        {
            var user = users.Find(x => x.Id == dto.Id);
            if (user != null)
            {
                var favoriteMovies = dto.FavoriteMovies?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
                var watchList = dto.WatchList?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
                user.Update(dto.Username, dto.Email, dto.FirstName, dto.LastName, dto.ProfilePictureURL, dto.Settings, favoriteMovies, watchList);
                user.SetPasswordHashAndSalt(dto.PasswordHash ?? string.Empty, dto.PasswordSalt ?? string.Empty);
                userDAL.UpdateUser(TransformEntityToDTO(user));
            }
        }

        public override UserDTO Read(int id)
        {
            var user = users.Find(x => x.Id == id);
            return TransformEntityToDTO(user);
        }

        public UserDTO Read(string username)
        {
            var user = users.Find(x => x.Username == username);
            return TransformEntityToDTO(user);
        }

        public void AuthenticateUser(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                throw new SystemException("User not found");
            }
            var hashedPassword = PasswordHelper.HashPassword(password, user.GetPasswordSalt());
            if (hashedPassword != user.GetPasswordHash())
            {
                throw new SystemException("Invalid password");
            }
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName)
        {
            if (users.Any(u => u.Username == username))
            {
                throw new SystemException("Username already exists");
            }
            var passwordSalt = PasswordHelper.GenerateSalt();
            var passwordHash = PasswordHelper.HashPassword(password, passwordSalt);
            var user = new User(0, username, string.Empty, email, firstName, lastName, string.Empty, string.Empty, new List<Movie>(), new List<Movie>());
            user.SetPasswordHashAndSalt(passwordHash, passwordSalt);
            users.Add(user);
            userDAL.CreateUser(TransformEntityToDTO(user));
        }

        public void ChangePassword(string username, string newPassword)
        {
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                throw new SystemException("User not found");
            }
            var passwordSalt = PasswordHelper.GenerateSalt();
            var passwordHash = PasswordHelper.HashPassword(newPassword, passwordSalt);
            user.SetPasswordHashAndSalt(passwordHash, passwordSalt);
            userDAL.UpdateUser(TransformEntityToDTO(user));
        }

        public override User? TransformDTOToEntity(UserDTO dto)
        {
            if (dto == null) return null;

            var favoriteMovies = dto.FavoriteMovies?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
            var watchList = dto.WatchList?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();

            var user = new User(
                dto.Id,
                dto.Username,
                string.Empty, 
                dto.Email,
                dto.FirstName,
                dto.LastName,
                dto.ProfilePictureURL,
                dto.Settings,
                favoriteMovies ?? new List<Movie>(),
                watchList ?? new List<Movie>()
            );
            user.SetPasswordHashAndSalt(dto.PasswordHash ?? string.Empty, dto.PasswordSalt ?? string.Empty);
            return user;
        }

        public override UserDTO TransformEntityToDTO(User entity)
        {
            if (entity == null) return null;

            var favoriteMovies = entity.FavoriteMovies?.Select(m => new MovieDTO(m.Id, m.Title ?? string.Empty, m.Year, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Actors ?? new List<string>(), m.Directors ?? new List<string>())).ToList();
            var watchList = entity.WatchList?.Select(m => new MovieDTO(m.Id, m.Title ?? string.Empty, m.Year, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Actors ?? new List<string>(), m.Directors ?? new List<string>())).ToList();

            return new UserDTO(
                entity.Id,
                entity.Username,
                entity.Email,
                entity.GetPasswordHash(),
                entity.GetPasswordSalt(),
                entity.FirstName,
                entity.LastName,
                entity.ProfilePictureURL,
                entity.Settings,
                favoriteMovies ?? new List<MovieDTO>(),
                watchList ?? new List<MovieDTO>()
            );
        }
    }
}
