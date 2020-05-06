using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GARAGE
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Запишем новые параметры
            Gar.IP_MySQL = this.IP_MySQL.Text;
            Gar.MySQL_username = this.User_MySQL.Text;
            Gar.MySQL_password = this.Passport_MySQL.Text;

            GARAGE.CurP o = new GARAGE.CurP();
            o.IP_MySQL = Gar.IP_MySQL;
            o.MySQL_username = Gar.MySQL_username;
            o.MuSQL_password = Gar.MySQL_password;

            FEServerConfig.CreateSettings(o);

            this.Dispose();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.IP_MySQL.Text = Gar.IP_MySQL;
            this.User_MySQL.Text = Gar.MySQL_username;
            this.Passport_MySQL.Text = Gar.MySQL_password;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Gar.Gar_Exit = true;
            this.Dispose();
        }
    }
}
