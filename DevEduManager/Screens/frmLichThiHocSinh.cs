using BusinessLogic;
using Entity.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmLichThiHocSinh : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _examUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Exam/";
        private readonly string _courseUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";

        private readonly string _studentID = CurrentUser.UserId;

        public frmLichThiHocSinh()
        {
            InitializeComponent();
        }

        private async void frmLichThiHocSinh_Load(object sender, EventArgs e)
        {
            await LoadCourses();
            cboCT.SelectedIndexChanged += CboCT_SelectedIndexChanged;
        }

        /// <summary>
        /// Load danh sách chương trình học của học viên
        /// </summary>
        private async Task LoadCourses()
        {
            try
            {
                string url = $"{_courseUrl}layKhoaHocTheoHocVienForLichThi?studentID={_studentID}";
                DataTable result = await callAPI.GetAPI(url);

                if (result != null && result.Rows.Count > 0)
                {
                    cboCT.DataSource = result;
                    cboCT.DisplayMember = "course_name";
                    cboCT.ValueMember = "course_id";
                }
                else
                {
                    cboCT.DataSource = null;
                    MessageBox.Show("Không có dữ liệu chương trình học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khóa học: " + ex.Message);
            }
        }

        /// <summary>
        /// Khi chọn 1 chương trình học => load lịch thi
        /// </summary>
        private async void CboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCT.SelectedValue != null)
            {
                string courseID = cboCT.SelectedValue.ToString();
                await LoadExamSchedule(courseID);
            }
        }

        /// <summary>
        /// Load lịch thi từ API theo CourseID
        /// </summary>
        private async Task LoadExamSchedule(string courseID)
        {
            try
            {
                string url = $"{_examUrl}layDanhSachLichThi?courseID={courseID}";
                DataTable result = await callAPI.GetAPI(url);

                dtgvLichThi.DataSource = null;

                if (result != null && result.Rows.Count > 0)
                {
                    //foreach (DataRow row in result.Rows)
                    //{
                    //    dtgvLichThi.Rows.Add(
                    //        row["ClassName"].ToString(),
                    //        row["SubjectName"].ToString(),
                    //        row["ExamName"].ToString(),
                    //        row["ExamType"].ToString(),
                    //        Convert.ToDateTime(row["ExamDateStart"]).ToString("dd/MM/yyyy HH:mm"),
                    //        Convert.ToDateTime(row["ExamDateEnd"]).ToString("dd/MM/yyyy HH:mm"),
                    //        row["Room"].ToString()
                    //    );
                    //}
                    dtgvLichThi.AutoGenerateColumns = false;
                    dtgvLichThi.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Không có lịch thi cho khóa học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch thi: " + ex.Message);
            }
        }
    }
}
