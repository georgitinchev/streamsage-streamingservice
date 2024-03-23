using LogicClassLibrary;
using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerLibrary
{
	public class UserInterfaceImplementation : UserInterface
	{
		private DesktopController desktopController = new DesktopController();
		private WebController webController = new WebController();
		public List<Movie> DisplayMovies()
		{
			return desktopController.GetMovies();
		}
		public bool desktopLogin(string username, string password)
		{
			return desktopController.authenticate(username, password);
		}
	}
}
