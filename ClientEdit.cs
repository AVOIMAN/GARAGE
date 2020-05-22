using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GARAGE
{
    public partial class ClientEdit : Form
    {
        private Int32 Id_client; // Id клиента

        public ClientEdit(Int32 ID)
        {
            InitializeComponent();

            this.Id_client = ID;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;


            if (this.Id_client == 0)
            {
                // получим очередной номер
                this.Id_client = Gar.GetNN("customer");
                _MySqlSelectCommand.CommandText = "INSERT INTO customer (Id_customer, name, lastname, middlename, phone) VALUES(@ID, @NAME, @LNAME, @MNAME, @PHONE)";

            }
            else
            {
                _MySqlSelectCommand.CommandText = "UPDATE customer SET name = @NAME, lastname = @LNAME, middlename = @MNAME, phone = @PHONE WHERE Id_customer = @ID";

            }

            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_client);
            _MySqlSelectCommand.Parameters.AddWithValue("@NAME", this.Name.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@LNAME", this.LastName.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PHONE", this.Phone.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@MNAME", this.PatrName.Text);

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }

        private void ClientEdit_Load(object sender, EventArgs e)
        {
            if (this.Id_client > 0)
            {
                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT name, lastname, middlename, phone FROM customer where Id_customer = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_client);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Name.Text = _Reader.GetString(0);
                    this.LastName.Text = _Reader.GetString(1);
                    this.PatrName.Text = _Reader.GetString(2);
                    this.Phone.Text = _Reader.GetString(3);
                   
                }
                _Reader.Close();
            }
        }
    }
}
