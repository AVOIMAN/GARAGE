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
        public static ArrayList StatusOrderList = new ArrayList();   //статус заказа
        public static string StatusOrderFirst = "B"; // начальный статус заказа

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

        // Получение очередного номера
        public static Int32 GetNN(string Table)
        {
            MySqlCommand _MySqlSelectCommand;
            MySqlDataReader _Reader;

            Int32 NextNN;
            Int32 CheckNN;
            int rowEffected;
            int NN;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;

            _MySqlSelectCommand.CommandText = "SET autocommit = 0";
            rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            _MySqlSelectCommand.CommandText = "SELECT Id FROM NN WHERE Tables = @TB FOR UPDATE";
            _MySqlSelectCommand.Parameters.AddWithValue("@TB", Table);

            _Reader = _MySqlSelectCommand.ExecuteReader();
            _Reader.Read();
            if (_Reader.HasRows)
            {
                CheckNN = _Reader.GetInt32(0);
            }
            else
            {
                CheckNN = 0;
            }
            _Reader.Close();
            _MySqlSelectCommand.Parameters.Clear();



            NN = CheckNN + 1;
            NextNN = NN;

            _MySqlSelectCommand.CommandText = "REPLACE INTO NN SET Id = @ID, Tables = @TABL";
            _MySqlSelectCommand.Parameters.AddWithValue("@ID", NextNN);
            _MySqlSelectCommand.Parameters.AddWithValue("@TABL", Table);

            rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            _MySqlSelectCommand.Parameters.Clear();
            _MySqlSelectCommand.CommandText = "COMMIT";
            rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            _MySqlSelectCommand.CommandText = "SET autocommit = 1";
            rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            return NextNN;
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

    public class UDCS
    {
        // Для формирования массива по UDC
        private string myKY;
        private string myDL;

        public UDCS(string strKY, string strDL)
        {

            this.myKY = strKY;
            this.myDL = strDL;
        }

        public string KY
        {
            get
            {
                return myKY;
            }
        }

        public string DL
        {

            get
            {
                return myDL;
            }
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

                //Заполним классификатор статусов заказа
                Gar.StatusOrderList.Add(new UDCS("B", "Черновик"));
                Gar.StatusOrderList.Add(new UDCS("W", "В работе"));
                Gar.StatusOrderList.Add(new UDCS("D", "Выполнен"));
                Gar.StatusOrderList.Add(new UDCS("C", "Отменен"));



            Application.Run(new MainScreen());
        }
    }
}
