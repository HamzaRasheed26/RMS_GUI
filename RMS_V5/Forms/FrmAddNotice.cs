using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_V5.Forms
{
    public partial class FrmAddNotice : Form
    {
        public FrmAddNotice()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string notice = txtNotice.Text;
                if(notice == "")
                {
                    throw new Exception("Invalid Input !");
                }

                Utility.Notice = notice;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdminMenu formAdminMenu = new FormAdminMenu();
            formAdminMenu.Show();
        }
    }
}
