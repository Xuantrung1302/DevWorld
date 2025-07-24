using DevEduManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Configuration;
using Entity.Models;

namespace DevEduManager.Screens
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Service/";
        public DataTable userData;
        #region Events

        private bool CheckDangNhap()
        {
            if (txtTenDangNhap.Text == "")
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

        private void frmDangNhap_Load_1(object sender, EventArgs e)
        {
            chkSave.Checked = Settings.Default.Login_IsSaved;

            if (chkSave.Checked)
            {
                txtTenDangNhap.Text = Settings.Default.Login_UserName;
                txtMatKhau.Text = Settings.Default.Login_Password;
            }

            lblNotification.Text = string.Empty;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void chkSave_CheckedChanged_1(object sender, EventArgs e)
        {
            Settings.Default.Login_IsSaved = chkSave.Checked;
            Settings.Default.Save();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (CheckDangNhap())
            {
                string userName = txtTenDangNhap.Text;
                string passWord = txtMatKhau.Text;

                try
                {
                    string url = $"{_url}dangNhap?Username={userName}&Password={passWord}";
                    DataTable result = await callAPI.GetAPI(url);

                    if (result.Rows.Count > 0)
                    {
                        DataRow row = result.Rows[0];

                        // Gán Role và Username gốc
                        CurrentUser.Role = row["Role"].ToString();
                        CurrentUser.Username = row["Username"].ToString();

                        // Nếu không phải Admin, thì gán tên thực dựa trên ID
                        if (CurrentUser.Role != "Admin")
                        {
                            if (!string.IsNullOrEmpty(row["EmployeeID"].ToString()))
                            {
                                CurrentUser.Username = row["EmployeeName"].ToString();
                            }
                            else if (!string.IsNullOrEmpty(row["StudentID"].ToString()))
                            {
                                CurrentUser.Username = row["StudentName"].ToString();
                            }
                            else if (!string.IsNullOrEmpty(row["TeacherID"].ToString()))
                            {
                                CurrentUser.Username = row["TeacherName"].ToString();
                            }
                        }

                        // Lưu thông tin vào Settings (nếu muốn lưu đăng nhập)
                        Settings.Default.Login_UserName = txtTenDangNhap.Text;
                        Settings.Default.Login_Password = txtMatKhau.Text;
                        Settings.Default.Save();

                        // Mở form chính
                        userData = result;
                        frmMain frm = new frmMain(userData);
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    lblNotification.Text = "Đã xảy ra lỗi khi đăng nhập. Vui lòng thử lại.";
                    System.Media.SystemSounds.Exclamation.Play();
                    Console.WriteLine(ex.ToString()); // Ghi log lỗi chi tiết
                }
            }
        }


        #endregion

    }
}
