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
    public partial class frmThongKeDiemTheoLop : Form
    {
        private Thread thLop;
        private Thread thBangDiem;

        public frmThongKeDiemTheoLop()
        {
            InitializeComponent();
        }
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        /// <summary>
        /// Tính điểm trung bình lớp
        /// </summary>
        /// <returns></returns>
        public double DiemTrungBinhLop()
        {
            double diem = 0;
            for (int i = 0; i < gridThongKe.Rows.Count; i++)
                diem += Convert.ToDouble(gridThongKe.Rows[i].Cells["clmDiemTrungBinh"].Value);

            return diem / gridThongKe.Rows.Count;
        }

        

        /// <summary>
        /// Kiểm tra nhập liệu tìm kiếm có hợp lệ
        /// </summary>
        public void ValidateSearch()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
                throw new ArgumentException("Mã lớp không được trống");
        }

        private void frmThongKeDiemTheoLop_Load(object sender, EventArgs e)
        {
            gridLop.AutoGenerateColumns = false;
            LoadDataToGridView();
            //btnHienTatCa_Click(sender, e);
            //gridLop_Click(sender, e);

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

        private void gridThongKe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên. Điểm trung bình của lớp: {1:N2} điểm.", gridThongKe.Rows.Count, DiemTrungBinhLop());
        }

        private void gridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridLop_Click(object sender, EventArgs e)
        {


            string url = $"{_url}layDiemLop?maLop={maLop}";
            DataTable result = await callAPI.GetAPI(url);

            //gridLop.Dock = DockStyle.Fill;

            if (result.Rows.Count > 0)
            {
                gridLop.DataSource = result;
            }
        }
    }
}
