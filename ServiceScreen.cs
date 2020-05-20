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
    public partial class ServiceScreen : Form
    {
        public ServiceScreen()
        {
            InitializeComponent();
            this.serviceTableAdapter.Connection = Gar.MySqlCon;
        }

        private void ServiceScreen_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.garageDataSet.service);

        }

        private void AddService_Click(object sender, EventArgs e)
        {
            ServiceEdit FormServiceEdit = new ServiceEdit(0);
            FormServiceEdit.ShowDialog(this);

            this.serviceTableAdapter.Fill(this.garageDataSet.service);
        }

        private void DelService_Click(object sender, EventArgs e)
        {
            Int32 tekID;

            if ((this.ServiceBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем работу?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idserviceDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM service where Id_service = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.serviceTableAdapter.Fill(this.garageDataSet.service);
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
            Int32 tekID;
           

            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].IsNewRow == false)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["idserviceDataGridViewTextBoxColumn"].Value.ToString());

                    ServiceEdit FormServiceEdit = new ServiceEdit(tekID);
                    FormServiceEdit.ShowDialog(this);

                    this.serviceTableAdapter.Fill(this.garageDataSet.service);

                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                }

            }
        }
    }
}
