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

namespace RMS_V5.Forms
{
    public partial class FrmLoginPage : Form
    {
        public FrmLoginPage()
        {
            

            InitializeComponent();
        }

        private void FrmLoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignIn frm = new FrmSignIn();
            frm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp frm = new FrmSignUp();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
