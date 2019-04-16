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
    public partial class FineReports : Form
    {
        List<string>arr = new List<string>();
        List<string>arr1 = new List<string>();
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public FineReports()
        {
            InitializeComponent();
        }

        public FineReports(string x)
        {
            InitializeComponent();
            ofcr_txt.Text = x;
        }
        private void ret_btn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }
        private void FineReports_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "Get_Fine_ID";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fid_cmb.Items.Add(dr[0]);
            }
            dr.Close();
            cmd.CommandText = "select Plate_Number  from Vehicles";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd.ExecuteReader();
            int i = 0;
            while (dr1.Read())
            {
                arr1.Add(dr1[0].ToString());
                vpn_cmb.Items.Add(dr1[0]);
                i++;
            }
            dr1.Close();
            cmd.CommandText = "select Issue_Number  from court";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            int j= 0;
            while (dr2.Read())
            {
                arr.Add(dr2[0].ToString());
                cin_cmb.Items.Add(dr2[0]);
                j++;
            }
            dr2.Close();
        }

        private void fid_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Fine_Type from Fines where FineID =:fid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("fid", fid_cmb.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fty_txt.Text = dr[0].ToString();
            }
            dr.Close();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "get_fines_Ammount";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("fine_id", Convert.ToInt32(fid_cmb.Text.ToString()));
            cmd1.Parameters.Add("fin_Amount", OracleDbType.Decimal, ParameterDirection.Output);
            cmd1.ExecuteNonQuery();
            amt_txt.Text = Convert.ToString(cmd1.Parameters["fin_Amount"].Value.ToString());
        }

        private void sbmt_btn_Click(object sender, EventArgs e)
        {
            //Insert Record in table fine Report (Using Procedure) 
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert_FineReport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("fid", Convert.ToInt32(fid_cmb.SelectedItem.ToString()));
            cmd.Parameters.Add("vpn", vpn_cmb.SelectedItem.ToString());
            bool b = true;
            for (int i = 0; i < 100 ; i++)
            {
                if ((arr[i] == fid_cmb.SelectedItem.ToString())&& (arr1[i] == vpn_cmb.SelectedItem.ToString()))
                {
                    b = false;
                }
            }
            if (b)
            {
                cmd.Parameters.Add("cin", Convert.ToInt32(cin_cmb.SelectedItem.ToString()));
                cmd.Parameters.Add("oum", ofcr_txt.Text);
                cmd.ExecuteNonQuery();
                //Update total amount in table driver (Without Procedure)
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "UpdateReport";
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("fineid", Convert.ToInt32(fid_cmb.SelectedItem.ToString()));
                cmd1.Parameters.Add("vplatenum", vpn_cmb.SelectedItem.ToString());
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Fine Added");
            }
            else
            {
                MessageBox.Show("invaild inputs)");
            }
        }
        private void FineReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void vd_btn_Click(object sender, EventArgs e)
        {
            Vehicles v = new Vehicles();
            v.Show();
        }
    }
}
