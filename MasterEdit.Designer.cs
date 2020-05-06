namespace GARAGE
{
    partial class MasterEdit
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(123, 19);
            this.Name.MaxLength = 100;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(192, 20);
            this.Name.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(123, 45);
            this.Login.MaxLength = 100;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(192, 20);
            this.Login.TabIndex = 1;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(123, 71);
            this.Phone.MaxLength = 18;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(192, 20);
            this.Phone.TabIndex = 2;
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(123, 97);
            this.Passport.MaxLength = 100;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(192, 20);
            this.Passport.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(123, 123);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(105, 17);
            this.Type.TabIndex = 4;
            this.Type.Text = "Администратор";
            this.Type.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 155);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 37);
            this.OK.TabIndex = 9;
            this.OK.Text = "Сохранить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // MasterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 204);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Name);
            this.Text = "Редактирование мастера";
            this.Load += new System.EventHandler(this.MasterEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.CheckBox Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
    }
}