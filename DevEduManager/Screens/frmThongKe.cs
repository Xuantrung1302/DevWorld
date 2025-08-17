using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DevEduManager.Screens
{
    public partial class frmThongKe : Form
    {
        private Chart chartThuChi1, chartHocVienThang, chartTopKhoaHoc, chartTiLeTotNghiep1;

        public frmThongKe()
        {
            InitializeComponent();

            // Tạo comboBox năm
            cboYear.Items.AddRange(new object[] { "2022", "2023", "2024" });
            cboYear.SelectedIndex = 0; // chọn mặc định
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;

            // Khởi tạo Chart
            chartThuChi1 = new Chart();
            chartHocVienThang = new Chart();
            chartTopKhoaHoc = new Chart();
            chartTiLeTotNghiep1 = new Chart();

            InitializeCharts();

            // Load dữ liệu ban đầu
            LoadDataForYear(2024);
        }

        private void InitializeCharts()
        {
            chartThuChi1.Dock = DockStyle.Fill;
            chartHocVienThang.Dock = DockStyle.Fill;
            chartTopKhoaHoc.Dock = DockStyle.Fill;
            chartTiLeTotNghiep1.Dock = DockStyle.Fill;

            tableLayoutPanelCharts.Controls.Add(chartThuChi1, 0, 0);
            tableLayoutPanelCharts.Controls.Add(chartHocVienThang, 1, 0);
            tableLayoutPanelCharts.Controls.Add(chartTopKhoaHoc, 0, 1);
            tableLayoutPanelCharts.Controls.Add(chartTiLeTotNghiep1, 1, 1);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(cboYear.SelectedItem.ToString());
            LoadDataForYear(year);
        }

        private void LoadDataForYear(int year)
        {
            // ================= Panel Numbers =================
            int soHocVien = 1200 + (year % 10) * 10;
            int soGiaoVien = 80 + (year % 5);
            int soNhanVien = 50 + (year % 3);
            int soChuongTrinh = 15 + (year % 2);

            panelHocSinh.Controls.Clear();
            panelGiaoVien.Controls.Clear();
            panelNhanVien.Controls.Clear();
            panelChuongTrinh.Controls.Clear();

            panelHocSinh.Controls.Add(new Label() { Text = $"Học viên: {soHocVien}", AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) });
            panelGiaoVien.Controls.Add(new Label() { Text = $"Giảng viên: {soGiaoVien}", AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) });
            panelNhanVien.Controls.Add(new Label() { Text = $"Nhân viên: {soNhanVien}", AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) });
            panelChuongTrinh.Controls.Add(new Label() { Text = $"Chương trình: {soChuongTrinh}", AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold) });

            Random rnd = new Random();

            // ================= Chart 1: Thu chi theo tháng =================
            chartThuChi1.Series.Clear();
            chartThuChi1.ChartAreas.Clear();
            chartThuChi1.Titles.Clear();
            chartThuChi1.Legends.Clear();

            var ca1 = new ChartArea();
            chartThuChi1.ChartAreas.Add(ca1);

            var legend1 = new Legend();
            chartThuChi1.Legends.Add(legend1);

            var seriesThu = new Series("Thu")
            {
                ChartType = SeriesChartType.Column,
                ToolTip = "Tháng #VALX: #VAL"
            };
            var seriesChi = new Series("Chi")
            {
                ChartType = SeriesChartType.Column,
                ToolTip = "Tháng #VALX: #VAL"
            };

            for (int m = 1; m <= 12; m++)
            {
                seriesThu.Points.AddXY($"T{m}", rnd.Next(50, 200));
                seriesChi.Points.AddXY($"T{m}", rnd.Next(20, 150));
            }

            chartThuChi1.Series.Add(seriesThu);
            chartThuChi1.Series.Add(seriesChi);
            chartThuChi1.Titles.Add("Thu chi theo tháng");

            // ================= Chart 2: Học viên theo tháng =================
            chartHocVienThang.Series.Clear();
            chartHocVienThang.ChartAreas.Clear();
            chartHocVienThang.Titles.Clear();

            var ca2 = new ChartArea();
            chartHocVienThang.ChartAreas.Add(ca2);
            var seriesHocVien = new Series("Học viên")
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                BorderWidth = 2,
                ToolTip = "Tháng #VALX: #VAL"
            };

            for (int m = 1; m <= 12; m++)
            {
                seriesHocVien.Points.AddXY($"T{m}", rnd.Next(20, 100));
            }

            chartHocVienThang.Series.Add(seriesHocVien);
            chartHocVienThang.Titles.Add("Số học viên theo tháng");

            // ================= Chart 3: Top 5 khóa học =================
            chartTopKhoaHoc.Series.Clear();
            chartTopKhoaHoc.ChartAreas.Clear();
            chartTopKhoaHoc.Titles.Clear();

            var ca3 = new ChartArea();
            chartTopKhoaHoc.ChartAreas.Add(ca3);

            var seriesKhoaHoc = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Bar,
                ToolTip = "#VALX: #VAL"
            };

            string[] khoaHoc = { "C#", "Java", "Python", "JS", "SQL" };
            foreach (var kh in khoaHoc)
            {
                seriesKhoaHoc.Points.AddXY(kh, rnd.Next(100, 500));
            }

            chartTopKhoaHoc.Series.Add(seriesKhoaHoc);
            chartTopKhoaHoc.Titles.Add("Top 5 khóa học");

            // ================= Chart 4: Tỉ lệ tốt nghiệp =================
            chartTiLeTotNghiep1.Series.Clear();
            chartTiLeTotNghiep1.ChartAreas.Clear();
            chartTiLeTotNghiep1.Titles.Clear();
            chartTiLeTotNghiep1.Legends.Clear();

            var ca4 = new ChartArea();
            chartTiLeTotNghiep1.ChartAreas.Add(ca4);

            var legend4 = new Legend();
            chartTiLeTotNghiep1.Legends.Add(legend4);

            var seriesTiLe = new Series("Tỉ lệ")
            {
                ChartType = SeriesChartType.Pie,
                Label = "#PERCENT{P0}",   // hiển thị % trên chart
                ToolTip = "#VALX: #VAL (#PERCENT{P0})"
            };

            seriesTiLe.Points.AddXY("Tốt nghiệp", rnd.Next(70, 90));
            seriesTiLe.Points.AddXY("Chưa tốt nghiệp", rnd.Next(10, 30));

            chartTiLeTotNghiep1.Series.Add(seriesTiLe);
            chartTiLeTotNghiep1.Titles.Add("Tỉ lệ tốt nghiệp");
        }

    }
}
