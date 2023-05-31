using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string userid
        {
            get { return txtUserid.Text; }
            set
            {
                txtUserid.Text = value;
            }
        }

        public string pass
        {
            get { return txtPassword.Text; }
            set
            {
                txtPassword.Text = value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "ixwidi";
            string pass = "123";

            if (txtUserid.Text == "" || txtPassword.Text=="")
            {
                MessageBox.Show("Please input user and password");
                return;
            }

            if (user == txtUserid.Text && pass == txtPassword.Text)
            {
                GlobalVar.user = txtUserid.Text;
                GlobalVar.pass = txtPassword.Text;
                MainMenu mainMenu = new MainMenu();              
                mainMenu.Show();

                //frmLogin frmlogin = new frmLogin();               
                //frmlogin.Close();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Wrong User or Password, please contact Admin");
            }

           
        }
    }
}
