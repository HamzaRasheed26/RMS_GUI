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
    public partial class FrmBuyTicket : Form
    {
        private Route route;
        public FrmBuyTicket(Route route)
        {
            InitializeComponent();
            this.route = route;
        }

        private void FrmBuyTicket_Load(object sender, EventArgs e)
        {
            txtTrainName.Text = route.TrainName;
            txtTicketPrice.Text = route.TicketPrice.ToString();

            cbFrom.DataSource = route.StationNamesList();
            cbTo.DataSource = route.StationNamesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frmUserMenu = new FrmUserMenu();
            frmUserMenu.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                string trainName = route.TrainName;
                string from = cbFrom.Text;
                string to = cbTo.Text;
                if(from == to)
                {
                    throw new Exception("Error Stations Name are same !");
                }
                int quantity = (int)numQuantity.Value;
                int price = quantity * route.TicketPrice;

                int month = (int)numMonth.Value;
                int year = (int)numYear.Value;
                int day = (int)numDay.Value;

                int bookingNo = TrainTicketDL.ListCount() + 1;


                TrainTicket ticket = new TrainTicket(trainName, from, to, quantity, price, bookingNo, day, month, year);
                ticket.calculateDate();
                MessageBox.Show("Ticket Buyed Successfullly :)");
                TrainTicketDL.addIntoList(ticket);
                TrainTicketDL.storeDataIntoFile(Utility.TicketPath);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            int price = (int)numQuantity.Value * int.Parse(txtTicketPrice.Text);
            txtPrice.Text = price.ToString();
        }

        private void numMonth_ValueChanged(object sender, EventArgs e)
        {
            int m = (int)numMonth.Value;
            if(m == 2)
            {
                numDay.Maximum = 28;
            }
            else if(m == 4 || m ==  6 || m ==  9 || m == 11)
            {
                numDay.Maximum = 30;
            }
            else if(m == 1 || m == 3 || m == 5 || m == 7 || m== 8 || m == 10 || m== 12)
            {
                numDay.Maximum = 31;
            }
        }
    }
}
