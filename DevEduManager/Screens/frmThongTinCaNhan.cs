using BusinessLogic;
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

namespace DevEduManager.Screens
{
    public partial class frmThongTinCaNhan : Form
    {
        string ma = CurrentUser.UserId;
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _serviceUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private async void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadThongTinCaNhan(ma);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task LoadThongTinCaNhan(string ma)
        {
            try
            {
                string url = $"{_serviceUrl}thongTinCuaTacNhan?ID={ma}";
                var dt = await callAPI.GetAPI(url);

                if (dt != null && dt.Rows.Count > 0)
                {
                    txtMa.Text = dt.Rows[0]["ID"].ToString();
                    txtHoTen.Text = dt.Rows[0]["FullName"].ToString();
                    txtSex.Text = dt.Rows[0]["Gender"].ToString();
                    txtDiaChi.Text = dt.Rows[0]["Address"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtSDT.Text = dt.Rows[0]["PhoneNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cá nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
