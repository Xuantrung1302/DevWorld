using BusinessLogic;
using Enity.Models;
using Newtonsoft.Json;
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
    public partial class frmKyHocEdit : Form
    {
        private DataTable _kh;
        private bool isInsert = true;
        CallAPI callAPI = new CallAPI();

        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";

        public frmKyHocEdit(DataTable kh)
        {
            InitializeComponent();
            _kh = kh;
            isInsert = _kh == null;
            Load += frmKyHocEdit_Load; // Đăng ký sự kiện Load
        }

        private bool ValidateLuu()
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                errorProvider1.SetError(txtMaKH, "Bạn chưa nhập mã kỳ học");
                txtMaKH.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTenKyHoc.Text))
            {
                errorProvider1.SetError(txtTenKyHoc, "Bạn chưa nhập tên kỳ học");
                txtTenKyHoc.Focus();
                return false;
            }
            else if (dateStart.Value > dateEnd.Value)
            {
                errorProvider1.SetError(dateEnd, "Ngày kết thúc phải lớn hơn ngày bắt đầu");
                dateEnd.Focus();
                return false;
            }
            return true;
        }

        private async void frmKyHocEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //LoadTrangThai();
                if (isInsert)
                {
                    await GenerateMaKyHoc();  // Gọi mã tự động
                    txtTenKyHoc.Text = "";
                    dateStart.Value = DateTime.Today;
                    dateEnd.Value = DateTime.Today;
                }
                else
                {
                    if (_kh != null && _kh.Rows.Count > 0)
                    {
                        FillData(_kh.Rows[0]);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            txtMaKH.ReadOnly = !isInsert;
        }


        //private void LoadTrangThai()
        //{
        //    var items = new List<KeyValuePair<string, string>>
        //    {
        //        new KeyValuePair<string, string>("1", "Chuẩn bị"),
        //        new KeyValuePair<string, string>("2", "Đang diễn ra"),
        //        new KeyValuePair<string, string>("3", "Kết thúc")
        //    };

        //    cboTrangThai.DataSource = items;
        //    cboTrangThai.DisplayMember = "Value";   // Dòng này sẽ hiển thị giá trị văn bản
        //    cboTrangThai.ValueMember = "Key";       // Dòng này là giá trị thật (1,2,3)
        //}


        private async Task GenerateMaKyHoc()
        {
            try
            {
                string url = $"{_url2}taoIdTuDong?ngay={DateTime.Now:dd/MM/yyyy}&prefix=KH";
                string result = await callAPI.CallApiAsync(url);
                txtMaKH.Text = result.Trim('\"');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mã kỳ học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FillData(DataRow kh)
        {
            try
            {
                txtMaKH.Text = kh["SemesterID"].ToString();
                txtTenKyHoc.Text = kh["SemesterName"].ToString();

                if (kh["StartDate"] != DBNull.Value)
                    dateStart.Value = Convert.ToDateTime(kh["StartDate"]);

                if (kh["EndDate"] != DBNull.Value)
                    dateEnd.Value = Convert.ToDateTime(kh["EndDate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi điền dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateLuu()) return;

                // Tạo đối tượng Semester để gửi
                var semester = new
                {
                    SemesterID = txtMaKH.Text,
                    SemesterName = txtTenKyHoc.Text,
                    StartDate = dateStart.Value.Date,
                    EndDate = dateEnd.Value.Date,

                    //Status = cboTrangThai.SelectedValue?.ToString() // Status chỉ dùng cho update
                };

                string jsonData = JsonConvert.SerializeObject(semester, new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc
                });

                string url = isInsert ? $"{_url}themThongTinKyHoc" : $"{_url}suaThongTinKyHoc";

                bool result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} kỳ học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} kỳ học không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi {(isInsert ? "thêm" : "cập nhật")}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}