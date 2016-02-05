using System;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.f3 = this;
            Program.OpenForm2();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            Program.f3 = this;
            Program.OpenForm4();
        }
    }
}
