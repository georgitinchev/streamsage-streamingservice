namespace DesktopApp.Forms
{
    public partial class Analytics : Form
    {
        public DesktopController desktopController { get; private set; }
        public Analytics(DesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
        }
    }
}
