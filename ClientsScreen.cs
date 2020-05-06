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
    public partial class ClientsScreen : Form
    {
        public ClientsScreen()
        {
            InitializeComponent();
            this.customerTableAdapter.Connection = Gar.MySqlCon;
        }

        private void ClientsScreen_Load(object sender, EventArgs e)
        {

            this.customerTableAdapter.Fill(this.garageDataSet.customer);

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            ClientEdit FormClientEdit = new ClientEdit(0);
            FormClientEdit.ShowDialog(this);

            this.customerTableAdapter.Fill(this.garageDataSet.customer);
        }

        private void DelClient_Click(object sender, EventArgs e)
        {
            Int16 tekID;

            if ((this.ClientBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем клиента?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt16(this.dataGridView1.CurrentRow.Cells["idcustomerDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM customer where Id_customer = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.customerTableAdapter.Fill(this.garageDataSet.customer);
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

                    tekID = Convert.ToInt16(this.dataGridView1.Rows[e.RowIndex].Cells["idcustomerDataGridViewTextBoxColumn"].Value.ToString());

                    ClientEdit FormClientEdit = new ClientEdit(tekID);
                    FormClientEdit.ShowDialog(this);

                    this.customerTableAdapter.Fill(this.garageDataSet.customer);
                }

            }
        }
    }
}
