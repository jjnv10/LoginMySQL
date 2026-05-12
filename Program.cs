using LoginMySQL.Views;
using LoginMySQL.Models;
namespace LoginMySQL
{
    internal static class Program
    {
        public static Usuario utilizador = new ();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Mostrar e validar o ecrã de login antes de abrir a aplicação principal
            using var fmLogin = new fmLogin();
            var result = fmLogin.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            else
            {
                // Fecha a aplicação se o utilizador cancelar o login
                Application.Exit();
            }
        }
    }
}
