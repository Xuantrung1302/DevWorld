using BusinessLogic;
using Enity.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DevEduManager.Screens
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private List<ChiTietTaiKhoan> _accounts;
        private int _pageIndex = 1;
        private int _pageSize = 30;
        private int _totalCount = 0;
        private int _totalPages = 1;

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private async void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadRolesToComboBox();
            await LoadDataToGridView();
        }

        private void LoadRolesToComboBox()
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("Tất cả");
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Employee");
            cboRole.Items.Add("Teacher");
            cboRole.Items.Add("Student");
            cboRole.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }


        private async Task LoadDataToGridView(string search = "")
        {
            try
            {
                string role = cboRole.SelectedItem?.ToString();
                if (role == "Tất cả") role = "";

                string url = $"{_url}danhSachTaiKhoan?search={search}&role={role}&pageIndex={_pageIndex}&pageSize={_pageSize}";
                var result = await callAPI.GetApiObject<TaiKhoanResponse>(url);

                if (result == null) return;

                _totalCount = result.TotalCount;
                _totalPages = (int)Math.Ceiling(_totalCount / (double)_pageSize);
                _accounts = result.Data;
                dgvAccount.AutoGenerateColumns = false;
                dgvAccount.DataSource = _accounts;

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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            await LoadDataToGridView(txtSearch.Text);
        }

        private async void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAccount.SelectedRows[0].DataBoundItem as ChiTietTaiKhoan;
            if (selectedRow == null) return;

            string newPassword = GenerateRandomPassword();

            // Gửi API cập nhật mật khẩu
            var resetRequest = new
            {
                Username = selectedRow.Username,
                NewPassword = newPassword
            };

            string resetUrl = $"{_url}resetPassword";
            var result = await callAPI.PostApiObject<object>(resetUrl, resetRequest);

            if (result == null)
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xuất PDF
            ExportToPdf(selectedRow.Username, selectedRow.Role, newPassword);
        }



        private string GenerateRandomPassword(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ExportToPdf(string username, string role, string newPassword)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF file (*.pdf)|*.pdf",
                FileName = $"{username}_ResetPassword.pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, 12);

                pdfDoc.Add(new Paragraph("THÔNG TIN RESET MẬT KHẨU", font));
                pdfDoc.Add(new Paragraph($"Username: {username}", font));
                pdfDoc.Add(new Paragraph($"Role: {role}", font));
                pdfDoc.Add(new Paragraph($"Mật khẩu mới: {newPassword}", font));

                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _totalPages)
            {
                _pageIndex++;
                await LoadDataToGridView();
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

        private async void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageIndex = 1;
            await LoadDataToGridView(txtSearch.Text);
        }

        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cboRole.SelectedIndex = 0; // "Tất cả"
            _pageIndex = 1;
            await LoadDataToGridView();
        }

    }
}
