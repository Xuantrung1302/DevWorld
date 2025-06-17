using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmXepLop : Form
    {
        //private frmThoiKhoaBieu _frmThoiKhoaBieu;
        public frmXepLop()
        {
            InitializeComponent();
        }

        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";

        private void frmXepLop_Load(object sender, EventArgs e)
        {
            //LoadDataGridView();
            //plThoiKhoaBieu.Width = 800; // Điều chỉnh theo nhu cầu
            //plThoiKhoaBieu.Height = 600;
            OpenThoiKhoaBieu();
        }

        private async void LoadDataGridView()
        {
            string url = $"{_url}thongTinHocVien";
            DataTable result = await callAPI.GetAPI(url);
            if (result != null)
            {
                gridDSHV.DataSource = result;
            }
        }

        private void OpenThoiKhoaBieu()
        {
            var tkbData = new Dictionary<DateTime, int>
            {
                { new DateTime(2025, 6, 5), 1 },
                { new DateTime(2025, 6, 10), 2 },
                { new DateTime(2025, 7, 6), 3 }
            };
            var uc = new ucThoiKhoaBieuTuan();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            //panel1.Controls.Add(uc);
            plThoiKhoaBieu.Controls.Add(uc); // Thêm vào panel
            //_frmThoiKhoaBieu.Show(); // Hiển thị form
            //if (_frmThoiKhoaBieu == null || _frmThoiKhoaBieu.IsDisposed)
            //{
            //    //_frmThoiKhoaBieu = new frmThoiKhoaBieu
            //    //{
            //    //    TopLevel = false, // Không phải form độc lập
            //    //    FormBorderStyle = FormBorderStyle.None, // Loại bỏ viền
            //    //    Dock = DockStyle.Fill // Điền đầy panel
            //    //};

            //    //var tkbData = new Dictionary<DateTime, int>
            //    //{
            //    //    { new DateTime(2025, 6, 5), 1 },
            //    //    { new DateTime(2025, 6, 10), 2 },
            //    //    { new DateTime(2025, 7, 6), 3 }
            //    //};

            //}
            //else
            //{
            //    _frmThoiKhoaBieu.BringToFront(); // Đưa form lên trước nếu đã mở
            //}
        }

        // Ví dụ: Kích hoạt khi nhấn button (thêm button btnXemThoiKhoaBieu trong Designer)
        private void btnXemThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            plThoiKhoaBieu.Width = 800; // Điều chỉnh theo nhu cầu
            plThoiKhoaBieu.Height = 600;
            OpenThoiKhoaBieu();
        }

        private void gridDSHV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Tùy chọn: Đóng form khi chọn học viên (nếu cần)
        //private void gridDSHV_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (_frmThoiKhoaBieu != null && !_frmThoiKhoaBieu.IsDisposed)
        //    {
        //        _frmThoiKhoaBieu.Close(); // Đóng form cũ khi chọn học viên khác
        //        plThoiKhoaBieu.Controls.Clear(); // Xóa khỏi panel
        //        _frmThoiKhoaBieu = null;
        //    }
        //}
    }
}