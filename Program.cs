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
            Application.Run(new Form1());

        }
    }
}