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
    public partial class FrmMyCargo : Form
    {
        public FrmMyCargo()
        {
            InitializeComponent();
        }

        private void BindData(List<TrainCargo> cargoList)
        {
            gvCargo.DataSource = null;
            gvCargo.DataSource = cargoList;
            gvCargo.Columns["Date"].Visible = false;
            gvCargo.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frm = new FrmUserMenu();
            frm.Show();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.Text == "Price")
            {
                List<TrainCargo> t = TrainCargoDL.CargoList.OrderBy(o => o.Price).ToList();
                BindData(t);
            }
            else if (cbSort.Text == "Booking No")
            {
                List<TrainCargo> t = TrainCargoDL.CargoList.OrderBy(o => o.Booking_no).ToList();
                BindData(t);
            }
            else if (cbSort.Text == "Date")
            {
                List<TrainCargo> t = TrainCargoDL.CargoList.OrderBy(o => o.Date).ToList();
                BindData(t);
            }
            else if (cbSort.Text == "Weight")
            {
                List<TrainCargo> t = TrainCargoDL.CargoList.OrderBy(o => o.Weight).ToList();
                BindData(t);
            }
            else if (cbSort.Text == "Train Name")
            {
                List<TrainCargo> t = TrainCargoDL.CargoList.OrderBy(o => o.TrainName).ToList();
                BindData(t);
            }
        }

        private void FrmMyCargo_Load(object sender, EventArgs e)
        {
            BindData(TrainCargoDL.CargoList);
        }

        private void gvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TrainCargo cargo = (TrainCargo)gvCargo.CurrentRow.DataBoundItem;

            if (gvCargo.Columns["Delete"].Index == e.ColumnIndex)
            {
                TrainCargoDL.CargoList.Remove(cargo);
                TrainCargoDL.storeDataIntoFile(Utility.TicketPath);
                BindData(TrainCargoDL.CargoList);
            }
        }
    }
}
