using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Traffic_Fines_Application
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
        private void viewPayFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver drvr = new Driver();
            this.Hide();
            drvr.Show();            
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Officer ofcr = new Officer();
           this.Hide();
            ofcr.Show();            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payFineToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Driver_Pay_Fine dr = new Driver_Pay_Fine();
            dr.Show();
        }
    }
}
