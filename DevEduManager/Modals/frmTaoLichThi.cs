using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entity.Models;

namespace DevEduManager.Modals
{
    public partial class frmTaoLichThi : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _courseUrl = $"{System.Configuration.ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private readonly string _classUrl = $"{System.Configuration.ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private readonly string _subjectUrl = $"{System.Configuration.ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private readonly string _roomUrl = $"{System.Configuration.ConfigurationManager.AppSettings["HOST_API_URL"]}api/Room/";
        private readonly string _examUrl = $"{System.Configuration.ConfigurationManager.AppSettings["HOST_API_URL"]}api/Exam/";

        public frmTaoLichThi()
        {
            InitializeComponent();
            Load += frmTaoLichThi_Load;
        }

        private async void frmTaoLichThi_Load(object sender, EventArgs e)
        {
            txtKyThi.Text = ""; // Cho người dùng nhập
            LoadCaThi();
            await LoadPhongThiAsync();
            await LoadChuongTrinhHocAsync();
        }

        /// <summary>
        /// Chỉ load danh sách Chương trình học khi mở form
        /// </summary>
        private async Task LoadChuongTrinhHocAsync()
        {
            var dt = await callAPI.GetAPI($"{_courseUrl}danhSachKhoaHoc");
            if (dt != null && dt.Rows.Count > 0)
            {
                cboCT.DataSource = dt;
                cboCT.DisplayMember = "CourseName";
                cboCT.ValueMember = "CourseID";

                // Gắn sự kiện khi người dùng chọn CT
                cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;
            }
        }

