using BusinessLogic;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class frmNhapDiemMoi : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _courseUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private readonly string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private readonly string _subjectUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Subject/";
        private readonly string _studentUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Student/";
        private readonly string _examUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Exam/";

        public frmNhapDiemMoi()
        {
            InitializeComponent();
        }

        private async void frmNhapDiemMoi_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }

        private async Task LoadComboBoxCourseAsync()
        {
            try
            {
                string url = $"{_courseUrl}danhSachKhoaHoc";
                DataTable dt = await callAPI.GetAPI(url);

                cboCT.SelectedIndexChanged -= cboCT_SelectedIndexChanged;
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboCT.DataSource = dt;
                    cboCT.DisplayMember = "CourseName";
                    cboCT.ValueMember = "CourseID";
                    cboCT.SelectedIndex = -1;
                }
                cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load khóa học: {ex.Message}");
            }
        }

        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCT.SelectedValue == null) return;
            string courseID = cboCT.SelectedValue.ToString();
            await LoadComboBoxClassAsync(courseID);
            cboMH.DataSource = null;
            dgvNhapDiem.Rows.Clear();
        }

        private async Task LoadComboBoxClassAsync(string courseID)
        {
            try
            {
                string url = $"{_courseUrl}danhSachLopTrongKhoaHoc?CourseID={courseID}";
                DataTable dt = await callAPI.GetAPI(url);

                cboLH.SelectedIndexChanged -= cboLH_SelectedIndexChanged;
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboLH.DataSource = dt;
                    cboLH.DisplayMember = "ClassName";
                    cboLH.ValueMember = "ClassID";
                    cboLH.SelectedIndex = -1;
                }
                cboLH.SelectedIndexChanged += cboLH_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load lớp: {ex.Message}");
            }
        }

        private async void cboLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLH.SelectedValue == null) return;
            string classID = cboLH.SelectedValue.ToString();
            await LoadComboBoxMonHocAsync(classID);
            dgvNhapDiem.Rows.Clear();
        }

        private async Task LoadComboBoxMonHocAsync(string classID)
        {
            try
            {
                string url = $"{_subjectUrl}layDanhSachMonHocTheoLopHoc?ClassID={classID}";
                DataTable dt = await callAPI.GetAPI(url);

                cboMH.SelectedIndexChanged -= cboMH_SelectedIndexChanged;
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboMH.DataSource = dt;
                    cboMH.DisplayMember = "SubjectName";
                    cboMH.ValueMember = "SubjectID";
                    cboMH.SelectedIndex = -1;
                }
                cboMH.SelectedIndexChanged += cboMH_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load môn học: {ex.Message}");
            }
        }

        private async void cboMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMH.SelectedValue == null) return;
            string classID = cboLH.SelectedValue?.ToString();
            string subjectID = cboMH.SelectedValue?.ToString();
            await LoadStudentAndScoreAsync(classID, subjectID);
        }

        /// <summary>
        /// Lấy danh sách học viên theo lớp + Điểm theo môn và hiển thị lên DataGridView
        /// </summary>
        private async Task LoadStudentAndScoreAsync(string classID, string subjectID)
        {
            try
            {
                // 1. Gọi API lấy danh sách học viên theo lớp
                string studentUrl = $"{_classUrl}layDanhSachSinhVienTheoLop?classID={classID}&subjectID={subjectID}";
                DataTable dtStudents = await callAPI.GetAPI(studentUrl);

                // 2. Gọi API lấy điểm theo lớp và môn
                string scoreUrl = $"{_examUrl}layDanhSachKetQua?ClassID={classID}&SubjectID={subjectID}";
                DataTable dtScores = await callAPI.GetAPI(scoreUrl);

                // 3. Chuẩn bị DataTable để hiển thị
                DataTable dtFinal = new DataTable();
                dtFinal.Columns.Add("StudentID");
                dtFinal.Columns.Add("FullName");
                dtFinal.Columns.Add("Score");

                if (dtStudents != null && dtStudents.Rows.Count > 0)
                {
                    foreach (DataRow student in dtStudents.Rows)
                    {
                        string studentID = student["StudentID"].ToString();
                        string fullName = student["FullName"].ToString();
                        string score = "";

                        // Tìm điểm của học viên trong dtScores
                        if (dtScores != null && dtScores.Rows.Count > 0)
                        {
                            var rowScore = dtScores.AsEnumerable()
                                .FirstOrDefault(r => r["StudentID"].ToString() == studentID);

                            if (rowScore != null)
                            {
                                score = rowScore["Score"].ToString();
                            }
                        }

                        dtFinal.Rows.Add(studentID, fullName, score);
                    }
                }

                // 4. Bind vào DataGridView
                dgvNhapDiem.AutoGenerateColumns = false;
                dgvNhapDiem.DataSource = dtFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load danh sách học viên & điểm: {ex.Message}");
            }
        }

    }
}
