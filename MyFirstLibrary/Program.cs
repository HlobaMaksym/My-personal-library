namespace MyFirstLibrary
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            while(true)
            {
                LoginForm loginForm = new LoginForm();
                Form1 form1 = new Form1();
                Application.Run(loginForm);
                if (loginForm.OpenMainForm)
                {
                    Application.Run(form1);
                }
                if (!form1.OpenLogin)
                {
                    break;
                }
            }
        }
    }
}