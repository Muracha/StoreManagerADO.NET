using StoreManager.App.ListForm;
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
            if (loginForm.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
