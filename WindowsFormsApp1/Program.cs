using msvload.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using WordRemmember.Forms;

namespace WordRemmember
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
