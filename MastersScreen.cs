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
    public partial class MastersScreen : Form
    {
        public MastersScreen()
        {
            InitializeComponent();
            this.staffTableAdapter.Connection = Gar.MySqlCon;
        }

        private void MastersScreen_Load(object sender, EventArgs e)
        {

            this.staffTableAdapter.Fill(this.garageDataSet.staff);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 tekID;
            
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.Rows[e.RowIndex].IsNewRow == false)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["idstaffDataGridViewTextBoxColumn"].Value.ToString());

                    MasterEdit FormMasterEdit = new MasterEdit(tekID);
                    FormMasterEdit.ShowDialog(this);

                    this.staffTableAdapter.Fill(this.garageDataSet.staff);
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                }

            }
        }

        private void AddMaster_Click(object sender, EventArgs e)
        {
            MasterEdit FormMasterEdit = new MasterEdit(0);
            FormMasterEdit.ShowDialog(this);

            this.staffTableAdapter.Fill(this.garageDataSet.staff);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DelMaster_Click(object sender, EventArgs e)
        {

            Int32 tekID;

            if ((this.staffBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем мастера?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idstaffDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM staff where Id_staff = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.staffTableAdapter.Fill(this.garageDataSet.staff);
                    }

                }
            }


        }
    }
}
