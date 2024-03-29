using PresentationLayerLibrary;
using System.Windows.Forms;
using System.Linq;

namespace DesktopApp
{
	public static class Program
	{
		// method for form navigation
		public static void SwitchToForm(Form currentForm, Form newForm)
		{
			if (currentForm != null)
			{
				if (currentForm != newForm)
				{
					currentForm.Close(); 
				}
				else
				{
					return;
				}
			}
			newForm.Show();
		}

		public static void SwitchToForm(Form newForm)
		{
			Form currentForm = Application.OpenForms.Cast<Form>().FirstOrDefault();
			if (currentForm != null)
			{
				if (currentForm != newForm)
				{
					currentForm.Hide(); // Close the current form
				}
				else
				{
					return;
				}
			}
			newForm.Show();
		}

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new ApplicationContext(new Forms.Authentication()));
		}
	}
}
