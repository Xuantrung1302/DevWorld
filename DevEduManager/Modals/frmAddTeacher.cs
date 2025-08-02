using BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmAddTeacher : Form
    {
        private CallAPI callAPI = new CallAPI();
        private string _courseId;
        private string _classId;
        private readonly string _classIDs = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";

        public frmAddTeacher(string courseId, string classId, string programName, string className)
        {
            InitializeComponent();
            _courseId = courseId;
            _classId = classId;
            txtProgramName.Text = programName;
            txtClassName.Text = className;
            
        }

        private async void frmAddTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                string url = $"{_classIDs}layGiangVienChoLop?ClassID={_classId}";
                DataTable result = await callAPI.GetAPI(url);
                gridTeachers.AutoGenerateColumns = false;
                gridTeachers.DataSource = result;
                gridTeachers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách giảng viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (gridTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacherId = gridTeachers.SelectedRows[0].Cells["TeacherID"].Value?.ToString();
            try
            {
                // Gọi API để thêm giảng viên vào lớp
                string addTeacherUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/themGiangVienVaoLop?classId={_classId}&teacherId={teacherId}";
                bool result = await callAPI.PostAPI(addTeacherUrl, null); // Giả sử API không cần body

                if (result)
                {
                    // Gọi API tự sinh lịch
                    string generateScheduleUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/taoLichHoc?classId={_classId}";
                    bool scheduleResult = await callAPI.PostAPI(generateScheduleUrl, null);

                    if (scheduleResult)
                    {
                        MessageBox.Show("Thêm giảng viên và tạo lịch thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sinh lịch thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm giảng viên hoặc sinh lịch: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}