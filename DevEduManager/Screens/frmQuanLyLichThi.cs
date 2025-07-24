using BusinessLogic;
using DevEduManager.Modals;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyLichThi : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _courseUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private readonly string _examUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Exam/";
        private readonly string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private readonly string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";

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

                    // Load môn học khi form load
                    await LoadComboBoxMonHocAsync(cboCT.SelectedValue?.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách khóa học: {ex.Message}");
            }
        }

        /// <summary>
        /// Hàm load danh sách môn học dựa vào CourseID
        /// </summary>
        private async Task LoadComboBoxMonHocAsync(string courseID)
        {
            try
            {
                if (string.IsNullOrEmpty(courseID))
                    return;

                string url = $"{_subjectUrl}layDanhSachMonHocTheoKhoaHoc?courseId={courseID}";
                DataTable dt = await callAPI.GetAPI(url);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboMH.SelectedIndexChanged -= cboMH_SelectedIndexChanged;

                    cboMH.DataSource = dt;
                    cboMH.DisplayMember = "SubjectName"; 
                    cboMH.ValueMember = "SubjectID";     
                    cboMH.SelectedIndex = 0;

                    cboMH.SelectedIndexChanged += cboMH_SelectedIndexChanged;

                    await LoadExamScheduleAsync(courseID, cboMH.SelectedValue?.ToString());
                }
                else
                {
                    cboMH.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách môn học: {ex.Message}");
            }
        }

        /// <summary>
        /// Sự kiện khi chọn khóa học khác => load lại cboMH và dtgv
        /// </summary>
        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseID = cboCT.SelectedValue?.ToString();
            await LoadComboBoxMonHocAsync(courseID);
        }

        /// <summary>
        /// Sự kiện khi chọn môn học => load lại DataGridView
        /// </summary>
        private async void cboMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseID = cboCT.SelectedValue?.ToString();
            string subjectID = cboMH.SelectedValue?.ToString();
            await LoadExamScheduleAsync(courseID, subjectID);
        }

        /// <summary>
        /// Gọi API lấy danh sách lịch thi và bind vào DataGridView
        /// </summary>
        private async Task LoadExamScheduleAsync(string courseID, string subjectID)
        {
            try
            {
                string url = $"{_examUrl}LayDanhSachLichThi";

                if (!string.IsNullOrEmpty(courseID) || !string.IsNullOrEmpty(subjectID))
                {
                    url += $"?courseID={courseID}&SubjectID={subjectID}";
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

        private async void btnThemLich_Click(object sender, EventArgs e)
        {
            frmTaoLichThi frm = new frmTaoLichThi();
            frm.ShowDialog();
            string courseID = cboCT.SelectedValue?.ToString();
            string subjectID = cboMH.SelectedValue?.ToString();
            await LoadExamScheduleAsync(courseID, subjectID);
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            //frmTaoLichThi frm = new frmTaoLichThi();
            //frm.ShowDialog();
        }
    }
}
