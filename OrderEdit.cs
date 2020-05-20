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
    public partial class OrderEdit : Form
    {

        private Int32 Id_order; // Id заказа
        private Boolean NewOrder; // Признак нового заказа
        private Decimal SUM_Service; // сумма работ
        private Decimal SUM_Glass; // сумма деталей
        private Decimal SUM_Order; // сумма заказа

        public OrderEdit(Int32 ID)
        {
            InitializeComponent();
            Id_order = ID;
            this.vcar1TableAdapter.Connection = Gar.MySqlCon;
            this.staffTableAdapter.Connection = Gar.MySqlCon;
            this.serviceTableAdapter.Connection = Gar.MySqlCon;
            this.order_serviceTableAdapter.Connection = Gar.MySqlCon;
            this.vglassTableAdapter.Connection = Gar.MySqlCon;
            this.order_glassTableAdapter.Connection = Gar.MySqlCon;

        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {

            this.vcar1TableAdapter.Fill(this.garageDataSet.vcar1);  // Заполним данные по списку автомобилей
            this.staffTableAdapter.Fill(this.garageDataSet.staff);  // Заполним данные по списку сотрудников
            this.serviceTableAdapter.Fill(this.garageDataSet.service);  // Заполним данные по списку работ
            this.vglassTableAdapter.Fill(this.garageDataSet.vglass); // Заполним данные по списку запчастей

            this.Status.DataSource = Gar.StatusOrderList;
            this.Status.DisplayMember = "DL";
            this.Status.ValueMember = "KY";


            if (this.Id_order > 0)
            {
                this.NewOrder = false;

                // Редактирование
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Id_car, Id_staff, Date_plan, Date_complete, Note, Status, `Sum` FROM `order` where Id_order = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_order);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.Car.SelectedValue = _Reader.GetInt32(0);
                    this.Staff.SelectedValue = _Reader.GetInt32(1);
                    this.Date_Plan.Value = _Reader.GetMySqlDateTime(2).Value;
                    this.Date_Complete.Value = _Reader.GetMySqlDateTime(3).Value;
                    this.Note.Text = _Reader.GetString(4);
                    this.Status.SelectedValue = _Reader.GetString(5);
                    this.OrderSUM.Text = _Reader.GetDecimal(6).ToString();



                }
                _Reader.Close();
            }
            else
            {
                this.NewOrder = true;

                // получим очередной номер заказа
                this.Id_order = Gar.GetNN("order");

                this.Status.SelectedValue = Gar.StatusOrderFirst;

            }


            // Заполним данные по списку работ заказа
            this.order_serviceTableAdapter.FillBy(this.garageDataSet.order_service, this.Id_order);

            // Заполним данные по списку запчастей заказа
            this.order_glassTableAdapter.FillBy(this.garageDataSet.order_glass, this.Id_order);

            CALC_ITOG();


        }

        private void CALC_ITOG()
        {
            DataGridViewCell tekCell = dataGridViewService.CurrentCell;
            Decimal Price = 0;
            Int32 Qnty = 0;
            SUM_Service = 0;
            SUM_Glass = 0;
            SUM_Order = 0;

            for (int i = 0; i < this.dataGridViewService.Rows.Count; i++)
            {

                try { Price = Convert.ToDecimal(this.dataGridViewService.Rows[i].Cells["priceDataGridViewTextBoxColumn"].Value); }
                catch { Price = 0; }

                try { Qnty = Convert.ToInt32(this.dataGridViewService.Rows[i].Cells["qntyDataGridViewTextBoxColumn"].Value); }
                catch { Qnty = 0; }

                SUM_Service = SUM_Service + Price * Qnty;
            }

            ServiceSUM.Text = SUM_Service.ToString();

            if (tekCell != null) dataGridViewService.CurrentCell = tekCell;

            tekCell = dataGridView1.CurrentCell;

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {

                try { Price = Convert.ToDecimal(this.dataGridView1.Rows[i].Cells["priceDataGridViewTextBoxColumn1"].Value); }
                catch { Price = 0; }

                try { Qnty = Convert.ToInt32(this.dataGridView1.Rows[i].Cells["qntyDataGridViewTextBoxColumn1"].Value); }
                catch { Qnty = 0; }

                SUM_Glass = SUM_Glass + Price * Qnty;
            }

            if (tekCell != null) dataGridView1.CurrentCell = tekCell;

            GlassSUM.Text = SUM_Glass.ToString();

            SUM_Order = SUM_Glass + SUM_Service;

            OrderSUM.Text = SUM_Order.ToString();

            

        }

        private void OK_Click(object sender, EventArgs e)
        {
            MySqlCommand _MySqlSelectCommand;

            _MySqlSelectCommand = new MySqlCommand();
            _MySqlSelectCommand.Connection = Gar.MySqlCon;

            Decimal _sum = 0;

            if (this.NewOrder)
            {
                _MySqlSelectCommand.CommandText = "INSERT INTO `order` (Id_order, Id_car, Id_staff, Date_plan, Date_complete, Note, Status, `Sum`) VALUES(@ID, @CAR, @STAFF, @DPLAN, @DFACT, @NOTE, @STATUS, @SUM)";
            }
            else
            {
                _MySqlSelectCommand.CommandText = "UPDATE `order` SET Id_car = @CAR, Id_staff = @STAFF, Date_plan = @DPLAN, Date_complete = @DFACT, Note = @NOTE, Status = @STATUS, `Sum` = @SUM WHERE Id_order = @ID";
            }

            _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.Id_order);
            _MySqlSelectCommand.Parameters.AddWithValue("@CAR", this.Car.SelectedValue);
            _MySqlSelectCommand.Parameters.AddWithValue("@STAFF", this.Staff.SelectedValue);
            _MySqlSelectCommand.Parameters.AddWithValue("@DPLAN", this.Date_Plan.Value);
            _MySqlSelectCommand.Parameters.AddWithValue("@DFACT", this.Date_Complete.Value);
            _MySqlSelectCommand.Parameters.AddWithValue("@NOTE", this.Note.Text);
            _MySqlSelectCommand.Parameters.AddWithValue("@STATUS", this.Status.SelectedValue);

            try { _sum = Convert.ToDecimal(this.OrderSUM.Text); }
            catch { _sum = 0; }

            _MySqlSelectCommand.Parameters.AddWithValue("@SUM", _sum);


            int rowEffected = _MySqlSelectCommand.ExecuteNonQuery();

            this.ServiceBindingSource.EndEdit();
            this.order_serviceTableAdapter.Update(this.garageDataSet.order_service);

            this.GlassBindingSource.EndEdit();
            this.order_glassTableAdapter.Update(this.garageDataSet.order_glass);


            this.Dispose();
        }

        private void dataGridViewService_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["idorderDataGridViewTextBoxColumn"].Value = this.Id_order;
        }

        private void dataGridViewService_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void dataGridViewService_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewService.Columns[e.ColumnIndex].Name == "idserviceDataGridViewTextBoxColumn") // Меняем работу
            {
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Price FROM service where Id_service = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.dataGridViewService.Rows[e.RowIndex].Cells["idserviceDataGridViewTextBoxColumn"].Value);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.dataGridViewService.Rows[e.RowIndex].Cells["priceDataGridViewTextBoxColumn"].Value =_Reader.GetInt16(0);
                }
                _Reader.Close();
            }

            CALC_ITOG();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["idorderDataGridViewTextBoxColumn1"].Value = this.Id_order;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Id_glass") // Меняем деталь
            {
                MySqlCommand _MySqlSelectCommand;
                MySqlDataReader _Reader;

                _MySqlSelectCommand = new MySqlCommand();

                _MySqlSelectCommand.Connection = Gar.MySqlCon;
                _MySqlSelectCommand.CommandText = "SELECT Price FROM glass where Id_glass = @ID";
                _MySqlSelectCommand.Parameters.AddWithValue("@ID", this.dataGridView1.Rows[e.RowIndex].Cells["Id_glass"].Value);

                _Reader = _MySqlSelectCommand.ExecuteReader();
                _Reader.Read();
                if (_Reader.HasRows)
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["priceDataGridViewTextBoxColumn1"].Value = _Reader.GetDecimal(0);
                }
                _Reader.Close();
            }

            CALC_ITOG();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.ServiceBindingSource.Count == 0) return;

            if (this.dataGridViewService.CurrentRow != null)
            {

                this.dataGridViewService.Rows.RemoveAt(this.dataGridViewService.CurrentRow.Index);
            }
        }

        private void DeleteOrderGlass_Click(object sender, EventArgs e)
        {
            if (this.ServiceBindingSource.Count == 0) return;

            if (this.dataGridView1.CurrentRow != null)
            {

                this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
            }
        }
    }
}
