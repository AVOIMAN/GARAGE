using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GARAGE
{
    public partial class MasterEdit : Form
    {
        private Int32 Id_master; // Id Мастера

        public MasterEdit(Int32 ID)
        {
            InitializeComponent();

            this.Id_master = ID;

        }

        private void MasterEdit_Load(object sender, EventArgs e)
        {
            string strType;

            if (this.Id_master > 0)
            {
                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Name, Login, Phone, Password, Type FROM staff where Id_staff = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_master);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Name.Text = _Reader.GetString(0);
                    this.Login.Text = _Reader.GetString(1);
                    this.Phone.Text = _Reader.GetString(2);
                    this.Passport.Text = _Reader.GetString(3);
                    strType = _Reader.GetString(4);

                    if (strType == "1") this.Type.Checked = true;
                    else this.Type.Checked = false;

                }
                _Reader.Close();
            }
            else
            {
                // новая запись
                this.Type.Checked = false;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;


            if (this.Id_master == 0)
            {
                // получим очередной номер
                this.Id_master = Gar.GetNN("staff");
                _MySqlSelectCommand.CommandText = "REPLACE INTO staff SET Id_staff = @ID, Name = @NAME, Login = @LOGIN, Phone = @PHONE, Password = @PAW, Type = @TYPE";

            }
            else
            {
                _MySqlSelectCommand.CommandText = "UPDATE staff SET Name = @NAME, Login = @LOGIN, Phone = @PHONE, Password = @PAW, Type = @TYPE WHERE Id_staff = @ID";

            }

            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_master);
            _MySqlSelectCommand.Parameters.AddWithValue("@NAME", this.Name.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@LOGIN", this.Login.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PHONE", this.Phone.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PAW", this.Passport.Text);
            if (this.Type.Checked) _MySqlSelectCommand.Parameters.AddWithValue("@TYPE", "1");
            else _MySqlSelectCommand.Parameters.AddWithValue("@TYPE", "0");

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }
    }
}
