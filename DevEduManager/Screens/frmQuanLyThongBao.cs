using BusinessLogic;
using Entity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyThongBao : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _noticeUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Notice/";
        private readonly string _autoIdUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service"; // Để gọi taoIdTuDong
        private bool isAdding = false;

        public frmQuanLyThongBao()
        {
            InitializeComponent();
        }

        private async void frmQuanLyThongBao_Load(object sender, EventArgs e)
        {
            await LoadNoticesAsync();
        }

        /// <summary>
        /// Load danh sách thông báo
        /// </summary>
        private async System.Threading.Tasks.Task LoadNoticesAsync()
        {
            try
            {
                string url = $"{_noticeUrl}danhSachThongBao";
                DataTable dt = await callAPI.GetAPI(url);

                dtgvThongBao.AutoGenerateColumns = false;
                dtgvThongBao.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load danh sách thông báo: {ex.Message}");
            }
        }

        /// <summary>
        /// Khi click vào grid -> load dữ liệu lên textbox
        /// </summary>
        //private void dtgvThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        //txtTitle.Text = dtgvThongBao.Rows[e.RowIndex].Cells["Title"].Value.ToString();
        //        //txtContent.Text = dtgvThongBao.Rows[e.RowIndex].Cells["Content"].Value.ToString();
        //        isAdding = false;
        //    }
        //}

        /// <summary>
        /// Thêm mới
        /// </summary>
        private async void btnThem_Click(object sender, EventArgs e)
        {
            frmThongBaoPopup popup = new frmThongBaoPopup(false);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                await LoadNoticesAsync();
            }
        }

        /// <summary>
        /// Lưu (Thêm hoặc Sửa)
        /// </summary>
        //private async void btnLuu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text))
        //        {
        //            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        //            return;
        //        }

        //        if (isAdding)
        //        {
        //            // ✅ Lấy mã tự động từ API
        //            string ngay = DateTime.Now.ToString("yyyy-MM-dd");
        //            string prefix = "TT";
        //            string idUrl = $"{_autoIdUrl}taoIdTuDong?ngay={ngay}&prefix={prefix}";

        //            DataTable idTable = await callAPI.GetAPI(idUrl);
        //            if (idTable == null || idTable.Rows.Count == 0)
        //            {
        //                MessageBox.Show("Không thể tạo mã thông báo tự động!");
        //                return;
        //            }

        //            string newID = idTable.Rows[0][0].ToString(); // API trả về chuỗi trong DataTable

        //            // ✅ Chuẩn bị dữ liệu thêm mới
        //            var insertData = new
        //            {
        //                NewsID = newID,
        //                Title = txtTitle.Text.Trim(),
        //                Content = txtContent.Text.Trim(),
        //                PostDate = DateTime.Now,
        //                PostedBy = CurrentUser.Username // Lấy từ thông tin đăng nhập
        //            };

        //            string json = JsonConvert.SerializeObject(insertData);
        //            bool result = await callAPI.PostAPI($"{_noticeUrl}themThongBao", json);

        //            if (result)
        //            {
        //                MessageBox.Show("Thêm thông báo thành công!");
        //                await LoadNoticesAsync();
        //                isAdding = false;
        //            }
        //            else
        //                MessageBox.Show("Thêm thông báo thất bại!");
        //        }
        //        else
        //        {
        //            // ✅ Sửa thông báo
        //            if (dtgvThongBao.CurrentRow == null)
        //            {
        //                MessageBox.Show("Vui lòng chọn thông báo để sửa!");
        //                return;
        //            }

        //            var updateData = new
        //            {
        //                NewsID = dtgvThongBao.CurrentRow.Cells["NewsID"].Value.ToString(),
        //                Title = txtTitle.Text.Trim(),
        //                Content = txtContent.Text.Trim()
        //            };

        //            string json = JsonConvert.SerializeObject(updateData);
        //            bool result = await callAPI.PostAPI($"{_noticeUrl}suaThongTinThongBao", json);

        //            if (result)
        //            {
        //                MessageBox.Show("Cập nhật thông báo thành công!");
        //                await LoadNoticesAsync();
        //            }
        //            else
        //                MessageBox.Show("Cập nhật thông báo thất bại!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi lưu thông báo: {ex.Message}");
        //    }
        //}

        /// <summary>
        /// Xóa thông báo
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvThongBao.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn thông báo cần xóa!");
                    return;
                }

                string newsID = dtgvThongBao.CurrentRow.Cells["NewsID"].Value.ToString();
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa thông báo này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool result = await callAPI.PostAPI($"{_noticeUrl}xoaThongBao?newID={newsID}");

                    if (result)
                    {
                        MessageBox.Show("Xóa thông báo thành công!");
                        await LoadNoticesAsync();
                    }
                    else
                        MessageBox.Show("Xóa thông báo thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa thông báo: {ex.Message}");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvThongBao.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thông báo cần sửa!");
                return;
            }

            string id = dtgvThongBao.CurrentRow.Cells["NewsID"].Value.ToString();
            string title = dtgvThongBao.CurrentRow.Cells["Title"].Value.ToString();
            string content = dtgvThongBao.CurrentRow.Cells["Content"].Value.ToString();

            frmThongBaoPopup popup = new frmThongBaoPopup(true, id, title, content);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                await LoadNoticesAsync();
            }
        }
    }
}
