using System;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Активация поля ввода Other
        private void radioButton__EducationOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__EducationOther.Checked) textBox_EducationOther.Enabled = true;
            else textBox_EducationOther.Enabled = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            
            Program.f1 = this;
            Program.OpenForm2();
        }


        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Вы действительно хотите выйти ?", "Выйти", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }
    }
}
