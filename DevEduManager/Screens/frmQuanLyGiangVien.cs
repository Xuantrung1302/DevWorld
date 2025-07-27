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
    public partial class frmQuanLyGiangVien : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Teacher/";
        private List<GiangVien> _teachers;
        private int _pageIndex = 1;
        private int _pageSize = 30;
        private int _totalCount = 0;
        private int _totalPages = 1;
        private Panel _mainPanel;

        public frmQuanLyGiangVien(Panel mainPanel)
        {
            InitializeComponent();
            _mainPanel = mainPanel;
        }

        private async Task LoadDataToGridView(string search = "")
        {
            try
            {
                string url = $"{_url}thongTinGiangVien?search={search}&pageIndex={_pageIndex}&pageSize={_pageSize}";
                var result = await callAPI.GetApiObject<GiangVienResponse>(url);

                if (result == null)
                    return;

                _totalCount = result.TotalCount;
                _totalPages = (int)Math.Ceiling(_totalCount / (double)_pageSize);
                _teachers = result.Data;

                gridGV.AutoGenerateColumns = false;
                gridGV.DataSource = _teachers;

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

        #region Events

        private async void frmQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            await LoadDataToGridView();
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
                    frm.Text = "Cập nhật thông tin giảng viên";
                    frm.ShowDialog();

                    await LoadDataToGridView();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một giảng viên để sửa.");
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
                    MessageBox.Show("Vui lòng chọn một giảng viên để sửa.");
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


        #endregion


        private void gridGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maGV = gridGV.Rows[e.RowIndex].Cells["clmMaGV"].Value.ToString();
                var frm = new frmThongTinGiangVien(_mainPanel, maGV)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false
                };

                _mainPanel.Controls.Clear();
                _mainPanel.Controls.Add(frm);
                frm.Show();
            }
        }


        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataToGridView();
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
