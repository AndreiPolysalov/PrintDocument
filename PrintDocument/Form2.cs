using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form2 : Form
    {
        public Form2()
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
                        profile[i].Id,
                        profile[i].LastName,
                        profile[i].FirstName,
                        profile[i].DateOfTime
                    );
            }
        }

        private void button_RemoveSelectedProfile_Click(object sender, EventArgs e)
        {
            //Проверяем, есть ли среди выделенных строк пустая
            int countSelectedRows = dataGridView1.SelectedRows.Count;//Кол-во выделенных строк
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
            else return;
            
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную анкету(ты) из базы?", "Удалить?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int idProfile = int.Parse(dataGridView1.Rows[item.Index].Cells[0].Value.ToString());
                    DataBase.RemoveProfile(idProfile);

                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void button_OpenSelectedProfile_Click(object sender, EventArgs e)
        {
            int countSelectedRows = dataGridView1.SelectedRows.Count;//Кол-во выделенных строк
            if (countSelectedRows == 1)
            {
                Form1 f1 = Program.f1;

                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    string idProfile = dataGridView1.Rows[item.Index].Cells[0].Value.ToString();

                    Profile profile = DataBase.GetProfileFromXMLFile(idProfile);
                    
                    f1.TextBox_LastName.Text = profile.LastName;
                    f1.TextBox_FirstName.Text = profile.FirstName;
                    if (profile.Gender == "0") { f1.radioButton_GenderMan.Checked = false; f1.radioButton__GenderWoman.Checked = false; }
                    else if (profile.Gender == "1") f1.radioButton_GenderMan.Checked = true;
                    else if (profile.Gender == "2") f1.radioButton__GenderWoman.Checked = true;
                    f1.textBox_DateOfTime.Text = profile.DateOfTime;
                    f1.textBox_CityRegionCountry.Text = profile.CityRegionCountry;
                    f1.textBox_OrdinaryPassportNumber.Text = profile.OrdinaryPassportNumber;
                    f1.textBox_PassportNumber.Text = profile.OrdinaryPassportNumber;
                    f1.textBox_DateOfIssue.Text = profile.DateOfIssue;
                    f1.textBox_PassportValidUntil.Text = profile.PassportValidUntil;
                    f1.textBox_PassportPlaceOfIssue.Text = profile.PassportPlaceOfIssue;

                    f1.checkBox_OccupationOtherCompanies.Checked = profile.OccupationOtherCompanies == "1" ? true : false;
                    f1.checkBox_OccupationStudent.Checked = profile.OccupationStudent == "1" ? true : false;
                    f1.checkBox_OccupationPrivateEnterpreneuer.Checked = profile.OccupationPrivateEnterpreneuer== "1" ? true : false;
                    f1.checkBox_OccupationRetired.Checked = profile.OccupationRetired == "1" ? true : false;

                    if (profile.Education == "0") { f1.radioButton_EducationMaster.Checked = false; f1.radioButton_EducationBachelor.Checked = false; }
                    else if (profile.Education == "1") f1.radioButton_EducationMaster.Checked = true;
                    else if (profile.Education == "2") f1.radioButton_EducationBachelor.Checked = true;

                    f1.textBox_WorkName.Text = profile.WorkName;
                    f1.textBox_WorkAddress.Text = profile.WorkAddress;
                    f1.textBox_WorkPhoneNumber.Text = profile.WorkPhoneNumber;
                    f1.textBox_WorkPostcode.Text = profile.WorkPostcode;

                    f1.textBox_HomeAddress.Text = profile.HomeAddress;
                    f1.textBox_HomePostcode.Text = profile.HomePostcode;
                    f1.textBox_HomeMobileNumber.Text = profile.HomeMobileNumber;

                    if (profile.FamilyStatus == "0") { f1.radioButton_FamilyStatusMarried.Checked = false; f1.radioButton_FamilyStatusSingle.Checked = false; }
                    else if (profile.FamilyStatus == "1") f1.radioButton_FamilyStatusMarried.Checked = true;
                    else if (profile.FamilyStatus == "2") f1.radioButton_FamilyStatusSingle.Checked = true;

                    f1.textBox_Row1FIO.Text = profile.Row1FIO;
                    f1.textBox_Row1Citizenship.Text = profile.Row1Citizenship;
                    f1.textBox_Row1Profession.Text = profile.Row1Profession;
                    f1.textBox_Row1Relation.Text = profile.Row1Relation;
                    f1.textBox_Row2FIO.Text = profile.Row2FIO;
                    f1.textBox_Row2Citizenship.Text = profile.Row2Citizenship;
                    f1.textBox_Row2Profession.Text = profile.Row2Profession;
                    f1.textBox_Row2Relation.Text = profile.Row2Relation;

                    f1.textBox_ChPFIO.Text = profile.ChPFIO;
                    f1.textBox_ChPNumberMobilePhone.Text = profile.ChPNumberMobilePhone;
                    f1.textBox_ChPRelation.Text = profile.ChPRelation;

                    f1.checkBox_TargetBusiness.Checked = profile.TargetBusiness == "1" ? true : false;
                    f1.checkBox_TargetTourism.Checked = profile.TargetTourism == "1" ? true : false;

                    if(profile.Visit == "0")
                    {
                        f1.radioButton_VisitsSingle.Checked = false;
                        f1.radioButton_VisitsTwice.Checked = false;
                        f1.radioButton_VisitsRepeatedly.Checked = false;
                        f1.radioButton_VisitsRepeatedly2.Checked = false;
                    }
                    if (profile.Visit == "1") f1.radioButton_VisitsSingle.Checked = true;
                    if (profile.Visit == "2") f1.radioButton_VisitsTwice.Checked = true;
                    if (profile.Visit == "3") f1.radioButton_VisitsRepeatedly.Checked = true;
                    if (profile.Visit == "4") f1.radioButton_VisitsRepeatedly2.Checked = true;

                    if (profile.Service == "0") { f1.radioButton_ServiceYes.Checked = false; f1.radioButton_ServiceNo.Checked = false; }
                    else if (profile.Service == "1") f1.radioButton_ServiceYes.Checked = true;
                    else if (profile.Service == "2") f1.radioButton_ServiceNo.Checked = true;

                    f1.textBox_ArrivalDate.Text = profile.ArrivalDate;

                    f1.comboBox_Tenure.SelectedIndex = int.Parse(profile.Tenure);

                    if (profile.Pays == "0") { f1.radioButton_PaysApplicant.Checked = false; f1.radioButton_PaysParents.Checked = false; }
                    else if (profile.Pays == "1") f1.radioButton_PaysApplicant.Checked = true;
                    else if (profile.Pays == "2") f1.radioButton_PaysParents.Checked = true;

                    f1.textBox_PaymentOfExpenses.Text = profile.PaymentOfExpenses;

                    f1.textBox_OtherСountries.Text = profile.OtherСountries;


                    f1.comboBox_FIO.SelectedIndex = int.Parse(profile.FIO);
                }

                Program.f1 = f1;
                Program.OpenForm1();
            }
            else
            {
                MessageBox.Show("Вы не можете открывать более одной анкеты");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OpenForm1();
        }
    }
}
