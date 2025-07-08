using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyLopHoc : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private string _semesterUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";

        public frmQuanLyLopHoc()
        {
            InitializeComponent();
            // Disable auto-generated columns
            gridLop.AutoGenerateColumns = false;
            gridListStudent.AutoGenerateColumns = false;
        }

        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                // Load semesters into combo box
                //LoadComBoSemester();
                // Load classes for the selected semester
                LoadDataToGridView();
                // Enable/disable text boxes based on checkboxes
                txtTenMon.Enabled = chkTenMon.Checked;
                txtTenLop.Enabled = chkTenLop.Checked;
                // Load students for the first class if available
                if (gridLop.Rows.Count > 0)
                {
                    gridLop.Rows[0].Selected = true;
                    LoadStudentData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async  void LoadComBoSemester()
        {
            try
            {
                string url = $"{_semesterUrl}thongTinKyHoc";
                DataTable result = await callAPI.GetAPI(url);
                cboKy.DataSource = result;
                cboKy.DisplayMember = "SemesterName";
                cboKy.ValueMember = "SemesterID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách kỳ học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void LoadDataToGridView()
        {
            try
            {
                //string semesterId = cboKy.SelectedValue?.ToString();
                //if (string.IsNullOrEmpty(semesterId))
                //    return;

                // Construct API URL for classes with semester filter
                string url = $"{_classUrl}layLop";
                //if (chkTenMon.Checked && !string.IsNullOrEmpty(txtTenMon.Text))
                //    url += $"&subjectName={Uri.EscapeDataString(txtTenMon.Text)}";
                //if (chkTenLop.Checked && !string.IsNullOrEmpty(txtTenLop.Text))
                //    url += $"&className={Uri.EscapeDataString(txtTenLop.Text)}";

                DataTable result = await callAPI.GetAPI(url);
                gridLop.AutoGenerateColumns = false;
                gridLop.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lớp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadStudentData()
        {
            try
            {
                if (gridLop.SelectedRows.Count == 0)
                {
                    gridListStudent.DataSource = null;
                    return;
                }

                string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();
                if (string.IsNullOrEmpty(classId))
                {
                    gridListStudent.DataSource = null;
                    return;
                }

                string url = $"{_classUrl}layDanhSachSinhVienTheoLop?classID={Uri.EscapeDataString(classId)}";
                DataTable result = await callAPI.GetAPI(url);
                gridListStudent.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ValidateSearch()
        {
            if (chkTenMon.Checked && string.IsNullOrEmpty(txtTenMon.Text))
                throw new ArgumentException("Tên môn không được trống");
            if (chkTenLop.Checked && string.IsNullOrEmpty(txtTenLop.Text))
                throw new ArgumentException("Tên lớp không được trống");
        }



        private void chkTenLop_CheckedChanged(object sender, EventArgs e)
        {
            txtTenLop.Enabled = chkTenLop.Checked;
            if (!chkTenLop.Checked)
                txtTenLop.Text = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();
                LoadDataToGridView();
                if (gridLop.Rows.Count > 0)
                {
                    gridLop.Rows[0].Selected = true;
                    LoadStudentData();
                }
                else
                {
                    gridListStudent.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gridLop.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();
                //string semesterName = ((DataRowView)cboKy.SelectedItem)["SemesterName"].ToString();
                string semesterName = cboKy.Text; // Lấy giá trị đang hiển thị (tên học kỳ)

                //string className = gridLop.SelectedRows[0].Cells["TenLop"].Value?.ToString();
                // Fetch max students from API or configuration
                //string url = $"{_classUrl}thongTinLopHoc?classID={Uri.EscapeDataString(classId)}";
                //DataTable classInfo = callAPI.GetAPI(url).Result;
                //int maxStudents = classInfo.Rows.Count > 0 ? Convert.ToInt32(classInfo.Rows[0]["MaxStudents"]) : 30;

                frmThemHocVienVaoLop frm = new frmThemHocVienVaoLop(classId, semesterName);
                frm.ShowDialog();
                // Reload student data after adding
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form thêm học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkTenMon.Checked = false;
            chkTenLop.Checked = false;
            txtTenMon.Text = string.Empty;
            txtTenLop.Text = string.Empty;
            LoadDataToGridView();
            if (gridLop.Rows.Count > 0)
            {
                gridLop.Rows[0].Selected = true;
                LoadStudentData();
            }
            else
            {
                gridListStudent.DataSource = null;
            }
        }

       
        private void cboKy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDataToGridView();
            if (gridLop.Rows.Count > 0)
            {
                gridLop.Rows[0].Selected = true;
                LoadStudentData();
            }
            else
            {
                gridListStudent.DataSource = null;
            }
        }

        private void gridLop_SelectionChanged_1(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void chkTenMon_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTenMon.Enabled = chkTenMon.Checked;
            if (!chkTenMon.Checked)
                txtTenMon.Text = string.Empty;
        }

        private void frmQuanLyLopHoc_Shown(object sender, EventArgs e)
        {
            LoadComBoSemester();
        }
    }
}