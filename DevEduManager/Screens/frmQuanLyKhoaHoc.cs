using BusinessLogic;
using Enity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyKhoaHoc : Form
    {
        CallAPI callAPI = new CallAPI();

        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";

        public frmQuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private async void frmQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxCourseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load chương trình học: " + ex.Message);
            }
        }

        private async Task LoadComboBoxCourseAsync()
        {
            try
            {
                string url = $"{_url}danhSachKhoaHoc";
                DataTable dt = await callAPI.GetAPI(url);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboCT.DataSource = dt;
                    cboCT.DisplayMember = "CourseName";
                    cboCT.ValueMember = "CourseID";

                    // Gắn sự kiện sau khi gán DataSource để tránh chạy 2 lần
                    cboCT.SelectedIndexChanged -= cboCT_SelectedIndexChanged;
                    cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;

                    // Mặc định chọn dòng đầu và load dữ liệu tương ứng
                    cboCT.SelectedIndex = 0;
                    string selectedCourseID = cboCT.SelectedValue.ToString();
                    await LoadDataToGridView(selectedCourseID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load combobox CT: " + ex.Message);
            }
        }

        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCT.SelectedValue != null && Guid.TryParse(cboCT.SelectedValue.ToString(), out Guid courseId))
                {
                    await LoadDataToGridView(courseId.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn CT: " + ex.Message);
            }
        }

        private async Task LoadDataToGridView(string courseId)
        {
            try
            {
                string url = $"{_url}chiTietChuongTrinhHoc?CourseID={courseId}";
                DataTable result = await callAPI.GetAPI(url);
                dtgvCT.AutoGenerateColumns = false;
                dtgvCT.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu chi tiết: " + ex.Message);
            }
        }
    }
}
