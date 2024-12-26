using WinFormsApp3;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura l'applicazione e avvia Form1
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // Usa la tua classe Form1
        }
    }
}
