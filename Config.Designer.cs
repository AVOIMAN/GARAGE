namespace GARAGE
{
    partial class Config
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
            this.button1 = new System.Windows.Forms.Button();
            this.IP_MySQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User_MySQL = new System.Windows.Forms.TextBox();
            this.Passport_MySQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IP_MySQL
            // 
            this.IP_MySQL.Location = new System.Drawing.Point(101, 49);
            this.IP_MySQL.Name = "IP_MySQL";
            this.IP_MySQL.Size = new System.Drawing.Size(200, 20);
            this.IP_MySQL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL MySQL";
            // 
            // User_MySQL
            // 
            this.User_MySQL.Location = new System.Drawing.Point(101, 75);
            this.User_MySQL.Name = "User_MySQL";
            this.User_MySQL.Size = new System.Drawing.Size(200, 20);
            this.User_MySQL.TabIndex = 3;
            // 
            // Passport_MySQL
            // 
            this.Passport_MySQL.Location = new System.Drawing.Point(101, 101);
            this.Passport_MySQL.Name = "Passport_MySQL";
            this.Passport_MySQL.Size = new System.Drawing.Size(200, 20);
            this.Passport_MySQL.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User MySQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parol MySQL";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(283, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(89, 32);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 174);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Passport_MySQL);
            this.Controls.Add(this.User_MySQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_MySQL);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IP_MySQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_MySQL;
        private System.Windows.Forms.TextBox Passport_MySQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
    }
}