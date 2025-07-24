using BusinessLogic;
using DevEduManager.Properties;
using Entity.Modals;
using Entity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThongBaoPopup : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _noticeUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Notice/";
        private readonly string _serviceUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private bool isEdit;
        private string newsID;

        public frmThongBaoPopup(bool editMode = false, string id = null, string title = "", string content = "")
        {
            InitializeComponent();
            isEdit = editMode;
            newsID = id;

            txtTitle.Text = title;
            txtContent.Text = content;

            this.Text = isEdit ? "Sửa Thông Báo" : "Thêm Thông Báo";
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = false;

                if (isEdit)
                {
                    // ✅ Sửa
                    var updateData = new
                    {
                        NewsID = newsID,
                        Title = txtTitle.Text.Trim(),
                        Content = txtContent.Text.Trim(),
                        PostDate = DateTime.Now,
                        PostedBy = Settings.Default.Login_UserName

                    };

                    string json = JsonConvert.SerializeObject(updateData);
                    //result = await callAPI.PostAPI($"{_noticeUrl}suaThongTinThongBao", json);
                    string url = $"{_noticeUrl}suaThongTinThongBao";
                    result = await callAPI.PostAPI(url, json);
                }
                else
                {
                    

                    // ✅ Thêm mới
                    var insertData = new
                    {
                        Title = txtTitle.Text.Trim(),
                        Content = txtContent.Text.Trim(),
                        PostDate = DateTime.Now,
                        PostedBy = Settings.Default.Login_UserName // Lấy từ thông tin đăng nhập
                    };

                    string json = JsonConvert.SerializeObject(insertData);
                    result = await callAPI.PostAPI($"{_noticeUrl}themThongBao", json);
                }

                if (result)
                {
                    MessageBox.Show(isEdit ? "Cập nhật thành công!" : "Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Báo cho form cha reload
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
