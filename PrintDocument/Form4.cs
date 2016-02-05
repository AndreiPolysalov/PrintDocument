using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form4 : Form
    {
        private Form1 _f1;
        private Form2 _f2;
        private Form3 _f3;
        private Form4 _f4;

        private Bitmap ListA4_1 = Properties.Resources.ListA4_1;
        private Bitmap ListA4_2 = Properties.Resources.ListA4_2;
        private Bitmap ListA4_3 = Properties.Resources.ListA4_3;
        private Bitmap ListA4_4 = Properties.Resources.ListA4_4;
        private Bitmap Krestik = Properties.Resources.krestik;

        private int page = 0;



        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            _f1 = Program.f1;
            _f2 = Program.f2;
            _f3 = Program.f3;
            _f4 = Program.f4;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.f4 = this;
            Program.OpenForm3();
        }


        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(PrintPackage);
            printPreviewDialog1.ShowDialog();
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

        private void PageOne(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_1, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            //Ф.И.О.
            e.Graphics.DrawString(_f1.TextBox_LastName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 413, 265);//Фамилия
            e.Graphics.DrawString(_f1.TextBox_FirstName.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 400, 323);//Имя

            //Выбора пола
            if (_f1.radioButton_GenderMan.Checked) e.Graphics.DrawImage(Krestik, 178, 388, 15, 15);
            else if (_f1.radioButton__GenderWoman.Checked) e.Graphics.DrawImage(Krestik, 265, 388, 15, 15);
            else { MessageBox.Show("Выберите пол"); return; }

            e.Graphics.DrawString(_f1.textBox_DateOfTime.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 480, 380);//Дата рождения
            e.Graphics.DrawString(_f1.textBox_Citizenship.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 140, 415);//Гражданство в настоящее время
            e.Graphics.DrawString(_f1.textBox_CityRegionCountry.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 230, 452);//Страна рождения
            e.Graphics.DrawString(_f1.textBox_OrdinaryPassportNumber.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 390, 497);//Номер общегражданского паспорта гражданина

            //Вид паспорта
            if (_f1.radioButton_PassportDiplomatic.Checked) e.Graphics.DrawImage(Krestik, 362, 529, 15, 15);//Дипломатический
            else if (_f1.radioButton_PassportService.Checked) e.Graphics.DrawImage(Krestik, 544, 529, 15, 15);//Служебный
            else if (_f1.radioButton_PassportOrdinary.Checked) e.Graphics.DrawImage(Krestik, 362, 552, 15, 15);//Общегражданский
            else if (_f1.radioButton_PassportOther.Checked)
            {
                if (string.IsNullOrEmpty(_f1.textBox_PassportOther.Text)) { MessageBox.Show("Поле " + '"' + "Вид паспорта Иное " + '"' + "не заполнено"); return; }
                e.Graphics.DrawImage(Krestik, 362, 570, 15, 15);//Крестик иное
                e.Graphics.DrawString(_f1.textBox_PassportOther.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 600, 567);//Текст Иное
            }
            else { MessageBox.Show("Выберите вид паспорта"); return; }

            e.Graphics.DrawString(_f1.textBox_PassportNumber.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 180, 602);//Номер паспорта
            e.Graphics.DrawString(_f1.textBox_DateOfIssue.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 566, 602);//Дата выдачи паспорта
            e.Graphics.DrawString(_f1.textBox_PassportPlaceOfIssue.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 155, 627);//Место выдачи паспорта
            e.Graphics.DrawString(_f1.textBox_PassportValidUntil.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 600, 635);//Паспорт действителен до

            //Профессия
            if (_f1.checkBox_OccupationBusinessman.Checked) e.Graphics.DrawImage(Krestik, 177, 672, 15, 15);//Бизнесмен
            if (_f1.checkBox_OccupationOtherCompanies.Checked) e.Graphics.DrawImage(Krestik, 177, 697, 15, 15);//Служащий в раз. компаниях
            if (_f1.checkBox_OccupationArtist.Checked) e.Graphics.DrawImage(Krestik, 177, 721, 15, 15);//Артист
            if (_f1.checkBox_OccupationAgriculturalWorker.Checked) e.Graphics.DrawImage(Krestik, 177, 744, 15, 15);//Промышленный работник
            if (_f1.checkBox_OccupationStudent.Checked) e.Graphics.DrawImage(Krestik, 177, 785, 15, 15);//Студент
            if (_f1.checkBox_OccupationCrewMember.Checked) e.Graphics.DrawImage(Krestik, 177, 808, 15, 15);//Член экипажа
            if (_f1.checkBox_OccupationPrivateEnterpreneuer.Checked) e.Graphics.DrawImage(Krestik, 177, 832, 15, 15);//Частный предпринематель
            if (_f1.checkBox_OccupationUnemployed.Checked) e.Graphics.DrawImage(Krestik, 177, 855, 15, 15);//Безработный
            if (_f1.checkBox_OccupationRetired.Checked) e.Graphics.DrawImage(Krestik, 177, 878, 15, 15);//Пенсионеры
            if (_f1.checkBox_OccupationNPOStaff.Checked) e.Graphics.DrawImage(Krestik, 449, 840, 15, 15);//Сотрудники НПО
            if (_f1.checkBox_OccupationCleric.Checked) e.Graphics.DrawImage(Krestik, 449, 864, 15, 15);//Священослужитель
            if (_f1.checkBox_OccupationMediaWorker.Checked) e.Graphics.DrawImage(Krestik, 449, 886, 15, 15);//Работник СМИ
            if (!string.IsNullOrEmpty(_f1.textBox_OccupationDeputy.Text))
            {
                e.Graphics.DrawString(_f1.textBox_OccupationDeputy.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 560, 704);//Депутат
                e.Graphics.DrawImage(Krestik, 449, 666, 15, 15);
            }
            if (!string.IsNullOrEmpty(_f1.textBox_OccupationOfficial.Text))
            {
                e.Graphics.DrawString(_f1.textBox_OccupationOfficial.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 560, 768);//Чиновник
                e.Graphics.DrawImage(Krestik, 449, 730, 15, 15);
            }
            if (!string.IsNullOrEmpty(_f1.textBox_OccupationMilitary.Text))
            {
                e.Graphics.DrawString(_f1.textBox_OccupationMilitary.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 560, 814);//Военнослужащий
                e.Graphics.DrawImage(Krestik, 449, 794, 15, 15);
            }
            if (!string.IsNullOrEmpty(_f1.textBox_OccupationOther.Text))
            {
                e.Graphics.DrawString(_f1.textBox_OccupationOther.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 367, 917);//Иное
                e.Graphics.DrawImage(Krestik, 177, 920, 15, 15);
            }

            //Образование
            if (_f1.radioButton_EducationMaster.Checked) e.Graphics.DrawImage(Krestik, 178, 956, 15, 15);
            else if (_f1.radioButton_EducationBachelor.Checked) e.Graphics.DrawImage(Krestik, 412, 956, 15, 15);
            else if (_f1.radioButton__EducationOther.Checked)
            {
                if (string.IsNullOrEmpty(_f1.textBox_EducationOther.Text)) { MessageBox.Show("Поле " + '"' + "Иное образование" + '"' + "не заполнено"); return; }
                e.Graphics.DrawImage(Krestik, 178, 975, 15, 15);//Крестик иное
                e.Graphics.DrawString(_f1.textBox_EducationOther.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 370, 976);//Текст Иное
            }

            //Место работы
            e.Graphics.DrawString(_f1.textBox_WorkName.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 234, 1028);//Название
            e.Graphics.DrawString(_f1.textBox_WorkAddress.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 246, 1067);//Адрес
            e.Graphics.DrawString(_f1.textBox_WorkPhoneNumber.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 642, 1028);//Телефон
            e.Graphics.DrawString(_f1.textBox_WorkPostcode.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 650, 1070);//Индекс
        }

        private void PageTwo(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_2, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            e.Graphics.DrawString(_f1.textBox_HomeAddress.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 163, 40);//Домашний адрес
            e.Graphics.DrawString(_f1.textBox_HomePostcode.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 580, 54);//Домашний индекс
            e.Graphics.DrawString(_f1.textBox_HomeMobileNumber.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 158, 91);//Домашний телефон

            //Семейное положение
            if (_f1.radioButton_FamilyStatusMarried.Checked) e.Graphics.DrawImage(Krestik, 311, 132, 15, 15);
            else if (_f1.radioButton_FamilyStatusSingle.Checked) e.Graphics.DrawImage(Krestik, 460, 132, 15, 15);
            else if (_f1.radioButton_FamilyStatusOther.Checked)
            {
                if (string.IsNullOrEmpty(_f1.textBox_FamilyStatusOther.Text)) { MessageBox.Show("Поле " + '"' + "Семейное положение Иное " + '"' + "не заполнено"); return; }
                e.Graphics.DrawImage(Krestik, 312, 157, 15, 15);//Крестик иное
                e.Graphics.DrawString(_f1.textBox_FamilyStatusOther.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 456, 157);//Текст Иное
            }

            //Основные члены семьи
            e.Graphics.DrawString(_f1.textBox_Row1FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 168, 220);//Стр1 ФИО
            e.Graphics.DrawString(_f1.textBox_Row2FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 168, 253);//Стр2 ФИО
            e.Graphics.DrawString(_f1.textBox_Row3FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 168, 286);//Стр3 ФИО
            e.Graphics.DrawString(_f1.textBox_Row4FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 168, 319);//Стр4 ФИО
            e.Graphics.DrawString(_f1.textBox_Row1Citizenship.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 350, 220);//Стр1 Гражданство
            e.Graphics.DrawString(_f1.textBox_Row2Citizenship.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 350, 253);//Стр2 Гражданство
            e.Graphics.DrawString(_f1.textBox_Row3Citizenship.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 350, 286);//Стр3 Гражданство
            e.Graphics.DrawString(_f1.textBox_Row4Citizenship.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 350, 319);//Стр4 Гражданство
            e.Graphics.DrawString(_f1.textBox_Row1Profession.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 473, 220);//Стр1 Профессия
            e.Graphics.DrawString(_f1.textBox_Row2Profession.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 473, 253);//Стр2 Профессия
            e.Graphics.DrawString(_f1.textBox_Row3Profession.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 473, 286);//Стр3 Профессия
            e.Graphics.DrawString(_f1.textBox_Row4Profession.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 473, 319);//Стр4 Профессия
            e.Graphics.DrawString(_f1.textBox_Row1Relation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 633, 220);//Стр1 Отношения
            e.Graphics.DrawString(_f1.textBox_Row2Relation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 633, 253);//Стр2 Отношения
            e.Graphics.DrawString(_f1.textBox_Row3Relation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 633, 286);//Стр3 Отношения
            e.Graphics.DrawString(_f1.textBox_Row4Relation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 633, 319);//Стр4 Отношения

            //Контактное лицо при ЧП
            e.Graphics.DrawString(_f1.textBox_ChPFIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 215, 370);//ФИО
            e.Graphics.DrawString(_f1.textBox_ChPNumberMobilePhone.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 510, 370);//Домашний индекс
            e.Graphics.DrawString(_f1.textBox_ChPRelation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 308, 415);//Домашний телефон

            e.Graphics.DrawString(_f1.textBox_CountryLocation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 472, 460);//Страна нахождения заявителя


            /////////////////////////////////
            //Раздел 2
            /////////////////////////////////

            //Цель поездки в КНР
            if (_f2.checkBox_TargetOfficialVisit.Checked) e.Graphics.DrawImage(Krestik, 167, 521, 15, 15);//Официальный визит
            if (_f2.checkBox_TargetTourism.Checked) e.Graphics.DrawImage(Krestik, 167, 547, 15, 15);//Туризм
            if (_f2.checkBox_TargetBusinessTrip.Checked) e.Graphics.DrawImage(Krestik, 167, 573, 15, 15);//Неделовой визит
            if (_f2.checkBox_TargetBusiness.Checked) e.Graphics.DrawImage(Krestik, 167, 594, 15, 15);//Бизнес
            if (_f2.checkBox_TargetIntroductionOfTalent.Checked) e.Graphics.DrawImage(Krestik, 167, 617, 15, 15);//Введение талатнов
            if (_f2.checkBox_TargetCrewMember.Checked) e.Graphics.DrawImage(Krestik, 167, 639, 15, 15);//Член экипажа
            if (_f2.checkBox_TargetTransit.Checked) e.Graphics.DrawImage(Krestik, 167, 661, 15, 15);//Транзит
            if (_f2.checkBox_TargetVizit1.Checked) e.Graphics.DrawImage(Krestik, 167, 682, 15, 15);//Краткосрочный визит к гражданину КНР
            if (_f2.checkBox_TargetVizit2.Checked) e.Graphics.DrawImage(Krestik, 167, 783, 15, 15);//Краткосрочный визит к иностранному гражданину
            if (_f2.checkBox_TargetTraining1.Checked) e.Graphics.DrawImage(Krestik, 165, 855, 15, 15);//Краткосрочное обучение
            if (_f2.checkBox_TargetTraining2.Checked) e.Graphics.DrawImage(Krestik, 480, 855, 15, 15);//Долгосрочное обучение
            if (_f2.checkBox_TargetTripCorrespondents.Checked) e.Graphics.DrawImage(Krestik, 165, 891, 15, 15);//командировка корреспондентов
            if (_f2.checkBox_TargetAccreditedCorrespondents.Checked) e.Graphics.DrawImage(Krestik, 480, 891, 15, 15);//аккредитование корреспондентов 
            if (_f2.checkBox_TargetResidentDiplomat.Checked) e.Graphics.DrawImage(Krestik, 480, 522, 15, 15);//в качестве резидента дипломата
            if (_f2.checkBox_TargetPermanentResidents.Checked) e.Graphics.DrawImage(Krestik, 480, 573, 15, 15);//Постоянные резиденты
            if (_f2.checkBox_TargetJob.Checked) e.Graphics.DrawImage(Krestik, 480, 593, 15, 15);//Работа
            if (_f2.checkBox_TargetFosterFamily.Checked) e.Graphics.DrawImage(Krestik, 480, 618, 15, 15);//Приемная семья
            if (_f2.checkBox_TargetFamilyReunification.Checked) e.Graphics.DrawImage(Krestik, 480, 683, 15, 15);//Воссоединение с семьей
            if (_f2.checkBox_TargetAccompaniment.Checked) e.Graphics.DrawImage(Krestik, 480, 784, 15, 15);//сопровождающий член семьи
            if (_f2.checkBox_TargetOther.Checked)
            {
                if (string.IsNullOrEmpty(_f2.textBox_TargetOther.Text)) { MessageBox.Show("Поле " + '"' + "Цель поездки в КНР Иное " + '"' + "не заполнено"); return; }
                e.Graphics.DrawImage(Krestik, 167, 928, 15, 15);//Бизнесмен
                e.Graphics.DrawString(_f2.textBox_TargetOther.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 374, 930);//Стр4 Отношения
            }

            //Планируемое число посещений
            if (_f2.radioButton_VisitsSingle.Checked) e.Graphics.DrawImage(Krestik, 167, 953, 15, 15);
            else if (_f2.radioButton_VisitsTwice.Checked) e.Graphics.DrawImage(Krestik, 167, 971, 15, 15);
            else if (_f2.radioButton_VisitsRepeatedly.Checked) e.Graphics.DrawImage(Krestik, 167, 994, 15, 15);
            else if (_f2.radioButton_VisitsRepeatedly2.Checked) e.Graphics.DrawImage(Krestik, 167, 1016, 15, 15);
            else if (_f2.radioButton_VisitsOther.Checked)
            {
                if (string.IsNullOrEmpty(_f2.textBox_VisitsOther.Text)) { MessageBox.Show("Поле " + '"' + "Планируемое число посещений Иное " + '"' + "не заполнено"); return; }
                e.Graphics.DrawImage(Krestik, 167, 1035, 15, 15);//Крестик иное
                e.Graphics.DrawString(_f2.textBox_VisitsOther.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 380, 1035);//Текст Иное
            }

            //Обязательный сервис
            if (_f2.radioButton_ServiceYes.Checked) e.Graphics.DrawImage(Krestik, 546, 1073, 15, 15);
            else if (_f2.radioButton_ServiceNo.Checked) e.Graphics.DrawImage(Krestik, 675, 1073, 15, 15);
        }

        private void PageThree(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_3, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            e.Graphics.DrawString(_f2.textBox_ArrivalDate.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 54);//Предполагаемая дата въезда в КНР
            e.Graphics.DrawString(_f2.textBox_Tenure.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 96);//Срок пребывания каждой поездки

            //Маршрут в КНР
            e.Graphics.DrawString(_f2.textBox_RouteDataRow1.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 226, 168);//Дата стр 1
            e.Graphics.DrawString(_f2.textBox_RouteDataRow2.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 226, 211);//Дата стр 2
            e.Graphics.DrawString(_f2.textBox_RouteDataRow3.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 226, 251);//Дата стр 3
            e.Graphics.DrawString(_f2.textBox_RouteDataRow4.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 226, 293);//Дата стр 4
            e.Graphics.DrawString(_f2.textBox_RouteDataRow5.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 226, 339);//Дата стр 5
            e.Graphics.DrawString(_f2.textBox_RouteAddressRow1.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 168);//Адрес стр 1
            e.Graphics.DrawString(_f2.textBox_RouteAddressRow2.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 211);//Адрес стр 2
            e.Graphics.DrawString(_f2.textBox_RouteAddressRow3.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 251);//Адрес стр 3
            e.Graphics.DrawString(_f2.textBox_RouteAddressRow4.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 293);//Адрес стр 4
            e.Graphics.DrawString(_f2.textBox_RouteAddressRow5.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 339);//Адрес стр 5

            e.Graphics.DrawString(_f2.textBox_Costs.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 383);//Кто оплачивает расходы заявителя

            //Информация о приглашающей стороне
            e.Graphics.DrawString(_f2.textBox_InvitingName.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 370, 445);//Название
            e.Graphics.DrawString(_f2.textBox_invitingAddress.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 370, 490);//Адрес
            e.Graphics.DrawString(_f2.textBox_invitingNumber.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 370, 535);//Номер телефона
            e.Graphics.DrawString(_f2.textBox_invitingRelation.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 370, 580);//Отношения с заявителем

            e.Graphics.DrawString(_f2.textBox_PaymentOfExpenses.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 620);//Вам когда-нибудь были предоставлены китайские визы?
            e.Graphics.DrawString(_f2.textBox_OtherСountries.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 530, 685);//Были ли вы в других странах 

            //////////////////////////////
            //Раздел 3
            //////////////////////////////

            //Были ли вы в КНР
            if (_f3.radioButton_UnlawfulPresenceYes.Checked) e.Graphics.DrawImage(Krestik, 605, 788, 15, 15);
            else if (_f3.radioButton_UnlawfulPresenceNo.Checked) e.Graphics.DrawImage(Krestik, 676, 788, 15, 15);

            //Вам когда-либо отказывали
            if (_f3.radioButton_FailureYes.Checked) e.Graphics.DrawImage(Krestik, 605, 826, 15, 15);
            else if (_f3.radioButton_FailureNo.Checked) e.Graphics.DrawImage(Krestik, 676, 826, 15, 15);

            //Наличие судимости в КНР
            if (_f3.radioButton_PreviousConvictionYes.Checked) e.Graphics.DrawImage(Krestik, 605, 863, 15, 15);
            else if (_f3.radioButton_PreviousConvictionNo.Checked) e.Graphics.DrawImage(Krestik, 676, 862, 15, 15);

            //Болеете ли вы 
            if (_f3.radioButton_DiseasesYes.Checked) e.Graphics.DrawImage(Krestik, 605, 915, 15, 15);
            else if (_f3.radioButton_DiseasesNo.Checked) e.Graphics.DrawImage(Krestik, 676, 914, 15, 15);

            //Были ли вы в странах
            if (_f3.radioButton_InfectionYes.Checked) e.Graphics.DrawImage(Krestik, 605, 968, 15, 15);
            else if (_f3.radioButton_InfectionNo.Checked) e.Graphics.DrawImage(Krestik, 676, 968, 15, 15);


        }

        private void PageFour(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ListA4_4, 0, 0, e.PageBounds.Width, e.PageBounds.Height);

            e.Graphics.DrawString(_f3.textBox_Explained.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 76, 71);//Просьба дать подробные разъяснения в случае 
            e.Graphics.DrawString(_f3.textBox_MoreInfo.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 76, 202);//Если вы располагаете большей информацией

            //Если кто-то путешествует с заявителем
            e.Graphics.DrawString(_f3.textBox_ApplicantFIORow1.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 260, 434);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantFIORow2.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 446, 434);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantFIORow3.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 636, 434);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantGenderRow1.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 260, 495);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantGenderRow2.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 446, 495);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantGenderRow3.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 636, 495);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantDateOfBirthdayRow1.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 260, 526);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantDateOfBirthdayRow2.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 450, 526);//Если вы располагаете большей информацией
            e.Graphics.DrawString(_f3.textBox_ApplicantDateOfBirthdayRow3.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 636, 526);//Если вы располагаете большей информацией

            //////////////////////////////
            //Раздел 5
            //////////////////////////////

            e.Graphics.DrawString(_f4.comboBox_FIO.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 196, 923);//ФИО
            e.Graphics.DrawString(_f4.textBox_Relations.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 604, 923);//Отношения с заявителем
            e.Graphics.DrawString(_f4.textBox_Address.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 196, 965);//Адрес
            e.Graphics.DrawString(_f4.textBox_Number.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 604, 965);//Номер телефона
        }
    }
}
