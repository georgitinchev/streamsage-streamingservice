using DesktopApp.Forms;
using PresentationLayerLibrary;

namespace DesktopApp
{
	public partial class AdminDashboard : Form
	{
		private UserInterfaceImplementation _myInterface;
		public AdminDashboard(UserInterfaceImplementation myInterface)
		{
			InitializeComponent();
			_myInterface = myInterface;
			moviesBtnPicture.Cursor = Cursors.Hand;
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			Authentication authForm = new Authentication();
			Program.SwitchToForm(this, authForm);
		}

		private void moviesBtnPicture_Click(object sender, EventArgs e)
		{
			MovieDashboard movieDashboard = new MovieDashboard(_myInterface);
			Program.SwitchToForm(movieDashboard); 
		}
	}
}
