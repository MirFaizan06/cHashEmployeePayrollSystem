using System;
using System.Windows.Forms;

namespace PayrollSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            EnvLoader.Load();
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}


