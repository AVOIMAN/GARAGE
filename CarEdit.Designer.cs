namespace GARAGE
{
    partial class CarEdit
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
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Gov_numb = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.ComboBox();
            this.vcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageDataSet = new GARAGE.GarageDataSet();
            this.vcustomerTableAdapter = new GARAGE.GarageDataSetTableAdapters.vcustomerTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(13, 148);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 37);
            this.OK.TabIndex = 35;
            this.OK.Text = "Сохранить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Марка";
            // 
            // Brand
            // 
            this.Brand.Location = new System.Drawing.Point(124, 12);
            this.Brand.MaxLength = 200;
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(192, 20);
            this.Brand.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Модель";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(124, 38);
            this.Model.MaxLength = 200;
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(192, 20);
            this.Model.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Гос.номер";
            // 
            // Gov_numb
            // 
            this.Gov_numb.Location = new System.Drawing.Point(124, 64);
            this.Gov_numb.MaxLength = 9;
            this.Gov_numb.Name = "Gov_numb";
            this.Gov_numb.Size = new System.Drawing.Size(192, 20);
            this.Gov_numb.TabIndex = 38;
            // 
            // Customer
            // 
            this.Customer.DataSource = this.vcustomerBindingSource;
            this.Customer.DisplayMember = "fullname";
            this.Customer.FormattingEnabled = true;
            this.Customer.Location = new System.Drawing.Point(124, 90);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(192, 21);
            this.Customer.TabIndex = 40;
            this.Customer.ValueMember = "Id_customer";
            // 
            // vcustomerBindingSource
            // 
            this.vcustomerBindingSource.DataMember = "vcustomer";
            this.vcustomerBindingSource.DataSource = this.garageDataSet;
            // 
            // garageDataSet
            // 
            this.garageDataSet.DataSetName = "GarageDataSet";
            this.garageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vcustomerTableAdapter
            // 
            this.vcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Владелец";
            // 
            // CarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gov_numb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brand);
            this.Name = "CarEdit";
            this.Text = "Редактирование автомобиля";
            this.Load += new System.EventHandler(this.CarEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Gov_numb;
        private System.Windows.Forms.ComboBox Customer;
        private GarageDataSet garageDataSet;
        private System.Windows.Forms.BindingSource vcustomerBindingSource;
        private GarageDataSetTableAdapters.vcustomerTableAdapter vcustomerTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}