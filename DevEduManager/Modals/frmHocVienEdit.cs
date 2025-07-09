using BusinessLogic;
using Enity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmHocVienEdit : Form
    {
        private HocVien _hv;
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Students/";
        public frmHocVienEdit(HocVien hv)
        {
            InitializeComponent();
            _hv = hv;
        }
        private bool ValidateLuu()
        {
            if (txtHoTen.Text == "")
            {
                errorProvider1.SetError(txtHoTen, "Bạn chưa nhập họ và tên");
                txtHoTen.Focus();
                return false;
            }
            else if (txtSDT.Text == "")
            {
                errorProvider1.SetError(txtSDT, "Bạn chưa nhập số điện thoại");
                txtSDT.Focus();
                return false;
            }
            else if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Bạn chưa nhập email");
                txtEmail.Focus();
                return false;
            }
            else if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Bạn chưa nhập địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            else if (txtMatKhau.Text == "")
            {
                errorProvider1.SetError(txtMatKhau, "Bạn chưa nhập số mật khẩu");
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

        private async void frmHocVienEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (_hv is null)
                {
                    string url = $"{_url}taoIdTuDong?ngay={DateTime.Now.Date.ToString("dd/MM/yyyy")}&prefix=HV";
                    string result = await callAPI.CallApiAsync(url);

                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Không thể tạo ID tự động.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    txtMaHV.Text = result.Trim('"');
                    txtTenDangNhap.ReadOnly = false;
                    cboGioiTinh.SelectedIndex = 0;
                    return;
                }

                FillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillData()
        {
            txtMaHV.Text = _hv.StudentID;
            txtHoTen.Text = _hv.FullName;
            cboGioiTinh.Text = _hv.Gender;
            txtDiaChi.Text = _hv.Address;
            txtSDT.Text = _hv.PhoneNumber;
            txtEmail.Text = _hv.Email;
            dateNgayTiepNhan.Value = _hv.EnrollmentDate.Value;
            txtTenDangNhap.Text = _hv.Username;
            dateNgaySinh.Value = _hv.BirthDate.Value;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateLuu())
                {
                    return;
                }

                HocVien hocVien = new HocVien()
                {
                    StudentID = txtMaHV.Text,
                    FullName = txtHoTen.Text,
                    Gender = cboGioiTinh.SelectedItem.ToString(),
                    BirthDate = DateTime.Parse(dateNgaySinh.Value.ToString()).Date, // Chuyển đổi giá trị từ DateTimePicker
                    Address = txtDiaChi.Text,
                    PhoneNumber = txtSDT.Text,
                    Email = txtEmail.Text,
                    EnrollmentDate = DateTime.Parse(dateNgayTiepNhan.Value.ToString()).Date,
                    Username = txtTenDangNhap.Text,
                    Password = txtMatKhau.Text
                };

                string jsonData = JsonConvert.SerializeObject(hocVien);
                string url = null;
                bool result = false;

                if (_hv is null)
                {
                    url = $"{_url2}themThongTinHocVien";
                    result = await callAPI.PostAPI(url, jsonData);
                    if (result)
                    {
                        MessageBox.Show("Thêm thông tin học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin học viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }

                // Update teacher info
                url = $"{_url2}suaThongTinHocVien";
                result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin học viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
