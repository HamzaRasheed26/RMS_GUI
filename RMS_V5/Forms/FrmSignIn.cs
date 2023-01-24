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
using RMS_V5.Forms.CustomerForms;

namespace RMS_V5.Forms
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLoginPage frm = new FrmLoginPage();
            frm.Show();
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role;
            if (username != "" && password != "")
            {
                MUser u = new MUser(username, password);

                MUser user = MUserDL.findUser(u);
                if (user != null)
                {
                    role = user.getRole();
                }
                else
                {
                    role = "nill";
                }
            }
            else
            {
                role = "nill";
            }

            if(role == "admin")
            {
                //..
                // Admin form code
                //..

                this.Hide();
                FormAdminMenu formAdminMenu = new FormAdminMenu();
                formAdminMenu.Show();

            }
            else if(role == "user")
            {
                //..
                // User form code
                //..

                this.Hide();
                FrmUserMenu frmUserMenu = new FrmUserMenu();
                frmUserMenu.Show();

                CustomerDL.initializeCustomer(username);
                
            }
            else
            {

                MessageBox.Show("    Invalid Input !  ");
                
            }
        }
    }
}
