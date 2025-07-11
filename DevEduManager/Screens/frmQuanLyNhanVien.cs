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
    //string maHocVien = "LNV00";


    public partial class frmQuanLyNhanVien : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Employee/";
        List<NhanVien> _employees;

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kiểm tra nhập liệu tìm kiếm có hợp lệ
        /// </summary>
        public void ValidateSearch()
        {
            if (chkMaNV.Checked && txtMaNV.Text == string.Empty)
                throw new ArgumentException("Mã nhân viên không được trống");
            if (chkTenNV.Checked && txtTenNV.Text == string.Empty)
                throw new ArgumentException("Họ và tên nhân viên không được trống");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVienEdit frm = new frmNhanVienEdit(null);
            frm.Text = "Thêm nhân viên mới";
            frm.ShowDialog();

            btnHienTatCa_Click(sender, e);
        }

        private void chkMaNV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaNV.Enabled = chkMaNV.Checked;
        }

        private void chkTenNV_CheckedChanged(object sender, EventArgs e)
        {
            txtTenNV.Enabled = chkTenNV.Checked;
        }

        private void chkLoaiNV_CheckedChanged(object sender, EventArgs e)
        {
            //cboLoaiNV.Enabled = chkLoaiNV.Checked;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkMaNV.Checked = true;
            txtMaNV.Text = txtTenNV.Text = string.Empty;
        }
        private async Task LoadDataToGridView(string employeeId = null, string name = null)
        {
            try
            {
                string url = $"{_url2}thongTinNhanVien?employeeID={employeeId}&fullName={name}";
                _employees = await callAPI.GetAPI<NhanVien>(url);

                gridNV.AutoGenerateColumns = false;
                if (_employees.Any())
                {
                    gridNV.DataSource = _employees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            btnDatLai_Click(sender, e);
            await LoadDataToGridView();
        }

        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private void gridNV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} nhân viên", gridNV.Rows.Count);
        }

        private void gridNV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} nhân viên", gridNV.Rows.Count);
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();

                string maNV = chkMaNV.Checked ? txtMaNV.Text.Trim() : null;
                string tenNV = chkTenNV.Checked ? txtTenNV.Text.Trim() : null;

                // Gọi LoadDataToGridView với tham số cần thiết
                await LoadDataToGridView(maNV, tenNV);
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

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridNV.SelectedRows.Count > 0 && gridNV.CurrentRow != null)
                {
                    var employeeId = gridNV.CurrentRow.Cells["clmMaNV"].Value?.ToString();

                    // Mở form sửa thông tin giáo viên
                    NhanVien employeeSelected = _employees.FirstOrDefault(p => p.EmployeeID == employeeId);
                    frmNhanVienEdit frm = new frmNhanVienEdit(employeeSelected);
                    frm.Text = "Cập nhật thông tin nhân viên";
                    frm.ShowDialog();

                    await LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridNV_DoubleClick(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridNV.SelectedRows.Count > 0 && gridNV.CurrentRow != null)
                {
                    var employeeId = gridNV.CurrentRow.Cells["clmMaNV"].Value?.ToString();
                    var userName = _employees.FirstOrDefault(p => p.EmployeeID == employeeId).Username;

                    string url = $"{_url}xoaThongTinNhanVien?employeeID={employeeId}&username={userName}";
                    var result = await callAPI.PostAPI(url);
                    if (result)
                    {
                        MessageBox.Show("Xóa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    await LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
