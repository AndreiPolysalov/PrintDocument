using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrintDocument
{
    static class Program
    {
        public static Form1 f1;
        public static Form2 f2;
        public static Form3 f3;
        public static Form4 f4;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            f1 = new Form1();
            f2 = new Form2();
            f3 = new Form3();
            f4 = new Form4();

            Application.Run(f1);
        }

        public static void OpenForm1()
        {
            f1.Show();
            f2.Hide();
        }

        public static void OpenForm2()
        {
            f2.Show();
            f3.Hide();
            f1.Hide();
        }

        public static void OpenForm3()
        {
            f3.Show();
            f4.Hide();
            f2.Hide();
        }

        public static void OpenForm4()
        {
            f4.Show();
            f3.Hide();
        }
    }
}
