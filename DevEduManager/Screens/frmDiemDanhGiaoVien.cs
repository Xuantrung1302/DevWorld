using BusinessLogic;
using Enity.Models;
using Entity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmDiemDanhGiaoVien : Form
    {
        private List<ThongTinGiangDay> _thongTinGiangDay;
        private List<DiemDanhViewModel> _attendance;
        private CallAPI callAPI = new CallAPI();
        private string _hostApiConfig = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/";

        public frmDiemDanhGiaoVien()
        {
            InitializeComponent();
            _thongTinGiangDay = new List<ThongTinGiangDay>();
        }

        private async void frmDiemDanhGiaoVien_Load(object sender, EventArgs e)
        {
            string url = $"{_hostApiConfig}Teacher/thongTinGiangDay?teacherID={UserSession.UserId}";
            _thongTinGiangDay = await callAPI.GetAPI<ThongTinGiangDay>(url);

            LoadComboBoxCourse();
            cboChuongTrinhHoc.SelectedIndexChanged += new EventHandler(cboChuongTrinhHoc_SelectedIndexChanged);
        }

        private void cboChuongTrinhHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cboChuongTrinhHoc.SelectedValue?.ToString();

            if (selectedId is null) return;

            LoadComboBoxClass();
            cboLopHoc.Enabled = true;
            cboMonHoc.Enabled = false;
            cboMonHoc.DataSource = null;
            cboNgayHoc.Enabled = false;
            cboNgayHoc.DataSource = null;
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuongTrinhHoc.SelectedValue is null || cboLopHoc.SelectedValue is null)
                return;

            LoadComboBoxSubject();
            cboMonHoc.Enabled = true;
            cboNgayHoc.Enabled = false;
            cboNgayHoc.DataSource = null;
        }

        private void cboMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuongTrinhHoc.SelectedValue is null || cboLopHoc.SelectedValue is null || cboMonHoc.SelectedValue is null)
                return;
            LoadComboBoxDate();
            cboNgayHoc.Enabled = true;
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

        private void LoadComboBoxDate()
        {
            string courseID = cboChuongTrinhHoc.SelectedValue.ToString();
            string classID = cboLopHoc.SelectedValue.ToString();
            string subjectID = cboMonHoc.SelectedValue.ToString();

            var ngayHocList = _thongTinGiangDay
                .Where(x => x.CourseID == courseID
                         && x.ClassID == classID
                         && x.SubjectID == subjectID)
                .GroupBy(x => new { x.ClassScheduleID, x.Date.Date })
                .Select(g => g.Key)
                .OrderBy(x => x.Date)
                .ToList();

            cboNgayHoc.DataSource = ngayHocList;
            cboNgayHoc.DisplayMember = "Date";
            cboNgayHoc.ValueMember = "ClassScheduleID";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadGrid();
        }

        private async Task LoadGrid()
        {
            var selectedSchedule = cboNgayHoc.SelectedValue.ToString();
            string url = $"{_hostApiConfig}Record/danhSachDiemDanh?scheduleID={selectedSchedule}";
            _attendance = await callAPI.GetAPI<DiemDanhViewModel>(url);

            dgvHV.AutoGenerateColumns = false;
            if (_attendance.Any())
            {
                dgvHV.DataSource = _attendance;
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (_attendance == null || !_attendance.Any())
            {
                MessageBox.Show("Không có dữ liệu để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid classScheduleId = Guid.Parse(cboNgayHoc.SelectedValue.ToString());

            var diemDanhModel = new DiemDanh
            {
                ClassScheduleID = classScheduleId,
                RecordedBy = UserSession.UserId,
                ChiTiet = new List<ChiTietDiemDanh>()
            };

            foreach (DataGridViewRow row in dgvHV.Rows)
            {
                if (row.DataBoundItem is DiemDanhViewModel hv)
                {
                    diemDanhModel.ChiTiet.Add(new ChiTietDiemDanh
                    {
                        StudentID = hv.StudentID,
                        Status = hv.Status,
                        Notes = hv.Notes
                    });
                }
            }

            string url = $"{_hostApiConfig}Record/themThongTinDiemDanh";
            string json = JsonConvert.SerializeObject(diemDanhModel);

            bool success = await callAPI.PostAPI(url, json);

            if (success)
            {
                MessageBox.Show("Lưu điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu điểm danh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await LoadGrid();
        }

        private void cboNgayHoc_EnabledChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = cboNgayHoc.Enabled;
        }

        private void cboNgayHoc_Format(object sender, ListControlConvertEventArgs e)
        {
            var item = (dynamic)e.ListItem;
            if (item != null)
            {
                DateTime date = item.Date;
                e.Value = date.ToString("yyyy-MM-dd");
            }
        }
    }
}
