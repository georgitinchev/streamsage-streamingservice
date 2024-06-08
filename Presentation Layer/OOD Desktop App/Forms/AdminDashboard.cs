using DesktopApp.Forms;

namespace DesktopApp
{
    public partial class AdminDashboard : Form
    {
        private IDesktopController _desktopController;
        public AdminDashboard(IDesktopController desktopController)
        {
            InitializeComponent();
            _desktopController = desktopController;
            this.Activated += AdminDashboard_Activated;
            UIStyler.StyleCursorFormButtonHands(moviesBtnPicture, usersBtnPic, reviewsBtnPic, interpretationsBtnPic, analyticsBtnPic, settingsBtnPic);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.SwitchToForm(new Authentication(_desktopController));
        }

        private void AdminDashboard_Activated(object sender, EventArgs e)
        {
            UpdateTotalCounts();
        }
        private void moviesBtnPicture_Click(object sender, EventArgs e)
        {
            MovieDashboard movieDashboard = new MovieDashboard(_desktopController);
            Program.SwitchToForm(movieDashboard);
        }

        private void usersBtnPic_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement(_desktopController);
            Program.SwitchToForm(userManagement);
        }

        private void reviewsBtnPic_Click(object sender, EventArgs e)
        {
            ReviewManagement reviewManagement = new ReviewManagement(_desktopController);
            Program.SwitchToForm(reviewManagement);
        }

        private void interpretationsBtnPic_Click(object sender, EventArgs e)
        {
            InterpretationManagement interpretationManagement = new InterpretationManagement(_desktopController);
            Program.SwitchToForm(interpretationManagement);
        }

        private void analyticsBtnPic_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics(_desktopController);
            Program.SwitchToForm(analytics);
        }

        private void UpdateTotalCounts()
        {
            totalUsersLabel.Text = $"Total Users:\n{_desktopController.GetTotalUsers()}";
            totalMoviesLabel.Text = $"Total Movies:\n{_desktopController.GetTotalMovies()}";
            totalReviewsLabel.Text = $"Total Reviews:\n{_desktopController.GetTotalReviews()}";
            // totalInterpretationsLabel.Text = $"Total Interpretations: {_desktopController.GetTotalInterpretations()}";
        }


        private void settingsBtnPic_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(_desktopController);
            Program.SwitchToForm(settingsForm);
        }
    }
}
