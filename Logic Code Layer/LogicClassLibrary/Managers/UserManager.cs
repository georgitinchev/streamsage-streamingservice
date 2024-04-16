using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
    internal class UserManager
    {
        private string? username;
        private string? password;
        private string? email;

        private void changePassword(string newPassword)
        {
            password = newPassword;
        }

        private void updateEmail(string newEmail)
        {
            email = newEmail;
        }

        private void addToFavorites(int movieId)
        {

        }

        private void removeFromFavorites(int movieId)
        {

        }

        private void addToWatchlist(int movieId)
        {

        }

        private void removefromWatchlist(int movieId)
        {

        }

        private void updateUserRole(int userId, string newRole)
        {

        }
    }
}
