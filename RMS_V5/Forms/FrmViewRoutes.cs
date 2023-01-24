using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_V5.DL;
using RMS_V5.BL;
using RMS_V5.Forms.CustomerForms;

namespace RMS_V5.Forms
{
    public partial class FrmViewRoutes : Form
    {
        private string role;

        public FrmViewRoutes(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void FrmViewRoutes_Load(object sender, EventArgs e)
        {
            gvTrainName.DataSource = RouteDL.RouteList;/*.Select(c => new { c.TrainName }).ToList();*/
            if(role == "user")
            {
                gvTrainName.Columns["Edit"].Visible = false;
            }
            gvTrainName.Columns["cargoPrice"].Visible = false;
            gvTrainName.Columns["ticketPrice"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (role == "user")
            {
                FrmUserMenu frmUserMenu = new FrmUserMenu();
                frmUserMenu.Show();
            }
            else
            {
                FormAdminMenu formAdminMenu = new FormAdminMenu();
                formAdminMenu.Show();
            }

        }

        private void gvTrainName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Route route = (Route)gvTrainName.CurrentRow.DataBoundItem;

            if (gvTrainName.Columns["View"].Index == e.ColumnIndex)
            {
                this.Close();
                FrmRouteData frmRouteData = new FrmRouteData(route, role);
                frmRouteData.Show();
            }
            else if (gvTrainName.Columns["Edit"].Index == e.ColumnIndex && role != "user")
            {
                this.Close();
                FrmEditRoute frmRouteData = new FrmEditRoute(route);
                frmRouteData.Show();
            }
        }
    }
}
