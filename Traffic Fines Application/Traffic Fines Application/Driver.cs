using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Traffic_Fines_Application
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }
        DriverFine dr;
        private void ret_btn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            dr.Close();
            main.Show();
        }
        private void Driver_Load(object sender, EventArgs e)
        {
            dr = new DriverFine();
        }
        private void src_btn_Click(object sender, EventArgs e)
        {
            dr.SetParameterValue(0,textBox1.Text);
            dr.SetParameterValue(1, textBox2.Text);
            crystalReportViewer1.ReportSource = dr;
        }
    }
}
