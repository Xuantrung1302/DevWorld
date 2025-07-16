using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyLopHoc : Form
    {
        private readonly CallAPI callAPI = new CallAPI();

        private readonly string _courseUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private readonly string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";

        public frmQuanLyLopHoc()
        {
            InitializeComponent();
            gridLop.AutoGenerateColumns = false;
            gridListStudent.AutoGenerateColumns = false;
        }

        private async void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxCourseAsync();

                txtTenMon.Enabled = chkTenMon.Checked;
                txtTenLop.Enabled = chkTenLop.Checked;

                if (gridLop.Rows.Count > 0)
                {
                    gridLop.Rows[0].Selected = true;
                    await LoadStudentDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadComboBoxCourseAsync()
        {
            try
            {
                string url = $"{_courseUrl}danhSachKhoaHoc";
                DataTable dt = await callAPI.GetAPI(url);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboCT.SelectedIndexChanged -= cboCT_SelectedIndexChanged;

                    cboCT.DataSource = dt;
                    cboCT.DisplayMember = "CourseName";
                    cboCT.ValueMember = "CourseID";

                    cboCT.SelectedIndex = 0;

                    cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;

                    string selectedCourseID = cboCT.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(selectedCourseID))
                        await LoadClassDataAsync(selectedCourseID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khóa học: " + ex.Message);
            }
        }

        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCT.SelectedValue != null && Guid.TryParse(cboCT.SelectedValue.ToString(), out Guid courseId))
                {
                    await LoadClassDataAsync(courseId.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn khóa học: " + ex.Message);
            }
        }

        private async Task LoadClassDataAsync(string courseId)
        {
            try
            {
                string url = $"{_courseUrl}chiTietChuongTrinhHoc?CourseID={courseId}";
                DataTable dt = await callAPI.GetAPI(url);
                gridLop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
            }
        }

        private async Task LoadStudentDataAsync()
        {
            try
            {
                if (gridLop.SelectedRows.Count == 0)
                {
                    gridListStudent.DataSource = null;
                    return;
                }

                string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();
                if (string.IsNullOrEmpty(classId)) return;

                string url = $"{_classUrl}layDanhSachSinhVienTheoLop?classID={Uri.EscapeDataString(classId)}";
                DataTable dt = await callAPI.GetAPI(url);
                gridListStudent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTenMon_CheckedChanged(object sender, EventArgs e)
        {
            txtTenMon.Enabled = chkTenMon.Checked;
            if (!chkTenMon.Checked) txtTenMon.Text = string.Empty;
        }

        private void chkTenLop_CheckedChanged(object sender, EventArgs e)
        {
            txtTenLop.Enabled = chkTenLop.Checked;
            if (!chkTenLop.Checked) txtTenLop.Text = string.Empty;
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();
                await LoadClassDataAsync(cboCT.SelectedValue?.ToString());
                if (gridLop.Rows.Count > 0)
                {
                    gridLop.Rows[0].Selected = true;
                    await LoadStudentDataAsync();
                }
                else gridListStudent.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDatLai_Click(object sender, EventArgs e)
        {
            chkTenMon.Checked = false;
            chkTenLop.Checked = false;
            txtTenMon.Text = string.Empty;
            txtTenLop.Text = string.Empty;

            await LoadClassDataAsync(cboCT.SelectedValue?.ToString());

            if (gridLop.Rows.Count > 0)
            {
                gridLop.Rows[0].Selected = true;
                await LoadStudentDataAsync();
            }
            else gridListStudent.DataSource = null;
        }

        private async void gridLop_SelectionChanged(object sender, EventArgs e)
        {
            await LoadStudentDataAsync();
        }

        private void ValidateSearch()
        {
            if (chkTenMon.Checked && string.IsNullOrEmpty(txtTenMon.Text))
                throw new ArgumentException("Tên môn không được để trống");
            if (chkTenLop.Checked && string.IsNullOrEmpty(txtTenLop.Text))
                throw new ArgumentException("Tên lớp không được để trống");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridLop.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();

                string className = gridLop.SelectedRows[0].Cells["ClassName"].Value?.ToString();
                //string semesterName = ((DataRowView)cboKy.SelectedItem)["SemesterName"].ToString();
                //string semesterName = cboKy.Text; // Lấy giá trị đang hiển thị (tên học kỳ)


                //frmThemHocVienVaoLop frm = new frmThemHocVienVaoLop(classId, semesterName, className);
                //frm.ShowDialog();
                // Reload student data after adding
                //LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form thêm học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
