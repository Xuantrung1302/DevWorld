using BusinessLogic;
using DevEduManager.Screens;
using DocumentFormat.OpenXml.VariantTypes;
using Entity.Models;
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

namespace DevEduManager.Modals
{
    public partial class frmTaoChat : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _userUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/User/";
        private readonly string _messageUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Message/";
        private readonly string _hubUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}signalr"; // URL SignalR


        public frmTaoChat()
        {
            InitializeComponent();

        }

        private void frmTaoChat_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAccountTypes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập mã tác nhân cần tìm kiếm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtgvAccount.DataSource is DataTable dt)
            {
                // Tạo view lọc theo cột ID
                DataView view = new DataView(dt);
                view.RowFilter = $"ID LIKE '%{searchText}%'"; // hoặc đổi 'ID' thành tên cột đúng

                if (view.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dtgvAccount.DataSource = view;
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dtgvAccount.CurrentRow;
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản để tạo cuộc trò chuyện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID người được chọn (giả sử cột "ID" kiểu string hoặc int, chuyển sang string)
                string receiverId = selectedRow.Cells["ID"].Value?.ToString();
                if (string.IsNullOrEmpty(receiverId))
                {
                    MessageBox.Show("ID tài khoản không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy ID người đăng nhập
                string senderId = CurrentUser.UserId; // Bạn thay đổi theo cách lấy ID người dùng đăng nhập của bạn

                if (receiverId == senderId)
                {
                    MessageBox.Show("Không thể tạo cuộc trò chuyện với chính bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo object Message với MessageContent null
                var message = new Message
                {
                    SenderID = senderId,
                    ReceiverID = receiverId,
                    MessageContent = null,
                    SentDateTime = null
                };

                // Chuyển object thành JSON (dùng Newtonsoft.Json hoặc System.Text.Json)
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(message);

                // Gửi POST API
                string url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Message/taoCuocTroChuyen";
                bool result = await callAPI.PostAPI(url, json);

                if (result)
                {
                    MessageBox.Show("Tạo cuộc trò chuyện thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bạn có thể gọi hàm reload lại danh sách cuộc trò chuyện nếu có
                    // LoadConversationList(); // Ví dụ hàm reload

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tạo cuộc trò chuyện thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo cuộc trò chuyện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void LoadAccountTypes()
        {
            var accountTypes = new Dictionary<int, string>
            {
                { 1, "Nhân viên" },
                { 2, "Giảng viên" },
                { 3, "Học viên" }
            };
            cboAccountType.DataSource = new BindingSource(accountTypes, null);
            cboAccountType.DisplayMember = "Value";
            cboAccountType.ValueMember = "Key";
            cboAccountType.SelectedIndex = 0;
            await LoadAccountsAsync(cboAccountType.SelectedValue.ToString());
            cboAccountType.SelectedIndexChanged += CboAccountType_SelectedIndexChanged;
        }
        private async void CboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAccountType.SelectedValue != null)
            {
                await LoadAccountsAsync(cboAccountType.SelectedValue.ToString());
            }
        }

        private async Task LoadAccountsAsync(string accountTypeId)
        {
            try
            {
                string _id = CurrentUser.UserId;
                string url = $"{_messageUrl}GetAccountsByRole?roleId={accountTypeId}&CurrentUserID={_id}"; // Khớp với route API
                DataTable dt = await callAPI.GetAPI(url);
                //dtgvAccount.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dtgvAccount.AutoGenerateColumns = false;
                    dtgvAccount.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadAccountsAsync(cboAccountType.SelectedValue.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public class Message
    {
        public string MessageID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string MessageContent { get; set; }
        public DateTime? SentDateTime { get; set; }
    }
}
