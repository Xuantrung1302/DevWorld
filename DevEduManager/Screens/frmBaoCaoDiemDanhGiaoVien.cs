using BusinessLogic;
using Enity.Models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmBaoCaoDiemDanhGiaoVien : Form
    {
        private CallAPI callAPI = new CallAPI();
        private string _hostApiConfig = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/";
        private List<ThongTinGiangDay> _thongTinGiangDay;
        private List<BaoCaoDiemDanh> _baoCaoDiemDanh;


        public frmBaoCaoDiemDanhGiaoVien()
        {
            InitializeComponent();
            _thongTinGiangDay = new List<ThongTinGiangDay>();
            _baoCaoDiemDanh = new List<BaoCaoDiemDanh>();
        }

        private async Task SetupDataGridView()
        {
            var courseId = cboChuongTrinhHoc.SelectedValue.ToString();
            var classId = cboLopHoc.SelectedValue.ToString();
            var subjectId = cboMonHoc.SelectedValue.ToString();

            string url = $"{_hostApiConfig}Record/baoCaodanhSachDiemDanh?courseID={courseId}&classID={classId}&subjectID={subjectId}";
            _baoCaoDiemDanh = await callAPI.GetAPI<BaoCaoDiemDanh>(url);

            var thongTinNgayHoc = _thongTinGiangDay
                .Where(x => x.CourseID == courseId
                         && x.ClassID == classId
                         && x.SubjectID == subjectId)
                .GroupBy(x => new { x.ClassScheduleID, x.Date.Date })
                .Select(g => g.Key)
                .OrderBy(x => x.Date)
                .ToList();

            gridReportAttendance.Columns.Clear();
            // Ngăn DataGridView tự tạo cột
            gridReportAttendance.AutoGenerateColumns = false;

            // Thêm cột Mã HV và Tên HV
            var colMaHV = new DataGridViewTextBoxColumn();
            colMaHV.Name = "MaHV";
            colMaHV.HeaderText = "Mã học viên";
            colMaHV.DataPropertyName = "StudentID";
            gridReportAttendance.Columns.Add(colMaHV);

            var colTenHV = new DataGridViewTextBoxColumn();
            colTenHV.Name = "TenHV";
            colTenHV.HeaderText = "Tên học viên";
            colTenHV.DataPropertyName = "StudentName";
            gridReportAttendance.Columns.Add(colTenHV);

            foreach (var ngayHoc in thongTinNgayHoc)
            {
                gridReportAttendance.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = $"Schedule_{ngayHoc.ClassScheduleID}",
                    HeaderText = ngayHoc.Date.ToString("dd/MM/yyyy"),
                    DataPropertyName = $"Schedule_{ngayHoc.ClassScheduleID}"
                });
            }


            //// Thêm 8 cột ngày học
            //DateTime startDate = new DateTime(2025, 6, 1);
            //for (int i = 0; i < 8; i++)
            //{
            //    string colName = "Ngay" + (i + 1);
            //    string headerText = startDate.AddDays(i).ToString("yyyy-MM-dd");
            //    gridReportAttendance.Columns.Add(colName, headerText);
            //}

            // Thêm cột phần trăm
            gridReportAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AttendancePercentage",
                HeaderText = "Phần trăm",
                DataPropertyName = "AttendancePercentage",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "P1" }
            });

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
            gridReportAttendance.Columns["AttendancePercentage"].Width = 100;

            var distinctStudents = _baoCaoDiemDanh
                .GroupBy(x => new { x.StudentID, x.StudentName })
                .Select(g => g.Key)
                .ToList();

            var dataTable = new DataTable();

            // Thêm cột mã, tên
            dataTable.Columns.Add("StudentID");
            dataTable.Columns.Add("StudentName");

            // Thêm cột động cho từng buổi học
            foreach (var ngayHoc in thongTinNgayHoc)
            {
                dataTable.Columns.Add($"Schedule_{ngayHoc.ClassScheduleID}");
            }

            // Cột % (tuỳ chọn)
            dataTable.Columns.Add("AttendancePercentage", typeof(double));

            foreach (var sv in distinctStudents)
            {
                var row = dataTable.NewRow();
                row["StudentID"] = sv.StudentID;
                row["StudentName"] = sv.StudentName;

                int totalLich = thongTinNgayHoc.Count;
                int diemDanhCoThongTin = 0;
                int diemDanhDung = 0;

                foreach (var ngayHoc in thongTinNgayHoc)
                {
                    var record = _baoCaoDiemDanh
                        .FirstOrDefault(x => x.StudentID == sv.StudentID && x.Class_ScheID == ngayHoc.ClassScheduleID);

                    if (record == null || record.IsLearned == false)
                    {
                        row[$"Schedule_{ngayHoc.ClassScheduleID}"] = "Chưa học";
                    }
                    else
                    {
                        var giaTri = (record.AttendanceID == Guid.Empty || record.AttendanceID == null || !record.Status)
                                     ? "A"
                                     : "P";

                        row[$"Schedule_{ngayHoc.ClassScheduleID}"] = giaTri;

                        diemDanhCoThongTin++;
                        if (giaTri == "P") diemDanhDung++;
                    }
                }

                // Tính phần trăm học (trên tổng 8 buổi lịch)
                double percent = totalLich == 0 ? 0 : (double)diemDanhDung / totalLich;
                row["AttendancePercentage"] = percent;

                dataTable.Rows.Add(row);
            }

            // Đổ vào DataGridView
            gridReportAttendance.DataSource = dataTable;


            // Màu sắc cho "P"/"A"
            gridReportAttendance.CellFormatting += gridReportAttendance_CellFormatting;
            // Không cho chỉnh sửa dữ liệu
            gridReportAttendance.ReadOnly = true;

            // Không cho phép resize cột
            gridReportAttendance.AllowUserToResizeColumns = false;

            // Không cho phép resize dòng
            gridReportAttendance.AllowUserToResizeRows = false;

            // Không cho phép người dùng sắp xếp cột (tuỳ chọn)
            foreach (DataGridViewColumn column in gridReportAttendance.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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
            cboMonHoc.Enabled = false;
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

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            await SetupDataGridView();
        }
    }
}
