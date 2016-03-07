using System;
using System.Windows.Forms;

namespace PrintDocument
{
    static class Program
    {
        public static Form1 f1;
        public static Form2 f2;
        public static Form3 f3;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            f1 = new Form1();
            f2 = new Form2();
            f3 = new Form3();

           Application.Run(new Form1());
        }

        public static void OpenForm1()
        {
            f1.Show();
            f2.Hide();
        }

        public static void OpenForm2()
        {
            f2.Show();
            f1.Hide();
        }

        public static void OpenForm3()
        {
            f3.Show();
            f1.Hide();
        }
    }
}
