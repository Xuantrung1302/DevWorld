using BusinessLogic;
using DevEduManager.Properties;
using Entity.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        CurrentUser.Password = row["Password"].ToString();

                        if (row["EmployeeName"] != DBNull.Value && !string.IsNullOrEmpty(row["EmployeeName"].ToString()))
                        {
                            CurrentUser.FullName = row["EmployeeName"].ToString();
                        }
                        else if (row["StudentName"] != DBNull.Value && !string.IsNullOrEmpty(row["StudentName"].ToString()))
                        {
                            CurrentUser.FullName = row["StudentName"].ToString();
                        }
                        else if (row["TeacherName"] != DBNull.Value && !string.IsNullOrEmpty(row["TeacherName"].ToString()))
                        {
                            CurrentUser.FullName = row["TeacherName"].ToString();
                        }
                        else
                        {
                            CurrentUser.FullName = string.Empty; // Hoặc null
                        }


                        if (row["EmployeeID"] != DBNull.Value && !string.IsNullOrEmpty(row["EmployeeID"].ToString()))
                        {
                            CurrentUser.UserId = row["EmployeeID"].ToString();
                        }
                        else if (row["StudentID"] != DBNull.Value && !string.IsNullOrEmpty(row["StudentID"].ToString()))
                        {
                            CurrentUser.UserId = row["StudentID"].ToString();
                        }
                        else if (row["TeacherID"] != DBNull.Value && !string.IsNullOrEmpty(row["TeacherID"].ToString()))
                        {
                            CurrentUser.UserId = row["TeacherID"].ToString();
                        }
                        else
                        {
                            CurrentUser.UserId = string.Empty; // Hoặc null
                        }

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

                        if (CurrentUser.Role == "Employee" || CurrentUser.Role == "Admin")
                        {
                            var (lat, lon) = await GetCurrentLocation();
                            if (IsWithinSchoolRadius(lat, lon))
                            {
                                string apiUrl = $"{_url}payroll/addWorkDay?employeeId={CurrentUser.UserId}";
                                await callAPI.PostAPI(apiUrl, "");
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
        private async Task<(double Latitude, double Longitude)> GetCurrentLocation()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetStringAsync("https://ipinfo.io/json");
                    var json = JObject.Parse(response);
                    string loc = (string)json["loc"]; // Ví dụ: "10.762622,106.660172"
                    var parts = loc.Split(',');

                    double lat = double.Parse(parts[0]);
                    double lon = double.Parse(parts[1]);
                    return (lat, lon);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lấy vị trí IP", ex);
            }
        }


        private bool IsWithinSchoolRadius(double userLat, double userLon)
        {
            double schoolLat = double.Parse(ConfigurationManager.AppSettings["SchoolLatitude"]);
            double schoolLon = double.Parse(ConfigurationManager.AppSettings["SchoolLongitude"]);
            double radius = double.Parse(ConfigurationManager.AppSettings["SchoolRadius"]); // in meters

            double distance = GetDistanceInMeters(schoolLat, schoolLon, userLat, userLon);
            return distance <= radius;
        }

        // Kiem tra do sai lech ban kinh
        private double GetDistanceInMeters(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6371000; // radius of Earth in meters
            var dLat = (lat2 - lat1) * Math.PI / 180;
            var dLon = (lon2 - lon1) * Math.PI / 180;
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

    }
}
