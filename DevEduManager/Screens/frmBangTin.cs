using BusinessLogic;
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
    public partial class frmBangTin : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Notice/";
        public frmBangTin()
        {
            InitializeComponent();
        }

        private void LoadPosts(List<BusinessLogic.Post> ds)
        {
            try
            {
                // Tạo nội dung HTML để hiển thị các bài đăng
                string htmlContent = "<html><body style='font-family: Meiryo UI, Arial, sans-serif; font-size: 14px;'>";
                htmlContent += "<table style='width: 100%;'>";

                // Kiểm tra danh sách bài đăng
                if (ds == null || ds.Count == 0)
                {
                    htmlContent += "<tr><td>Chưa có thông báo nào.</td></tr>";
                }
                else
                {
                    // Hiển thị danh sách bài đăng, sắp xếp theo ngày giảm dần (mới nhất lên đầu)
                    var sortedPosts = ds.OrderByDescending(p => p.PostDate).ToList();
                    foreach (var post in sortedPosts)
                    {
                        string formattedContent = post.Content.Replace("\n", "<br>");
                        string formattedDate = post.PostDate.ToString("dd-MM-yyyy"); // Định dạng ngày

                        htmlContent += "<tr valign='top'>";
                        htmlContent += $"<td style='width: 600px; font-weight: bold;'>{formattedDate}</td>"; // Chỉnh độ rộng cột
                        htmlContent += "<td style='width: 150px;'>&nbsp;</td>";
                        htmlContent += "<td style='width: 90%;'>";
                        htmlContent += $"<h3 style='margin: 0; font-size: 16px;'>{post.Title}</h3>";
                        htmlContent += $"<p>{formattedContent}</p>";
                        htmlContent += "<hr/></td></tr>";
                    }
                }

                htmlContent += "</table></body></html>";

                // Hiển thị nội dung HTML trong WebBrowser
                webBrowser1.DocumentText = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thông báo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            //LoadPosts();
        }

        private async void frmBangTin_Shown(object sender, EventArgs e)
        {
            //DataStore.Posts = new List<BusinessLogic.Post>
            //{
            //    new BusinessLogic.Post
            //    {
            //        MaBangTin = "4ea7911b-1300-4711-8bdd-449e7a6cc1b9",
            //        Title = "Cập nhật nội quy mới",
            //        Content = "Phòng HCNS thông báo về ngày nghỉ lễ Giỗ Tổ Hùng Vương...",
            //        MaNV = "NV0003",
            //        Date = "2025-04-02"
            //    },
            //    new BusinessLogic.Post
            //    {
            //        MaBangTin = "4ea7911b-1300-4711-8bdd-449e7a6cc1b2",
            //        Title = "Thông báo kì nghỉ dài",
            //        Content = "Phòng HCNS thông báo về ngày nghỉ lễ và tổ chức đi du lịchxcccccccccczx" +
            //        "xzccccccccccccccccccccccccccccccccccccccccccczxczxczxczxc" +
            //        "zxcccccccccccccccccccccccccc. \r\nTrân trọng!",
            //        MaNV = "NV0003",
            //        Date = "2025-04-02"
            //    }
            //};

            try
            {
                string url = $"{_url}danhSachThongBao";
                List<BusinessLogic.Post> ds = new List<BusinessLogic.Post>();
                ds = await callAPI.GetListAPI(url);
                LoadPosts(ds);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnExitNotice_Click(object sender, EventArgs e)
        {

        }
    }
}
