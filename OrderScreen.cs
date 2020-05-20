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
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();
            this.vorderTableAdapter.Connection = Gar.MySqlCon;
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {

            this.vorderTableAdapter.Fill(this.garageDataSet.vorder);

        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            OrderEdit FormOrderEdit = new OrderEdit(0);
            FormOrderEdit.ShowDialog(this);

            this.vorderTableAdapter.Fill(this.garageDataSet.vorder);
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            Int32 tekID;

            if ((this.vorderBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Отменяем заказ?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idorderDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "UPDATE `order` SET Status = 'C' where Id_order = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.vorderTableAdapter.Fill(this.garageDataSet.vorder);
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

                    tekID = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["idorderDataGridViewTextBoxColumn"].Value.ToString());

                    OrderEdit FormOrderEdit = new OrderEdit(tekID);
                    FormOrderEdit.ShowDialog(this);

                    this.vorderTableAdapter.Fill(this.garageDataSet.vorder);
                    
                     dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0]; 


                }

            }
        }
    }
}
