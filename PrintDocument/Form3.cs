using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void FillTable()
        {
            List<Profile> profile = DataBase.GetProfilesFromXMLFile();

            for (int i = 0; i < profile.Count; i++)
            {
                dataGridView1.Rows.Add
                    (
                        profile[i].LastName,
                        profile[i].FirstName,
                        profile[i].DateOfTime
                    );
            }
        }

        private void button_RemoveSelectedProfile_Click(object sender, EventArgs e)
        {
            //Проверяем, есть ли среди выделенных строк пустая
            int countSelectedRows = dataGridView1.SelectedRows.Count;
            if (countSelectedRows > 0)
            {
                foreach (DataGridViewRow rw in dataGridView1.SelectedRows)
                {
                    for (int i = 0; i < rw.Cells.Count; i++)
                    {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || string.IsNullOrEmpty(rw.Cells[i].Value.ToString()))
                        {
                            return;
                        }
                    }
                }
            }
            
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную анкету(ты) из базы?", "Удалить?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void button1_OpenSelectedProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
