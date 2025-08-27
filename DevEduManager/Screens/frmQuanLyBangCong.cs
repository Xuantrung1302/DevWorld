using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyBangCong : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _employeeUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Employee/";

        public frmQuanLyBangCong()
        {
            InitializeComponent();
            InitializeComponents();
            LoadMonths();
            LoadYears();
            cboYear.SelectedIndexChanged += CboYear_SelectedIndexChanged;
            cboMonth.SelectedIndexChanged += CboMonth_SelectedIndexChanged;
            btnTimKiem.Click += BtnTimKiem_Click;
        }

        private void InitializeComponents()
        {
            // Cấu hình DataGridView
            dtgvSoCong.AllowUserToAddRows = false;
            dtgvSoCong.RowHeadersVisible = false;
            dtgvSoCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSoCong.Columns.Add("Date", "Ngày");
            dtgvSoCong.Columns.Add("WorkDays", "Số công");
        }

        private void LoadMonths()
        {
            var months = new Dictionary<int, string>
            {
                { 1, "Tháng 1" }, { 2, "Tháng 2" }, { 3, "Tháng 3" }, { 4, "Tháng 4" },
                { 5, "Tháng 5" }, { 6, "Tháng 6" }, { 7, "Tháng 7" }, { 8, "Tháng 8" },
                { 9, "Tháng 9" }, { 10, "Tháng 10" }, { 11, "Tháng 11" }, { 12, "Tháng 12" }
            };
            cboMonth.DataSource = new BindingSource(months, null);
            cboMonth.DisplayMember = "Value";
            cboMonth.ValueMember = "Key";
        }

        private void LoadYears()
        {
            var years = new Dictionary<int, string>
            {
                { 2023, "2023" }, { 2024, "2024" }, { 2025, "2025" }, { 2026, "2026" }
            };
            cboYear.DataSource = new BindingSource(years, null);
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
        }

        private async void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedValue != null && cboMonth.SelectedValue != null)
            {
                await LoadEmployeesAsync(Convert.ToInt32(cboYear.SelectedValue), Convert.ToInt32(cboMonth.SelectedValue));
            }
        }

        private async void CboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedValue != null && cboMonth.SelectedValue != null)
            {
                await LoadEmployeesAsync(Convert.ToInt32(cboYear.SelectedValue), Convert.ToInt32(cboMonth.SelectedValue));
            }
        }

        private async Task LoadEmployeesAsync(int year, int month)
        {
            try
            {
                string url = $"{_employeeUrl}danhSachNVHours?year={year}&month={month}";
                DataTable dt = await callAPI.GetAPI(url);

                cboNV.DataSource = null;
                cboNV.DisplayMember = "FullName";
                cboNV.ValueMember = "EmployeeID";

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboNV.DataSource = dt;
                    cboNV.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNV.SelectedValue == null || cboMonth.SelectedValue == null || cboYear.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên, tháng và năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string _selectedEmployeeId = cboNV.SelectedValue.ToString();
                int selectedMonth = Convert.ToInt32(cboMonth.SelectedValue);
                int selectedYear = Convert.ToInt32(cboYear.SelectedValue);

                await LoadWorkingHours(_selectedEmployeeId, selectedMonth, selectedYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadWorkingHours(string employeeId, int month, int year)
        {
            try
            {
                dtgvSoCong.Rows.Clear();

                // Gọi API để lấy bảng công (endpoint bạn cần tạo bên API)
                string url = $"{_employeeUrl}tongSoGioCongCuaNhanVienTheoThang?employeeID={employeeId}&Month={month}&Year={year}";
                DataTable dt = await callAPI.GetAPI(url);

                decimal totalHours = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime recordDate = Convert.ToDateTime(row["RecordDate"]);
                        decimal workingHours = Convert.ToDecimal(row["WorkDays"]);
                        int rowIndex = dtgvSoCong.Rows.Add();
                        dtgvSoCong.Rows[rowIndex].Cells["Date"].Value = recordDate.ToString("dd/MM/yyyy");
                        dtgvSoCong.Rows[rowIndex].Cells["WorkDays"].Value = workingHours;
                        totalHours += workingHours;
                    }

                    // Thêm dòng tổng
                    int totalRowIndex = dtgvSoCong.Rows.Add();
                    dtgvSoCong.Rows[totalRowIndex].Cells["Date"].Value = "Tổng cộng";
                    dtgvSoCong.Rows[totalRowIndex].Cells["WorkDays"].Value = totalHours;
                    dtgvSoCong.Rows[totalRowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dtgvSoCong.Rows[totalRowIndex].DefaultCellStyle.Font = new Font(dtgvSoCong.Font, FontStyle.Bold);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chấm công cho nhân viên này trong tháng/năm đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải bảng công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
