using BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyHocPhi : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _studentUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";
        private readonly string _invoiceUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Invoice/";

        public frmQuanLyHocPhi()
        {
            InitializeComponent();
            this.Load += frmQuanLyHocPhi_Load;
            dgvHocVien.CellClick += dgvHocVien_CellClick;
            btnSearch.Click += btnSearch_Click;
            btnThoat.Click += (s, e) => this.Close();

            dgvLichSuDongTien.CellFormatting += dgvLichSuDongTien_CellFormatting;
        }

        /// <summary>
        /// Load toàn bộ học viên khi mở form
        /// </summary>
        private async void frmQuanLyHocPhi_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDanhSachHocVien();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Hàm gọi API danh sách học viên
        /// </summary>
        private async Task LoadDanhSachHocVien(string studentId = null)
        {
            try
            {
                string url = $"{_studentUrl}danhSachHocVienCoHocPhi";
                if (!string.IsNullOrEmpty(studentId))
                {
                    url += $"?studentID={studentId}";
                }

                DataTable dtHocVien = await callAPI.GetAPI(url);
                if (dtHocVien != null && dtHocVien.Rows.Count > 0)
                {
                    dgvHocVien.AutoGenerateColumns = false;
                    dgvHocVien.DataSource = dtHocVien;
                }
                else
                {
                    dgvHocVien.AutoGenerateColumns = false;
                    dgvHocVien.DataSource = null;
                }

                dgvLichSuDongTien.DataSource = null; // Xóa lịch sử khi load mới danh sách
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Lỗi load danh sách học viên: {ex.Message}");
            }
        }

        /// <summary>
        /// Khi click chọn học viên → load lịch sử đóng tiền
        /// </summary>
        private async void dgvHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string studentId = dgvHocVien.Rows[e.RowIndex].Cells["StudentID"].Value?.ToString();
                if (!string.IsNullOrEmpty(studentId))
                {
                    await LoadLichSuDongTien(studentId);
                }
            }
        }

        /// <summary>
        /// Gọi API lấy lịch sử đóng tiền
        /// </summary>
        private async Task LoadLichSuDongTien(string studentId)
        {
            try
            {
                string url = $"{_invoiceUrl}layThongTinHoaDonTheoMaHocVien?StudentID={studentId}";
                DataTable dtInvoice = await callAPI.GetAPI(url);
                if (dtInvoice != null && dtInvoice.Rows.Count > 0)
                {
                    dgvLichSuDongTien.AutoGenerateColumns = false;
                    dgvLichSuDongTien.DataSource = dtInvoice;
                }
                else
                {
                    dgvLichSuDongTien.AutoGenerateColumns = false;
                    dgvLichSuDongTien.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Lỗi load lịch sử đóng tiền: {ex.Message}");
            }
        }

        /// <summary>
        /// Tìm kiếm theo mã học viên
        /// </summary>
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string studentId = txtSearch.Text.Trim();
            await LoadDanhSachHocVien(studentId);
        }
        /// <summary>
        /// Đổi màu cho cột Status
        /// </summary>
        private void dgvLichSuDongTien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLichSuDongTien.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().Trim();

                if (status.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, System.Drawing.FontStyle.Bold);
                }
                else if (status.Equals("Chưa thanh toán", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, System.Drawing.FontStyle.Bold);
                }
            }
        }
    }
}
