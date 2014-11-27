using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Hvylya_Worker
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        private static Mutex m_instance;
        private const string m_appName = "Hvylya Worker";

        [STAThread]
        static void Main()
        {
            bool tryCreateNewApp;  
            m_instance = new Mutex(true, m_appName, out tryCreateNewApp);
            if (tryCreateNewApp)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));
                Application.Run(new frmMain());
            }
        }
    }
}
