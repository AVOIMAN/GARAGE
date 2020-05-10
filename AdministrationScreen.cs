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
    public partial class AdministrationScreen : Form
    {
        public AdministrationScreen()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Masters_Click(object sender, EventArgs e)
        {
            MastersScreen FormMaster = new MastersScreen();
            FormMaster.ShowDialog(this);
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            ClientsScreen FormClientsScreen = new ClientsScreen();
            FormClientsScreen.ShowDialog(this);
        }

        private void Glass_Click(object sender, EventArgs e)
        {
            GlassScreen FormGlassScreeen = new GlassScreen();
            FormGlassScreeen.ShowDialog(this);
        }

        private void Service_Click(object sender, EventArgs e)
        {
            ServiceScreen FormServiceScreeen = new ServiceScreen();
            FormServiceScreeen.ShowDialog(this);
        }
    }
}
