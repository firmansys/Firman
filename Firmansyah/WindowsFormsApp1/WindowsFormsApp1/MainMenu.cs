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
    public partial class MainMenu : Form
    {
      

        public MainMenu()
        {
            InitializeComponent();
        }

      
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            AdminSecurity newMDIChild = new AdminSecurity();            
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
