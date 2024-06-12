using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Helpers;
using LogicClassLibrary.Service_Classes;
using Moq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UserServiceTests
    {
        private UserService userService;
        private Mock<IUserManager> mockUserManager;
        private Mock<IPasswordHelper> mockPasswordHelper;

        [TestInitialize]
        public void Setup()
        {
            mockUserManager = new Mock<IUserManager>();
            mockPasswordHelper = new Mock<IPasswordHelper>();
            userService = new UserService(mockUserManager.Object, mockPasswordHelper.Object);
        }

        [TestMethod]
        public void AuthenticateUser_ValidUser_CallsAuthenticateUser()
        {
            string username = "testUser";
            string password = "testPassword";
            userService.AuthenticateUser(username, password);
            mockUserManager.Verify(u => u.AuthenticateUser(username, password), Times.Once);
        }

        [TestMethod]
        public void ChangePassword_ValidUser_CallsChangePassword()
        {
            string username = "testUser";
            string newPassword = "newPassword";
            string newPasswordSalt = "newSalt";
            string newPasswordHash = "newHash";

            mockPasswordHelper.Setup(p => p.GenerateSalt()).Returns(newPasswordSalt);
            mockPasswordHelper.Setup(p => p.HashPassword(newPassword, newPasswordSalt)).Returns(newPasswordHash);

            userService.ChangePassword(username, newPassword);

            mockUserManager.Verify(u => u.ChangePassword(username, newPasswordHash, newPasswordSalt), Times.Once);
        }

        [TestMethod]
        public void Delete_ValidUserId_CallsDelete()
        {
            int userId = 1;
            userService.Delete(userId);
            mockUserManager.Verify(u => u.Delete(userId), Times.Once);
        }

        [TestMethod]
        public void GetAllUsers_CallsGetAllUsers()
        {
            userService.GetAllUsers();
            mockUserManager.Verify(u => u.GetAllUsers(), Times.Once);
        }

        [TestMethod]
        public void Read_ValidUserId_CallsRead()
        {
            int userId = 1;
            userService.Read(userId);
            mockUserManager.Verify(u => u.Read(userId), Times.Once);
        }

        [TestMethod]
        public void Update_ValidUser_CallsUpdate()
        {
            int id = 1;
            string username = "testUser";
            string email = "testEmail";
            string firstName = "testFirstName";
            string lastName = "testLastName";
            UserSettingsDTO settings = new UserSettingsDTO { Role = "Admin" };

            userService.Update(id, username, email, firstName, lastName, settings);

            mockUserManager.Verify(u => u.Update(It.Is<UserDTO>(u => u.Id == id && u.Username == username && u.Email == email)), Times.Once);
        }
        [TestMethod]
        public void Create_ValidUser_CallsRegisterUser()
        {
            string username = "testUser";
            string email = "testEmail";
            string password = "testPassword";
            string firstName = "testFirstName";
            string lastName = "testLastName";
            UserSettingsDTO settings = new UserSettingsDTO { Role = "Admin" };

            userService.Create(username, email, password, firstName, lastName, settings);

            mockUserManager.Verify(u => u.RegisterUser(username, email, password, firstName, lastName, settings), Times.Once);
        }

        [TestMethod]
        public void AddToRecentlyWatched_ValidUserIdAndMovieId_CallsAddToRecentlyWatched()
        {
            int userId = 1;
            int movieId = 1;

            userService.AddToRecentlyWatched(userId, movieId);

            mockUserManager.Verify(u => u.AddToRecentlyWatched(userId, movieId), Times.Once);
        }

        [TestMethod]
        public void AddToWatchlist_ValidUserIdAndMovieId_CallsAddToWatchlist()
        {
            int userId = 1;
            int movieId = 1;

            userService.AddToWatchlist(userId, movieId);

            mockUserManager.Verify(u => u.AddToWatchlist(userId, movieId), Times.Once);
        }

        [TestMethod]
        public void AddToFavorites_ValidUserIdAndMovieId_CallsAddToFavorites()
        {
            int userId = 1;
            int movieId = 1;

            userService.AddToFavorites(userId, movieId);

            mockUserManager.Verify(u => u.AddToFavorites(userId, movieId), Times.Once);
        }

        [TestMethod]
        public void GetTotalUsers_CallsGetTotalUsers()
        {
            userService.GetTotalUsers();

            mockUserManager.Verify(u => u.GetTotalUsers(), Times.Once);
        }

        [TestMethod]
        public void GetUsersPage_ValidPageNumberAndSize_CallsGetUsersPage()
        {
            int pageNumber = 1;
            int pageSize = 10;

            userService.GetUsersPage(pageNumber, pageSize);

            mockUserManager.Verify(u => u.GetUsersPage(pageNumber, pageSize), Times.Once);
        }
    }
}
