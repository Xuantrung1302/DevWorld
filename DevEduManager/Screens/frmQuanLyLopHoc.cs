using BusinessLogic;
using DevEduManager.Modals;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
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
        private readonly string _studentUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";

        public frmQuanLyLopHoc()
        {
            InitializeComponent();
            gridLop.AutoGenerateColumns = false;
            gridListStudent.AutoGenerateColumns = false;
            gridLop.CellFormatting += new DataGridViewCellFormattingEventHandler(gridClasses_CellFormatting);
        }

        private async void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxCourseAsync();


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
                string url = $"{_courseUrl}danhSachLopTrongKhoaHoc?CourseID={courseId}";
                DataTable result = await callAPI.GetAPI(url);
                gridLop.DataSource = result;

                if (!result.Columns.Contains("StatusText"))
                {
                    result.Columns.Add("StatusText", typeof(string));
                    foreach (DataRow row in result.Rows)
                    {
                        int status = row["Status"] != DBNull.Value ? Convert.ToInt32(row["Status"]) : 0;
                        row["StatusText"] = GetStatusText(status);
                    }
                }

                gridLop.ClearSelection();
                if (gridListStudent.Rows.Count > 0)
                {
                    lblTotalStudents.Text = $"Tổng cộng: {gridListStudent.Rows.Count} học viên";
                }
                else
                {
                    lblTotalStudents.Text = "Không có học viên";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
            }
        }

        // Hàm chuyển đổi giá trị Status sang chuỗi
        private string GetStatusText(int status)
        {
            switch (status)
            {
                case 1:
                    return "Đang học";
                case 2:
                    return "Đã kết thúc";
                case 3:
                    return "Chưa có lịch";
                default:
                    return "Không xác định";
            }
        }

        // Thêm sự kiện CellFormatting để định dạng hiển thị
        private void gridClasses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == gridLop.Columns["StatusText"].Index && e.RowIndex >= 0)
            {
                int status = Convert.ToInt32(gridLop.Rows[e.RowIndex].Cells["Status"].Value);
                e.Value = GetStatusText(status);
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

                string url = $"{_studentUrl}thongTinHocVienCuaLop?classID={Uri.EscapeDataString(classId)}";
                DataTable dt = await callAPI.GetAPI(url);

                gridListStudent.DataSource = dt;
                if (gridListStudent.Rows.Count > 0)
                {
                    lblTotalStudents.Text = $"Tổng cộng: {gridListStudent.Rows.Count} học viên";
                }
                else
                {
                    lblTotalStudents.Text = "Không có học viên";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                //ValidateSearch();
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
            //txtTenMon.Text = string.Empty;

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
            UpdateAddTeacherButtonState(); // Cập nhật trạng thái nút khi chọn dòng mới
        }

        private void UpdateAddTeacherButtonState()
        {
            // Mặc định disable nút và set màu xám
            btnAddTeacher.Enabled = false;
            btnAddTeacher.BackColor = Color.Gray;
            btnAddTeacher.ForeColor = Color.White;

            try
            {
                // Kiểm tra có dòng được chọn không
                if (gridLop.SelectedRows.Count == 0)
                    return;

                // Lấy giá trị Status
                var statusValue = gridLop.SelectedRows[0].Cells["Status"].Value;
                if (statusValue == null)
                    return;

                if (int.TryParse(statusValue.ToString(), out int status) && status == 3)
                {
                    btnAddTeacher.Enabled = true;
                    btnAddTeacher.BackColor = Color.LightCoral; // hoặc chọn màu bạn muốn
                    btnAddTeacher.ForeColor = Color.White;
                }
            }
            catch
            {
                btnAddTeacher.Enabled = false;
                btnAddTeacher.BackColor = Color.Gray;
                btnAddTeacher.ForeColor = Color.White;
            }
        }



        //private void ValidateSearch()
        //{
        //    if (chkTenMon.Checked && string.IsNullOrEmpty(txtTenMon.Text))
        //        throw new ArgumentException("Tên môn không được để trống");
        //    if (chkTenLop.Checked && string.IsNullOrEmpty(txtTenLop.Text))
        //        throw new ArgumentException("Tên lớp không được để trống");
        //}

        private async void btnThem_Click(object sender, EventArgs e)
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

                // Nếu có combobox kỳ học (cboKy)
                string courseName = cboCT.Text; // lấy tên hiển thị trong combobox

                frmThemHocVienVaoLop frm = new frmThemHocVienVaoLop(classId, courseName, className);
                frm.ShowDialog();

                // Sau khi form đóng, load lại danh sách học viên
                await LoadStudentDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form thêm học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridLop.SelectedRows.Count > 0)
                {
                    string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();
                    //int status = (int)gridLop.SelectedRows[0].Cells["Status"].Value; // Giả sử cột Status đã có
                    int status;

                    // Kiểm tra và ép kiểu an toàn
                    if (gridLop.SelectedRows[0].Cells["Status"].Value == null ||
                        !int.TryParse(gridLop.SelectedRows[0].Cells["Status"].Value.ToString(), out status))
                    {
                        MessageBox.Show("Trạng thái lớp không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (status == 3)
                    {
                        string className = gridLop.SelectedRows[0].Cells["ClassName"].Value?.ToString();
                        //string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();

                        // Giả sử lấy courseId từ dữ liệu hoặc cấu hình, cần điều chỉnh theo API thực tế
                        string courseId = cboCT.SelectedValue?.ToString(); // Lấy mã khóa từ ValueMember (CourseID)
                        string programName = cboCT.Text;

                        frmAddTeacher addTeacherForm = new frmAddTeacher(courseId, classId, programName, className);
                        addTeacherForm.ShowDialog();

                        LoadClassDataAsync(courseId);
                        // Reload dữ liệu sau khi thêm thành công (nếu cần)
                        //LoadDataToGridView().Wait();
                    }
                    else
                    {
                        MessageBox.Show("Lớp học đã có giảng viên hoặc không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                string courseId = cboCT.SelectedValue?.ToString();
                frmLopHocEdit frm = new frmLopHocEdit(courseId);
                frm.ShowDialog();

                await LoadClassDataAsync(courseId);

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void gridLop_DoubleClick(object sender, EventArgs e)
        {
            string classId = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();
            frmChiTietLopHoc frm = new frmChiTietLopHoc(classId);
            frm.ShowDialog();
        }
    }
}
