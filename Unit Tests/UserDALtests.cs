using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DTOs;
using Microsoft.Data.SqlClient;
using DataAccessLibrary;

namespace UnitTests
{
    [TestClass]
    public class UserDALtests
    {
        [TestMethod]
        public void CreateUser_ValidUser_CreatesUser()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var user = new UserDTO(1, "username", "email");

            mockUserDAL.Setup(m => m.CreateUser(user)).Returns(1);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.CreateUser(user);

            Assert.AreEqual(1, result);
        }



        [TestMethod]
        public void GetUserById_ValidId_ReturnsUser()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var user = new UserDTO(1, "username", "email");

            mockUserDAL.Setup(m => m.GetUserById(1)).Returns(user);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.GetUserById(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(user, result);
        }

        [TestMethod]
        public void DeleteUser_ValidId_DeletesUser()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var user = new UserDTO(1, "username", "email");

            mockUserDAL.Setup(m => m.DeleteUser(1));

            var userDAL = mockUserDAL.Object;

            userDAL.DeleteUser(1);

            mockUserDAL.Verify(m => m.DeleteUser(1), Times.Once);
        }

        [TestMethod]
        public void GetTotalUsers_ReturnsTotalUsers()
        {
            var mockUserDAL = new Mock<IUserDAL>();

            mockUserDAL.Setup(m => m.GetTotalUsers()).Returns(10);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.GetTotalUsers();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void UpdateUser_ValidUser_UpdatesUser()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var user = new UserDTO(1, "username", "email");

            mockUserDAL.Setup(m => m.UpdateUser(user));

            var userDAL = mockUserDAL.Object;

            userDAL.UpdateUser(user);

            mockUserDAL.Verify(m => m.UpdateUser(user), Times.Once);
        }

        [TestMethod]
        public void GetUserByUsername_ValidUsername_ReturnsUser()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var user = new UserDTO(1, "username", "email");

            mockUserDAL.Setup(m => m.GetUserByUsername("username")).Returns(user);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.GetUserByUsername("username");

            Assert.IsNotNull(result);
            Assert.AreEqual(user, result);
        }

        [TestMethod]
        public void GetUsersPage_ValidPageNumberAndSize_ReturnsUsers()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var users = new List<UserDTO> { new UserDTO(1, "username1", "email1"), new UserDTO(2, "username2", "email2") };

            mockUserDAL.Setup(m => m.GetUsersPage(1, 2)).Returns(users);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.GetUsersPage(1, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(users, result);
        }

        [TestMethod]
        public void ReadAllUsers_ReturnsAllUsers()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var users = new List<UserDTO> { new UserDTO(1, "username1", "email1"), new UserDTO(2, "username2", "email2") };

            mockUserDAL.Setup(m => m.ReadAllUsers()).Returns(users);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.ReadAllUsers();

            Assert.IsNotNull(result);
            Assert.AreEqual(users, result);
        }

        [TestMethod]
        public void UpdateUserWithoutPassword_ValidUser_UpdatesUser()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var user = new UserDTO(1, "username", "email");

            mockUserDAL.Setup(m => m.UpdateUserWithoutPassword(user));

            var userDAL = mockUserDAL.Object;

            userDAL.UpdateUserWithoutPassword(user);

            mockUserDAL.Verify(m => m.UpdateUserWithoutPassword(user), Times.Once);
        }

        [TestMethod]
        public void ChangePassword_ValidUserIdAndPassword_ChangesPassword()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var userId = 1;
            var newPasswordHash = "newPasswordHash";
            var newPasswordSalt = "newPasswordSalt";

            mockUserDAL.Setup(m => m.ChangePassword(userId, newPasswordHash, newPasswordSalt));

            var userDAL = mockUserDAL.Object;

            userDAL.ChangePassword(userId, newPasswordHash, newPasswordSalt);

            mockUserDAL.Verify(m => m.ChangePassword(userId, newPasswordHash, newPasswordSalt), Times.Once);
        }

        [TestMethod]
        public void AddMovieToFavorites_ValidUserIdAndMovieId_AddsMovieToFavorites()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var userId = 1;
            var movieId = 1;

            mockUserDAL.Setup(m => m.AddMovieToFavorites(userId, movieId));

            var userDAL = mockUserDAL.Object;

            userDAL.AddMovieToFavorites(userId, movieId);

            mockUserDAL.Verify(m => m.AddMovieToFavorites(userId, movieId), Times.Once);
        }

        [TestMethod]
        public void RemoveMovieFromFavorites_ValidUserIdAndMovieId_RemovesMovieFromFavorites()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var userId = 1;
            var movieId = 1;

            mockUserDAL.Setup(m => m.RemoveMovieFromFavorites(userId, movieId));

            var userDAL = mockUserDAL.Object;

            userDAL.RemoveMovieFromFavorites(userId, movieId);

            mockUserDAL.Verify(m => m.RemoveMovieFromFavorites(userId, movieId), Times.Once);
        }

        [TestMethod]
        public void GetRecentlyWatchedMoviesForUser_ValidUserId_ReturnsMovieIds()
        {
            var mockUserDAL = new Mock<IUserDAL>();
            var userId = 1;
            var movieIds = new List<int> { 1, 2, 3 };

            mockUserDAL.Setup(m => m.GetRecentlyWatchedMoviesForUser(userId)).Returns(movieIds);

            var userDAL = mockUserDAL.Object;

            var result = userDAL.GetRecentlyWatchedMoviesForUser(userId);

            Assert.IsNotNull(result);
            Assert.AreEqual(movieIds, result);
        }

    }
}
