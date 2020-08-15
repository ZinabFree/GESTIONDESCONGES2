using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace GESTIONDESCONGES2
{
    public partial class REPORTVIEW : Form
    {
        public REPORTVIEW()
        {
            InitializeComponent();
        }

        private void REPORTVIEW_Load(object sender, EventArgs e)
        {

        }
        public REPORTVIEW(ReportClass report):this()
        {
            crystalReportViewer1.ReportSource = report;
        }
    }
}
