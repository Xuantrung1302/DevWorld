using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Newtonsoft.Json;

namespace DevEduManager.Screens
{
    public partial class frmChat : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _userUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/User/";
        private readonly string _messageUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Message/";
        private int currentUserId = 1; // Giả sử UserID của người đăng nhập (có thể lấy từ session)
        private int selectedUserId = -1; // UserID của tài khoản được chọn

        public frmChat()
        {
            InitializeComponent();
            InitializeComponents();
            LoadAccountTypes();
            txtMessage.KeyDown += TxtMessage_KeyDown; // Thêm sự kiện Enter để gửi tin
        }

        private void InitializeComponents()
        {
            // Cấu hình DataGridView
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.Columns.Add("UserID", "Mã");
            dtgvAccount.Columns.Add("FullName", "Họ tên");
            dtgvAccount.Columns.Add("Role", "Vai trò");
            dtgvAccount.CellClick += DtgvAccount_CellClick;

            // Cấu hình TextBox chat history
            txtChatHistory.ReadOnly = true;
            txtChatHistory.ScrollBars = ScrollBars.Vertical;
        }

        private async void LoadAccountTypes()
        {
            // Dữ liệu cố định cho cboAccountType (có thể thay bằng API nếu cần)
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
                string url = $"{_userUrl}GetUsersByRole?roleId={accountTypeId}";
                DataTable dt = await callAPI.GetAPI(url);
                dtgvAccount.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (Convert.ToInt32(row["UserID"]) != currentUserId) // Loại bỏ chính mình
                        {
                            int rowIndex = dtgvAccount.Rows.Add();
                            dtgvAccount.Rows[rowIndex].Cells["UserID"].Value = row["UserID"];
                            dtgvAccount.Rows[rowIndex].Cells["FullName"].Value = row["FullName"];
                            dtgvAccount.Rows[rowIndex].Cells["Role"].Value = row["RoleName"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(dtgvAccount.Rows[e.RowIndex].Cells["UserID"].Value);
                await LoadChatHistoryAsync();
            }
        }

        private async Task LoadChatHistoryAsync()
        {
            try
            {
                if (selectedUserId == -1) return;

                string url = $"{_messageUrl}GetMessages?senderId={currentUserId}&receiverId={selectedUserId}";
                DataTable dt = await callAPI.GetAPI(url);

                txtChatHistory.Text = "";
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string senderId = row["SenderID"].ToString();
                        string senderName = await GetUserNameAsync(Convert.ToInt32(senderId));
                        string time = Convert.ToDateTime(row["SentDateTime"]).ToString("HH:mm");
                        string messageText = $"{senderName} ({time}): {row["MessageContent"]}\r\n";

                        txtChatHistory.AppendText(messageText);

                        // Định dạng tin nhắn của người gửi hiện tại (currentUser) là màu xanh
                        if (senderId == currentUserId.ToString())
                        {
                            txtChatHistory.Select(txtChatHistory.TextLength - messageText.Length, messageText.Length);
                            //txtChatHistory.SelectionColor = Color.SteelBlue;
                        }
                    }
                }
                txtChatHistory.SelectionStart = txtChatHistory.TextLength;
                txtChatHistory.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải lịch sử chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetUserNameAsync(int userId)
        {
            try
            {
                string url = $"{_userUrl}GetUserName?userId={userId}";
                DataTable dt = await callAPI.GetAPI(url);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["FullName"].ToString();
                }
                return "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1 || string.IsNullOrWhiteSpace(txtMessage.Text)) return;

            try
            {
                string messageContent = txtMessage.Text.Trim();
                DateTime sentTime = DateTime.Now; // Lấy thời gian hiện tại (01:19 AM +07, 02/08/2025)

                // Gửi tin nhắn qua API
                var message = new
                {
                    SenderID = currentUserId,
                    ReceiverID = selectedUserId,
                    MessageContent = messageContent,
                    SentDateTime = sentTime
                };
                string json = JsonConvert.SerializeObject(message);
                string url = $"{_messageUrl}SendMessage";

                bool success = await callAPI.PostAPI(url, json);

                if (success)
                {
                    // Cập nhật lịch sử chat
                    await LoadChatHistoryAsync();
                    txtMessage.Text = ""; // Xóa nội dung nhập
                }
                else
                {
                    MessageBox.Show("Gửi tin nhắn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi tin nhắn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true; // Ngăn Enter tạo dòng mới
                btnSend_Click(null, null);
            }
        }
    }
}