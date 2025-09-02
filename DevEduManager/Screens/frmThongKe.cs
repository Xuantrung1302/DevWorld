using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace DevEduManager.Screens
{
    public partial class frmThongKe : Form
    {
        // base url tới API Statistical controller (ví dụ: https://localhost:44394/api/Statistical/)
        private readonly string _thongkeurl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Statistical/";

        public frmThongKe()
        {
            InitializeComponent();

            // Load danh sách năm vào combo (2020 -> currentYear + 1)
            LoadYears();

            // Khi form vừa khởi tạo, tải dashboard theo năm mặc định (năm được set trong LoadYears)
            if (cboYear.SelectedItem != null)
            {
                // Không chặn luồng UI — chạy bất đồng bộ
                _ = LoadDashboardAsync((int)cboYear.SelectedItem);
            }
        }

        private void LoadYears()
        {
            cboYear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int y = 2024; y <= currentYear; y++)
            {
                cboYear.Items.Add(y);
            }
            cboYear.SelectedItem = currentYear;
        }

        /// <summary>
        /// Tải toàn bộ thông tin dashboard cho một năm
        /// </summary>
        private async Task LoadDashboardAsync(int year)
        {
            try
            {
                await LoadPanelsAsync();
                await LoadChartDoanhThuChiAsync(year);
                await LoadChartHocVienThangAsync(year);
                await LoadChartTopKhoaHocAsync(year);
                await LoadChartTiLeTotNghiepAsync(year);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dashboard: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Panels
        private async Task LoadPanelsAsync()
        {
            try
            {
                var dt = await GetDataTableFromApi("tongQuatVeTacNhan");
                if (dt == null) dt = new DataTable();

                // Clear cacs panel trước khi add label mới
                panelHocSinh.Controls.Clear();
                panelGiaoVien.Controls.Clear();
                panelNhanVien.Controls.Clear();
                panelChuongTrinh.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string loai = row["LoaiDoiTuong"].ToString();
                    string soLuong = row["SoLuong"].ToString();

                    var lbl = new Label()
                    {
                        Text = $"{loai}: {soLuong}",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold)
                    };

                    switch (loai)
                    {
                        case "Học viên":
                            panelHocSinh.Controls.Add(lbl);
                            break;
                        case "Giảng viên":
                            panelGiaoVien.Controls.Add(lbl);
                            break;
                        case "Nhân viên":
                            panelNhanVien.Controls.Add(lbl);
                            break;
                        case "Khóa học":
                            panelChuongTrinh.Controls.Add(lbl);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load panels: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Chart DoanhThu/Chi (Pie)
        private async Task LoadChartDoanhThuChiAsync(int year)
        {
            try
            {
                var dt = await GetDataTableFromApi($"thongKeTyLeDoanhThu?year={year}") ?? new DataTable();

                // Sử dụng chart từ Designer: chartThuChi
                var chart = chartThuChi;

                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Titles.Clear();
                chart.Legends.Clear();

                var ca = new ChartArea();
                chart.ChartAreas.Add(ca);
                chart.Legends.Add(new Legend());

                var series = new Series("Tỉ lệ Doanh thu/Chi")
                {
                    ChartType = SeriesChartType.Pie,
                    Label = "#PERCENT{P0}",
                    ToolTip = "#VALX: #VAL"
                };

                decimal chi = 0, doanhThu = 0;
                if (dt.Rows.Count > 0)
                {
                    decimal.TryParse(dt.Rows[0]["TongChi"]?.ToString() ?? "0", out chi);
                    decimal.TryParse(dt.Rows[0]["TongDoanhThu"]?.ToString() ?? "0", out doanhThu);
                }

                // Nếu cả doanhthu và chi đều 0 thì thêm 1 slice "Không có dữ liệu"
                if (chi == 0 && doanhThu == 0)
                {
                    series.Points.AddXY("Không có dữ liệu", 1);
                }
                else
                {
                    series.Points.AddXY("Chi phí", (double)chi);
                    series.Points.AddXY("Doanh thu", (double)doanhThu);
                }

                chart.Series.Add(series);
                chart.Titles.Add($"Tỉ lệ Doanh thu - Chi phí ({year})");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chart doanh thu/chi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Chart Học viên theo tháng (Line)
        private async Task LoadChartHocVienThangAsync(int year)
        {
            try
            {
                var dt = await GetDataTableFromApi($"thongKeSoHocSinhDangKyHocTheoThangTrongNam?year={year}") ?? new DataTable();

                var chart = chartChart3; // dùng chartChart3 cho biểu đồ học viên theo tháng

                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Titles.Clear();
                chart.Legends.Clear();

                var ca = new ChartArea();
                chart.ChartAreas.Add(ca);

                var series = new Series("Học viên")
                {
                    ChartType = SeriesChartType.Line,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 2,
                    ToolTip = "Tháng #VALX: #VAL"
                };

                // Chuẩn hoá dữ liệu: đảm bảo có điểm cho T1..T12
                int[] monthCounts = new int[13]; // chỉ dùng index 1..12
                foreach (DataRow row in dt.Rows)
                {
                    if (int.TryParse(row["Month"]?.ToString(), out int month) &&
                        int.TryParse(row["TotalEnrollments"]?.ToString(), out int total) &&
                        month >= 1 && month <= 12)
                    {
                        monthCounts[month] = total;
                    }
                }

                for (int m = 1; m <= 12; m++)
                {
                    series.Points.AddXY($"T{m}", monthCounts[m]);
                }

                chart.Series.Add(series);
                chart.Titles.Add($"Số học viên đăng ký theo tháng ({year})");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chart học viên theo tháng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Chart Top 5 khóa học (Bar)
        private async Task LoadChartTopKhoaHocAsync(int year)
        {
            try
            {
                var dt = await GetDataTableFromApi($"thongKeTopNamKhoaHoc?year={year}") ?? new DataTable();

                var chart = chartChart4; // dùng chartChart4 cho top khoá học

                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Titles.Clear();
                chart.Legends.Clear();

                var ca = new ChartArea();
                chart.ChartAreas.Add(ca);

                var series = new Series("Số học viên")
                {
                    ChartType = SeriesChartType.Bar,
                    ToolTip = "#VALX: #VAL"
                };

                foreach (DataRow row in dt.Rows)
                {
                    string courseName = row.Table.Columns.Contains("course_name") ? row["course_name"].ToString() :
                                        row.Table.Columns.Contains("CourseName") ? row["CourseName"].ToString() : "Khóa học";
                    int total = 0;
                    int.TryParse(row["TotalStudents"]?.ToString() ?? "0", out total);

                    series.Points.AddXY(courseName, total);
                }

                chart.Series.Add(series);
                chart.Titles.Add($"Top 5 khóa học ({year})");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chart Top khóa học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Chart Tỉ lệ tốt nghiệp (Pie)
        private async Task LoadChartTiLeTotNghiepAsync(int year)
        {
            try
            {
                var dt = await GetDataTableFromApi($"thongKeTyLeTotNghiep?year={year}") ?? new DataTable();

                var chart = chartTiLeTotNghiep;

                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Titles.Clear();
                chart.Legends.Clear();

                var ca = new ChartArea();
                chart.ChartAreas.Add(ca);
                chart.Legends.Add(new Legend());

                var series = new Series("Tỉ lệ")
                {
                    ChartType = SeriesChartType.Pie,
                    Label = "#PERCENT{P0}",
                    ToolTip = "#VALX: #VAL (#PERCENT{P0})"
                };

                // mỗi course -> thêm 2 slice (tốt nghiệp và chưa)
                if (dt.Rows.Count == 0)
                {
                    series.Points.AddXY("Không có dữ liệu", 1);
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string courseName = row["CourseName"]?.ToString() ?? "Khóa học";
                        int graduated = 0, total = 0;
                        int.TryParse(row["GraduatedCount"]?.ToString() ?? "0", out graduated);
                        int.TryParse(row["TotalStudents"]?.ToString() ?? "0", out total);

                        // nếu total == 0 thì bỏ qua hoặc hiển thị 0
                        if (total <= 0)
                        {
                            series.Points.AddXY(courseName + " (Không có HV)", 1);
                        }
                        else
                        {
                            // Thêm hai slice cho pie
                            if (graduated > 0)
                                series.Points.AddXY(courseName + " (Tốt nghiệp)", graduated);
                            int notGraduated = total - graduated;
                            if (notGraduated > 0)
                                series.Points.AddXY(courseName + " (Chưa TN)", notGraduated);
                        }
                    }
                }

                chart.Series.Add(series);
                chart.Titles.Add($"Tỉ lệ tốt nghiệp theo khóa học ({year})");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chart tỉ lệ tốt nghiệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Helper - gọi API và trả về DataTable
        private async Task<DataTable> GetDataTableFromApi(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var fullUrl = _thongkeurl + url;
                    var response = await client.GetStringAsync(fullUrl);

                    if (string.IsNullOrWhiteSpace(response))
                        return new DataTable();

                    // Deserialize JSON -> DataTable
                    var dt = JsonConvert.DeserializeObject<DataTable>(response);
                    return dt ?? new DataTable();
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Lỗi kết nối tới API: " + httpEx.Message, "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý dữ liệu từ API: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        #endregion

        // Event handler do bạn đã binding sẵn trong Designer:
        private async void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem == null) return;

            if (!int.TryParse(cboYear.SelectedItem.ToString(), out int selectedYear)) return;

            await LoadDashboardAsync(selectedYear);
        }

        // Nếu bạn vẫn muốn action khi form Load (Designer đã bind frmThongKe_Load), có thể để trống hoặc gọi LoadDashboard ở đây.
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            // không cần làm gì ở đây vì constructor đã gọi LoadDashboard cho năm mặc định
        }
    }
}
