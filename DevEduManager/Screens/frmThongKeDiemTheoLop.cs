using BusinessLogic;
using System.Data;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Configuration;

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
        public double DiemTrungBinhLop()
        {
            double diem = 0;
            if (gridThongKe.Rows.Count == 0) return 0;
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

        private async void frmThongKeDiemTheoLop_Load(object sender, EventArgs e)
        {
            gridLop.AutoGenerateColumns = false;
            gridThongKe.AutoGenerateColumns = false;

            // Load danh sách lớp
            await LoadDataToGridView();

            // Nếu có lớp, chọn lớp đầu tiên và load điểm
            if (gridLop.Rows.Count > 0)
            {
                gridLop.Rows[0].Selected = true;
                string maLop = gridLop.Rows[0].Cells["clmMaLop"].Value.ToString(); // Thay "clmMaLop" bằng tên cột thực tế
                await LoadDiemToGridThongKe(maLop);
            }
        }

        private async Task LoadDataToGridView(string maLop = null)
        {
            string url = string.IsNullOrEmpty(maLop) ? $"{_url}layLopTheoID" : $"{_url}layLopTheoID?maLop={maLop}";
            DataTable result = await callAPI.GetAPI(url);

            if (result.Rows.Count > 0)
            {
                gridLop.DataSource = result;
            }
            else
            {
                gridLop.DataSource = null; // Xóa dữ liệu nếu không có kết quả
            }
        }

        private async Task LoadDiemToGridThongKe(string maLop)
        {
            string url = $"{_url}layDiemLop?maLop={maLop}";
            DataTable result = await callAPI.GetAPI(url);

            if (result.Rows.Count > 0)
            {
                gridThongKe.DataSource = result;
            }
            else
            {
                gridThongKe.DataSource = null; // Xóa dữ liệu nếu không có điểm
            }

            // Cập nhật label tổng cộng
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên. Điểm trung bình của lớp: {1:N2} điểm.",
                gridThongKe.Rows.Count, DiemTrungBinhLop());
        }

        private async void gridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có chọn dòng hợp lệ không
            {
                string maLop = gridLop.Rows[e.RowIndex].Cells["clmMaLop"].Value.ToString(); // Thay "clmMaLop" bằng tên cột thực tế
                await LoadDiemToGridThongKe(maLop);
            }
        }

        private void gridThongKe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên. Điểm trung bình của lớp: {1:N2} điểm.",
                gridThongKe.Rows.Count, DiemTrungBinhLop());
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSearch();
                string maLop = txtMaLop.Text;
                await LoadDataToGridView(maLop);

                // Load điểm của lớp vừa tìm
                if (gridLop.Rows.Count > 0)
                {
                    gridLop.Rows[0].Selected = true;
                    string maLopTimKiem = gridLop.Rows[0].Cells["clmMaLop"].Value.ToString();
                    await LoadDiemToGridThongKe(maLopTimKiem);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = null;
            await LoadDataToGridView();

            // Load điểm của lớp đầu tiên nếu có
            if (gridLop.Rows.Count > 0)
            {
                gridLop.Rows[0].Selected = true;
                string maLop = gridLop.Rows[0].Cells["clmMaLop"].Value.ToString();
                await LoadDiemToGridThongKe(maLop);
            }
        }

        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataToGridView();

            // Load điểm của lớp đầu tiên nếu có
            if (gridLop.Rows.Count > 0)
            {
                gridLop.Rows[0].Selected = true;
                string maLop = gridLop.Rows[0].Cells["clmMaLop"].Value.ToString();
                await LoadDiemToGridThongKe(maLop);
            }
        }

        private void gridLop_Click(object sender, EventArgs e)
        {

        }
    }
}