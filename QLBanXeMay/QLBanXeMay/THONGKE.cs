using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanXeMay
{
    public partial class THONGKE : Form
    {
        public THONGKE()
        {
            InitializeComponent();
        }

        private void THONGKE_Load(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.Refresh();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            HoaDon a = new HoaDon();
            a.Show();
        }
    }
}
