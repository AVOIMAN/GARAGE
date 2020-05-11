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
    public partial class CarScreen : Form
    {
        public CarScreen()
        {
            InitializeComponent();
            this.vcarTableAdapter.Connection = Gar.MySqlCon;
        }

        private void CarScreen_Load(object sender, EventArgs e)
        {
            this.vcarTableAdapter.Fill(this.garageDataSet.vcar);

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            CarEdit FormCarEdit = new CarEdit(0);
            FormCarEdit.ShowDialog(this);

            this.vcarTableAdapter.Fill(this.garageDataSet.vcar);
        }

        private void DelCar_Click(object sender, EventArgs e)
        {
            Int16 tekID;

            if ((this.CarBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем автомобиль?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt16(this.dataGridView1.CurrentRow.Cells["idcarDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM car where Id_car = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.vcarTableAdapter.Fill(this.garageDataSet.vcar);
                    }

                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int16 tekID;

            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].IsNewRow == false)
                {

                    tekID = Convert.ToInt16(this.dataGridView1.Rows[e.RowIndex].Cells["idcarDataGridViewTextBoxColumn"].Value.ToString());

                    CarEdit FormCarEdit = new CarEdit(tekID);
                    FormCarEdit.ShowDialog(this);

                    this.vcarTableAdapter.Fill(this.garageDataSet.vcar);
                }

            }
        }
    }
}
