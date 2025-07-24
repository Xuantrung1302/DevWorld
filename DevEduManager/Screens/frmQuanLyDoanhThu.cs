using LiveCharts;
using LiveCharts.WinForms; // Dành cho Control trong WinForms
using WpfSeries = LiveCharts.Wpf; // Alias cho Series
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyDoanhThu : Form
    {
        private TableLayoutPanel layout;

        public frmQuanLyDoanhThu()
        {
            InitializeComponent();
            InitializeCharts();
            //this.WindowState = FormWindowState.Maximized;

        }

        private void InitializeCharts()
        {
            // === Layout chính ===
            layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(10),
                AutoSize = true
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            this.Controls.Add(layout);

            // 1️⃣ Biểu đồ Thu - Chi theo tháng
            var chartThuChi = new CartesianChart
            {
                Dock = DockStyle.Fill
            };
            chartThuChi.Series = new SeriesCollection
            {
                new WpfSeries.ColumnSeries
                {
                    Title = "Thu",
                    Values = new ChartValues<double> { 500, 700, 800, 600, 750, 900, 1200, 1100, 950, 1000, 1300, 1400 }
                },
                new WpfSeries.ColumnSeries
                {
                    Title = "Chi",
                    Values = new ChartValues<double> { 300, 400, 350, 500, 450, 600, 650, 700, 680, 720, 800, 900 }
                }
            };
            chartThuChi.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = Enumerable.Range(1, 12).Select(i => $"T{i}").ToArray()
            });
            chartThuChi.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "Số tiền (triệu VNĐ)" });
            layout.Controls.Add(CreateGroupBox("Thu - Chi theo Tháng", chartThuChi), 0, 0);

            // 2️⃣ Biểu đồ Tỉ lệ tốt nghiệp
            var chartTotNghiep = new PieChart { Dock = DockStyle.Fill };
            chartTotNghiep.Series = new SeriesCollection
            {
                new WpfSeries.PieSeries { Title = "Java", Values = new ChartValues<double> { 45 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "C#", Values = new ChartValues<double> { 30 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "Python", Values = new ChartValues<double> { 50 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "PHP", Values = new ChartValues<double> { 25 }, DataLabels = true }
            };
            layout.Controls.Add(CreateGroupBox("Tỉ lệ tốt nghiệp theo Chương trình", chartTotNghiep), 1, 0);

            // 3️⃣ Biểu đồ Số lượng học viên theo tháng
            var chartHocVien = new CartesianChart { Dock = DockStyle.Fill };
            chartHocVien.Series = new SeriesCollection
            {
                new WpfSeries.LineSeries
                {
                    Title = "Học viên",
                    Values = new ChartValues<int> { 120, 130, 125, 140, 160, 170, 180, 200, 190, 210, 220, 230 },
                    PointGeometry = WpfSeries.DefaultGeometries.Circle,
                    PointGeometrySize = 10
                }
            };
            chartHocVien.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = Enumerable.Range(1, 12).Select(i => $"T{i}").ToArray()
            });
            chartHocVien.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "Số học viên" });
            layout.Controls.Add(CreateGroupBox("Số lượng học viên theo Tháng", chartHocVien), 0, 1);

            // 4️⃣ Biểu đồ Top 5 khóa học doanh thu cao nhất
            var chartTopKhoaHoc = new PieChart { Dock = DockStyle.Fill };
            chartTopKhoaHoc.Series = new SeriesCollection
            {
                new WpfSeries.PieSeries { Title = "Java OOP", Values = new ChartValues<double> { 500 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "Python Pro", Values = new ChartValues<double> { 450 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "C# Master", Values = new ChartValues<double> { 400 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "ReactJS", Values = new ChartValues<double> { 350 }, DataLabels = true },
                new WpfSeries.PieSeries { Title = "PHP Laravel", Values = new ChartValues<double> { 300 }, DataLabels = true }
            };
            layout.Controls.Add(CreateGroupBox("Top 5 Khóa học Doanh thu cao nhất", chartTopKhoaHoc), 1, 1);
        }

        private GroupBox CreateGroupBox(string title, Control chart)
        {
            return new GroupBox
            {
                Text = title,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Padding = new Padding(10),
                BackColor = Color.White,
                Controls = { chart }
            };
        }
    }
}
