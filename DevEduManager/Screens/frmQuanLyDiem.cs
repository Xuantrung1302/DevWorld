using BusinessLogic;
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
        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            //thLop = new Thread(() =>
            //{
            //    object source = LopHoc.SelectAll();

            //    gridLop.Invoke((MethodInvoker)delegate
            //    {
            //        gridLop.DataSource = source;
            //    });
            //});

            //thLop.Start();
        }


    }
}
