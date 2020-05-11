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
    public partial class CarEdit : Form
    {
        private Int16 Id_car; // Id машины

        public CarEdit(Int16 ID)
        {
            InitializeComponent();
            Id_car = ID;
            this.vcustomerTableAdapter.Connection = Gar.MySqlCon;
        }

        private void CarEdit_Load(object sender, EventArgs e)
        {

            this.vcustomerTableAdapter.Fill(this.garageDataSet.vcustomer);

            if (this.Id_car > 0)
            {
                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Brand, Model, Gov_numb, Id_customer FROM car where Id_car = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_car);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Brand.Text = _Reader.GetString(0);
                    this.Model.Text = _Reader.GetString(1);
                    this.Gov_numb.Text = _Reader.GetString(2);
                    this.Customer.SelectedValue = _Reader.GetInt16(3);

                }
                _Reader.Close();
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;
            MySqlDataReader _Reader;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;

            int NN;

            if (this.Id_car == 0)
            {
                // получим очередной номер
                _MySqlSelectCommand.CommandText = "SELECT IFNULL(MAX(Id_car),0) FROM car";
                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                NN = _Reader.GetInt32(0) + 1;
                this.Id_car = (short)NN;
                _Reader.Close();

            }

            _MySqlSelectCommand.CommandText = "REPLACE INTO car SET Id_car = @ID, Brand = @BRAND, Model = @MODEL, Gov_numb = @GOV, Id_customer = @CUSTOMER";
            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_car);
            _MySqlSelectCommand.Parameters.AddWithValue("@BRAND", this.Brand.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@MODEL", this.Model.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@GOV", this.Gov_numb.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@CUSTOMER", this.Customer.SelectedValue);
            

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }
    }
}
