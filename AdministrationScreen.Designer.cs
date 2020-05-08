namespace GARAGE
{
    partial class AdministrationScreen
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
            this.Return = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Masters = new System.Windows.Forms.Button();
            this.Glass = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.Button();
            this.Car = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(34, 11);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(344, 54);
            this.Return.TabIndex = 0;
            this.Return.Text = "Назад";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(34, 71);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(344, 54);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Masters
            // 
            this.Masters.Location = new System.Drawing.Point(34, 131);
            this.Masters.Name = "Masters";
            this.Masters.Size = new System.Drawing.Size(344, 54);
            this.Masters.TabIndex = 2;
            this.Masters.Text = "Мастера";
            this.Masters.UseVisualStyleBackColor = true;
            this.Masters.Click += new System.EventHandler(this.Masters_Click);
            // 
            // Glass
            // 
            this.Glass.Location = new System.Drawing.Point(34, 191);
            this.Glass.Name = "Glass";
            this.Glass.Size = new System.Drawing.Size(344, 54);
            this.Glass.TabIndex = 3;
            this.Glass.Text = "Запчасти";
            this.Glass.UseVisualStyleBackColor = true;
            this.Glass.Click += new System.EventHandler(this.Glass_Click);
            // 
            // Service
            // 
            this.Service.Location = new System.Drawing.Point(34, 251);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(344, 54);
            this.Service.TabIndex = 4;
            this.Service.Text = "Работы";
            this.Service.UseVisualStyleBackColor = true;
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(34, 311);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(344, 54);
            this.Car.TabIndex = 5;
            this.Car.Text = "Автомобили";
            this.Car.UseVisualStyleBackColor = true;
            // 
            // AdministrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 380);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.Glass);
            this.Controls.Add(this.Masters);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministrationScreen";
            this.Text = "Администрирование";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Masters;
        private System.Windows.Forms.Button Glass;
        private System.Windows.Forms.Button Service;
        private System.Windows.Forms.Button Car;
    }
}