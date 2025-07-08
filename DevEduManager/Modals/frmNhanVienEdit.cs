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
    public partial class frmNhanVienEdit : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        private string _url2 = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Employee/";
        private NhanVien _nv;
        public frmNhanVienEdit(NhanVien nv)
        {
            InitializeComponent();
            _nv = nv;
        }
        private bool ValidateLuu()
        {
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập họ và tên");
                txtTenNV.Focus();
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
                errorProvider1.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

        private async void frmNhanVienEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (_nv is null)
                {
                    string url = $"{_url}taoIdTuDong?ngay={DateTime.Now.Date.ToString("dd/MM/yyyy")}&prefix=NV";
                    string result = await callAPI.CallApiAsync(url);

                    txtMaNV.Text = result.Trim('"');
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
            txtMaNV.Text = _nv.EmployeeID;
            txtTenNV.Text = _nv.FullName;
            txtSDT.Text = _nv.PhoneNumber;
            txtEmail.Text = _nv.Email;
            cboGioiTinh.Text = _nv.Gender;
            txtDiaChi.Text = _nv.Address;
            txtTenDangNhap.Text = _nv.Username;
            txtMatKhau.Text = _nv.Password;
        }

        private async void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateLuu())
                {
                    return;
                }

                NhanVien nhanVien = new NhanVien()
                {
                    EmployeeID = txtMaNV.Text,
                    FullName = txtTenNV.Text,
                    PhoneNumber = txtSDT.Text,
                    Address = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    Gender = cboGioiTinh.SelectedItem.ToString(),
                    Username = txtTenDangNhap.Text,
                    Password = txtMatKhau.Text
                };

                string jsonData = JsonConvert.SerializeObject(nhanVien);
                string url = null;
                bool result = false;

                if (_nv is null)
                {
                    url = $"{_url2}themThongTinNhanVien";
                    result = await callAPI.PostAPI(url, jsonData);
                    if (result)
                    {
                        MessageBox.Show("Thêm thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }

                // Update teacher info
                url = $"{_url2}suaThongTinNhanVien";
                result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
