using DataAccessLibrary.DataAccessLibrary;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
	internal class UserManager
	{
		private List<User>? users;
		private UserDAL? userDAL;

		public UserManager(UserDAL userDAL)
		{
			users = new List<User>();
			this.userDAL = userDAL;
		}

		private void changePassword(string newPassword)
		{
		}

		private void updateEmail(string newEmail)
		{
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
