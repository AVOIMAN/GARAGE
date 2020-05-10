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
    public partial class ServiceEdit : Form
    {
        private Int16 Id_service; // Id работы

        public ServiceEdit(Int16 ID)
        {
            InitializeComponent();
            Id_service = ID;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;
            MySqlDataReader _Reader;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;

            int NN;

            if (this.Id_service == 0)
            {
                // получим очередной номер
                _MySqlSelectCommand.CommandText = "SELECT IFNULL(MAX(Id_service),0) FROM service";
                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                NN = _Reader.GetInt32(0) + 1;
                this.Id_service = (short)NN;
                _Reader.Close();

            }

            _MySqlSelectCommand.CommandText = "REPLACE INTO service SET Id_service = @ID, Name = @NAME, Price = @PRICE";
            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_service);
            _MySqlSelectCommand.Parameters.AddWithValue("@PRICE", this.Price.Value);
            _MySqlSelectCommand.Parameters.AddWithValue("@NAME", this.Name.Text);

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }

        private void ServiceEdit_Load(object sender, EventArgs e)
        {
            if (this.Id_service > 0)
            {
                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Name, Price FROM service where Id_service = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_service);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Name.Text = _Reader.GetString(0);
                    this.Price.Value = _Reader.GetInt16(1);

                }
                _Reader.Close();
            }
        }
    }
}
