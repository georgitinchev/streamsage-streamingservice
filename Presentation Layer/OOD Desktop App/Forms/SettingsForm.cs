using LogicClassLibrary.Managers;
using System.Data;

namespace DesktopApp.Forms
{
    public partial class SettingsForm : Form
    {
        public DesktopController desktopController { get; private set; }
        public SettingsForm(DesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            PopulateUserPicker();
            UIStyler.MakeCheckBoxesMutuallyExclusive(selectBehaviorBasedCheckBox, selectContentBasedCheckBox);

        }

        private async void DisplayRecommendations()
        {
            settingsDisplayRecommendationsListBox.Items.Clear();
            if (settingsUserPicker.SelectedItem == null || (!selectBehaviorBasedCheckBox.Checked && !selectContentBasedCheckBox.Checked))
            {
                return;
            }
            string username = settingsUserPicker.SelectedItem.ToString();
            int numRecommendations = 5; // can be adjusted here
            // determine type of recommend based on user selection
            var type = selectBehaviorBasedCheckBox.Checked ?
                RecommendationManager.RecommendationType.BehaviorBased :
                RecommendationManager.RecommendationType.ContentBased;

            //var recommendations = await desktopController.backendService?.recommendationManager?.RecommendMoviesForUser(username, numRecommendations, type);

            //if (recommendations != null)
            //{
            //    foreach (var movie in recommendations)
            //    {
            //        settingsDisplayRecommendationsListBox.Items.Add(movie.Title);
            //    }
            //}
        }

        private void settingsTestAlgorithm_Click(object sender, EventArgs e)
        {
            DisplayRecommendations();
        }

        private void PopulateUserPicker()
        {
            //var userNames = desktopController.backendService?.GetAllUsers().Select(u => u.Username).ToList();
            //UIStyler.PopulateComboBox(settingsUserPicker, userNames);
        }
    }
}
