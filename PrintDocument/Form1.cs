using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form1 : Form
    {
        private Bitmap ListA4_1 = Properties.Resources.ListA4_1;
        private Bitmap ListA4_2 = Properties.Resources.ListA4_2;
        private Bitmap ListA4_3 = Properties.Resources.ListA4_3;
        private Bitmap ListA4_4 = Properties.Resources.ListA4_4;
        private Bitmap Krestik = Properties.Resources.krestik;
        
        private int page = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Активация поля ввода Other
        private void radioButton__EducationOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__EducationOther.Checked) textBox_EducationOther.Enabled = true;
            else textBox_EducationOther.Enabled = false;
        }

        private void checkBox_TargetOther_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_TargetOther.Checked) textBox_TargetOther.Enabled = true;
            else textBox_TargetOther.Enabled = false;
        }

        private void radioButton_VisitsOther_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_VisitsOther.Checked) textBox_VisitsOther.Enabled = true;
            else textBox_VisitsOther.Enabled = false;
        }


        private void button_PrintPreview_Click(object sender, EventArgs e)
        {
            if (FieldIsNull() == true)
            {
                printDocument1.PrintPage -= new PrintPageEventHandler(PrintPackage);
                printPreviewDialog1.Document = printDocument1;
                printDocument1.PrintPage += new PrintPageEventHandler(PrintPackage);
                printPreviewDialog1.ShowDialog();
            }
        }


        public void PrintPackage(object sender, PrintPageEventArgs e)
        {            
            switch (page)
            {
                case (0): PageOne(e); break;//Заполняем поля для второй страницы
                case (1): PageTwo(e); break;//Заполняем поля для второй страницы
                case (2): PageThree(e); break;//Заполняем поля для третьей страницы
                case (3): PageFour(e); break;//Заполняем поля для четвертой страницы
            }

            page++;
            if (page < 4)
            {
                e.HasMorePages = true;
            }
            else
            {
                page = 0;
                e.HasMorePages = false;
            }
        }


        private bool FieldIsNull()
        {
            return true;

            if (string.IsNullOrEmpty(TextBox_LastName.Text)) { MessageBox.Show("В пункте 1.1 не указана фамилия"); return false; }
            if (string.IsNullOrEmpty(TextBox_FirstName.Text)) { MessageBox.Show("В пункте 1.1 не указано имя"); return false; }

            if (!radioButton_GenderMan.Checked && !radioButton__GenderWoman.Checked) { MessageBox.Show("В пункте 1.4 не выбран пол"); return false; }

            if (string.IsNullOrEmpty(textBox_DateOfTime.Text)) { MessageBox.Show("В пункте 1.5 не указана дата рождения"); return false; }
            if (string.IsNullOrEmpty(textBox_CityRegionCountry.Text)) { MessageBox.Show("В пункте 1.8 не указано место рождения"); return false; }
            if (string.IsNullOrEmpty(textBox_OrdinaryPassportNumber.Text)) { MessageBox.Show("В пункте 1.9 не указан номер паспорта РФ"); return false; }

            if (string.IsNullOrEmpty(textBox_PassportNumber.Text)) { MessageBox.Show("В пункте 1.11 не указан номер загран паспорта"); return false; }
            if (string.IsNullOrEmpty(textBox_DateOfIssue.Text)) { MessageBox.Show("В пункте 1.12 не указана дата выдачи паспорта"); return false; }
            if (string.IsNullOrEmpty(textBox_PassportPlaceOfIssue.Text)) { MessageBox.Show("В пункте 1.13 не указано место выдачи паспорта"); return false; }
            if (string.IsNullOrEmpty(textBox_PassportValidUntil.Text)) { MessageBox.Show("В пункте 1.14 не указана дата действия паспорта"); return false; }

            if (!checkBox_OccupationOtherCompanies.Checked && !checkBox_OccupationStudent.Checked &&
                !checkBox_OccupationPrivateEnterpreneuer.Checked && !checkBox_OccupationRetired.Checked &&
                string.IsNullOrEmpty(textBox_OccupationOther.Text)) { MessageBox.Show("В пункте 1.15 не выбрано ни одиной профессии"); return false; }

            if (!radioButton_EducationMaster.Checked && !radioButton_EducationBachelor.Checked &&
                !radioButton__EducationOther.Checked) { MessageBox.Show("В пункте 1.16 не указано образование"); return false; }
            else if (radioButton__EducationOther.Checked && string.IsNullOrEmpty(textBox_EducationOther.Text)) { MessageBox.Show("В пункте 1.16 не указано Иное образование"); return false; }

            if (string.IsNullOrEmpty(textBox_WorkName.Text)) { MessageBox.Show("В пункте 1.17 не указано название"); return false; }
            if (string.IsNullOrEmpty(textBox_WorkAddress.Text)) { MessageBox.Show("В пункте 1.17 не указан адрес"); return false; }
            if (string.IsNullOrEmpty(textBox_WorkPhoneNumber.Text)) { MessageBox.Show("В пункте 1.17 не указан номер телефона"); return false; }
            if (string.IsNullOrEmpty(textBox_WorkPostcode.Text)) { MessageBox.Show("В пункте 1.17 не указан почтовый индекс"); return false; }

            if (string.IsNullOrEmpty(textBox_HomeAddress.Text)) { MessageBox.Show("В пункте 1.18 не указан домашний адрес"); return false; }

            if (string.IsNullOrEmpty(textBox_HomePostcode.Text)) { MessageBox.Show("В пункте 1.19 не указан почтовый индекс"); return false; }

            if (string.IsNullOrEmpty(textBox_HomeMobileNumber.Text)) { MessageBox.Show("В пункте 1.20 не указан номер телефона"); return false; }

            if (!radioButton_FamilyStatusMarried.Checked && !radioButton_FamilyStatusSingle.Checked) { MessageBox.Show("В пункте 1.22 не указано семейное положение"); return false; }

            if (string.IsNullOrEmpty(textBox_Row1FIO.Text) && string.IsNullOrEmpty(textBox_Row2FIO.Text) &&
                string.IsNullOrEmpty(textBox_Row1Citizenship.Text) && string.IsNullOrEmpty(textBox_Row2Citizenship.Text) &&
                string.IsNullOrEmpty(textBox_Row1Profession.Text) && string.IsNullOrEmpty(textBox_Row2Profession.Text) &&
                string.IsNullOrEmpty(textBox_Row1Relation.Text) && string.IsNullOrEmpty(textBox_Row2Relation.Text)) { MessageBox.Show("В пункте 1.23 не указан ни один член семьи"); return false; }

            if (string.IsNullOrEmpty(textBox_ChPFIO.Text)) { MessageBox.Show("В пункте 1.24 не указано Ф.И.О."); return false; }
            if (string.IsNullOrEmpty(textBox_ChPNumberMobilePhone.Text)) { MessageBox.Show("В пункте 1.24 не указан номер мобильного телефона"); return false; }
            if (string.IsNullOrEmpty(textBox_ChPRelation.Text)) { MessageBox.Show("В пункте 1.24 не указано отношения с заявителем"); return false; }

            if (!checkBox_TargetTourism.Checked && !checkBox_TargetBusiness.Checked &&
                !checkBox_TargetOther.Checked) { MessageBox.Show("В пункте 2.1 не указана цель поездки"); return false; }
            if (checkBox_TargetOther.Checked && string.IsNullOrEmpty(textBox_TargetOther.Text)) { MessageBox.Show("В пункте 2.1 не указана Иная цель поездки"); return false; }

            if (!radioButton_VisitsSingle.Checked && !radioButton_VisitsTwice.Checked &&
                !radioButton_VisitsRepeatedly.Checked && !radioButton_VisitsRepeatedly2.Checked &&
                !radioButton_VisitsOther.Checked) { MessageBox.Show("В пункте 2.2 не указано планируемое число посещений"); return false; }
            if (radioButton_VisitsOther.Checked && string.IsNullOrEmpty(textBox_VisitsOther.Text)) { MessageBox.Show("В пункте 2.2 не указана Иное число посещений"); return false; }

            if (!radioButton_ServiceYes.Checked && !radioButton_ServiceNo.Checked) { MessageBox.Show("В пункте 2.3 ни чего не выбрано"); return false; }

            if (string.IsNullOrEmpty(textBox_ArrivalDate.Text)) { MessageBox.Show("В пункте 2.4 не указана дата Въезда в КНР"); return false; }

            if (string.IsNullOrEmpty(comboBox_Tenure.Text)) { MessageBox.Show("В пункте 2.5 не указан срок пребывания в КНР"); return false; }

            if (string.IsNullOrEmpty(textBox_RouteData.Text)) { MessageBox.Show("В пункте 2.6 не указана дата"); return false; }

            if (!radioButton_PaysApplicant.Checked && !radioButton_PaysParents.Checked) { MessageBox.Show("В пункте 2.7 ни чего не выбрано"); return false; }

            if (string.IsNullOrEmpty(comboBox_FIO.Text)) { MessageBox.Show("В пункте 5.1 не указан срок пребывания в КНР"); return false; }

            return true;
        }

        private void PageOne(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_1, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            //Ф.И.О.
            e.Graphics.DrawString(TextBox_LastName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 413, 265);//Фамилия
            e.Graphics.DrawString(TextBox_FirstName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 400, 323);//Имя
            
            //Выбор пола
            if (radioButton_GenderMan.Checked) e.Graphics.DrawImage(Krestik, 178, 388, 15, 15);
            else if (radioButton__GenderWoman.Checked) e.Graphics.DrawImage(Krestik, 265, 388, 15, 15);
            
            e.Graphics.DrawString(textBox_DateOfTime.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 480, 380);//Дата рождения
            e.Graphics.DrawString("РФ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 140, 415);//Гражданство в настоящее время
            e.Graphics.DrawString(textBox_CityRegionCountry.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 230, 452);//Страна рождения
            e.Graphics.DrawString(textBox_OrdinaryPassportNumber.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 390, 497);//Номер общегражданского паспорта гражданина

            //Вид паспорта
            e.Graphics.DrawImage(Krestik, 362, 552, 15, 15);//Общегражданский

            e.Graphics.DrawString(textBox_PassportNumber.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 180, 602);//Номер паспорта
            e.Graphics.DrawString(textBox_DateOfIssue.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 566, 602);//Дата выдачи паспорта
            e.Graphics.DrawString(textBox_PassportPlaceOfIssue.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 155, 627);//Место выдачи паспорта
            e.Graphics.DrawString(textBox_PassportValidUntil.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 600, 635);//Паспорт действителен до

            //Профессия
            if (checkBox_OccupationOtherCompanies.Checked) e.Graphics.DrawImage(Krestik, 177, 697, 15, 15);//Служащий в раз. компаниях
            if (checkBox_OccupationStudent.Checked) e.Graphics.DrawImage(Krestik, 177, 785, 15, 15);//Студент
            if (checkBox_OccupationPrivateEnterpreneuer.Checked) e.Graphics.DrawImage(Krestik, 177, 832, 15, 15);//Частный предпринематель
            if (checkBox_OccupationRetired.Checked) e.Graphics.DrawImage(Krestik, 177, 878, 15, 15);//Пенсионеры
            if (!string.IsNullOrEmpty(textBox_OccupationOther.Text))
            {
                e.Graphics.DrawString(textBox_OccupationOther.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 367, 917);//Иное
                e.Graphics.DrawImage(Krestik, 177, 920, 15, 15);
            }

            //Образование
            if (radioButton_EducationMaster.Checked) e.Graphics.DrawImage(Krestik, 178, 956, 15, 15);
            else if (radioButton_EducationBachelor.Checked) e.Graphics.DrawImage(Krestik, 412, 956, 15, 15);
            else if (radioButton__EducationOther.Checked)
            {
                if (string.IsNullOrEmpty(textBox_EducationOther.Text)) { MessageBox.Show("Поле " + '"' + "Иное образование" + '"' + "не заполнено"); return; }
                e.Graphics.DrawImage(Krestik, 178, 975, 15, 15);//Крестик иное
                e.Graphics.DrawString(textBox_EducationOther.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 370, 976);//Текст Иное
            }

            //Место работы
            e.Graphics.DrawString(textBox_WorkName.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 234, 1028);//Название
            e.Graphics.DrawString(textBox_WorkAddress.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 246, 1067);//Адрес
            e.Graphics.DrawString(textBox_WorkPhoneNumber.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 642, 1028);//Телефон
            e.Graphics.DrawString(textBox_WorkPostcode.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 650, 1070);//Индекс
        }

        private void PageTwo(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_2, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            e.Graphics.DrawString(textBox_HomeAddress.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 163, 40);//Домашний адрес
            e.Graphics.DrawString(textBox_HomePostcode.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 580, 54);//Домашний индекс
            e.Graphics.DrawString(textBox_HomeMobileNumber.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 158, 91);//Домашний телефон

            //Семейное положение
            if (radioButton_FamilyStatusMarried.Checked) e.Graphics.DrawImage(Krestik, 311, 132, 15, 15);
            else if (radioButton_FamilyStatusSingle.Checked) e.Graphics.DrawImage(Krestik, 460, 132, 15, 15);

            //Основные члены семьи
            e.Graphics.DrawString(textBox_Row1FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 168, 220);//Стр1 ФИО
            e.Graphics.DrawString(textBox_Row2FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 168, 253);//Стр2 ФИО
            e.Graphics.DrawString(textBox_Row1Citizenship.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 350, 220);//Стр1 Гражданство
            e.Graphics.DrawString(textBox_Row2Citizenship.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 350, 253);//Стр2 Гражданство
            e.Graphics.DrawString(textBox_Row1Profession.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 473, 220);//Стр1 Профессия
            e.Graphics.DrawString(textBox_Row2Profession.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 473, 253);//Стр2 Профессия
            e.Graphics.DrawString(textBox_Row1Relation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 633, 220);//Стр1 Отношения
            e.Graphics.DrawString(textBox_Row2Relation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 633, 253);//Стр2 Отношения

            //Контактное лицо при ЧП
            e.Graphics.DrawString(textBox_ChPFIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 215, 370);//ФИО
            e.Graphics.DrawString(textBox_ChPNumberMobilePhone.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 510, 370);//Номер мобильного телефона
            e.Graphics.DrawString(textBox_ChPRelation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 308, 415);//Домашний телефон

            e.Graphics.DrawString("РФ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 472, 460);//Страна или территория нахождения заявителя


            /////////////////////////////////
            //Раздел 2
            /////////////////////////////////

            //Цель поездки в КНР
            if (checkBox_TargetTourism.Checked) e.Graphics.DrawImage(Krestik, 167, 547, 15, 15);//Туризм
            if (checkBox_TargetBusiness.Checked) e.Graphics.DrawImage(Krestik, 167, 594, 15, 15);//Бизнес
            if (checkBox_TargetOther.Checked)
            {
                e.Graphics.DrawImage(Krestik, 167, 928, 15, 15);//Бизнесмен
                e.Graphics.DrawString(textBox_TargetOther.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 374, 930);//Стр4 Отношения
            }

            //Планируемое число посещений
            if (radioButton_VisitsSingle.Checked) e.Graphics.DrawImage(Krestik, 167, 953, 15, 15);
            else if (radioButton_VisitsTwice.Checked) e.Graphics.DrawImage(Krestik, 167, 971, 15, 15);
            else if (radioButton_VisitsRepeatedly.Checked) e.Graphics.DrawImage(Krestik, 167, 994, 15, 15);
            else if (radioButton_VisitsRepeatedly2.Checked) e.Graphics.DrawImage(Krestik, 167, 1016, 15, 15);
            else if (radioButton_VisitsOther.Checked)
            {
                e.Graphics.DrawImage(Krestik, 167, 1035, 15, 15);//Крестик иное
                e.Graphics.DrawString(textBox_VisitsOther.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 380, 1035);//Текст Иное
            }

            //Срочный сервис
            if (radioButton_ServiceYes.Checked) e.Graphics.DrawImage(Krestik, 546, 1073, 15, 15);
            else if (radioButton_ServiceNo.Checked) e.Graphics.DrawImage(Krestik, 675, 1073, 15, 15);
        }

        private void PageThree(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_3, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            e.Graphics.DrawString(textBox_ArrivalDate.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 54);//Предполагаемая дата въезда в КНР
            e.Graphics.DrawString(comboBox_Tenure.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 630, 95);//Срок пребывания каждой поездки

            //Маршрут в КНР
            e.Graphics.DrawString(textBox_RouteData.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 236, 168);//Дата стр 1
            e.Graphics.DrawString("№1, Nanheyan street," + "\n" + "Beijing 100006", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 530, 164);//Адрес стр 1
            e.Graphics.DrawString("Jade Garden Hotel,", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 540, 216);//Адрес стр 2
            e.Graphics.DrawString("tel: 010 – 5858 0909", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 540, 258);//Адрес стр 3

            //Кто оплачивает расходы заявителя
            if (radioButton_PaysApplicant.Checked) e.Graphics.DrawString("Заявитель", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 600, 392);
            else if (radioButton_PaysParents.Checked) e.Graphics.DrawString("Родители", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 600, 392);

            //Информация о приглашающей стороне
            if (radioButton_VisitsRepeatedly.Checked || radioButton_VisitsRepeatedly2.Checked)
            {
                e.Graphics.DrawString("maofahaiwaibu@hotmail.com", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 370, 445);//Название
                e.Graphics.DrawString("010-65224434", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 370, 535);//Номер телефона
            }


            e.Graphics.DrawString(textBox_PaymentOfExpenses.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 620);//Вам когда-нибудь были предоставлены китайские визы?
            e.Graphics.DrawString(textBox_OtherСountries.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 685);//Были ли вы в других странах 



            //////////////////////////////
            //Раздел 3
            //////////////////////////////



            e.Graphics.DrawImage(Krestik, 676, 788, 15, 15);//Были ли вы в КНР
            e.Graphics.DrawImage(Krestik, 676, 826, 15, 15);//Вам когда-либо отказывали
            e.Graphics.DrawImage(Krestik, 676, 862, 15, 15);//Наличие судимости в КНР
            e.Graphics.DrawImage(Krestik, 676, 914, 15, 15);//Болеете ли вы 
            e.Graphics.DrawImage(Krestik, 676, 968, 15, 15);//Были ли вы в странах
        }

        private void PageFour(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_4, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            //////////////////////////////
            //Раздел 5
            //////////////////////////////

            e.Graphics.DrawString(comboBox_FIO.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 196, 912);//ФИО
            e.Graphics.DrawString("Представитель", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 604, 912);//Отношения с заявителем
            e.Graphics.DrawString("Екатеринбург," + "\n" + "пр. Ленина, 52/4", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 196, 945);//Адрес
            e.Graphics.DrawString("8-922-100-66-55", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 604, 955);//Номер телефона
        }
    }
}
