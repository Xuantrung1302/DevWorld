using BusinessLogic;
using Enity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyDiem : Form
    {
        private Thread thLop;
        private Thread thHocVien;
        private Thread thPanelDiem;
        public frmQuanLyDiem()
        {
            InitializeComponent();
        }

        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Score/";
        private void frmQuanLyDiem_Click(object sender, EventArgs e)
        {
            
        }
        private void frmQuanLyDiem_Load(object sender, EventArgs e)
        {
            // Khởi tạo các control
            lblTenMon.Text = string.Empty;
            lblTenLop.Text = string.Empty;
            lblKy.Text = string.Empty;
            lblMaHV.Text = string.Empty;
            lblTenHV.Text = string.Empty;
            numDiemGiuaKy.Value = 0;
            numDiemCuoiKy.Value = 0;
            numDiemCuoiKy.Value = 0;

            gridDSHV.AutoGenerateColumns = false;
            gridLop.AutoGenerateColumns = false;

            // Tải dữ liệu ban đầu
            btnHienTatCa_Click(sender, e);
            LoadClassesToGrid();
        }

        private async void LoadClassesToGrid(string maLop = null)
        {
            string url = $"{_url}layLopTheoID?maLop={maLop}";
            DataTable result = await callAPI.GetAPI(url);

            if (result.Rows.Count > 0)
            {
                gridLop.DataSource = result;
            }
        }

        private async void LoadStudentsToGrid(string maLop = null)
        {
            string url = $"{_url}layDanhSachHVTheoLop?maLop={maLop}";
            DataTable result = await callAPI.GetAPI(url);

            if (result.Rows.Count > 0)
            {
                gridDSHV.DataSource = result;
            }
        }

        private async void LoadStudentScores(string maHv = null)
        {
            string url = $"{_url2}thongTinDiem?maHv={maHv}";
            DataTable result = await callAPI.GetAPI(url);

            // Reset các control trước khi hiển thị dữ liệu mới
            lblTenMon.Text = string.Empty;
            lblTenLop.Text = string.Empty;
            lblKy.Text = string.Empty;
            lblMaHV.Text = string.Empty;
            lblTenHV.Text = string.Empty;
            numDiemGiuaKy.Value = 0;
            numDiemCuoiKy.Value = 0;
            //numDiemDuAn.Value = 0;
            //numDiemCuoiKy.Value = 0;

            if (result.Rows.Count > 0)
            {
                try
                {
                    // Gán giá trị từ DataTable vào các control
                    lblTenMon.Text = result.Rows[0]["MaLop"]?.ToString() ?? string.Empty;
                    lblTenLop.Text = result.Rows[0]["TenLop"]?.ToString() ?? string.Empty;
                    lblKy.Text = result.Rows[0]["TenKH"]?.ToString() ?? string.Empty;
                    lblMaHV.Text = result.Rows[0]["MaHV"]?.ToString() ?? string.Empty;
                    lblTenHV.Text = result.Rows[0]["TenHV"]?.ToString() ?? string.Empty;

                    // Chuyển đổi và gán điểm, xử lý trường hợp null hoặc lỗi định dạng
                    numDiemGiuaKy.Value = result.Rows[0]["DiemLyThuyet"] != DBNull.Value
                        ? Convert.ToDecimal(result.Rows[0]["DiemLyThuyet"]) : 0;
                    numDiemCuoiKy.Value = result.Rows[0]["DiemThucHanh"] != DBNull.Value
                        ? Convert.ToDecimal(result.Rows[0]["DiemThucHanh"]) : 0;
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi (ví dụ: thông báo cho người dùng)
                    MessageBox.Show($"Lỗi khi tải thông tin điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            LoadClassesToGrid();
        }

        private void gridDSHV_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridDSHV.SelectedRows.Count > 0)
                {
                    string maHv = gridDSHV.SelectedRows[0].Cells["clmMaHV"].Value.ToString();
                    LoadStudentScores(maHv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ValidateSearch()
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
                throw new ArgumentException("Mã lớp không được trống");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();
                LoadClassesToGrid(txtMaLop.Text);
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

        private void gridLop_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gridLop.SelectedRows.Count > 0)
                {
                    string maLop = gridLop.SelectedRows[0].Cells["clmMaLop"].Value.ToString();
                    LoadStudentsToGrid(maLop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienTatCa_Click_1(object sender, EventArgs e)
        {
            LoadClassesToGrid();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = string.Empty;
        }
    }
}