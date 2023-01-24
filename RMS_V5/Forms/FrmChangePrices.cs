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

namespace RMS_V5.Forms
{
    public partial class FrmChangePrices : Form
    {
        public FrmChangePrices()
        {
            InitializeComponent();
        }

        private void FrmChangePrices_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gvTrains.DataSource = null;
            gvTrains.DataSource = RouteDL.getRouteList();
            gvTrains.Refresh();
        }

        private void gvTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Route route = (Route)gvTrains.CurrentRow.DataBoundItem;

            if (gvTrains.Columns["ChangeTicketPrice"].Index == e.ColumnIndex)
            {
                FrmChangeTicketPrice frm = new FrmChangeTicketPrice(route);
                frm.ShowDialog();
            }
            else if (gvTrains.Columns["ChangeCargoPrice"].Index == e.ColumnIndex)
            {
                FrmChangeCargoPrice frm = new FrmChangeCargoPrice(route);
                frm.ShowDialog();
            }

            RouteDL.storeDataIntoFlie(Utility.RoutePath);
            BindData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdminMenu formAdminMenu = new FormAdminMenu();
            formAdminMenu.Show();
        }
    }
}
