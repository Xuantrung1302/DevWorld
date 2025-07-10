using BusinessLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmLopHocEdit : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private string _roomUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Room/";
        private string _teacherUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Teacher/";

        string classID = null;
        string className = null;
        string subjectID = null;
        bool isAddingTeacher = false;

        public frmLopHocEdit(string classId, string className, string subjectId)
        {
            InitializeComponent();

            this.classID = classId;
            this.className = className;
            this.subjectID = subjectId;
            //this.isAddingTeacher = isAddingTeacher;

            if (!isAddingTeacher)
            {
                cboGV.Enabled = false;
            }
        }

        private void frmLopHocEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenLH.Text = className;
                LoadCaHoc();
                LoadDaysOfWeek();
                LoadPhongHoc();

                if (isAddingTeacher)
                {
                    LoadListTeacher();

                    // Disable tất cả các control liên quan đến lớp học
                    txtTenLH.Enabled = false;
                    cboCaHoc.Enabled = false;
                    cboPhong.Enabled = false;
                    clbDaysOfWeek.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load form: " + ex.Message);
            }
        }

        private void LoadCaHoc()
        {
            List<string> caHocList = new List<string>
            {
                "08:00-10:00", "10:00-12:00", "13:00-15:00",
                "15:00-17:00", "17:00-19:00", "19:00-21:00"
            };
            cboCaHoc.DataSource = caHocList;
        }

        private async void LoadPhongHoc()
        {
            string url = $"{_roomUrl}layLop";
            DataTable result = await callAPI.GetAPI(url);

            cboPhong.DataSource = result;
            cboPhong.DisplayMember = "Room";
            cboPhong.ValueMember = "RoomID";
            cboPhong.Tag = result;
        }

        private void LoadDaysOfWeek()
        {
            List<string> daysOfWeek = new List<string>
            {
                "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật"
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
                string url = $"{_classUrl}layGiangVienChoLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
                cboGV.DataSource = result;
                cboGV.DisplayMember = "FullName";
                cboGV.ValueMember = "TeacherID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giảng viên: " + ex.Message);
            }
        }

        private async void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra điều kiện chung

                if (string.IsNullOrWhiteSpace(txtTenLH.Text) || cboCaHoc.SelectedItem == null ||
                    cboPhong.SelectedItem == null || clbDaysOfWeek.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin lớp học.");
                    return;
                }



                // Parse thời gian học
                string selectedCa = cboCaHoc.SelectedItem.ToString(); // Ví dụ "08:00-10:00"
                string[] timeParts = selectedCa.Split('-');
                string startTimeStr = timeParts[0];
                string endTimeStr = timeParts[1];
                DateTime startTime = DateTime.ParseExact(startTimeStr, "HH:mm", null);
                DateTime endTime = DateTime.ParseExact(endTimeStr, "HH:mm", null);

                // Parse ngày học trong tuần
                List<string> selectedDays = new List<string>();
                foreach (var item in clbDaysOfWeek.CheckedItems)
                {
                    switch (item.ToString())
                    {
                        case "Thứ 2": selectedDays.Add("2"); break;
                        case "Thứ 3": selectedDays.Add("3"); break;
                        case "Thứ 4": selectedDays.Add("4"); break;
                        case "Thứ 5": selectedDays.Add("5"); break;
                        case "Thứ 6": selectedDays.Add("6"); break;
                        case "Thứ 7": selectedDays.Add("7"); break;
                        case "Chủ nhật": selectedDays.Add("CN"); break;
                    }
                }

                string daysOfWeekStr = string.Join(",", selectedDays);

                // Lấy thông tin phòng và số chỗ
                DataTable dtRoom = cboPhong.Tag as DataTable;
                string roomID = cboPhong.SelectedValue.ToString();
                string roomName = cboPhong.Text;
                int maxSeats = 0;

                if (dtRoom != null)
                {
                    var row = dtRoom.AsEnumerable().FirstOrDefault(r => r["RoomID"].ToString() == roomID);
                    if (row != null)
                    {
                        maxSeats = Convert.ToInt32(row["MaxSeats"]);
                    }
                }

                //// Lấy teacherID nếu đang ở chế độ thêm giảng viên
                //string teacherID = null;
                //if (isAddingTeacher)
                //{
                //    if (cboGV.SelectedItem == null)
                //    {
                //        MessageBox.Show("Vui lòng chọn giảng viên để thêm vào lớp.");
                //        return;
                //    }

                //    teacherID = cboGV.SelectedValue.ToString();
                //}

                // Tạo đối tượng LopHoc
                LopHoc newClass = new LopHoc
                {
                    ClassName = txtTenLH.Text.Trim(),
                    SubjectID = subjectID,
                    StartTime = startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    EndTime = endTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    Room = roomName,
                    DaysOfWeek = daysOfWeekStr,
                    TeacherID = null,
                    MaxSeats = maxSeats
                };

                // Gửi dữ liệu lên API themLop
                string jsonData = JsonConvert.SerializeObject(newClass, new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc
                });

                string urlPost = $"{_classUrl}themLop";
                bool postResult = await callAPI.PostAPI(urlPost, jsonData);

                if (postResult)
                {
                    MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lưu thông tin không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class LopHoc
    {
        public string ClassID { get; set; }
        public string SubjectID { get; set; }
        public string ClassName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Room { get; set; }
        public string DaysOfWeek { get; set; }
        public string TeacherID { get; set; }
        public int MaxSeats { get; set; }
        public string StudentCount { get; set; }
    }
}
