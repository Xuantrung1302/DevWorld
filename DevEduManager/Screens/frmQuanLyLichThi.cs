using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyLichThi : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _courseUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private readonly string _examUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Exam/";

        public frmQuanLyLichThi()
        {
            InitializeComponent();
        }

        private async void frmQuanLyLichThi_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }

        /// <summary>
        /// Load danh sách khóa học vào comboBox cboCT
        /// </summary>
        private async Task LoadComboBoxCourseAsync()
        {
            try
            {
                string url = $"{_courseUrl}danhSachKhoaHoc";
                DataTable dt = await callAPI.GetAPI(url);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboCT.SelectedIndexChanged -= cboCT_SelectedIndexChanged;

                    cboCT.DataSource = dt;
                    cboCT.DisplayMember = "CourseName";
                    cboCT.ValueMember = "CourseID";
                    cboCT.SelectedIndex = 0;

                    cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;

                    // Load DataGridView với CourseID đầu tiên
                    await LoadExamScheduleAsync(cboCT.SelectedValue?.ToString(), null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách khóa học: {ex.Message}");
            }
        }

        /// <summary>
        /// Sự kiện khi chọn khóa học khác => load lại lịch thi
        /// </summary>
        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseID = cboCT.SelectedValue?.ToString();
            await LoadExamScheduleAsync(courseID, txtTenMon.Text.Trim());
        }

        /// <summary>
        /// Sự kiện click nút tìm kiếm
        /// </summary>
        private async void btnTK_Click(object sender, EventArgs e)
        {
            string courseID = cboCT.SelectedValue?.ToString();
            string subjectName = txtTenMon.Text.Trim();
            await LoadExamScheduleAsync(courseID, subjectName);
        }

        /// <summary>
        /// Gọi API lấy danh sách lịch thi và bind vào DataGridView
        /// </summary>
        private async Task LoadExamScheduleAsync(string courseID, string subjectName)
        {
            try
            {
                string url = $"{_examUrl}LayDanhSachLichThi";

                // Nếu có tham số => thêm query string
                if (!string.IsNullOrEmpty(courseID) || !string.IsNullOrEmpty(subjectName))
                {
                    url += $"?courseID={courseID}&subjectName={subjectName}";
                }

                DataTable dt = await callAPI.GetAPI(url);
                if (dt != null)
                {
                    dtgvLichThi.AutoGenerateColumns = false;
                    dtgvLichThi.DataSource = dt;

                }
                else
                {
                    dtgvLichThi.AutoGenerateColumns = false;
                    dtgvLichThi.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load lịch thi: {ex.Message}");
            }
        }

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            frmTaoLichThi frm = new frmTaoLichThi();
            frm.ShowDialog();

        }
    }
}
