namespace DesktopApp.Forms
{
    public partial class ReviewManagement : Form
    {
        public DesktopController desktopController { get; private set; }
        public ReviewManagement(DesktopController _desktopController)
        {
            this.desktopController = _desktopController;
            InitializeComponent();
        }
    }
}
