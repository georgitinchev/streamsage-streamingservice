using DTOs;
using LogicClassLibrary.Managers;
using System.Data;

namespace DesktopApp.Forms
{
    public partial class SettingsForm : Form
    {
        public IDesktopController desktopController { get; private set; }

        public SettingsForm(IDesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            itemsPerPageNumeric.Value = desktopController.GetPageSize();
        }

        private void savePaginatorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int newPageSize = (int)itemsPerPageNumeric.Value;
                desktopController.UpdatePageSize(newPageSize);
                settingsErrorLabel.ForeColor = Color.Green;
                settingsErrorLabel.Text = "Page size updated successfully!";
            }
            catch (System.Exception ex)
            {
                settingsErrorLabel.ForeColor = Color.Red;
                settingsErrorLabel.Text = $"Failed to update page size: {ex.Message}";
            }
            finally
            {
                Task.Delay(3000).Wait();
                settingsErrorLabel.Text = "";
            }
        }
    }
}
