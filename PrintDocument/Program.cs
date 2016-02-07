using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrintDocument
{
    static class Program
    {
        public static Form1 f1;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(f1);
        }
    }
}
