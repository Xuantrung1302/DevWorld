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
    public partial class frmQuanLySoGioDayHoc : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _teacherUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Teacher/";
        private int selectedTeacherId = -1;

        public frmQuanLySoGioDayHoc()
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
            dtgvHourTeach.AllowUserToAddRows = false;
            dtgvHourTeach.RowHeadersVisible = false;
            dtgvHourTeach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHourTeach.Columns.Add("Date", "Ngày");
            dtgvHourTeach.Columns.Add("TeachingHours", "Số giờ dạy");
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
            //cboMonth.SelectedIndex = DateTime.Now.Month - 1; // Mặc định tháng hiện tại (Tháng 8)
        }

        private void LoadYears()
        {
            var years = new Dictionary<int, string>
            {
                { 2024, "2024" }, { 2025, "2025" }
            };
            cboYear.DataSource = new BindingSource(years, null);
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            //cboYear.SelectedIndex = DateTime.Now.Year - 2023; // Mặc định năm hiện tại (2025)
        }

        private async void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedValue != null && cboMonth.SelectedValue != null)
            {
                await LoadTeachersAsync(Convert.ToInt32(cboYear.SelectedValue), Convert.ToInt32(cboMonth.SelectedValue));
            }
        }

        private async void CboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedValue != null && cboMonth.SelectedValue != null)
            {
                await LoadTeachersAsync(Convert.ToInt32(cboYear.SelectedValue), Convert.ToInt32(cboMonth.SelectedValue));
            }
        }

        private async Task LoadTeachersAsync(int year, int month)
        {
            try
            {
                string url = $"{_teacherUrl}danhSachGVHours?year={year}&month={month}";
                DataTable dt = await callAPI.GetAPI(url);

                cboGV.DataSource = null;
                cboGV.DisplayMember = "FullName";
                cboGV.ValueMember = "TeacherID";

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboGV.DataSource = dt;
                    cboGV.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách giảng viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboGV.SelectedValue == null || cboMonth.SelectedValue == null || cboYear.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên, tháng và năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string _selectedTeacherId = cboGV.SelectedValue.ToString();
                int selectedMonth = Convert.ToInt32(cboMonth.SelectedValue);
                int selectedYear = Convert.ToInt32(cboYear.SelectedValue);

                await LoadTeachingHours(_selectedTeacherId, selectedMonth, selectedYear);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task LoadTeachingHours(string teacherId, int month, int year)
        {
            try
            {
                dtgvHourTeach.Rows.Clear();

                // Gọi API để lấy số giờ dạy (giả định endpoint dựa trên Payroll)
                string url = $"{_teacherUrl}tongSoGioDayCuaGiangVienTheoThang?teacherID={teacherId}&Month={month}&Year={year}"; // Bạn sẽ sửa đường dẫn
                DataTable dt = await callAPI.GetAPI(url);

                decimal totalHours = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime recordDate = Convert.ToDateTime(row["RecordDate"]);
                        decimal teachingHours = Convert.ToDecimal(row["TeachingHours"]);
                        int rowIndex = dtgvHourTeach.Rows.Add();
                        dtgvHourTeach.Rows[rowIndex].Cells["Date"].Value = recordDate.ToString("dd/MM/yyyy");
                        dtgvHourTeach.Rows[rowIndex].Cells["TeachingHours"].Value = teachingHours;
                        totalHours += teachingHours;
                    }

                    // Thêm dòng tổng
                    int totalRowIndex = dtgvHourTeach.Rows.Add();
                    dtgvHourTeach.Rows[totalRowIndex].Cells["Date"].Value = "Tổng cộng";
                    dtgvHourTeach.Rows[totalRowIndex].Cells["TeachingHours"].Value = totalHours;
                    dtgvHourTeach.Rows[totalRowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dtgvHourTeach.Rows[totalRowIndex].DefaultCellStyle.Font = new Font(dtgvHourTeach.Font, FontStyle.Bold);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu số giờ dạy cho giảng viên này trong tháng/năm đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải số giờ dạy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}