using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_V5.Forms.CustomerForms;
using RMS_V5.DL;
using RMS_V5.BL;

namespace RMS_V5.Forms.CustomerForms
{
    public partial class FrmRoutesList : Form
    {
        private string work;
        public FrmRoutesList(string work)
        {
            InitializeComponent();
            this.work = work;
        }

        private void FrmRoutesList_Load(object sender, EventArgs e)
        {
            gvRoutes.DataSource = RouteDL.RouteList;
            if (work == "ticket")
            {
                gvRoutes.Columns["cargoPrice"].Visible = false;
            }
            else if(work == "cargo")
            {
                gvRoutes.Columns["ticketPrice"].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frmUserMenu = new FrmUserMenu();
            frmUserMenu.Show();
        }

        private void gvRoutes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Route route = (Route)gvRoutes.CurrentRow.DataBoundItem;

            this.Close();
            if (work == "ticket")
            {
                FrmBuyTicket frmBuyTicket = new FrmBuyTicket(route);
                frmBuyTicket.Show();
            }
            else if(work == "cargo")
            {
                FrmBookCargo frm = new FrmBookCargo(route);
                frm.Show();
            }
        }
    }
}
