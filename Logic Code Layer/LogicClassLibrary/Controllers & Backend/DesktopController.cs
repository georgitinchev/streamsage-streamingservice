using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary
{
	public class DesktopController
	{
		private MovieManager movieManager = new MovieManager();
		public List<Movie> GetMovies()
		{
			return movieManager.GetMovies();
		}
		public bool authenticate(string username, string password)
		{
			if(username == "admin" && password == "admin")
			{
				return true;
			}
			return false;
		}
	}
}
