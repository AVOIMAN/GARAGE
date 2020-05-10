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
    public partial class GlassEdit : Form
    {
        private Int16 Id_glass; // Id детали

        public GlassEdit(Int16 ID)
        {
            InitializeComponent();

            Id_glass = ID;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;
            MySqlDataReader _Reader;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;

            int NN;

            if (this.Id_glass == 0)
            {
                // получим очередной номер
                _MySqlSelectCommand.CommandText = "SELECT IFNULL(MAX(Id_glass),0) FROM glass";
                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                NN = _Reader.GetInt32(0) + 1;
                this.Id_glass = (short)NN;
                _Reader.Close();

            }

            _MySqlSelectCommand.CommandText = "REPLACE INTO glass SET Id_glass = @ID, Name = @NAME, Price = @PRICE, Provider = @PROVIDER, Eurocode = @CODE";
            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_glass);
            _MySqlSelectCommand.Parameters.AddWithValue("@NAME", this.Name.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@PRICE", this.Price.Value);
            _MySqlSelectCommand.Parameters.AddWithValue("@PROVIDER", this.Provider.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@CODE", this.Eurocode.Text);

            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.Dispose();
        }

        private void GlassEdit_Load(object sender, EventArgs e)
        {
            if (this.Id_glass > 0)
            {
                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Name, Price, Eurocode, Provider FROM glass where Id_glass = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_glass);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Name.Text = _Reader.GetString(0);
                    this.Price.Value = _Reader.GetInt16(1);
                    this.Eurocode.Text = _Reader.GetString(2);
                    this.Provider.Text = _Reader.GetString(3);
                    
                }
                _Reader.Close();
            }
        }
    }
}
