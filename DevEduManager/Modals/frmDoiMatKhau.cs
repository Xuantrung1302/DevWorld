using BusinessLogic;
using Entity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmDoiMatKhau : Form
    {
        private string _dbPassword = string.Empty; // Mật khẩu lấy từ DB
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                errorProvider1.SetError(txtMatKhauCu, "Vui lòng nhập mật khẩu cũ");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                errorProvider1.SetError(txtMatKhauMoi, "Vui lòng nhập mật khẩu mới");
                return false;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhauMoi, "Mật khẩu mới phải từ 6 ký tự trở lên");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhauMoiAgain.Text))
            {
                errorProvider1.SetError(txtMatKhauMoiAgain, "Vui lòng nhập lại mật khẩu mới");
                return false;
            }
            if (txtMatKhauMoi.Text != txtMatKhauMoiAgain.Text)
            {
                errorProvider1.SetError(txtMatKhauMoiAgain, "Mật khẩu nhập lại không khớp");
                return false;
            }
            return true;
        }

        private void ResetFields()
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtMatKhauMoiAgain.Clear();
        }

        private async void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi API lấy thông tin tài khoản hiện tại
                string url = $"{_url}layThongTinTaiKhoan?username={CurrentUser.Username}";
                DataTable dt = await callAPI.GetAPI(url); // Hàm này trả về DataTable

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    _dbPassword = row["Password"].ToString();  // Lấy mật khẩu từ DB
                }
                else
                {
                    MessageBox.Show("Không lấy được thông tin tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private async void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                // Kiểm tra mật khẩu cũ từ DB
                if (txtMatKhauCu.Text != _dbPassword)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo payload gửi API
                var data = new
                {
                    Username = CurrentUser.Username,
                    Password = txtMatKhauMoi.Text,
                    Role = CurrentUser.Role
                };

                string jsonData = JsonConvert.SerializeObject(data);
                string url = $"{_url}doiMatKhau";

                bool result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
