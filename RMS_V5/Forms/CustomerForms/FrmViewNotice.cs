using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_V5.Forms.CustomerForms
{
    public partial class FrmViewNotice : Form
    {
        public FrmViewNotice()
        {
            InitializeComponent();
        }

        private void FrmViewNotice_Load(object sender, EventArgs e)
        {
            txtNotice.Text = Utility.Notice;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frm = new FrmUserMenu();
            frm.Show();
        }
    }
}
