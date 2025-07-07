using BusinessLogic;
using DevEduManager.Modals;
using Enity.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyGiangVien : Form
    {
        public frmQuanLyGiangVien()
        {
            InitializeComponent();
        }
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Teacher/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private List<GiangVien> _teachers;

        /// <summary>
        /// Kiểm tra nhập liệu tìm kiếm có hợp lệ
        /// </summary>
        public void ValidateSearch()
        {
            if (chkMaGV.Checked && txtMaGV.Text == string.Empty)
                throw new ArgumentException("Mã giảng viên không được trống");
            if (chkTenGV.Checked && txtTenGV.Text == string.Empty)
                throw new ArgumentException("Họ và tên giảng viên không được trống");
        }

        private async Task LoadDataToGridView(string teacherId = null, string fullName = null)
        {
            string url = $"{_url}thongTinGiangVien?teacherID={teacherId}&fullName={fullName}";
            _teachers = await callAPI.GetAPI<GiangVien>(url);

            gridGV.Dock = DockStyle.Fill;
            gridGV.AutoGenerateColumns = false;

            if (_teachers.Any())
            {
                gridGV.DataSource = _teachers;
                string maGV = gridGV.Rows[0].Cells["clmMaGV"].Value.ToString();
                await LoadGridViewLop(maGV);
            }

        }

        #region Events
        private void chkMaGV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaGV.Enabled = chkMaGV.Checked;
        }

        private void chkTenGV_CheckedChanged(object sender, EventArgs e)
        {
            txtTenGV.Enabled = chkTenGV.Checked;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkMaGV.Checked = true;
            chkTenGV.Checked = false;
            txtMaGV.Text = txtTenGV.Text = string.Empty;
        }

        private async void frmQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            btnDatLai_Click(sender, e);
            await LoadDataToGridView();
        }

        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private void gridGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCongGV.Text = string.Format("Tổng cộng: {0} giảng viên", gridGV.Rows.Count);
        }

        private void gridGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCongGV.Text = string.Format("Tổng cộng: {0} giảng viên", gridGV.Rows.Count);
        }

        private void gridGV_DoubleClick(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridGV.SelectedRows.Count > 0 && gridGV.CurrentRow != null)
                {
                    var teacherId = gridGV.CurrentRow.Cells["clmMaGV"].Value?.ToString();

                    // Mở form sửa thông tin giáo viên
                    GiangVien teacherSelected = _teachers.FirstOrDefault(p => p.TeacherID == teacherId);
                    frmGiangVienEdit frm = new frmGiangVienEdit(teacherSelected);
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

        private async void btnThem_Click(object sender, EventArgs e)
        {
            frmGiangVienEdit frm = new frmGiangVienEdit(null); // Gửi null cho form khi thêm mới
            frm.Text = "Thêm giảng viên mới";
            frm.ShowDialog();

            await LoadDataToGridView();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridGV.SelectedRows.Count > 0 && gridGV.CurrentRow != null)
                {
                    var teacherId = gridGV.CurrentRow.Cells["clmMaGV"].Value?.ToString();
                    var userName = _teachers.FirstOrDefault(p => p.TeacherID == teacherId).Username;

                    string url = $"{_url}xoaThongTinGiangVien?teacherID={teacherId}&username={userName}";
                    var result = await callAPI.PostAPI(url);
                    if (result)
                    {
                        MessageBox.Show("Xóa thông tin giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin giảng viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridLop_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCongLop.Text = string.Format("Tổng cộng: {0} lớp", gridLop.Rows.Count);
        }

        private void gridLop_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCongLop.Text = string.Format("Tổng cộng: {0} lớp", gridLop.Rows.Count);
        }

        private void gridGV_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();

                string teacherId = chkMaGV.Checked ? txtMaGV.Text.Trim() : null;
                string fullName = chkTenGV.Checked ? txtTenGV.Text.Trim() : null;

                // Gọi LoadDataToGridView với tham số cần thiết
                await LoadDataToGridView(teacherId, fullName);
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

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private async void gridGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maGV = gridGV.Rows[e.RowIndex].Cells["clmMaGV"].Value.ToString();
            string url = $"{_url}thongTinLopDay?teacherID={maGV}";
            await LoadGridViewLop(maGV);
        }

        private async Task LoadGridViewLop(string maGV)
        {
            string url = $"{_url}thongTinLopDay?teacherID={maGV}";
            DataTable result = await callAPI.GetAPI(url);

            gridLop.Dock = DockStyle.Fill;
            gridLop.DataSource = result.Rows.Count > 0 ? result : null;
        }
    }
}
