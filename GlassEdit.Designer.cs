namespace GARAGE
{
    partial class GlassEdit
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
            this.OK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Provider = new System.Windows.Forms.TextBox();
            this.Eurocode = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(16, 152);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 37);
            this.OK.TabIndex = 27;
            this.OK.Text = "Сохранить";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Еврокод";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(127, 94);
            this.Phone.MaxLength = 100;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(192, 20);
            this.Phone.TabIndex = 22;
            // 
            // Provider
            // 
            this.Provider.Location = new System.Drawing.Point(127, 68);
            this.Provider.MaxLength = 100;
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(192, 20);
            this.Provider.TabIndex = 21;
            // 
            // Eurocode
            // 
            this.Eurocode.Location = new System.Drawing.Point(127, 16);
            this.Eurocode.MaxLength = 20;
            this.Eurocode.Name = "Eurocode";
            this.Eurocode.Size = new System.Drawing.Size(192, 20);
            this.Eurocode.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(127, 43);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(120, 20);
            this.Price.TabIndex = 28;
            // 
            // GlassEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 204);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Provider);
            this.Controls.Add(this.Eurocode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GlassEdit";
            this.Text = "Редактирование запчастей";
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Provider;
        private System.Windows.Forms.TextBox Eurocode;
        private System.Windows.Forms.NumericUpDown Price;
    }
}