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

namespace RMS_V5.Forms.CustomerForms
{
    public partial class FrmShowRoute : Form
    {
        private List<Route> routeList;
        private string stName;
        public FrmShowRoute(List<Route> routeList, string stName)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.stName = stName;
        }

        private void FrmShowRoute_Load(object sender, EventArgs e)
        {
            try
            {
                txtStationName.Text = stName;
                gvRoutes.DataSource = routeList;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmStationSchedule frm = new FrmStationSchedule();
            frm.Show();
        }
    }
}
