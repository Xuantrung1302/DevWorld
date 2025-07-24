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
        private List<KyHoc> _semesters;
        private List<MonHoc> _subjects;
        private List<LopDay> _classes;
        private List<DiemDanh> _attendance;
        private CallAPI callAPI = new CallAPI();
        private string _hostApiConfig = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/";

        public frmDiemDanhGiaoVien()
        {
            InitializeComponent();
            _semesters = new List<KyHoc>();
            _subjects = new List<MonHoc>();
            _classes = new List<LopDay>();
        }

        private async void frmDiemDanhGiaoVien_Load(object sender, EventArgs e)
        {
            await GetData();
            LoadComboBoxSemester();
            cboKyHoc.SelectedIndexChanged += new EventHandler(cboKyHoc_SelectedIndexChanged);
        }

        private async Task GetData()
        {
            try
            {
                string url = $"{_hostApiConfig}Semester/thongTinKyHoc";
                _semesters = await callAPI.GetAPI<KyHoc>(url);

                url = $"{_hostApiConfig}Subject/thongTinMonHoc";
                _subjects = await callAPI.GetAPI<MonHoc>(url);

                url = $"{_hostApiConfig}Teacher/thongTinLopDay?teacherID={UserSession.UserId}";
                _classes = await callAPI.GetAPI<LopDay>(url);
            }
            catch (Exception ex)
            {

            }
        }

        private void cboKyHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cboKyHoc.SelectedValue?.ToString();

            if (selectedId is null) return;

            LoadComboBoxSubject(selectedId);
            cboMonHoc.Enabled = true;
            cboLop.Enabled = false;
            cboLop.DataSource = null;
            cboNgayHoc.Enabled = false;
            cboNgayHoc.DataSource = null;
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cboMonHoc.SelectedValue?.ToString();

            if (selectedId is null) return;
            LoadComboBoxClass(selectedId);
            cboLop.Enabled = true;
            cboNgayHoc.Enabled = false;
            cboNgayHoc.DataSource = null;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cboLop.SelectedValue?.ToString();

            if (selectedId is null) return;
            LoadComboBoxDate(selectedId);
            cboNgayHoc.Enabled = true;
        }

        private void LoadComboBoxSemester()
        {
            cboKyHoc.DataSource = _semesters;
            cboKyHoc.DisplayMember = "SemesterName";
            cboKyHoc.ValueMember = "SemesterID";
        }

        private void LoadComboBoxSubject(string semesterId)
        {
            var filteredSubjects = _subjects
                .Where(s => s.SemesterID == semesterId)
                .ToList();

            cboMonHoc.DataSource = filteredSubjects;
            cboMonHoc.DisplayMember = "SubjectName";
            cboMonHoc.ValueMember = "SubjectID";
        }

        private void LoadComboBoxClass(string subjectId)
        {
            var filteredClasses = _classes
                .Where(s => s.SubjectID == subjectId)
                .ToList();

            cboLop.DataSource = filteredClasses;
            cboLop.DisplayMember = "ClassName";
            cboLop.ValueMember = "ClassID";
        }

        private void LoadComboBoxDate(string classID)
        {
            var uniqueDates = _classes
                .Where(l => l.ClassID == classID)
                .Select(l => l.StartTime.Date)
                .Distinct()
                .OrderBy(d => d)
                .Select(d => new
                {
                    Text = d.ToString("yyyy-MM-dd"),
                    Value = d
                })
                .ToList();

            cboNgayHoc.DisplayMember = "Text";
            cboNgayHoc.ValueMember = "Value";
            cboNgayHoc.DataSource = uniqueDates;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string semesterId = cboKyHoc.SelectedValue.ToString();
            string subjectId = cboMonHoc.SelectedValue.ToString();
            string classId = cboLop.SelectedValue.ToString();
            DateTime selectedDate = (DateTime)cboNgayHoc.SelectedValue;
            string url = $"{_hostApiConfig}Record/danhSachDiemDanh?semesterID={semesterId}&subjectID={subjectId}&classID={classId}";
            _attendance = await callAPI.GetAPI<DiemDanh>(url);

            var diemDanhViewList = _attendance
                .Where(p => p.StartTime.Date == selectedDate)
                .Select(dd => new DiemDanhViewModel
                {
                    AttendanceID = dd.AttendanceID,
                    StudentID = dd.StudentID,
                    StudentName = dd.StudentName,
                    Notes = dd.Notes,
                    IsChecked = dd.Status == 1
                })
                .ToList();

            dgvHV.AutoGenerateColumns = false;
            if (diemDanhViewList.Any())
            {
                dgvHV.DataSource = diemDanhViewList;
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            //var giangVien = new GiangVien()
            //{
            //    TeacherID = txtMaGV.Text,
            //    FullName = txtTenGV.Text,
            //    Gender = cboGioiTinh.SelectedItem.ToString(),
            //    Address = txtDiaChi.Text,
            //    Degree = txtBangCap.Text,
            //    PhoneNumber = txtSDT.Text,
            //    Email = txtEmail.Text,
            //    Username = txtTenDangNhap.Text,
            //    Password = txtMatKhau.Text
            //};

            //string jsonData = JsonConvert.SerializeObject(giangVien);

            //string url = $"{_hostApiConfig}Record/suaThongTinDiemDanh";
            //var result = await callAPI.PostAPI(url, jsonData);

            //if (result)
            //{
            //    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void dgvHV_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvHV.IsCurrentCellDirty && dgvHV.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvHV.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private async void dgvHV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHV.Columns[e.ColumnIndex].Name == "clmDiemDanh")
            {
                var row = dgvHV.Rows[e.RowIndex];

                var maDiemDanh = row.Cells["clmMaDiemDanh"].Value?.ToString();

                bool isChecked = Convert.ToBoolean(row.Cells["clmDiemDanh"].Value);
                int status = isChecked ? 1 : 2;

                DiemDanh diemDanh = new DiemDanh()
                {
                    AttendanceID = Guid.Parse(maDiemDanh),
                    Status = status,
                    RecordedBy = UserSession.UserId
                };

                string jsonData = JsonConvert.SerializeObject(diemDanh);

                string url = $"{_hostApiConfig}Record/suaThongTinDiemDanh";
                var result = await callAPI.PostAPI(url, jsonData);
            }
        }
    }
}
