using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_V5.Forms
{
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void btnViewRoutes_Click(object sender, EventArgs e)
        {
            //..
            // code for view routes 
            //..

            this.Hide();
            FrmViewRoutes frm = new FrmViewRoutes("admin");
            frm.Show();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            //..
            // code for adding new route
            //..
            this.Hide();
            FrmAddRoute frm = new FrmAddRoute();
            frm.Show();

        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            //..
            // code for deleting route
            //..

            this.Hide();
            FrmDeleteRoute frm = new FrmDeleteRoute();
            frm.Show();
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            //..
            // code for edit route
            //..

            this.Hide();
            FrmChangePrices frm = new FrmChangePrices();
            frm.Show();
        }

        private void btnddNotice_Click(object sender, EventArgs e)
        {
            //..
            // code for adding notice
            //..

            this.Hide();
            FrmAddNotice frmAddNotice = new FrmAddNotice();
            frmAddNotice.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginPage frmLoginPage = new FrmLoginPage();
            frmLoginPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void FormAdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
