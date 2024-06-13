namespace DesktopApp.Forms
{
    public partial class Analytics : Form
    {
        public IDesktopController desktopController { get; private set; }
        public Analytics(IDesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
        }
    }
}
