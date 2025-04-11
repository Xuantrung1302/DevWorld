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
        private void frmQuanLyDiem_Load_1(object sender, EventArgs e)
        {
            lblMaLop.Text = string.Empty;
            lblTenLop.Text = string.Empty;
            lblKhoa.Text = string.Empty;
            lblMaHV.Text = string.Empty;
            lblTenHV.Text = string.Empty;
            numDiemNghe.Value = 0;
            numDiemNoi.Value = 0;
            numDiemDoc.Value = 0;
            numDiemViet.Value = 0;

            gridDSHV.AutoGenerateColumns = false;
            gridLop.AutoGenerateColumns = false;

            btnHienTatCa_Click(sender, e);
            //gridLop_Click(sender, e);
            //gridDSHV_Click(sender, e);
            LoadDataToGridView();
            LoadDataToGridView3();
            //LoadDataToGridView2();

        }

        private async void LoadDataToGridView(string maLop = null)
        {
            string url = $"{_url}layLopTheoID?maLop={maLop}";
            DataTable result = await callAPI.GetAPI(url);

            //gridLop.Dock = DockStyle.Fill;

            if (result.Rows.Count > 0)
            {
                gridLop.DataSource = result;
            }

        }
        private async void LoadDataToGridView2(string maLop = null)
        {
            string url2 = $"{_url}layDanhSachHVTheoLop?maLop={maLop}";
            DataTable result2 = await callAPI.GetAPI(url2);

            //gridLop.Dock = DockStyle.Fill;

            if (result2.Rows.Count > 0)
            {
                gridDSHV.DataSource = result2;
            }
            

        }
        private async void LoadDataToGridView3(string maHv = null)
        {
            string url3 = $"{_url2}thongTinDiem?maHv={maHv}";
            DataTable result3 = await callAPI.GetAPI(url3);

            //gridLop.Dock = DockStyle.Fill;

            //lblMaLop.Text = result2.;
            lblTenLop.Text = string.Empty;
            lblKhoa.Text = string.Empty;
            lblMaHV.Text = string.Empty;
            lblTenHV.Text = string.Empty;
            numDiemNghe.Value = 0;
            numDiemNoi.Value = 0;
            numDiemDoc.Value = 0;
            numDiemViet.Value = 0;

            gridDSHV.AutoGenerateColumns = false;
            gridLop.AutoGenerateColumns = false;

        }
        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            //DataGridViewRow selectedRow = gridBaoCao.SelectedRows[0];
            //string maHv = gridDSHV.Cells["TenHV"].Value.ToString();
            LoadDataToGridView();
        }

        private void gridDSHV_Click(object sender, EventArgs e)
        {
            try
            {
                string maHv = gridDSHV.SelectedRows[0].Cells["clmMaHV"].Value.ToString();
                //LoadDataToGridView2(maHv);


                lblMaLop.Text = string.Empty;
                lblTenLop.Text = string.Empty;
                lblKhoa.Text = string.Empty;
                lblMaHV.Text = string.Empty;
                lblTenHV.Text = string.Empty;
                numDiemNghe.Value = 0;
                numDiemNoi.Value = 0;
                numDiemDoc.Value = 0;
                numDiemViet.Value = 0;

                gridDSHV.AutoGenerateColumns = false;
                gridLop.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ValidateSearch()
        {
            if (txtMaLop.Text == string.Empty)
                throw new ArgumentException("Mã lớp không được trống");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();
                LoadDataToGridView();
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
    }
}
