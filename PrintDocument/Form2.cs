using System;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f2 = this;
            Program.OpenForm1();
        }

        private void button_UpdateProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
