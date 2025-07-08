using BusinessLogic;
using Enity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmGiangVienEdit : Form
    {
        private GiangVien _gv;
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Teacher/";
        public frmGiangVienEdit(GiangVien gv)
        {
            InitializeComponent();
            _gv = gv;
        }

        private bool ValidateLuu()
        {
            if (txtTenGV.Text == "")
            {
                errorProvider1.SetError(txtTenGV, "Bạn chưa nhập họ và tên");
                txtTenGV.Focus();
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
            else if (txtTenDangNhap.Text == "")
            {
                errorProvider1.SetError(txtTenDangNhap, "Bạn chưa nhập tên đăng nhập");
                txtTenDangNhap.Focus();
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

        private void FillData()
        {
            txtMaGV.Text = _gv.TeacherID;
            txtTenGV.Text = _gv.FullName;
            cboGioiTinh.Text = _gv.Gender;
            txtSDT.Text = _gv.PhoneNumber;
            txtEmail.Text = _gv.Email;
            txtDiaChi.Text = _gv.Address;
            txtTenDangNhap.Text = _gv.Username;
            txtMatKhau.Text = _gv.Password;
            txtBangCap.Text = _gv.Degree;
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (!ValidateLuu())
                {
                    return;
                }

                var giangVien = new GiangVien()
                {
                    TeacherID = txtMaGV.Text,
                    FullName = txtTenGV.Text,
                    Gender = cboGioiTinh.SelectedItem.ToString(),
                    Address = txtDiaChi.Text,
                    Degree = txtBangCap.Text,
                    PhoneNumber = txtSDT.Text,
                    Email = txtEmail.Text,
                    Username = txtTenDangNhap.Text,
                    Password = txtMatKhau.Text
                };

                string jsonData = JsonConvert.SerializeObject(giangVien);
                string url = null;
                bool result = false;

                // Add new teacher
                if (_gv is null)
                {
                    url = $"{_url2}themThongTinGiangVien";
                    result = await callAPI.PostAPI(url, jsonData);
                    if (result)
                    {
                        MessageBox.Show("Thêm thông tin giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin giảng viên không thành c ông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }

                // Update teacher info
                url = $"{_url2}suaThongTinGiangVien";
                result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giảng viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void frmGiangVienEdit_Load(object sender, EventArgs e)
        {
            try
            {

                if (_gv is null)
                {
                    string url = $"{_url}taoIdTuDong?ngay={DateTime.Now.Date.ToString("dd/MM/yyyy")}&prefix=GV";
                    string result = await callAPI.CallApiAsync(url);

                    txtMaGV.Text = result.Trim('"');
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
    }
}
