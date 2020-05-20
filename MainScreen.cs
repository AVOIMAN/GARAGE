using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GARAGE
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (Gar.Staff_Type != "1")
                this.Admin.Enabled = false;
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdministrationScreen FormAdministration = new AdministrationScreen();
            FormAdministration.ShowDialog(this);

        }

        private void Work_Click(object sender, EventArgs e)
        {
            OrderScreen FormOrderScreen = new OrderScreen();
            FormOrderScreen.ShowDialog(this);
        }
    }
}
