namespace GARAGE
{
    partial class AuthScreen
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Autorization = new System.Windows.Forms.Button();
            this.NotFinde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(108, 18);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(227, 20);
            this.UserName.TabIndex = 0;
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(108, 44);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(227, 20);
            this.Passport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // Autorization
            // 
            this.Autorization.Location = new System.Drawing.Point(41, 96);
            this.Autorization.Name = "Autorization";
            this.Autorization.Size = new System.Drawing.Size(294, 41);
            this.Autorization.TabIndex = 4;
            this.Autorization.Text = "Авторизация";
            this.Autorization.UseVisualStyleBackColor = true;
            this.Autorization.Click += new System.EventHandler(this.Autorization_Click);
            // 
            // NotFinde
            // 
            this.NotFinde.AutoSize = true;
            this.NotFinde.Location = new System.Drawing.Point(46, 79);
            this.NotFinde.Name = "NotFinde";
            this.NotFinde.Size = new System.Drawing.Size(134, 13);
            this.NotFinde.TabIndex = 5;
            this.NotFinde.Text = "Пользователь не найден";
            // 
            // AuthScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 160);
            this.Controls.Add(this.NotFinde);
            this.Controls.Add(this.Autorization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthScreen";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Autorization;
        private System.Windows.Forms.Label NotFinde;
    }
}