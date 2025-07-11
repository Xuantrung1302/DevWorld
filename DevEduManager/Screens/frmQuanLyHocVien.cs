using BusinessLogic;
using DevEduManager.Modals;
using Enity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyHocVien : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";
        private List<HocVien> _students;

        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }

        public void ValidateSearch()
        {
            if (chkMaHV.Checked && string.IsNullOrEmpty(txtMaHV.Text))
                throw new ArgumentException("Mã học viên không được trống.");
            if (chkTenHV.Checked && string.IsNullOrEmpty(txtTenHV.Text))
                throw new ArgumentException("Họ và tên học viên không được trống.");
        }

        private async void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private async Task LoadDataToGridView(string studentId = null, string studentName = null)
        {
            try
            {
                string url = $"{_url}thongTinHocVien?studentID={studentId}&fullName={studentName}";
                _students = await callAPI.GetAPI<HocVien>(url);

                gridDSHV.AutoGenerateColumns = false;

                if (_students.Any())
                {
                    gridDSHV.DataSource = _students;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            // Hiển thị form thêm học viên mới
            frmHocVienEdit frm = new frmHocVienEdit(null); // Gửi null cho form khi thêm mới
            frm.Text = "Thêm học viên mới";
            frm.ShowDialog();

            // Tải lại danh sách sau khi thêm
            await LoadDataToGridView();
        }

        private async void btnDatLai_Click(object sender, EventArgs e)
        {
            // Đặt lại các checkbox và textbox tìm kiếm
            chkMaHV.Checked = true;
            txtMaHV.Text = txtTenHV.Text = string.Empty;
            await LoadDataToGridView();
        }

        private async void btnXemTatCa_Click(object sender, EventArgs e)
        {
            // Tải lại tất cả danh sách học viên
            await LoadDataToGridView();
        }

        private void chkMaHV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHV.Enabled = chkMaHV.Checked;
        }

        private void chkTenHV_CheckedChanged(object sender, EventArgs e)
        {
            txtTenHV.Enabled = chkTenHV.Checked;
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridDSHV.SelectedRows.Count > 0 && gridDSHV.CurrentRow != null)
                {
                    var studentId = gridDSHV.CurrentRow.Cells["clmMaHV"].Value?.ToString();

                    // Mở form sửa thông tin giáo viên
                    HocVien studentSelected = _students.FirstOrDefault(p => p.StudentID == studentId);
                    frmHocVienEdit frm = new frmHocVienEdit(studentSelected);
                    frm.Text = "Cập nhật thông tin học viên";
                    frm.ShowDialog();

                    await LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một học viên để sửa.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridDSHV_DoubleClick(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();

                string maHV = chkMaHV.Checked ? txtMaHV.Text.Trim() : null;
                string tenHV = chkTenHV.Checked ? txtTenHV.Text.Trim() : null;
                //string gioiTinhText = chkGioiTinh.Checked ? cboGioiTinh.Text : null;

                // Lấy giá trị của DateTimePicker nếu checkbox tương ứng được chọn, nếu không thì null
                //DateTime? dateStart = chkNgayTiepNhan.Checked ? (DateTime?)DateTime.Parse(dateTuNgay.Value.ToString("dd/MM/yyyy")) : null;
                //DateTime? dateEnd = chkNgayTiepNhan.Checked ? (DateTime?)DateTime.Parse(dateDenNgay.Value.ToString("dd/MM/yyyy")) : null;


                // Gọi LoadDataToGridView với tham số cần thiết
               await LoadDataToGridView(maHV, tenHV);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridDSHV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridDSHV.Rows.Count);
        }

        private void gridDSHV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên", gridDSHV.Rows.Count);
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridDSHV.SelectedRows.Count > 0 && gridDSHV.CurrentRow != null)
                {
                    var studentId = gridDSHV.CurrentRow.Cells["clmMaHV"].Value?.ToString();
                    var userName = _students.FirstOrDefault(p => p.StudentID == studentId).Username;

                    string url = $"{_url}xoaThongTinHocVien?studentID={studentId}&username={userName}";
                    var result = await callAPI.PostAPI(url);
                    if (result)
                    {
                        MessageBox.Show("Xóa thông tin học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin học viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    await LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một học viên để sửa.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
