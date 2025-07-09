using BusinessLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmLopHocEdit : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";

        private string _teacherUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        string classID = null;
        string className = null;
        public frmLopHocEdit(string classId, string className)
        {
            InitializeComponent();
            this.classID = classId;
            this.className = className;
        }

        private void frmLopHocEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenLH.Text = className;
                LoadCaHoc();
                LoadDaysOfWeek();
                LoadListTeacher();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadCaHoc()
        {
            List<string> caHocList = new List<string>
            {
                "08:00-10:00",
                "10:00-12:00",
                "13:00-15:00",
                "15:00-17:00",
                "17:00-19:00",
                "19:00-21:00"
            };

            cboCaHoc.DataSource = caHocList;
        }

        private void LoadPhòngHoc()
        {
            List<string> caHocList = new List<string>
            {
                "B100",
                "B101",
                "B102",
                "B103",
                "B104",
                "B105"
            };

            cboCaHoc.DataSource = caHocList;
        }



        private void LoadDaysOfWeek()
        {
            List<string> daysOfWeek = new List<string>
            {
                "Thứ 2",
                "Thứ 3",
                "Thứ 4",
                "Thứ 5",
                "Thứ 6",
                "Thứ 7",
                "Chủ nhật"
            };

            clbDaysOfWeek.Items.Clear();
            foreach (string day in daysOfWeek)
            {
                clbDaysOfWeek.Items.Add(day);
            }
        }

        private async void LoadListTeacher()
        {
            try
            {
                string url = $"{_teacherUrl}layGiangVienChoLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
                cboGV.DataSource = result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!ValidateLuu()) return;

                // Tạo đối tượng Semester để gửi
                var subject = new
                {
                    
                };

                string jsonData = JsonConvert.SerializeObject(subject, new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc
                });
                string url = isInsert ? $"{_classUrl}themLop" : $"{_classUrl}suaThongTinLop";

                bool result = await callAPI.PostAPI(url, jsonData);

                if (result)
                {
                    MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{(isInsert ? "Thêm" : "Cập nhật")} lớp học không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
