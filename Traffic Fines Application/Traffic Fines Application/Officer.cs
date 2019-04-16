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
    public partial class Officer : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Officer()
        {
            InitializeComponent();
        }
        private void signIN_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Officer where UserName=:us and UserPassword=:up ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("us", usrname_txt.Text);
            cmd.Parameters.Add("up", psw_txt.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                OfficerControl oc = new OfficerControl(usrname_txt.Text);
                this.Close();
                oc.Show();
            }
            else
                MessageBox.Show("Invalid Username or Password");
            dr.Close();
        }

        private void retBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void Officer_Load(object sender, EventArgs e)
        {;
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Officer_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
