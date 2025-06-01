using Projekt_Restauracja.Models;
using System;
using System.Windows.Forms;

namespace Projekt_Restauracja
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularz());
        }
    }
}
