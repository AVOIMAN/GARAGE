namespace GARAGE
{
    partial class GlassScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GlassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.glassTableAdapter = new GARAGE.GarageDataSetTableAdapters.glassTableAdapter();
            this.idglassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eurocodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.Button();
            this.DelGlass = new System.Windows.Forms.Button();
            this.AddGlass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idglassDataGridViewTextBoxColumn,
            this.eurocodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.GlassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(175, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // GlassBindingSource
            // 
            this.GlassBindingSource.DataMember = "glass";
            this.GlassBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glassTableAdapter
            // 
            this.glassTableAdapter.ClearBeforeFill = true;
            // 
            // idglassDataGridViewTextBoxColumn
            // 
            this.idglassDataGridViewTextBoxColumn.DataPropertyName = "Id_glass";
            this.idglassDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idglassDataGridViewTextBoxColumn.Name = "idglassDataGridViewTextBoxColumn";
            this.idglassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eurocodeDataGridViewTextBoxColumn
            // 
            this.eurocodeDataGridViewTextBoxColumn.DataPropertyName = "Eurocode";
            this.eurocodeDataGridViewTextBoxColumn.HeaderText = "Еврокод";
            this.eurocodeDataGridViewTextBoxColumn.Name = "eurocodeDataGridViewTextBoxColumn";
            this.eurocodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.eurocodeDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(5, 348);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(164, 33);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DelGlass
            // 
            this.DelGlass.Location = new System.Drawing.Point(5, 40);
            this.DelGlass.Name = "DelGlass";
            this.DelGlass.Size = new System.Drawing.Size(164, 33);
            this.DelGlass.TabIndex = 8;
            this.DelGlass.Text = "Удалить запчасть";
            this.DelGlass.UseVisualStyleBackColor = true;
            this.DelGlass.Click += new System.EventHandler(this.DelGlass_Click);
            // 
            // AddGlass
            // 
            this.AddGlass.Location = new System.Drawing.Point(5, 1);
            this.AddGlass.Name = "AddGlass";
            this.AddGlass.Size = new System.Drawing.Size(164, 33);
            this.AddGlass.TabIndex = 7;
            this.AddGlass.Text = "Добавить запчасть";
            this.AddGlass.UseVisualStyleBackColor = true;
            this.AddGlass.Click += new System.EventHandler(this.AddGlass_Click);
            // 
            // GlassScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 383);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DelGlass);
            this.Controls.Add(this.AddGlass);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GlassScreen";
            this.Text = "Запчасти";
            this.Load += new System.EventHandler(this.GlassScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource GlassBindingSource;
        private GarageDataSet garageDataSet;
        private GarageDataSetTableAdapters.glassTableAdapter glassTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idglassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eurocodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DelGlass;
        private System.Windows.Forms.Button AddGlass;
    }
}