namespace GARAGE
{
    partial class MainScreen
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
            this.Admin = new System.Windows.Forms.Button();
            this.Work = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(28, 10);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(396, 55);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Администрирование";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Work
            // 
            this.Work.Location = new System.Drawing.Point(28, 71);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(396, 55);
            this.Work.TabIndex = 1;
            this.Work.Text = "Автомобили на ремонте";
            this.Work.UseVisualStyleBackColor = true;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 144);
            this.Controls.Add(this.Work);
            this.Controls.Add(this.Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "Управление автосервисом";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Work;
    }
}