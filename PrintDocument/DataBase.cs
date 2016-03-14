using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PrintDocument
{
    public class Profile
    {
        public string Id;

        public string LastName;

        public string FirstName;

        public string Gender;

        public string DateOfTime;

        public string CityRegionCountry;

        public string OrdinaryPassportNumber;

        public string PassportNumber;

        public string DateOfIssue;

        public string PassportValidUntil;

        public string PassportPlaceOfIssue;

        public string OccupationOtherCompanies;
        public string OccupationStudent;
        public string OccupationPrivateEnterpreneuer;
        public string OccupationRetired;
        public string OccupationOther;

        public string Education;

        public string WorkName;
        public string WorkAddress;
        public string WorkPhoneNumber;
        public string WorkPostcode;

        public string HomeAddress;

        public string HomePostcode;
        public string HomeMobileNumber;

        public string FamilyStatus;

        public string Row1FIO;
        public string Row1Citizenship;
        public string Row1Profession;
        public string Row1Relation;
        public string Row2FIO;
        public string Row2Citizenship;
        public string Row2Profession;
        public string Row2Relation;

        public string ChPFIO;
        public string ChPNumberMobilePhone;
        public string ChPRelation;

        public string TargetTourism;
        public string TargetBusiness;

        public string Visit;

        public string Service;

        public string ArrivalDate;

        public string Tenure;

        public string Pays;

        public string PaymentOfExpenses;

        public string OtherСountries;

        public string FIO;
    }

    public static class DataBase
    {
        private static string Id = "0";//Хранит ID последней анкеты из базы

        public static Form1 f1 = new Form1();
        

        public static void SaveToXMLFile()
        {
            f1 = Program.f1;

            if (File.Exists("ProfileDataBase.xml") == false)//У нас нету базы с анкетами, поэтому создаем новую базу
            {
                XmlTextWriter writer = new XmlTextWriter("ProfileDataBase.xml", Encoding.UTF8) { Formatting = Formatting.Indented };
                writer.WriteStartDocument();

                writer.WriteStartElement("Profiles");
                {
                    writer.WriteStartElement("Profile");
                    {
                        writer.WriteAttributeString("ID", "1");
                        writer.WriteAttributeString("LastName", f1.TextBox_LastName.Text);
                        writer.WriteAttributeString("FirstName", f1.TextBox_FirstName.Text);

                        string gender = "0";
                        if (f1.radioButton_GenderMan.Checked) gender = "1";
                        if (f1.radioButton__GenderWoman.Checked) gender = "2";
                        writer.WriteAttributeString("Gender", gender);

                        writer.WriteAttributeString("DateOfTime", f1.textBox_DateOfTime.Text);
                        writer.WriteAttributeString("CityRegionCountry", f1.textBox_CityRegionCountry.Text);
                        writer.WriteAttributeString("OrdinaryPassportNumber", f1.textBox_OrdinaryPassportNumber.Text);

                        writer.WriteAttributeString("PassportNumber", f1.textBox_PassportNumber.Text);
                        writer.WriteAttributeString("DateOfIssue", f1.textBox_DateOfIssue.Text);
                        writer.WriteAttributeString("PassportValidUntil", f1.textBox_PassportValidUntil.Text);
                        writer.WriteAttributeString("PassportPlaceOfIssue", f1.textBox_PassportPlaceOfIssue.Text);

                        writer.WriteAttributeString("OccupationOtherCompanies", f1.checkBox_OccupationOtherCompanies.Checked == true ? "1" : "2");
                        writer.WriteAttributeString("OccupationStudent", f1.checkBox_OccupationStudent.Checked == true ? "1" : "2");
                        writer.WriteAttributeString("OccupationPrivateEnterpreneuer", f1.checkBox_OccupationPrivateEnterpreneuer.Checked == true ? "1" : "2");
                        writer.WriteAttributeString("OccupationRetired", f1.checkBox_OccupationRetired.Checked == true ? "1" : "2");
                        writer.WriteAttributeString("OccupationOther", f1.textBox_OccupationOther.Text);

                        string education = "0";
                        if (f1.radioButton_EducationMaster.Checked) education = "1";
                        if (f1.radioButton_EducationBachelor.Checked) education = "2";
                        writer.WriteAttributeString("Education", education);

                        writer.WriteAttributeString("WorkName", f1.textBox_WorkName.Text);
                        writer.WriteAttributeString("WorkAddress", f1.textBox_WorkAddress.Text);
                        writer.WriteAttributeString("WorkPhoneNumber", f1.textBox_WorkPhoneNumber.Text);
                        writer.WriteAttributeString("WorkPostcode", f1.textBox_WorkPostcode.Text);

                        writer.WriteAttributeString("HomeAddress", f1.textBox_HomeAddress.Text);
                        writer.WriteAttributeString("HomePostcode", f1.textBox_HomePostcode.Text);
                        writer.WriteAttributeString("HomeMobileNumber", f1.textBox_HomeMobileNumber.Text);

                        string familyStatus = "0";
                        if (f1.radioButton_FamilyStatusMarried.Checked) familyStatus = "1";
                        if (f1.radioButton_FamilyStatusSingle.Checked) familyStatus = "2";
                        writer.WriteAttributeString("FamilyStatus", familyStatus);

                        writer.WriteAttributeString("Row1FIO", f1.textBox_Row1FIO.Text);
                        writer.WriteAttributeString("Row1Citizenship", f1.textBox_Row1Citizenship.Text);
                        writer.WriteAttributeString("Row1Profession", f1.textBox_Row1Profession.Text);
                        writer.WriteAttributeString("Row1Relation", f1.textBox_Row1Relation.Text);
                        writer.WriteAttributeString("Row2FIO", f1.textBox_Row2FIO.Text);
                        writer.WriteAttributeString("Row2Citizenship", f1.textBox_Row2Citizenship.Text);
                        writer.WriteAttributeString("Row2Profession", f1.textBox_Row2Profession.Text);
                        writer.WriteAttributeString("Row2Relation", f1.textBox_Row2Relation.Text);

                        writer.WriteAttributeString("ChPFIO", f1.textBox_ChPFIO.Text);
                        writer.WriteAttributeString("ChPNumberMobilePhone", f1.textBox_ChPNumberMobilePhone.Text);
                        writer.WriteAttributeString("ChPRelation", f1.textBox_ChPRelation.Text);

                        writer.WriteAttributeString("TargetTourism", f1.checkBox_TargetTourism.Checked == true ? "1" : "2");
                        writer.WriteAttributeString("TargetBusiness", f1.checkBox_TargetBusiness.Checked == true ? "1" : "2");

                        string visit = "0";
                        if (f1.radioButton_VisitsSingle.Checked) visit = "1";
                        if (f1.radioButton_VisitsTwice.Checked) visit = "2";
                        if (f1.radioButton_VisitsRepeatedly.Checked) visit = "3";
                        if (f1.radioButton_VisitsRepeatedly2.Checked) visit = "4";
                        writer.WriteAttributeString("Visit", visit);

                        string service = "0";
                        if (f1.radioButton_ServiceYes.Checked) service = "1";
                        if (f1.radioButton_ServiceNo.Checked) service = "2";
                        writer.WriteAttributeString("Service", service);

                        writer.WriteAttributeString("ArrivalDate", f1.textBox_ArrivalDate.Text);

                        writer.WriteAttributeString("Tenure", f1.comboBox_Tenure.SelectedIndex.ToString());

                        string pays = "0";
                        if (f1.radioButton_PaysApplicant.Checked) pays = "1";
                        if (f1.radioButton_PaysParents.Checked) pays = "2";
                        writer.WriteAttributeString("Pays", pays);

                        writer.WriteAttributeString("PaymentOfExpenses", f1.textBox_PaymentOfExpenses.Text);

                        writer.WriteAttributeString("OtherСountries", f1.textBox_OtherСountries.Text);

                        writer.WriteAttributeString("FIO", f1.comboBox_FIO.SelectedIndex.ToString());
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();

                MessageBox.Show("Анкета сохранена");
            }
            else//У нас уже есть база с анкетами, поэтому надо добавить туда новую анкету либо обновить существующую
            {
                List<Profile> profiles = new List<Profile>();
                profiles = GetProfilesFromXMLFile();

                //Ищем в базе совпадения по фамилии и имени
                string findMatchID = FindMatch();
                if (findMatchID != "0")//Совпадение найдено, обновляем анкету
                {
                    DialogResult result = MessageBox.Show("В базе обнаружена анкета с такой же фамилией, именем и датой рождения. \n Обновить анкету в базе?", "Обновить анкету в базе?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < profiles.Count; i++)
                        {
                            if (profiles[i].Id == findMatchID)
                            {
                                //Обновляем анкету
                                profiles[i].LastName = f1.TextBox_LastName.Text;
                                profiles[i].FirstName = f1.TextBox_FirstName.Text;

                                string gender = "0";
                                if (f1.radioButton_GenderMan.Checked) gender = "1";
                                if (f1.radioButton__GenderWoman.Checked) gender = "2";
                                profiles[i].Gender = gender;

                                profiles[i].DateOfTime = f1.textBox_DateOfTime.Text;
                                profiles[i].CityRegionCountry = f1.textBox_CityRegionCountry.Text;
                                profiles[i].OrdinaryPassportNumber = f1.textBox_OrdinaryPassportNumber.Text;

                                profiles[i].PassportNumber = f1.textBox_PassportNumber.Text;
                                profiles[i].DateOfIssue = f1.textBox_DateOfIssue.Text;
                                profiles[i].PassportValidUntil = f1.textBox_PassportValidUntil.Text;
                                profiles[i].PassportPlaceOfIssue = f1.textBox_PassportPlaceOfIssue.Text;

                                profiles[i].OccupationOtherCompanies = f1.checkBox_OccupationOtherCompanies.Checked == true ? "1" : "2";
                                profiles[i].OccupationStudent = f1.checkBox_OccupationStudent.Checked == true ? "1" : "2";
                                profiles[i].OccupationPrivateEnterpreneuer = f1.checkBox_OccupationPrivateEnterpreneuer.Checked == true ? "1" : "2";
                                profiles[i].OccupationRetired = f1.checkBox_OccupationRetired.Checked == true ? "1" : "2";
                                profiles[i].OccupationOther = f1.textBox_OccupationOther.Text;
                                

                                string education = "0";
                                if (f1.radioButton_EducationMaster.Checked) education = "1";
                                if (f1.radioButton_EducationBachelor.Checked) education = "2";
                                profiles[i].Education = education;

                                profiles[i].WorkName = f1.textBox_WorkName.Text;
                                profiles[i].WorkAddress = f1.textBox_WorkAddress.Text;
                                profiles[i].WorkPhoneNumber = f1.textBox_WorkPhoneNumber.Text;
                                profiles[i].WorkPostcode = f1.textBox_WorkPostcode.Text;

                                profiles[i].HomeAddress = f1.textBox_HomeAddress.Text;
                                profiles[i].HomePostcode = f1.textBox_HomePostcode.Text;
                                profiles[i].HomeMobileNumber = f1.textBox_HomeMobileNumber.Text;

                                string familyStatus = "0";
                                if (f1.radioButton_FamilyStatusMarried.Checked) familyStatus = "1";
                                if (f1.radioButton_FamilyStatusSingle.Checked) familyStatus = "2";
                                profiles[i].FamilyStatus = familyStatus;

                                profiles[i].Row1FIO = f1.textBox_Row1FIO.Text;
                                profiles[i].Row1Citizenship = f1.textBox_Row1Citizenship.Text;
                                profiles[i].Row1Profession = f1.textBox_Row1Profession.Text;
                                profiles[i].Row1Relation = f1.textBox_Row1Relation.Text;
                                profiles[i].Row2FIO = f1.textBox_Row2FIO.Text;
                                profiles[i].Row2Citizenship = f1.textBox_Row2Citizenship.Text;
                                profiles[i].Row2Profession = f1.textBox_Row2Profession.Text;
                                profiles[i].Row2Relation = f1.textBox_Row2Relation.Text;

                                profiles[i].ChPFIO = f1.textBox_ChPFIO.Text;
                                profiles[i].ChPNumberMobilePhone = f1.textBox_ChPNumberMobilePhone.Text;
                                profiles[i].ChPRelation = f1.textBox_ChPRelation.Text;

                                profiles[i].TargetTourism = f1.checkBox_TargetTourism.Checked == true ? "1" : "2";
                                profiles[i].TargetBusiness = f1.checkBox_TargetBusiness.Checked == true ? "1" : "2";

                                profiles[i].Visit = "0";
                                if (f1.radioButton_VisitsSingle.Checked) profiles[i].Visit = "1";
                                if (f1.radioButton_VisitsTwice.Checked) profiles[i].Visit = "2";
                                if (f1.radioButton_VisitsRepeatedly.Checked) profiles[i].Visit = "3";
                                if (f1.radioButton_VisitsRepeatedly2.Checked) profiles[i].Visit = "4";

                                string service = "0";
                                if (f1.radioButton_ServiceYes.Checked) service = "1";
                                if (f1.radioButton_ServiceNo.Checked) service = "2";
                                profiles[i].Service = service;

                                profiles[i].ArrivalDate = f1.textBox_ArrivalDate.Text;

                                profiles[i].Tenure = f1.comboBox_Tenure.SelectedIndex.ToString();

                                string pays = "0";
                                if (f1.radioButton_PaysApplicant.Checked) pays = "1";
                                if (f1.radioButton_PaysParents.Checked) pays = "2";
                                profiles[i].Pays = pays;

                                profiles[i].PaymentOfExpenses = f1.textBox_PaymentOfExpenses.Text;

                                profiles[i].OtherСountries = f1.textBox_OtherСountries.Text;

                                profiles[i].FIO = f1.comboBox_FIO.SelectedIndex.ToString();
                            }
                            else continue;
                        }
                    }
                }
                else//Совпадение не найдено, добавляем анкету
                {
                    string gender = "0";
                    if (f1.radioButton_GenderMan.Checked) gender = "1";
                    if (f1.radioButton__GenderWoman.Checked) gender = "2";

                    string education = "0";
                    if (f1.radioButton_EducationMaster.Checked) education = "1";
                    if (f1.radioButton_EducationBachelor.Checked) education = "2";

                    string familyStatus = "0";
                    if (f1.radioButton_FamilyStatusMarried.Checked) familyStatus = "1";
                    if (f1.radioButton_FamilyStatusSingle.Checked) familyStatus = "2";

                    string visit = "0";
                    if (f1.radioButton_VisitsSingle.Checked) visit = "1";
                    if (f1.radioButton_VisitsTwice.Checked) visit = "2";
                    if (f1.radioButton_VisitsRepeatedly.Checked) visit = "3";
                    if (f1.radioButton_VisitsRepeatedly2.Checked) visit = "4";

                    string service = "0";
                    if (f1.radioButton_ServiceYes.Checked) service = "1";
                    if (f1.radioButton_ServiceNo.Checked) service = "2";

                    string pays = "0";
                    if (f1.radioButton_PaysApplicant.Checked) pays = "1";
                    if (f1.radioButton_PaysParents.Checked) pays = "2";

                    //Добавляем новую анкету
                    profiles.Add(new Profile()
                    {
                        Id = (LastID + 1).ToString(),
                        LastName = f1.TextBox_LastName.Text,
                        FirstName = f1.TextBox_FirstName.Text,
                        Gender = gender,
                        DateOfTime = f1.textBox_DateOfTime.Text,
                        CityRegionCountry = f1.textBox_CityRegionCountry.Text,
                        OrdinaryPassportNumber = f1.textBox_OrdinaryPassportNumber.Text,

                        PassportNumber = f1.textBox_PassportNumber.Text,
                        DateOfIssue = f1.textBox_DateOfIssue.Text,
                        PassportValidUntil = f1.textBox_PassportValidUntil.Text,
                        PassportPlaceOfIssue = f1.textBox_PassportPlaceOfIssue.Text,

                        OccupationOtherCompanies = f1.checkBox_OccupationOtherCompanies.Checked == true ? "1" : "2",
                        OccupationStudent = f1.checkBox_OccupationStudent.Checked == true ? "1" : "2",
                        OccupationPrivateEnterpreneuer = f1.checkBox_OccupationPrivateEnterpreneuer.Checked == true ? "1" : "2",
                        OccupationRetired = f1.checkBox_OccupationRetired.Checked == true ? "1" : "2",
                        OccupationOther = f1.textBox_OccupationOther.Text,

                        Education = education,

                        WorkName = f1.textBox_WorkName.Text,
                        WorkAddress = f1.textBox_WorkAddress.Text,
                        WorkPhoneNumber = f1.textBox_WorkPhoneNumber.Text,
                        WorkPostcode = f1.textBox_WorkPostcode.Text,

                        HomeAddress = f1.textBox_HomeAddress.Text,
                        HomePostcode = f1.textBox_HomePostcode.Text,
                        HomeMobileNumber = f1.textBox_HomeMobileNumber.Text,

                        FamilyStatus = familyStatus,

                        Row1FIO = f1.textBox_Row1FIO.Text,
                        Row1Citizenship = f1.textBox_Row1Citizenship.Text,
                        Row1Profession = f1.textBox_Row1Profession.Text,
                        Row1Relation = f1.textBox_Row1Relation.Text,
                        Row2FIO = f1.textBox_Row2FIO.Text,
                        Row2Citizenship = f1.textBox_Row2Citizenship.Text,
                        Row2Profession = f1.textBox_Row2Profession.Text,
                        Row2Relation = f1.textBox_Row2Relation.Text,

                        ChPFIO = f1.textBox_ChPFIO.Text,
                        ChPNumberMobilePhone = f1.textBox_ChPNumberMobilePhone.Text,
                        ChPRelation = f1.textBox_ChPRelation.Text,

                        TargetTourism = f1.checkBox_TargetTourism.Checked == true ? "1" : "2",
                        TargetBusiness = f1.checkBox_TargetBusiness.Checked == true ? "1" : "2",

                        Visit = visit,

                        Service = service,

                        ArrivalDate = f1.textBox_ArrivalDate.Text,

                        Tenure = f1.comboBox_Tenure.SelectedIndex.ToString(),

                        Pays = pays,

                        PaymentOfExpenses = f1.textBox_PaymentOfExpenses.Text,

                        OtherСountries = f1.textBox_OtherСountries.Text,

                        FIO = f1.comboBox_FIO.SelectedIndex.ToString(),
                    });
                }

                //создаем новую базу и записываем в нее ранее полученные анкеты
                XmlTextWriter writer = new XmlTextWriter("ProfileDataBase.xml", Encoding.UTF8) { Formatting = Formatting.Indented };
                writer.WriteStartDocument();

                writer.WriteStartElement("Profiles");
                {
                    foreach (Profile item in profiles)
                    {
                        writer.WriteStartElement("Profile");
                        {
                            writer.WriteAttributeString("ID", item.Id);
                            writer.WriteAttributeString("LastName", item.LastName);
                            writer.WriteAttributeString("FirstName", item.FirstName);
                            writer.WriteAttributeString("Gender", item.Gender);
                            writer.WriteAttributeString("DateOfTime", item.DateOfTime);
                            writer.WriteAttributeString("CityRegionCountry", item.CityRegionCountry);
                            writer.WriteAttributeString("OrdinaryPassportNumber", item.OrdinaryPassportNumber);

                            writer.WriteAttributeString("PassportNumber", item.PassportNumber);
                            writer.WriteAttributeString("DateOfIssue", item.DateOfIssue);
                            writer.WriteAttributeString("PassportValidUntil", item.PassportValidUntil);
                            writer.WriteAttributeString("PassportPlaceOfIssue", item.PassportPlaceOfIssue);

                            writer.WriteAttributeString("OccupationOtherCompanies", item.OccupationOtherCompanies);
                            writer.WriteAttributeString("OccupationStudent", item.OccupationStudent);
                            writer.WriteAttributeString("OccupationPrivateEnterpreneuer", item.OccupationPrivateEnterpreneuer);
                            writer.WriteAttributeString("OccupationRetired", item.OccupationRetired);
                            writer.WriteAttributeString("OccupationOther", item.OccupationOther);

                            writer.WriteAttributeString("Education", item.Education);

                            writer.WriteAttributeString("WorkName", item.WorkName);
                            writer.WriteAttributeString("WorkAddress", item.WorkAddress);
                            writer.WriteAttributeString("WorkPhoneNumber", item.WorkPhoneNumber);
                            writer.WriteAttributeString("WorkPostcode", item.WorkPostcode);

                            writer.WriteAttributeString("HomeAddress", item.HomeAddress);
                            writer.WriteAttributeString("HomePostcode", item.HomePostcode);
                            writer.WriteAttributeString("HomeMobileNumber", item.HomeMobileNumber);

                            writer.WriteAttributeString("FamilyStatus", item.FamilyStatus);

                            writer.WriteAttributeString("Row1FIO", item.Row1FIO);
                            writer.WriteAttributeString("Row1Citizenship", item.Row1Citizenship);
                            writer.WriteAttributeString("Row1Profession", item.Row1Profession);
                            writer.WriteAttributeString("Row1Relation", item.Row1Relation);
                            writer.WriteAttributeString("Row2FIO", item.Row2FIO);
                            writer.WriteAttributeString("Row2Citizenship", item.Row2Citizenship);
                            writer.WriteAttributeString("Row2Profession", item.Row2Profession);
                            writer.WriteAttributeString("Row2Relation", item.Row2Relation);

                            writer.WriteAttributeString("ChPFIO", item.ChPFIO);
                            writer.WriteAttributeString("ChPNumberMobilePhone", item.ChPNumberMobilePhone);
                            writer.WriteAttributeString("ChPRelation", item.ChPRelation);

                            writer.WriteAttributeString("TargetTourism", item.TargetTourism);
                            writer.WriteAttributeString("TargetBusiness", item.TargetBusiness);

                            writer.WriteAttributeString("Visit", item.Visit);

                            writer.WriteAttributeString("Service", item.Service);

                            writer.WriteAttributeString("ArrivalDate", item.ArrivalDate);

                            writer.WriteAttributeString("Tenure", item.Tenure);

                            writer.WriteAttributeString("Pays", item.Pays);

                            writer.WriteAttributeString("PaymentOfExpenses", item.PaymentOfExpenses);

                            writer.WriteAttributeString("OtherСountries", item.OtherСountries);

                            writer.WriteAttributeString("FIO", item.FIO);
                        }
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();

                MessageBox.Show("Анкета сохранена");
            }
        }

        public static void RemoveProfile(int IDProfile)
        {
            List<Profile> profiles = GetProfilesFromXMLFile();

            //создаем новую базу
            XmlTextWriter writer = new XmlTextWriter("ProfileDataBase.xml", Encoding.UTF8) { Formatting = Formatting.Indented };
            writer.WriteStartDocument();

            writer.WriteStartElement("Profiles");
            { 
                foreach (Profile item in profiles)
                {
                    //За счет этой проверки мы исключаем из записи в файл определенную анкету
                    if (item.Id == IDProfile.ToString()) continue;

                    writer.WriteStartElement("Profile");
                    {
                        writer.WriteAttributeString("ID", item.Id);
                        writer.WriteAttributeString("LastName", item.LastName);
                        writer.WriteAttributeString("FirstName", item.FirstName);
                        writer.WriteAttributeString("Gender", item.Gender);
                        writer.WriteAttributeString("DateOfTime", item.DateOfTime);
                        writer.WriteAttributeString("CityRegionCountry", item.CityRegionCountry);
                        writer.WriteAttributeString("OrdinaryPassportNumber", item.OrdinaryPassportNumber);
                        
                        writer.WriteAttributeString("PassportNumber", item.PassportNumber);
                        writer.WriteAttributeString("DateOfIssue", item.DateOfIssue);
                        writer.WriteAttributeString("PassportValidUntil", item.PassportValidUntil);
                        writer.WriteAttributeString("PassportPlaceOfIssue", item.PassportPlaceOfIssue);

                        writer.WriteAttributeString("OccupationOtherCompanies", item.OccupationOtherCompanies);
                        writer.WriteAttributeString("OccupationStudent", item.OccupationStudent);
                        writer.WriteAttributeString("OccupationPrivateEnterpreneuer", item.OccupationPrivateEnterpreneuer);
                        writer.WriteAttributeString("OccupationRetired", item.OccupationRetired);
                        writer.WriteAttributeString("OccupationOther", item.OccupationOther);

                        writer.WriteAttributeString("Education", item.Education);

                        writer.WriteAttributeString("WorkName", item.WorkName);
                        writer.WriteAttributeString("WorkAddress", item.WorkAddress);
                        writer.WriteAttributeString("WorkPhoneNumber", item.WorkPhoneNumber);
                        writer.WriteAttributeString("WorkPostcode", item.WorkPostcode);

                        writer.WriteAttributeString("HomeAddress", item.HomeAddress);
                        writer.WriteAttributeString("HomePostcode", item.HomePostcode);
                        writer.WriteAttributeString("HomeMobileNumber", item.HomeMobileNumber);

                        writer.WriteAttributeString("FamilyStatus", item.FamilyStatus);

                        writer.WriteAttributeString("Row1FIO", item.Row1FIO);
                        writer.WriteAttributeString("Row1Citizenship", item.Row1Citizenship);
                        writer.WriteAttributeString("Row1Profession", item.Row1Profession);
                        writer.WriteAttributeString("Row1Relation", item.Row1Relation);
                        writer.WriteAttributeString("Row2FIO", item.Row2FIO);
                        writer.WriteAttributeString("Row2Citizenship", item.Row2Citizenship);
                        writer.WriteAttributeString("Row2Profession", item.Row2Profession);
                        writer.WriteAttributeString("Row2Relation", item.Row2Relation);

                        writer.WriteAttributeString("ChPFIO", item.ChPFIO);
                        writer.WriteAttributeString("ChPNumberMobilePhone", item.ChPNumberMobilePhone);
                        writer.WriteAttributeString("ChPRelation", item.ChPRelation);

                        writer.WriteAttributeString("TargetTourism", item.TargetTourism);
                        writer.WriteAttributeString("TargetBusiness", item.TargetBusiness);

                        writer.WriteAttributeString("Visit", item.Visit);

                        writer.WriteAttributeString("Service", item.Service);

                        writer.WriteAttributeString("ArrivalDate", item.ArrivalDate);

                        writer.WriteAttributeString("Tenure", item.Tenure);

                        writer.WriteAttributeString("Pays", item.Pays);

                        writer.WriteAttributeString("PaymentOfExpenses", item.PaymentOfExpenses);

                        writer.WriteAttributeString("OtherСountries", item.OtherСountries);

                        writer.WriteAttributeString("FIO", item.FIO);
                    }
                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }

        /// <summary>
        /// Получаем все анкеты из базы.
        /// </summary>
        /// <returns></returns>
        public static List<Profile> GetProfilesFromXMLFile()
        {
            List<Profile> profiles = new List<Profile>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ProfileDataBase.xml");

            if(GetCountElements() > 0)
            {
                foreach (XmlNode item in xmlDoc.DocumentElement)
                {
                    profiles.Add(new Profile()
                    {
                        Id = item.Attributes["ID"].Value,
                        LastName = item.Attributes["LastName"].Value,
                        FirstName = item.Attributes["FirstName"].Value,
                        Gender = item.Attributes["Gender"].Value,
                        DateOfTime = item.Attributes["DateOfTime"].Value,
                        CityRegionCountry = item.Attributes["CityRegionCountry"].Value,
                        OrdinaryPassportNumber = item.Attributes["OrdinaryPassportNumber"].Value,

                        PassportNumber = item.Attributes["PassportNumber"].Value,
                        DateOfIssue = item.Attributes["DateOfIssue"].Value,
                        PassportValidUntil = item.Attributes["PassportValidUntil"].Value,
                        PassportPlaceOfIssue = item.Attributes["PassportPlaceOfIssue"].Value,

                        OccupationOtherCompanies = item.Attributes["OccupationOtherCompanies"].Value,
                        OccupationStudent = item.Attributes["OccupationStudent"].Value,
                        OccupationPrivateEnterpreneuer = item.Attributes["OccupationPrivateEnterpreneuer"].Value,
                        OccupationRetired = item.Attributes["OccupationRetired"].Value,
                        OccupationOther = item.Attributes["OccupationOther"].Value,

                        Education = item.Attributes["Education"].Value,

                        WorkName = item.Attributes["WorkName"].Value,
                        WorkAddress = item.Attributes["WorkAddress"].Value,
                        WorkPhoneNumber = item.Attributes["WorkPhoneNumber"].Value,
                        WorkPostcode = item.Attributes["WorkPostcode"].Value,

                        HomeAddress = item.Attributes["HomeAddress"].Value,
                        HomePostcode = item.Attributes["HomePostcode"].Value,
                        HomeMobileNumber = item.Attributes["HomeMobileNumber"].Value,

                        FamilyStatus = item.Attributes["FamilyStatus"].Value,

                        Row1FIO = item.Attributes["Row1FIO"].Value,
                        Row1Citizenship = item.Attributes["Row1Citizenship"].Value,
                        Row1Profession = item.Attributes["Row1Profession"].Value,
                        Row1Relation = item.Attributes["Row1Relation"].Value,
                        Row2FIO = item.Attributes["Row2FIO"].Value,
                        Row2Citizenship = item.Attributes["Row2Citizenship"].Value,
                        Row2Profession = item.Attributes["Row2Profession"].Value,
                        Row2Relation = item.Attributes["Row2Relation"].Value,

                        ChPFIO = item.Attributes["ChPFIO"].Value,
                        ChPNumberMobilePhone = item.Attributes["ChPNumberMobilePhone"].Value,
                        ChPRelation = item.Attributes["ChPRelation"].Value,

                        TargetTourism = item.Attributes["TargetTourism"].Value,
                        TargetBusiness = item.Attributes["TargetBusiness"].Value,

                        Visit = item.Attributes["Visit"].Value,

                        Service = item.Attributes["Service"].Value,

                        ArrivalDate = item.Attributes["ArrivalDate"].Value,

                        Tenure = item.Attributes["Tenure"].Value,

                        Pays = item.Attributes["Pays"].Value,

                        PaymentOfExpenses = item.Attributes["PaymentOfExpenses"].Value,

                        OtherСountries = item.Attributes["OtherСountries"].Value,

                        FIO = item.Attributes["FIO"].Value
                    });
                }
            }

            return profiles;
        }

        /// <summary>
        /// Получаем из базы одну определенную анкету по ID номеру.
        /// </summary>
        /// <returns></returns>
        public static Profile GetProfileFromXMLFile(string ID)
        {
            Profile profile = new Profile();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ProfileDataBase.xml");

            if (GetCountElements() > 0)
            {
                foreach (XmlNode item in xmlDoc.DocumentElement)
                {
                    if (item.Attributes["ID"].Value == ID)
                    {
                        profile = new Profile()
                        {
                            Id = item.Attributes["ID"].Value,
                            LastName = item.Attributes["LastName"].Value,
                            FirstName = item.Attributes["FirstName"].Value,
                            Gender = item.Attributes["Gender"].Value,
                            DateOfTime = item.Attributes["DateOfTime"].Value,
                            CityRegionCountry = item.Attributes["CityRegionCountry"].Value,
                            OrdinaryPassportNumber = item.Attributes["OrdinaryPassportNumber"].Value,

                            PassportNumber = item.Attributes["PassportNumber"].Value,
                            DateOfIssue = item.Attributes["DateOfIssue"].Value,
                            PassportValidUntil = item.Attributes["PassportValidUntil"].Value,
                            PassportPlaceOfIssue = item.Attributes["PassportPlaceOfIssue"].Value,

                            OccupationOtherCompanies = item.Attributes["OccupationOtherCompanies"].Value,
                            OccupationStudent = item.Attributes["OccupationStudent"].Value,
                            OccupationPrivateEnterpreneuer = item.Attributes["OccupationPrivateEnterpreneuer"].Value,
                            OccupationRetired = item.Attributes["OccupationRetired"].Value,
                            OccupationOther = item.Attributes["OccupationOther"].Value,

                            Education = item.Attributes["Education"].Value,

                            WorkName = item.Attributes["WorkName"].Value,
                            WorkAddress = item.Attributes["WorkAddress"].Value,
                            WorkPhoneNumber = item.Attributes["WorkPhoneNumber"].Value,
                            WorkPostcode = item.Attributes["WorkPostcode"].Value,

                            HomeAddress = item.Attributes["HomeAddress"].Value,
                            HomePostcode = item.Attributes["HomePostcode"].Value,
                            HomeMobileNumber = item.Attributes["HomeMobileNumber"].Value,

                            FamilyStatus = item.Attributes["FamilyStatus"].Value,

                            Row1FIO = item.Attributes["Row1FIO"].Value,
                            Row1Citizenship = item.Attributes["Row1Citizenship"].Value,
                            Row1Profession = item.Attributes["Row1Profession"].Value,
                            Row1Relation = item.Attributes["Row1Relation"].Value,
                            Row2FIO = item.Attributes["Row2FIO"].Value,
                            Row2Citizenship = item.Attributes["Row2Citizenship"].Value,
                            Row2Profession = item.Attributes["Row2Profession"].Value,
                            Row2Relation = item.Attributes["Row2Relation"].Value,

                            ChPFIO = item.Attributes["ChPFIO"].Value,
                            ChPNumberMobilePhone = item.Attributes["ChPNumberMobilePhone"].Value,
                            ChPRelation = item.Attributes["ChPRelation"].Value,

                            TargetTourism = item.Attributes["TargetTourism"].Value,
                            TargetBusiness = item.Attributes["TargetBusiness"].Value,

                            Visit = item.Attributes["Visit"].Value,

                            Service = item.Attributes["Service"].Value,

                            ArrivalDate = item.Attributes["ArrivalDate"].Value,

                            Tenure = item.Attributes["Tenure"].Value,

                            Pays = item.Attributes["Pays"].Value,

                            PaymentOfExpenses = item.Attributes["PaymentOfExpenses"].Value,

                            OtherСountries = item.Attributes["OtherСountries"].Value,

                            FIO = item.Attributes["FIO"].Value
                        };
                    }
                }
            }
            else MessageBox.Show("База пуста");

            return profile;
        }

        /// <summary>
        /// Возвращает кол-во сохраненных анкет в файле
        /// </summary>
        /// <returns></returns>
        public static int GetCountElements()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ProfileDataBase.xml");

            XmlNodeList elemList = xmlDoc.GetElementsByTagName("Profile");

            return elemList.Count;
        }

        /// <summary>
        /// Ищем в базе совпадения по фамилии и имени. /n Возвращает ID анкеты если найдено совпадение, если совпадение не найдено, возвращается 0
        /// </summary>
        /// <returns></returns>
        private static string FindMatch()
        {
            f1 = Program.f1;
            List<Profile> profiles = GetProfilesFromXMLFile();
            string result = "0";

            for (int i = 0; i < profiles.Count; i++)
            {
                string ProfileLastName = profiles[i].LastName;
                string ProfileFirstName = profiles[i].FirstName;
                string ProfileDateOfTime = profiles[i].DateOfTime;

                string CurrentLastName = f1.TextBox_LastName.Text;
                string CurrentFirstName = f1.TextBox_FirstName.Text;
                string CurrentDateOfTime = f1.textBox_DateOfTime.Text;


                if (ProfileLastName == CurrentLastName &&
                    ProfileFirstName == CurrentFirstName &&
                    ProfileDateOfTime == CurrentDateOfTime)
                {
                    result = profiles[i].Id;//Совпадение найдено
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Возвращает ID последней анкеты
        /// </summary>
        private static int LastID
        {
            get
            {
                int lastID = 1;

                List<Profile> profiles = new List<Profile>();
                profiles = GetProfilesFromXMLFile();

                foreach (Profile item in profiles)
                {
                    lastID = int.Parse(item.Id);
                }

                return lastID;
            }
        }
    }
}