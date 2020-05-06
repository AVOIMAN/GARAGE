namespace GARAGE
{
    partial class ClientsScreen
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
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.customerTableAdapter = new GARAGE.GarageDataSetTableAdapters.customerTableAdapter();
            this.Exit = new System.Windows.Forms.Button();
            this.DelClient = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
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
            this.idcustomerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ClientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(175, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "Id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            this.idcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middlenameDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataMember = "customer";
            this.ClientBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(5, 348);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(164, 33);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DelClient
            // 
            this.DelClient.Location = new System.Drawing.Point(5, 40);
            this.DelClient.Name = "DelClient";
            this.DelClient.Size = new System.Drawing.Size(164, 33);
            this.DelClient.TabIndex = 5;
            this.DelClient.Text = "Удалить клиента";
            this.DelClient.UseVisualStyleBackColor = true;
            this.DelClient.Click += new System.EventHandler(this.DelClient_Click);
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(5, 1);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(164, 33);
            this.AddClient.TabIndex = 4;
            this.AddClient.Text = "Добавить клиента";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ClientsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 383);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DelClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientsScreen";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private GarageDataSet garageDataSet;
        private GarageDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DelClient;
        private System.Windows.Forms.Button AddClient;
    }
}