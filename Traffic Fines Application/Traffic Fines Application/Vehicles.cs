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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            VehiclesDriver vd = new VehiclesDriver();
            crystalReportViewer1.ReportSource = vd;
        }
    }
}
