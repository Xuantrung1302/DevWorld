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
    public partial class frmQuanLyHocVien : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";
        private List<HocVien> _students;
        private int _pageIndex = 1;
        private int _pageSize = 30;
        private int _totalCount = 0;
        private int _totalPages = 1;
        private Panel _mainPanel;

        public frmQuanLyHocVien(Panel mainPanel)
        {
            InitializeComponent();
            _mainPanel = mainPanel;
        }

        private async void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private async Task LoadDataToGridView(string search = "")
        {
            try
            {
                string url = $"{_url}thongTinHocVien?search={search}&pageIndex={_pageIndex}&pageSize={_pageSize}";
                var result = await callAPI.GetApiObject<HocVienResponse>(url);

                if (result == null)
                    return;

                _totalCount = result.TotalCount;
                _totalPages = (int)Math.Ceiling(_totalCount / (double)_pageSize);
                _students = result.Data;
                gridDSHV.AutoGenerateColumns = false;
                gridDSHV.DataSource = _students;

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

        private async void btnThem_Click(object sender, EventArgs e)
        {
            // Hiển thị form thêm học viên mới
            frmHocVienEdit frm = new frmHocVienEdit(null); // Gửi null cho form khi thêm mới
            frm.Text = "Thêm học viên mới";
            frm.ShowDialog();

            // Tải lại danh sách sau khi thêm
            await LoadDataToGridView();
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

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            await LoadDataToGridView(txtSearch.Text);
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

        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private void gridDSHV_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var frm = new frmThongTinHocVien(_mainPanel)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false
                };

                _mainPanel.Controls.Clear();
                _mainPanel.Controls.Add(frm);
                frm.Show();
            }
        }
    }
}
