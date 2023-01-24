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
    public partial class FrmBookCargo : Form
    {
        private Route route;
        public FrmBookCargo(Route route)
        {
            InitializeComponent();
            this.route = route;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frmUserMenu = new FrmUserMenu();
            frmUserMenu.Show();
        }

        private void FrmBookCargo_Load(object sender, EventArgs e)
        {
            txtTrainName.Text = route.TrainName;
            txtCargoPrice.Text = route.TicketPrice.ToString();

            cbFrom.DataSource = route.StationNamesList();
            cbTo.DataSource = route.StationNamesList();
        }

        private void numWeight_ValueChanged(object sender, EventArgs e)
        {
            int price = (int)numWeight.Value * int.Parse(numWeight.Text);
            txtPrice.Text = price.ToString();
        }

        private void btnBookCargo_Click(object sender, EventArgs e)
        {
            try
            {
                string trainName = route.TrainName;
                string from = cbFrom.Text;
                string to = cbTo.Text;
                if (from == to)
                {
                    throw new Exception("Error Stations Name are same !");
                }
                int weight = (int)numWeight.Value;
                int price = weight * route.CargoPrice;

                int month = (int)numMonth.Value;
                int year = (int)numYear.Value;
                int day = (int)numDay.Value;

                int bookingNo = TrainCargoDL.ListCount() + 1;


                TrainCargo cargo = new TrainCargo(trainName, from, to, weight, price, bookingNo, day, month, year);
                cargo.calculateDate();
                MessageBox.Show("Cargo Booked Successfullly :)");
                TrainCargoDL.addIntoList(cargo);
                TrainCargoDL.storeDataIntoFile(Utility.CargoPath);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void numMonth_ValueChanged(object sender, EventArgs e)
        {
            int m = (int)numMonth.Value;
            if (m == 2)
            {
                numDay.Maximum = 28;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                numDay.Maximum = 30;
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                numDay.Maximum = 31;
            }
        }
    }
}
