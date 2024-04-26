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
