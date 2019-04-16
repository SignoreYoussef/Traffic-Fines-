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
    public partial class ViewFines : Form
    {
        public ViewFines()
        {
            InitializeComponent();
        }
        FinesReport fr;
        private void Viewbtn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = fr;
        }

        private void ViewFines_Load(object sender, EventArgs e)
        {
            fr = new FinesReport();
        }

        private void bk_button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            fr.Close();
            main.Show();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("User Id=scott;Password=tiger;Data Source=orcl");
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from finereport where ispaid ='Y'";
            cmd.CommandType = CommandType.Text;
            int r = cmd.ExecuteNonQuery();
            if (r !=0) { MessageBox.Show("Paid Fines Deleted"); }
            else { MessageBox.Show("No Paid Fines"); }
        }
    }
}
