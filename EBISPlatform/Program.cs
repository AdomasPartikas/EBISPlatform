using EBISPlatform.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBISPlatform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigJson configJson = new ConfigJson();
            configJson.ConfigureJsonAsync().GetAwaiter();
            Application.Run(new LoginForm());
        }
    }
}
