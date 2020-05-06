using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Management;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GARAGE
{

    public static class Gar
    {
        public static string IP_MySQL; // адрес сервера
        public static string MySQL_username; // имя пользователя 
        public static string MySQL_password; // пароль пользователя 
        public static MySqlConnection MySqlCon;
        public static Boolean Gar_Exit;
        public static string Staff_Type; // тип сотрудника 0 - рабочий, 1 - админ

        public static bool DBConnectionStatus()
        {
            try
            {

                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Name FROM staff";

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    _Reader.Close();
                    return true;
                }
                else
                {
                    _Reader.Close();
                    return false;
                }


            }
            catch
            {
                return false;
            }
        }
    }

    //структура для хранения сохраняемой в файл инфы
    public struct CurP
    {
        public string IP_MySQL;       // адрес MySQL сервера 
        public string MySQL_username; // имя пользователя 
        public string MuSQL_password; // пароль пользователя 

    }

    public class FEServerConfig
    {
        //Лишаем возможности создавать объекты этого класса
        private FEServerConfig() { }
        public static void CreateSettings(object o)
        {
            XmlSerializer myXmlSer = new XmlSerializer(o.GetType());
            StreamWriter myWriter = new StreamWriter(Application.StartupPath + @"\Garage.config");
            myXmlSer.Serialize(myWriter, o);
            myWriter.Close();
        }

        public static void LoadSettings(ref GARAGE.CurP o)
        {
            XmlSerializer myXmlSer = new XmlSerializer(typeof(GARAGE.CurP));
            FileStream mySet = new FileStream(Application.StartupPath + @"\Garage.config", FileMode.Open);
            o = (GARAGE.CurP)myXmlSer.Deserialize(mySet);
            mySet.Close();
        }


    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Boolean YesConn;

            Gar.Gar_Exit = false;

            /// Получим параметры
            GARAGE.CurP o = new GARAGE.CurP();

            if (File.Exists(Application.StartupPath + @"\Garage.config"))
            {
                FEServerConfig.LoadSettings(ref o);
                Gar.IP_MySQL = o.IP_MySQL; // адрес сервера
                Gar.MySQL_username = o.MySQL_username; // имя пользователя
                Gar.MySQL_password = o.MuSQL_password; // пароль пользователя
            }
            else
            {
                // не найден файл параметров, будем создавать
                Gar.IP_MySQL = ""; // адрес сервера
                Gar.MySQL_username = ""; // имя пользователя
                Gar.MySQL_password = ""; // пароль пользователя

                Config FormConfig = new Config();
                FormConfig.ShowDialog();

            }

            Gar.MySqlCon = new MySqlConnection();
            YesConn = false;

            // Будем запрашивать конфигурацию сервера БД пока не подключимся или не выйдем
            while ((YesConn == false) && (Gar.Gar_Exit != true))
            {

                try
                {

                    Gar.MySqlCon.ConnectionString = "database=garage;server=" + Gar.IP_MySQL + ";Username=" + Gar.MySQL_username + ";pwd=" + Gar.MySQL_password;
                    Gar.MySqlCon.Open();


                    if (Gar.DBConnectionStatus() == false)
                    {
                        YesConn = false;
                    }
                    else
                    {
                        YesConn = true;
                    }

                }
                catch
                {
                    YesConn = false;
                }

                if (!YesConn)
                {
                    Config FormConfig = new Config();
                    FormConfig.ShowDialog();
                }

            }

            // Авторизация
            AuthScreen FormAuth = new AuthScreen();
            FormAuth.ShowDialog();

            if (!Gar.Gar_Exit)

            Application.Run(new MainScreen());
        }
    }
}
