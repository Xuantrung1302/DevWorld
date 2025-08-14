using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DevEduManager.Screens
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            // Khởi tạo Chart ở đây
            chartThuChi = new Chart();
            chartTiLeTotNghiep = new Chart();
            chartChart3 = new Chart();
            chartChart4 = new Chart();

            // Cấu hình Chart (dock, area, series, title...) rồi thêm vào tableLayoutPanelCharts
            InitializeCharts();
        }
        private void InitializeCharts()
        {
            // Ví dụ thêm chartThuChi vào vị trí (0,0)
            chartThuChi.Dock = DockStyle.Fill;
            // Thiết lập ChartArea, Series, Title...
            tableLayoutPanelCharts.Controls.Add(chartThuChi, 0, 0);

            chartTiLeTotNghiep.Dock = DockStyle.Fill;
            tableLayoutPanelCharts.Controls.Add(chartTiLeTotNghiep, 1, 0);

            chartChart3.Dock = DockStyle.Fill;
            tableLayoutPanelCharts.Controls.Add(chartChart3, 0, 1);

            chartChart4.Dock = DockStyle.Fill;
            tableLayoutPanelCharts.Controls.Add(chartChart4, 1, 1);
        }
    }
}
