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
    public partial class MasterDetail : Form
    {
        OracleDataAdapter adapter1;
        OracleDataAdapter adapter2;
        DataSet ds;
        BindingSource bs_Master;
        BindingSource bs_Child;
        OracleCommandBuilder bulider;
        public MasterDetail()
        {
            InitializeComponent();
        }


        private void MasterDetail_Load(object sender, EventArgs e)
        {
                string constr = "User Id=scott;Password=tiger;Data Source=orcl";
                ds = new DataSet();
                adapter1 = new OracleDataAdapter("SELECT * from Driver", constr);
                adapter1.Fill(ds, "FCat");
                adapter2 = new OracleDataAdapter("SELECT * from Vehicles", constr);
                adapter2.Fill(ds, "FT");
                DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["Licence_Num"], ds.Tables[1].Columns["Driver_LN"]);
                ds.Relations.Add(r);
                bs_Master = new BindingSource(ds, "FCat");
                bs_Child = new BindingSource(bs_Master, "fk");
                dataGridView1.DataSource = bs_Master;
                dataGridView2.DataSource = bs_Child;
            
      
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
          
                bulider = new OracleCommandBuilder(adapter1);
                adapter1.Update(ds.Tables[0]);
                bs_Child[4] = bs_Master[0];
        }
    }
}
