using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Fines_Application
{
    public partial class OfficerControl : Form
    {
        public OfficerControl()
        {
            InitializeComponent();
        }
        FineReports fr;
        public OfficerControl(string x)
        {
            InitializeComponent();
            fr = new FineReports(x);
        }

        private void ret_btn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void addfine_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            fr.Show();
        }

        private void addtype_btn_Click(object sender, EventArgs e)
        {
            FineType ft = new FineType();
            this.Close();
            ft.Show();
        }

        private void viewrep_btn_Click(object sender, EventArgs e)
        {
            ViewFines vf = new ViewFines();
            this.Close();
            vf.Show();
        }

        private void drvr_vecbtn_Click(object sender, EventArgs e)
        {
            MasterDetail md = new MasterDetail();
            md.Show();
        }

        private void OfficerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
