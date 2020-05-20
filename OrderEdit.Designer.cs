namespace GARAGE
{
    partial class OrderEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.ComboBox();
            this.vcarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.Staff = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Date_Plan = new System.Windows.Forms.DateTimePicker();
            this.Date_Complete = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ServiceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id_staff = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qntyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new GARAGE.GarageDataSetTableAdapters.staffTableAdapter();
            this.vcar1TableAdapter = new GARAGE.GarageDataSetTableAdapters.vcar1TableAdapter();
            this.order_serviceTableAdapter = new GARAGE.GarageDataSetTableAdapters.order_serviceTableAdapter();
            this.serviceTableAdapter = new GARAGE.GarageDataSetTableAdapters.serviceTableAdapter();
            this.ServiceSUM = new System.Windows.Forms.TextBox();
            this.OrderSUM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GlassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_glassTableAdapter = new GARAGE.GarageDataSetTableAdapters.order_glassTableAdapter();
            this.GlassListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vglassTableAdapter = new GARAGE.GarageDataSetTableAdapters.vglassTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_glass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qntyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.GlassSUM = new System.Windows.Forms.TextBox();
            this.MenuOrderService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOrderGlass = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteOrderGlass = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vcarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuOrderService.SuspendLayout();
            this.MenuOrderGlass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Автомобиль";
            // 
            // Car
            // 
            this.Car.DataSource = this.vcarBindingSource;
            this.Car.DisplayMember = "car_name";
            this.Car.FormattingEnabled = true;
            this.Car.Location = new System.Drawing.Point(140, 62);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(200, 21);
            this.Car.TabIndex = 2;
            this.Car.ValueMember = "Id_car";
            // 
            // vcarBindingSource
            // 
            this.vcarBindingSource.DataMember = "vcar1";
            this.vcarBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Мастер";
            // 
            // Staff
            // 
            this.Staff.DataSource = this.staffBindingSource;
            this.Staff.DisplayMember = "Name";
            this.Staff.FormattingEnabled = true;
            this.Staff.Location = new System.Drawing.Point(140, 86);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(200, 21);
            this.Staff.TabIndex = 3;
            this.Staff.ValueMember = "Id_staff";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.garageDataSet;
            // 
            // Date_Plan
            // 
            this.Date_Plan.CustomFormat = "dd.MM.yyyy HH:MM";
            this.Date_Plan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Plan.Location = new System.Drawing.Point(140, 16);
            this.Date_Plan.Name = "Date_Plan";
            this.Date_Plan.Size = new System.Drawing.Size(121, 20);
            this.Date_Plan.TabIndex = 0;
            // 
            // Date_Complete
            // 
            this.Date_Complete.CustomFormat = "dd.MM.yyyy HH:MM";
            this.Date_Complete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Complete.Location = new System.Drawing.Point(140, 37);
            this.Date_Complete.Name = "Date_Complete";
            this.Date_Complete.Size = new System.Drawing.Size(121, 20);
            this.Date_Complete.TabIndex = 1;
            this.Date_Complete.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Дата, время план";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Дата, время факт";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(411, 15);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(200, 21);
            this.Status.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Статус";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(411, 62);
            this.Note.MaxLength = 200;
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(377, 71);
            this.Note.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Примечание";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(666, 431);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 37);
            this.OK.TabIndex = 8;
            this.OK.Text = "Сохранить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToOrderColumns = true;
            this.dataGridViewService.AutoGenerateColumns = false;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.idserviceDataGridViewTextBoxColumn,
            this.Id_staff,
            this.qntyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewService.ContextMenuStrip = this.MenuOrderService;
            this.dataGridViewService.DataSource = this.ServiceBindingSource;
            this.dataGridViewService.Location = new System.Drawing.Point(140, 157);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.Size = new System.Drawing.Size(648, 138);
            this.dataGridViewService.TabIndex = 6;
            this.dataGridViewService.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellValueChanged);
            this.dataGridViewService.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewService_DataError);
            this.dataGridViewService.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewService_DefaultValuesNeeded);
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "Id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Id_order";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.Visible = false;
            this.idorderDataGridViewTextBoxColumn.Width = 80;
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.DataSource = this.ServiceListBindingSource;
            this.idserviceDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idserviceDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "Работа";
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idserviceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idserviceDataGridViewTextBoxColumn.ValueMember = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.Width = 220;
            // 
            // ServiceListBindingSource
            // 
            this.ServiceListBindingSource.DataMember = "service";
            this.ServiceListBindingSource.DataSource = this.garageDataSet;
            // 
            // Id_staff
            // 
            this.Id_staff.DataPropertyName = "Id_staff";
            this.Id_staff.DataSource = this.staffBindingSource;
            this.Id_staff.DisplayMember = "Name";
            this.Id_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Id_staff.HeaderText = "Сотрудник";
            this.Id_staff.Name = "Id_staff";
            this.Id_staff.ValueMember = "Id_staff";
            this.Id_staff.Width = 220;
            // 
            // qntyDataGridViewTextBoxColumn
            // 
            this.qntyDataGridViewTextBoxColumn.DataPropertyName = "Qnty";
            this.qntyDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.qntyDataGridViewTextBoxColumn.Name = "qntyDataGridViewTextBoxColumn";
            this.qntyDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // ServiceBindingSource
            // 
            this.ServiceBindingSource.DataMember = "order_service";
            this.ServiceBindingSource.DataSource = this.garageDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // vcar1TableAdapter
            // 
            this.vcar1TableAdapter.ClearBeforeFill = true;
            // 
            // order_serviceTableAdapter
            // 
            this.order_serviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceSUM
            // 
            this.ServiceSUM.Location = new System.Drawing.Point(17, 173);
            this.ServiceSUM.Name = "ServiceSUM";
            this.ServiceSUM.ReadOnly = true;
            this.ServiceSUM.Size = new System.Drawing.Size(111, 20);
            this.ServiceSUM.TabIndex = 56;
            this.ServiceSUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrderSUM
            // 
            this.OrderSUM.Location = new System.Drawing.Point(140, 113);
            this.OrderSUM.Name = "OrderSUM";
            this.OrderSUM.ReadOnly = true;
            this.OrderSUM.Size = new System.Drawing.Size(200, 20);
            this.OrderSUM.TabIndex = 57;
            this.OrderSUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Перечень работ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Стоимость заказа:";
            // 
            // GlassBindingSource
            // 
            this.GlassBindingSource.DataMember = "order_glass";
            this.GlassBindingSource.DataSource = this.garageDataSet;
            // 
            // order_glassTableAdapter
            // 
            this.order_glassTableAdapter.ClearBeforeFill = true;
            // 
            // GlassListBindingSource
            // 
            this.GlassListBindingSource.DataMember = "vglass";
            this.GlassListBindingSource.DataSource = this.garageDataSet;
            // 
            // vglassTableAdapter
            // 
            this.vglassTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn1,
            this.Id_glass,
            this.qntyDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView1.ContextMenuStrip = this.MenuOrderGlass;
            this.dataGridView1.DataSource = this.GlassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(140, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // idorderDataGridViewTextBoxColumn1
            // 
            this.idorderDataGridViewTextBoxColumn1.DataPropertyName = "Id_order";
            this.idorderDataGridViewTextBoxColumn1.HeaderText = "Id_order";
            this.idorderDataGridViewTextBoxColumn1.Name = "idorderDataGridViewTextBoxColumn1";
            this.idorderDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Id_glass
            // 
            this.Id_glass.DataPropertyName = "Id_glass";
            this.Id_glass.DataSource = this.GlassListBindingSource;
            this.Id_glass.DisplayMember = "Name";
            this.Id_glass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Id_glass.HeaderText = "Наименование";
            this.Id_glass.Name = "Id_glass";
            this.Id_glass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_glass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Id_glass.ValueMember = "Id_glass";
            this.Id_glass.Width = 220;
            // 
            // qntyDataGridViewTextBoxColumn1
            // 
            this.qntyDataGridViewTextBoxColumn1.DataPropertyName = "Qnty";
            this.qntyDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.qntyDataGridViewTextBoxColumn1.Name = "qntyDataGridViewTextBoxColumn1";
            this.qntyDataGridViewTextBoxColumn1.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Перечень запчастей";
            // 
            // GlassSUM
            // 
            this.GlassSUM.Location = new System.Drawing.Point(17, 334);
            this.GlassSUM.Name = "GlassSUM";
            this.GlassSUM.ReadOnly = true;
            this.GlassSUM.Size = new System.Drawing.Size(111, 20);
            this.GlassSUM.TabIndex = 63;
            this.GlassSUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MenuOrderService
            // 
            this.MenuOrderService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.MenuOrderService.Name = "MenuOrderService";
            this.MenuOrderService.Size = new System.Drawing.Size(119, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 22);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // MenuOrderGlass
            // 
            this.MenuOrderGlass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteOrderGlass});
            this.MenuOrderGlass.Name = "MenuOrderGlass";
            this.MenuOrderGlass.Size = new System.Drawing.Size(119, 26);
            // 
            // DeleteOrderGlass
            // 
            this.DeleteOrderGlass.Name = "DeleteOrderGlass";
            this.DeleteOrderGlass.Size = new System.Drawing.Size(180, 22);
            this.DeleteOrderGlass.Text = "Удалить";
            this.DeleteOrderGlass.Click += new System.EventHandler(this.DeleteOrderGlass_Click);
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.GlassSUM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OrderSUM);
            this.Controls.Add(this.ServiceSUM);
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_Complete);
            this.Controls.Add(this.Date_Plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Car);
            this.Name = "OrderEdit";
            this.Text = "Редактирование заказа";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vcarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuOrderService.ResumeLayout(false);
            this.MenuOrderGlass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Staff;
        private GarageDataSet garageDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private GarageDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DateTimePicker Date_Plan;
        private System.Windows.Forms.DateTimePicker Date_Complete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.BindingSource vcarBindingSource;
        private GarageDataSetTableAdapters.vcar1TableAdapter vcar1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.BindingSource ServiceBindingSource;
        private GarageDataSetTableAdapters.order_serviceTableAdapter order_serviceTableAdapter;
        private System.Windows.Forms.BindingSource ServiceListBindingSource;
        private GarageDataSetTableAdapters.serviceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.TextBox ServiceSUM;
        private System.Windows.Forms.TextBox OrderSUM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Id_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource GlassBindingSource;
        private GarageDataSetTableAdapters.order_glassTableAdapter order_glassTableAdapter;
        private System.Windows.Forms.BindingSource GlassListBindingSource;
        private GarageDataSetTableAdapters.vglassTableAdapter vglassTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Id_glass;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GlassSUM;
        private System.Windows.Forms.ContextMenuStrip MenuOrderService;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ContextMenuStrip MenuOrderGlass;
        private System.Windows.Forms.ToolStripMenuItem DeleteOrderGlass;
    }
}