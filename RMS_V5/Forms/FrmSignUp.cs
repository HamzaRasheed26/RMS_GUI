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

namespace RMS_V5.Forms
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLoginPage frm = new FrmLoginPage();
            frm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = comboBoxRole.Text;
            if (username != "" && password != "" && role != "")
            {
                MUser user = new MUser(username, password,role);

                if (!MUserDL.isExist(user))
                {
                    MUserDL.AddUserIntoList(user);

                    if (user.getRole() == "user")
                    {
                        Customer newCustomer = new Customer(username);
                        CustomerDL.addIntoList(newCustomer);
                        //CustomerDL.storeData(customerFilePath);
                    }
                    MUserDL.storeSingleObject(Utility.CredentialFilePath, user);

                    MessageBox.Show("Sign Up Succesfully");
                }
                else
                {
                    MessageBox.Show("Invalid usernaame !");
                }

            }
            else
            {
                MessageBox.Show("Invalid Input !");
            }
            
            txtUserName.Text = "";
            txtPassword.Text = "";
            comboBoxRole.Text = "";
        }
    }
}
