using Microsoft.AspNet.SignalR.Client;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Newtonsoft.Json;
using DevEduManager.Modals;
using Entity.Models;

namespace DevEduManager.Screens
{
    public partial class frmChat : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _userUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/User/";
        private readonly string _messageUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Message/";
        private readonly string _hubUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}signalr";
        private IHubProxy chatHubProxy;
        private HubConnection connection;


        private string selectedUserId = null;

        public frmChat()
        {
            InitializeComponent();
            InitializeComponents();
            txtMessage.KeyDown += TxtMessage_KeyDown;
            ConnectToSignalR();
        }

        private async void ConnectToSignalR()
        {
            try
            {
                connection = new HubConnection(_hubUrl, $"userId={CurrentUser.UserId}");
                chatHubProxy = connection.CreateHubProxy("ChatHub");

                chatHubProxy.On<Message>("receiveMessage", (message) =>
                {
                    if (message.ReceiverID == CurrentUser.UserId &&
                        (message.SenderID == selectedUserId || selectedUserId == null))
                    {
                        BeginInvoke(new Action(async () =>
                        {
                            string senderName = GetUserNameAsync(message.SenderID);
                            string time = message.SentDateTime?.ToString("HH:mm") ?? "";
                            string messageText = $"{senderName} ({time}): {message.MessageContent}\r\n";
                            Control bubble = CreateMessageBubble(senderName, message.MessageContent, time, message.SenderID == CurrentUser.UserId);
                            flpChat.Controls.Add(bubble);
                            flpChat.ScrollControlIntoView(bubble);

                        }));
                    }
                });

                await connection.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối SignalR: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponents()
        {
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.CellClick += DtgvAccount_CellClick;
        }

        private async Task LoadAccountsAsync(string userId)
        {
            try
            {
                string url = $"{_messageUrl}layDanhSachTaiKhoanDaNhanTin?CurrentUserID={userId}";
                DataTable dt = await callAPI.GetAPI(url);

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

        private async void DtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = dtgvAccount.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                await LoadChatHistoryAsync();
            }
        }

        private async Task LoadChatHistoryAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(selectedUserId)) return;
                string senderID = CurrentUser.UserId;
                string receiverID = selectedUserId;
                string url = $"{_messageUrl}GetMessages?SenderID={senderID}&ReceiverID={receiverID}";
                DataTable dt = await callAPI.GetAPI(url);

                flpChat.Controls.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string senderId = row["SenderID"].ToString();
                        string senderName =  GetUserNameAsync(senderId);
                        string message = row["MessageContent"].ToString();
                        string time = Convert.ToDateTime(row["SentDateTime"]).ToString("HH:mm");

                        bool isCurrentUser = senderId == CurrentUser.UserId;

                        Control bubble = CreateMessageBubble(senderName, message, time, isCurrentUser);
                        flpChat.Controls.Add(bubble);
                    }
                }

                flpChat.VerticalScroll.Value = flpChat.VerticalScroll.Maximum;
                flpChat.ScrollControlIntoView(flpChat.Controls[flpChat.Controls.Count - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải lịch sử chat: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetUserNameAsync(string userId)
        {
            try
            {
                if (userId == CurrentUser.UserId)
                    return CurrentUser.FullName;
                else
                {
                    foreach (DataGridViewRow row in dtgvAccount.Rows)
                    {
                        if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == userId)
                        {
                            string fullName = row.Cells["FullName"].Value?.ToString() ?? "Unknown";
                            return fullName;
                        }
                    }
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
            if (string.IsNullOrWhiteSpace(selectedUserId) || string.IsNullOrWhiteSpace(txtMessage.Text)) return;

            try
            {
                string messageContent = txtMessage.Text.Trim();
                DateTime sentTime = DateTime.Now;

                var message = new
                {
                    SenderID = CurrentUser.UserId,
                    ReceiverID = selectedUserId,
                    MessageContent = messageContent,
                    SentDateTime = sentTime
                };

                string json = JsonConvert.SerializeObject(message);
                string url = $"{_messageUrl}SendMessage";

                bool success = await callAPI.PostAPI(url, json);

                if (success)
                {
                    await LoadChatHistoryAsync();
                    txtMessage.Text = "";
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
                e.SuppressKeyPress = true;
                btnSend_Click(null, null);
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            frmTaoChat frm = new frmTaoChat();
            frm.ShowDialog();

            await LoadAccountsAsync(CurrentUser.UserId);
        }

        private async void frmChat_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadAccountsAsync(CurrentUser.UserId);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private Control CreateMessageBubble(string senderName, string messageContent, string time, bool isCurrentUser)
        {
            Panel bubble = new Panel();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(400, 0);
            bubble.Padding = new Padding(8);
            bubble.BackColor = isCurrentUser ? Color.LightGreen : Color.LightGray;

            // Tạo label
            Label lblText = new Label();
            lblText.AutoSize = true;
            lblText.Text = $"{senderName} ({time}):\n{messageContent}";
            lblText.Font = new Font("Segoe UI", 16F);
            lblText.MaximumSize = new Size(400, 0);
            lblText.TextAlign = isCurrentUser ? ContentAlignment.TopRight : ContentAlignment.TopLeft;

            bubble.Controls.Add(lblText);

            // Căn lề để "đẩy" bubble về phải hoặc trái trong FlowLayoutPanel
            if (isCurrentUser)
            {
                bubble.Anchor = AnchorStyles.Right;
                bubble.Margin = new Padding(flpChat.Width - 420, 5, 5, 5); // Căn phải
            }
            else
            {
                bubble.Anchor = AnchorStyles.Left;
                bubble.Margin = new Padding(5, 5, flpChat.Width - 420, 5); // Căn trái
            }

            return bubble;
        }

    }

    public class Message
    {
        public int MessageID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string MessageContent { get; set; }
        public DateTime? SentDateTime { get; set; }
    }
}
