using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Report
{
    public partial class frmReport : Form
    {
        public ReportViewer ReportViewer
        {
            get { return this.reportViewer1; }
        }
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            ReportViewer.ZoomMode = ZoomMode.Percent;
            ReportViewer.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
