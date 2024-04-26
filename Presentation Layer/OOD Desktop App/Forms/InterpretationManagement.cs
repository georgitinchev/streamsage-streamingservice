using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
