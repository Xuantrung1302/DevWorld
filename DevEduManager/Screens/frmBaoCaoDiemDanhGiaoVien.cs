using BusinessLogic;
using Enity.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmBaoCaoDiemDanhGiaoVien : Form
    {
        private List<ThongTinGiangDay> _thongTinGiangDay;
        private CallAPI callAPI = new CallAPI();
        private string _hostApiConfig = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/";

        public frmBaoCaoDiemDanhGiaoVien()
        {
            InitializeComponent();
            _thongTinGiangDay = new List<ThongTinGiangDay>();
        }

        private void SetupDataGridView()
        {
            gridReportAttendance.Columns.Clear();

            // Thêm cột Mã HV và Tên HV
            gridReportAttendance.Columns.Add("MaHV", "Mã HV");
            gridReportAttendance.Columns.Add("TenHV", "Tên HV");

            // Thêm 8 cột ngày học
            DateTime startDate = new DateTime(2025, 6, 1);
            for (int i = 0; i < 8; i++)
            {
                string colName = "Ngay" + (i + 1);
                string headerText = startDate.AddDays(i).ToString("yyyy-MM-dd");
                gridReportAttendance.Columns.Add(colName, headerText);
            }

            // Thêm cột phần trăm
            gridReportAttendance.Columns.Add("PhanTram", "Phần trăm");

            // Căn chỉnh và định dạng
            gridReportAttendance.RowHeadersVisible = false;
            gridReportAttendance.AllowUserToAddRows = false;
            gridReportAttendance.ColumnHeadersHeight = 60;
            gridReportAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            gridReportAttendance.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            gridReportAttendance.EnableHeadersVisualStyles = false;

            gridReportAttendance.Columns["MaHV"].Width = 100;
            gridReportAttendance.Columns["TenHV"].Width = 160;
            for (int i = 2; i <= 9; i++)
            {
                gridReportAttendance.Columns[i].Width = 80;
            }
            gridReportAttendance.Columns["PhanTram"].Width = 100;

            // Dữ liệu minh họa (8 buổi học)
            string[] hocVien1 = { "HV001", "Nguyễn Văn A", "P", "A", "P", "P", "P", "A", "P", "P" };
            string[] hocVien2 = { "HV002", "Trần Thị B", "A", "A", "A", "P", "A", "P", "P", "A" };

            // Tính phần trăm vắng
            string[] row1 = hocVien1.Append(CalculateAbsentPercentage(hocVien1.Skip(2).ToArray())).ToArray();
            string[] row2 = hocVien2.Append(CalculateAbsentPercentage(hocVien2.Skip(2).ToArray())).ToArray();

            gridReportAttendance.Rows.Add(row1);
            gridReportAttendance.Rows.Add(row2);

            // Màu sắc cho "P"/"A"
            gridReportAttendance.CellFormatting += gridReportAttendance_CellFormatting;
        }

        private string CalculateAbsentPercentage(string[] attendance)
        {
            int total = attendance.Length;
            int absentCount = attendance.Count(s => s == "A");
            double percent = (double)absentCount / total * 100;
            return percent.ToString("0.#") + "%";
        }

        private void gridReportAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 2 && e.ColumnIndex <= 9) // 8 cột ngày học
            {
                if (e.Value != null && e.Value.ToString() == "P")
                    e.CellStyle.BackColor = Color.LightGreen;
                else if (e.Value != null && e.Value.ToString() == "A")
                    e.CellStyle.BackColor = Color.LightCoral;
            }
        }

        private async void frmBaoCaoDiemDanhGiaoVien_Load(object sender, EventArgs e)
        {
            string url = $"{_hostApiConfig}Teacher/thongTinGiangDay?teacherID={UserSession.UserId}";
            _thongTinGiangDay = await callAPI.GetAPI<ThongTinGiangDay>(url);

            LoadComboBoxCourse();
            cboChuongTrinhHoc.SelectedIndexChanged += new EventHandler(cboChuongTrinhHoc_SelectedIndexChanged);
            cboLopHoc.Enabled = false;
        }

        private void cboChuongTrinhHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cboChuongTrinhHoc.SelectedValue?.ToString();

            if (selectedId is null) return;

            LoadComboBoxClass();
            cboLopHoc.Enabled = true;
            cboMonHoc.Enabled = false;
            cboMonHoc.DataSource = null;
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuongTrinhHoc.SelectedValue is null || cboLopHoc.SelectedValue is null)
                return;

            LoadComboBoxSubject();
            cboMonHoc.Enabled = true;
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxCourse()
        {
            var chuongTrinhs = _thongTinGiangDay
                .GroupBy(x => new { x.CourseID, x.CourseName })
                .Select(g => g.Key)
                .ToList();

            cboChuongTrinhHoc.DataSource = chuongTrinhs;
            cboChuongTrinhHoc.DisplayMember = "CourseName";
            cboChuongTrinhHoc.ValueMember = "CourseID";
        }

        private void LoadComboBoxSubject()
        {
            string selectedCourseID = cboChuongTrinhHoc.SelectedValue.ToString();
            string selectedClassID = cboLopHoc.SelectedValue.ToString();

            var filteredSubjects = _thongTinGiangDay
                .Where(x => x.CourseID == selectedCourseID && x.ClassID == selectedClassID)
                .GroupBy(x => new { x.SubjectID, x.SubjectName })
                .Select(g => g.Key)
                .ToList();

            cboMonHoc.DataSource = filteredSubjects;
            cboMonHoc.DisplayMember = "SubjectName";
            cboMonHoc.ValueMember = "SubjectID";
        }

        private void LoadComboBoxClass()
        {
            string selectedCourseID = cboChuongTrinhHoc.SelectedValue.ToString();

            var filteredClasses = _thongTinGiangDay
                .Where(x => x.CourseID == selectedCourseID)
                .GroupBy(x => new { x.ClassID, x.ClassName })
                .Select(g => g.Key)
                .ToList();

            cboLopHoc.DataSource = filteredClasses;
            cboLopHoc.DisplayMember = "ClassName";
            cboLopHoc.ValueMember = "ClassID";
        }

        private void cboMonHoc_EnabledChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = cboMonHoc.Enabled;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
        }
    }
}
