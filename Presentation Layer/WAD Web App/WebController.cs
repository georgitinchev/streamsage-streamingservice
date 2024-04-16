using DesktopApp;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;

namespace StreamSageWAD
{
	public class WebController : UserInterface
	{
		private User? loggedInUser;
		private string? searchCriteria;
		private BackendService backendService;
		public WebController(User? _loggedInUser)
		{
			loggedInUser = _loggedInUser;
			searchCriteria = "";
			backendService = new BackendService();
		}
		public void displayHomePage()
		{
			// implement
		}
		public void displayMoviePage()
		{
			// implement
		}
		public void loginUser(string username, string password)
		{
			// implement
		}
		public void registerUser(string username, string password, string email)
		{
			// implement
		}
		public void logoutUser()
		{
			// implement
		}
	}
}