        /// <summary>
        /// Khi chọn Chương trình học => Load Lớp học
        /// </summary>
        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCT.SelectedValue != null)
            {
                string courseId = cboCT.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(courseId))
                {
                    await LoadLopHocAsync(courseId);
                }
            }
        }

        private async Task LoadLopHocAsync(string courseId)
        {
            var dt = await callAPI.GetAPI($"{_classUrl}layLop?CourseID={courseId}");
            cboLH.DataSource = null;
            cboMH.DataSource = null; // Reset môn học khi đổi lớp

            if (dt != null && dt.Rows.Count > 0)
            {
                cboLH.DataSource = dt;
                cboLH.DisplayMember = "ClassName";
                cboLH.ValueMember = "ClassID";

                // Gắn sự kiện khi người dùng chọn Lớp
                cboLH.SelectedIndexChanged -= cboLH_SelectedIndexChanged;
                cboLH.SelectedIndexChanged += cboLH_SelectedIndexChanged;
            }
        }

        /// <summary>
        /// Khi chọn Lớp => Load Môn học
        /// </summary>
        private async void cboLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLH.SelectedValue != null)
            {
                string classId = cboLH.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(classId))
                {
                    await LoadMonHocAsync(classId);
                }
            }
        }

        private async Task LoadMonHocAsync(string classId)
        {
            var dt = await callAPI.GetAPI($"{_subjectUrl}thongTinMonHoc?ClassID={classId}");
            cboMH.DataSource = null;

            if (dt != null && dt.Rows.Count > 0)
            {
                cboMH.DataSource = dt;
                cboMH.DisplayMember = "SubjectName";
                cboMH.ValueMember = "SubjectID";

                // Gắn sự kiện khi chọn môn học
                cboMH.SelectedIndexChanged -= cboMH_SelectedIndexChanged;
                cboMH.SelectedIndexChanged += cboMH_SelectedIndexChanged;
            }
        }

        /// <summary>
        /// Khi chọn Môn => Load ngày kết thúc
        /// </summary>
        private async void cboMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMH.SelectedValue != null)
            {
                string subjectId = cboMH.SelectedValue.ToString();
                string classId = cboLH.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(subjectId))
                {
                    await LoadNgayKetThucMonHoc(classId, subjectId);
                }
            }
        }

        private async Task LoadNgayKetThucMonHoc(string classId, string subjectId)
        {
            try
            {
                var dt = await callAPI.GetAPI($"{_subjectUrl}layNgayCuoiCungCuaMon?ClassID={classId}&SubjectID={subjectId}");
                if (dt != null && dt.Rows.Count > 0)
                {
                    DateTime endDate = Convert.ToDateTime(dt.Rows[0]["EndTime"]);
                    lblTB.Text = $"*Ngày kết thúc môn học: {endDate:dd/MM/yyyy}";
                }
                else
                {
                    lblTB.Text = "";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadCaThi()
        {
            cboTime.Items.Clear();
            cboTime.Items.AddRange(new string[]
            {
                "08:00 - 09:30",
                "09:30 - 11:00",
                "13:00 - 14:30",
                "14:30 - 16:00",
                "16:00 - 17:30"
            });
        }

        private async Task LoadPhongThiAsync()
        {
            var dt = await callAPI.GetAPI($"{_roomUrl}layLop");
            if (dt != null && dt.Rows.Count > 0)
            {
                cboRoom.DataSource = dt;
                cboRoom.DisplayMember = "Room";
                cboRoom.ValueMember = "RoomID";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Tạo lịch thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Gọi API tạo lịch thi
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtKyThi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboCT.SelectedItem == null || cboLH.SelectedItem == null || cboMH.SelectedItem == null || cboTime.SelectedItem == null || cboRoom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {

                // Lấy ngày kết thúc môn học từ lblTB (nếu có)
                if (!string.IsNullOrWhiteSpace(lblTB.Text))
                {
                    // lblTB.Text dạng: "*Ngày kết thúc môn học: dd/MM/yyyy"
                    string dateText = lblTB.Text.Replace("*Ngày kết thúc môn học:", "").Trim();
                    if (DateTime.TryParseExact(dateText, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime endDate))
                    {
                        if (dtpkNgayThi.Value.Date <= endDate.Date)
                        {
                            MessageBox.Show(
                                $"Ngày thi phải sau ngày kết thúc môn học ({endDate:dd/MM/yyyy})!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return; // Dừng lưu
                        }
                    }
                }
                int selectedIndex = cboTime.SelectedIndex;
                if (selectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn ca thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse giờ bắt đầu từ ca hiện tại
                string[] currentRange = cboTime.Items[selectedIndex].ToString().Split('-');
                TimeSpan startTime = TimeSpan.Parse(currentRange[0].Trim()); // Ví dụ: 08:00

                // Xác định giờ kết thúc
                TimeSpan endTime;
                if (selectedIndex + 1 < cboTime.Items.Count)
                {
                    // Lấy giờ bắt đầu của ca tiếp theo
                    string[] nextRange = cboTime.Items[selectedIndex + 1].ToString().Split('-');
                    endTime = TimeSpan.Parse(nextRange[0].Trim()); // Ví dụ: 09:30
                }
                else
                {
                    // Nếu là ca cuối, lấy giờ kết thúc trong ca hiện tại
                    endTime = TimeSpan.Parse(currentRange[1].Trim()); // Ví dụ: 17:30
                }

                // Lấy ngày từ DateTimePicker
                DateTime examDate = dtpkNgayThi.Value.Date;
                DateTime examDateStart = examDate.Add(startTime);
                DateTime examDateEnd = examDate.Add(endTime);

                var lichThi = new
                {
                    ClassID = Guid.Parse(cboLH.SelectedValue.ToString()),
                    SubjectID = cboMH.SelectedValue.ToString(),
                    ExamName = txtKyThi.Text.Trim(),
                    ExamType = "Kết thúc môn",
                    ExamDateStart = examDateStart,
                    ExamDateEnd = examDateEnd,
                    Room = cboRoom.Text,
                    CreatedBy = CurrentUser.UserId,
                    CreatedDate = DateTime.Now
                };

                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(lichThi);

                bool result = await callAPI.PostAPI($"{_examUrl}themLichThi", jsonData);

                if (result)
                {
                    MessageBox.Show("Thêm lịch thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm lịch thi. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
