using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_V5.BL;
using RMS_V5.Forms.CustomerForms;

namespace RMS_V5.Forms
{
    public partial class FrmRouteData : Form
    {
        private Route route;
        private string role;
        public FrmRouteData(Route route, string role)
        {
            InitializeComponent();
            this.route = route;
            this.role = role;
        }

        private void FrmRouteData_Load(object sender, EventArgs e)
        {
            lblRouteTrainName.Text = route.TrainName;
            lblRouteTicketPrice.Text = route.TicketPrice.ToString();
            lblRouteCargoPrice.Text = route.CargoPrice.ToString();
            gvStations.DataSource = route.Stations;
            gvStations.Columns["Ath"].HeaderText = "Arrival Time Hour";
            gvStations.Columns["Atm"].HeaderText = "Arrival Time Minute";
            gvStations.Columns["Dth"].HeaderText = "Departure Time Hour";
            gvStations.Columns["Dtm"].HeaderText = "Departure Time Minute";
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (role == "user")
            {
                FrmViewRoutes frmUserMenu = new FrmViewRoutes("user");
                frmUserMenu.Show();
            }
            else
            {
                FrmViewRoutes form = new FrmViewRoutes("admin");
                form.Show();
            }
        }
    }
}
