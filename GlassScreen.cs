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
    public partial class GlassScreen : Form
    {
        public GlassScreen()
        {
            InitializeComponent();
            this.glassTableAdapter.Connection = Gar.MySqlCon;
        }

        private void GlassScreen_Load(object sender, EventArgs e)
        {

            this.glassTableAdapter.Fill(this.garageDataSet.glass);

        }

        private void AddGlass_Click(object sender, EventArgs e)
        {
            GlassEdit FormGlassEdit = new GlassEdit(0);
            FormGlassEdit.ShowDialog(this);

            this.glassTableAdapter.Fill(this.garageDataSet.glass);
        }

        private void DelGlass_Click(object sender, EventArgs e)
        {
            Int16 tekID;

            if ((this.GlassBindingSource.Count > 0) && (this.dataGridView1.CurrentRow != null))
            {


                if (MessageBox.Show(this, "Удаляем запчасть?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    tekID = Convert.ToInt16(this.dataGridView1.CurrentRow.Cells["idglassDataGridViewTextBoxColumn"].Value.ToString());
                    if (this.dataGridView1.CurrentRow.IsNewRow == false)
                    {
                        MySqlCommand _MySqlSelectCommand;
                        _MySqlSelectCommand = new MySqlCommand();
                        _MySqlSelectCommand.Connection = Gar.MySqlCon;
                        _MySqlSelectCommand.CommandText = "DELETE FROM glass where Id_glass = @ID";
                        _MySqlSelectCommand.Parameters.AddWithValue("@ID", tekID);
                        int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

                        this.glassTableAdapter.Fill(this.garageDataSet.glass);
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

                    tekID = Convert.ToInt16(this.dataGridView1.Rows[e.RowIndex].Cells["idglassDataGridViewTextBoxColumn"].Value.ToString());

                    GlassEdit FormGlassEdit = new GlassEdit(tekID);
                    FormGlassEdit.ShowDialog(this);

                    this.glassTableAdapter.Fill(this.garageDataSet.glass);
                }

            }
        }
    }
}
