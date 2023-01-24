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

namespace RMS_V5.Forms
{
    public partial class FrmChangeTicketPrice : Form
    {
        private Route route;
        public FrmChangeTicketPrice(Route route)
        {
            InitializeComponent();
            this.route = route;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int price = int.Parse(txtNewPrice.Text);

                if (!(price <= 2000 && price >= 100))
                {
                    throw new Exception("Train Ticket Price Cannot be greater than 2000/Rs and cannot be less than 100 /Rs.");
                }

                route.TicketPrice = price;

                MessageBox.Show("Price Changed Successfully !");
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void FrmChangeTicketPrice_Load(object sender, EventArgs e)
        {
            txtTrainName.Text = route.TrainName;
            txtOLdPrice.Text = route.TicketPrice.ToString();
        }
    }
}
