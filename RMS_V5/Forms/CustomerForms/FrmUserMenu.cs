using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_V5.Forms.CustomerForms
{
    public partial class FrmUserMenu : Form
    {
        public FrmUserMenu()
        {
            InitializeComponent();
        }

        private void FrmUserMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewRoutes_Click(object sender, EventArgs e)
        {
            //..
            // code for view route
            //..

            this.Hide();
            FrmViewRoutes frm = new FrmViewRoutes("user");
            frm.Show();
        }

        private void btnStationSchedule_Click(object sender, EventArgs e)
        {
            //..
            // code for station schedule
            //..

            this.Hide();
            FrmStationSchedule frm = new FrmStationSchedule();
            frm.Show();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            //..
            // code for buying ticket
            //..
            this.Hide();
            FrmRoutesList frmRoutesList = new FrmRoutesList("ticket");
            frmRoutesList.Show();

        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            //..
            // code for my tickets
            //..
            this.Hide();
            FrmMyTickets frmMyTickets = new FrmMyTickets();
            frmMyTickets.Show();
        }

        private void btnBookedCargo_Click(object sender, EventArgs e)
        {
            //..
            // code for booked cargo
            //..

            this.Hide();
            FrmMyCargo frm = new FrmMyCargo();
            frm.Show();
        }

        private void btnViewNotice_Click(object sender, EventArgs e)
        {
            //..
            // code for view notice
            //..

            this.Hide();
            FrmViewNotice frm = new FrmViewNotice();
            frm.Show();
        }

        private void btnBookCargo_Click(object sender, EventArgs e)
        {
            //..
            // code
            //..

            this.Hide();
            FrmRoutesList frmMyTickets = new FrmRoutesList("cargo");
            frmMyTickets.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLoginPage frmLoginPage = new FrmLoginPage();
            frmLoginPage.Show();
        }
    }
}
