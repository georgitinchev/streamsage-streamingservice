using LogicClassLibrary.Interface.Service;
using System.Drawing.Drawing2D;

namespace DesktopApp.Forms
{
    public partial class Authentication : Form
    {
        private IDesktopController _desktopController;
        public Authentication(IDesktopController desktopController)
        {
            InitializeComponent();
            CustomizeButton(loginBtn);
            this._desktopController = desktopController;
            this.AcceptButton = loginBtn;
        }

        private void CustomizeButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(50, 50, 50);
            button.ForeColor = Color.White;
            button.Padding = new Padding(10);
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;
            int radius = 20;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorLabelAuth.Text = "";
            if (string.IsNullOrWhiteSpace(userNameLoginTextBox.Text) || string.IsNullOrWhiteSpace(passwordLoginTextBox.Text))
            {
                errorLabelAuth.Text = "Username and password cannot be empty";
                return;
            }
            try
            {
                _desktopController.LoginUser(userNameLoginTextBox.Text, passwordLoginTextBox.Text);
                AdminDashboard adminDashboard = new AdminDashboard(_desktopController);
                Program.SwitchToForm(adminDashboard);
            }
            catch (System.Exception ex)
            {
                errorLabelAuth.Text = ex.Message;
            }
            finally
            {
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            userNameLoginTextBox.Text = "";
            passwordLoginTextBox.Text = "";
        }
    }
}
