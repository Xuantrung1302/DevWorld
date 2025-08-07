using BusinessLogic;
using DevEduManager.Modals;
using Enity.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyNhanVien : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Employee/";
        private List<NhanVien> _employees;
        private int _pageIndex = 1;
        private int _pageSize = 30;
        private int _totalCount = 0;
        private int _totalPages = 1;

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVienEdit frm = new frmNhanVienEdit(null);
            frm.Text = "Thêm nhân viên mới";
            frm.ShowDialog();

            btnHienTatCa_Click(sender, e);
        }

        private async Task LoadDataToGridView(string search = "")
        {
            try
            {
                string url = $"{_url2}thongTinNhanVien?search={search}&pageIndex={_pageIndex}&pageSize={_pageSize}";
                var result = await callAPI.GetApiObject<NhanVienResponse>(url);

                if (result == null) return;

                _totalCount = result.TotalCount;
                _totalPages = (int)Math.Ceiling(_totalCount / (double)_pageSize);
                _employees = result.Data;
                gridNV.AutoGenerateColumns = false;
                gridNV.DataSource = _employees;

                UpdatePagingStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePagingStatus()
        {
            lblPageInfo.Text = $"Trang {_pageIndex} / {_totalPages}";
            btnPrev.Enabled = _pageIndex > 1;
            btnNext.Enabled = _pageIndex < _totalPages;
        }

        private async void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            await LoadDataToGridView(txtSearch.Text);
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
        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;
                await LoadDataToGridView();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
                if (_pageIndex < _totalPages)
                {
                    _pageIndex++;
                    await LoadDataToGridView();
                }
        }

    }
}
