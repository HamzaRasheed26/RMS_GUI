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

namespace RMS_V5.Forms
{
    public partial class FrmDeleteRoute : Form
    {
        public FrmDeleteRoute()
        {
            InitializeComponent();
        }

        private void FrmDeleteRoute_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void gvTrainName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Route route = (Route)gvTrainName.CurrentRow.DataBoundItem;

            if (gvTrainName.Columns["Delete"].Index == e.ColumnIndex)
            {
                RouteDL.RouteList.Remove(route);
                RouteDL.storeDataIntoFlie(Utility.RoutePath);
                BindData();
            }
        }

        private void BindData()
        {
            gvTrainName.DataSource = null;
            gvTrainName.DataSource = RouteDL.RouteList;
            gvTrainName.Columns["cargoPrice"].Visible = false;
            gvTrainName.Columns["ticketPrice"].Visible = false;
            gvTrainName.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdminMenu frmLoginPage = new FormAdminMenu();
            frmLoginPage.Show();
        }
    }
}
