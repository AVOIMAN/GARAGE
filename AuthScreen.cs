using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GARAGE
{
    public partial class AuthScreen : Form
    {
        public AuthScreen()
        {
            InitializeComponent();
        }

        private void Autorization_Click(object sender, EventArgs e)
        {
            // Проверим что есть такой сотрудник и получим его тип

            MySqlCommand _MySqlSelectCommand;
            MySqlDataReader _Reader;

            _MySqlSelectCommand = new MySqlCommand();

            _MySqlSelectCommand.Connection = Gar.MySqlCon;
            _MySqlSelectCommand.CommandText = "SELECT Type FROM staff where Login = @CODE and Password = @PWD";
            _MySqlSelectCommand.Parameters.AddWithValue("@CODE", this.UserName.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PWD", this.Passport.Text);

            _Reader = _MySqlSelectCommand.ExecuteReader();
            _Reader.Read();
            if (_Reader.HasRows)
            {
                Gar.Staff_Type = _Reader.GetString(0);
                _Reader.Close();
                Gar.Gar_Exit = false;
                this.Dispose();
            }
            else
            {
                this.NotFinde.Visible = true;
                _Reader.Close();
            }
            



        }

        private void AuthScreen_Load(object sender, EventArgs e)
        {
            this.NotFinde.Visible = false;
            Gar.Gar_Exit = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
