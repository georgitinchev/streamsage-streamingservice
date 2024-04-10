using DesktopApp.Forms;
using LogicClassLibrary;

namespace DesktopApp
{
	public partial class AdminDashboard : Form
	{
		private  DesktopController _desktopController;
		public AdminDashboard(DesktopController desktopController)
		{
			InitializeComponent();
			_desktopController = desktopController;
			moviesBtnPicture.Cursor = Cursors.Hand;
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			Authentication authForm = new Authentication();
			Program.SwitchToForm(this, authForm);
		}

		private void moviesBtnPicture_Click(object sender, EventArgs e)
		{
			MovieDashboard movieDashboard = new MovieDashboard(_desktopController);
			Program.SwitchToForm(movieDashboard); 
		}
	}
}
