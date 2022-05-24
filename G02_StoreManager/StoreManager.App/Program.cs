using System;
using System.Windows.Forms;


namespace StoreManager.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new LoginForm();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
