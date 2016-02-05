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

        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.f2 = this;
            Program.OpenForm1();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            Program.f2 = this;
            Program.OpenForm3();
        }

        private void checkBox_TargetOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TargetOther.Checked) textBox_TargetOther.Enabled = true;
            else textBox_TargetOther.Enabled = false;
        }

        private void radioButton_VisitsOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_VisitsOther.Checked) textBox_VisitsOther.Enabled = true;
            else textBox_VisitsOther.Enabled = false;
        }
    }
}
