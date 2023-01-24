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
    
    public partial class FrmChangeCargoPrice : Form
    {
        private Route route;
        public FrmChangeCargoPrice(Route route)
        {
            InitializeComponent();
            this.route = route;
        }

        private void FrmChangeCargoPrice_Load(object sender, EventArgs e)
        {
            txtTrainName.Text = route.TrainName;
            txtOLdPrice.Text = route.CargoPrice.ToString();
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

                if (!(price <= 500 && price >= 40))
                {
                    throw new Exception("Cargo price must be less than 500 per kg and greater than 40.");
                }

                route.CargoPrice = price;

                MessageBox.Show("Price Changed Successfully");
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
