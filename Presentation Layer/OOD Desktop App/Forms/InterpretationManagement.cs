namespace DesktopApp.Forms
{
    public partial class InterpretationManagement : Form
    {
        public DesktopController desktopController { get; private set; }
        public InterpretationManagement(DesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
        }
    }
}
