using Microsoft.Extensions.DependencyInjection;

namespace DesktopApp
{
    public static class Program
    {
        private static Stack<Form> formStack = new Stack<Form>();

        // We use a stack to keep track of the forms that are currently open & we pop closed forms.
        public static void SwitchToForm(Form newForm)
        {
            Form? currentForm = formStack.Count > 0 ? formStack.Peek() : null;
            if (currentForm != null)
            {
                currentForm.Hide();
                newForm.StartPosition = FormStartPosition.Manual;
                newForm.Location = new Point(
                    currentForm.Location.X + (currentForm.Width - currentForm.ClientSize.Width),
                    currentForm.Location.Y + (currentForm.Height - currentForm.ClientSize.Height)
                );
            }
            formStack.Push(newForm);
            newForm.Show();
            newForm.FormClosed += (s, args) => CloseForm();
        }



        private static void CloseForm()
        {
            if (formStack.Count > 0)
            {
                Form closedForm = formStack.Pop();
                if (closedForm is Forms.Authentication)
                {
                    Application.Exit();
                }
                else if (formStack.Count > 0)
                {
                    Form previousForm = formStack.Peek();
                    previousForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public static void ClearFormStack()
        {
            formStack.Clear();
        }

        [STAThread]
        static void Main()
        {
            // New instance of Startup class and build the service provider
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();

            ApplicationConfiguration.Initialize();
            var authenticationForm = serviceProvider.GetRequiredService<Forms.Authentication>();
            SwitchToForm(authenticationForm);
            Application.Run();
        }

    }
}
