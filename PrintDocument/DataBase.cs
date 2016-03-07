using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PrintDocument
{
    public class Profile
    {
        public string LastName;
        public string FirstName;
        public string Gender;
        public string DateOfTime;
        public string CityRegionCountry;
        public string OrdinaryPassportNumber;
    }

    public static class DataBase
    {
        public static Form1 f1 = new Form1();



        public static void SaveToXMLFile()
        {
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
                        writer.WriteAttributeString("Gender", (f1.radioButton_GenderMan.Checked == true ? 0 : 1).ToString());
                        writer.WriteAttributeString("DateOfTime", f1.textBox_DateOfTime.Text);
                        writer.WriteAttributeString("CityRegionCountry", f1.textBox_CityRegionCountry.Text);
                        writer.WriteAttributeString("OrdinaryPassportNumber", f1.textBox_OrdinaryPassportNumber.Text);
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();

                MessageBox.Show("Анкета сохранена");
            }
            else//У нас уже есть база с анкетами, поэтому надо добавить туда новую анкету
            {
                List<Profile> profiles = GetProfilesFromXMLFile();

                if(FindMatch() == true)
                {
                    DialogResult result = MessageBox.Show("В базе обнаружена анкета с такой же фамилией, именем и датой рождения. \n Обновить анкету в базе?", "Обновить анкету в базе?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                //Добавляем новую анкету
                profiles.Add(new Profile()
                {
                    LastName = f1.TextBox_LastName.Text,
                    FirstName = f1.TextBox_FirstName.Text,
                    Gender = (f1.radioButton_GenderMan.Checked == true ? 0 : 1).ToString(),
                    DateOfTime = f1.textBox_DateOfTime.Text,
                    CityRegionCountry = f1.textBox_CityRegionCountry.Text,
                    OrdinaryPassportNumber = f1.textBox_OrdinaryPassportNumber.Text
                });

                //создаем новую базу и записываем в нее ранее полученные анкеты
                XmlTextWriter writer = new XmlTextWriter("ProfileDataBase.xml", Encoding.UTF8) { Formatting = Formatting.Indented };
                writer.WriteStartDocument();

                writer.WriteStartElement("Profiles");
                {
                    foreach (Profile item in profiles)
                    {
                        writer.WriteStartElement("Profile");
                        {
                            writer.WriteAttributeString("LastName", item.LastName);
                            writer.WriteAttributeString("FirstName", item.FirstName);
                            writer.WriteAttributeString("Gender", item.Gender);
                            writer.WriteAttributeString("DateOfTime", item.DateOfTime);
                            writer.WriteAttributeString("CityRegionCountry", item.CityRegionCountry);
                            writer.WriteAttributeString("OrdinaryPassportNumber", item.OrdinaryPassportNumber);
                        }
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
            }
        }

        //Получаем все анкеты из базы
        public static List<Profile> GetProfilesFromXMLFile()
        {
            List<Profile> profiles = new List<Profile>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ProfileDataBase.xml");
            foreach (XmlNode item in xmlDoc.DocumentElement)
            {
                string LastName = item.Attributes["LastName"].Value;
                string FirstName = item.Attributes["FirstName"].Value;
                string Gender = item.Attributes["Gender"].Value;
                string DateOfTime = item.Attributes["DateOfTime"].Value;
                string CityRegionCountry = item.Attributes["CityRegionCountry"].Value;
                string OrdinaryPassportNumber = item.Attributes["OrdinaryPassportNumber"].Value;

                profiles.Add(new Profile()
                {
                    LastName = LastName,
                    FirstName = FirstName,
                    Gender = Gender,
                    DateOfTime = DateOfTime,
                    CityRegionCountry = CityRegionCountry,
                    OrdinaryPassportNumber = OrdinaryPassportNumber
                });



                //MessageBox.Show
                //    (
                //        LastName + "\n\r" +
                //        FirstName + "\r" +
                //        Gender + "\n" +
                //        DateOfTime + "\n" +
                //        CityRegionCountry + "\n" +
                //        OrdinaryPassportNumber
                //    );
            }

            return profiles;
        }

        //Ищем в базе совпадения по фамилии и имени
        private static bool FindMatch()
        {
            List<Profile> profiles = GetProfilesFromXMLFile();
            bool result = false;

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
                    result = true;//Совпадение найдено
                    break;
                }
            }

            return result;
        }
    }
}
