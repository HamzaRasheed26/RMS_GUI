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
using RMS_V5.DL;

namespace RMS_V5.Forms.CustomerForms
{
    public partial class FrmStationSchedule : Form
    {
        public FrmStationSchedule()
        {
            InitializeComponent();
        }

        private void FrmStationSchedule_Load(object sender, EventArgs e)
        {
            gvStations.DataSource = StationDL.StationsList.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frm = new FrmUserMenu();
            frm.Show();
        }

        private void gvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string stName = (string)gvStations.CurrentRow.DataBoundItem;

                List<Route> routeList = RouteDL.searchStationAndReturnList(stName);

                if(routeList == null)
                {
                    throw new Exception("No Route is link with this Station !");
                }
                this.Close();
                FrmShowRoute frm = new FrmShowRoute(routeList, stName);
                frm.Show();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
