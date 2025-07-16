using BusinessLogic;
using Enity.Models;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmQuanLyDiem : Form
    {
        CallAPI callAPI = new CallAPI();
        private string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private string _semesterUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Semester/";
        private string _examUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Exam/";

        public frmQuanLyDiem()
        {
            InitializeComponent();
        }

        private async void frmQuanLyDiem_Shown(object sender, EventArgs e)
        {
            await LoadComBoSemester();
        }

        private async Task LoadComBoSemester()
        {
            try
            {
                //UIHelper.ShowWaitForm(this);
                string url = $"{_semesterUrl}thongTinKyHoc";
                DataTable result = await callAPI.GetAPI(url);
                cboKy.DataSource = result;
                cboKy.DisplayMember = "SemesterName";
                cboKy.ValueMember = "SemesterID";
                await LoadDataToGridView(); // Load lớp ngay sau khi có kỳ
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải kỳ học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //UIHelper.CloseWaitForm();
            }
        }

        private async Task LoadDataToGridView()
        {
            try
            {
                //UIHelper.ShowWaitForm(this);

                string semesterId = cboKy.SelectedValue?.ToString();
                string url = $"{_url}layLop";

                if (!string.IsNullOrEmpty(semesterId))
                    url += $"?semesterID={Uri.EscapeDataString(semesterId)}";

                DataTable result = await callAPI.GetAPI(url);
                gridLop.AutoGenerateColumns = false;
                gridLop.DataSource = result;

                gridLop.ClearSelection();

                if (gridLop.Rows.Count > 0)
                {
                    gridLop.Rows[0].Selected = true;
                    string classID = gridLop.Rows[0].Cells["ClassID"].Value?.ToString();
                    await LoadStudentsToGrid(classID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lớp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //UIHelper.CloseWaitForm();
            }
        }

        private async Task LoadStudentsToGrid(string classID)
        {
            try
            {
                if (string.IsNullOrEmpty(classID)) return;
                //UIHelper.ShowWaitForm(this);

                string url = $"{_url}layDanhSachSinhVienTheoLop?ClassID={classID}";
                DataTable result = await callAPI.GetAPI(url);
                gridDSHV.AutoGenerateColumns = false;
                gridDSHV.DataSource = result;

                gridDSHV.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải học viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //UIHelper.CloseWaitForm();
            }
        }

        private async Task LoadStudentScores(string studentID)
        {
            try
            {
                string classID = gridLop.SelectedRows[0].Cells["ClassID"].Value?.ToString();
                if (string.IsNullOrEmpty(classID) || string.IsNullOrEmpty(studentID)) return;

                //UIHelper.ShowWaitForm(this);
                string url = $"{_examUrl}diemHocSinhTheoLop?StudentID={studentID}&ClassID={classID}";
                DataTable result = await callAPI.GetAPI(url);

                // Reset trước
                lblTenMon.Text = lblTenLop.Text = lblKy.Text = lblMaHV.Text = lblTenHV.Text = "";
                //numDiemGiuaKy.Value = numDiemCuoiKy.Value = 0;

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    lblTenMon.Text = row["SubjectName"]?.ToString();
                    lblTenLop.Text = row["ClassName"]?.ToString();
                    lblKy.Text = row["SemesterName"]?.ToString();
                    lblMaHV.Text = row["StudentID"]?.ToString();
                    lblTenHV.Text = row["FullName"]?.ToString();

                    //if (decimal.TryParse(row["ScoreMid"]?.ToString(), out decimal mid))
                    //    numDiemGiuaKy.Value = mid;
                    if (decimal.TryParse(row["ScoreEnd"]?.ToString(), out decimal end))
                        numDiemCuoiKy.Value = end;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //UIHelper.CloseWaitForm();
            }
        }

        private async void cboKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadDataToGridView();
        }

        private async void gridLop_SelectionChanged(object sender, EventArgs e)
        {
            if (gridLop.SelectedRows.Count > 0)
            {
                var cell = gridLop.SelectedRows[0].Cells["ClassID"].Value;
                if (cell != null)
                {
                    await LoadStudentsToGrid(cell.ToString());
                }
            }
        }

        private async void gridDSHV_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDSHV.SelectedRows.Count > 0)
            {
                var cell = gridDSHV.SelectedRows[0].Cells["StudentID"].Value;
                if (cell != null)
                {
                    await LoadStudentScores(cell.ToString());
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Đang để trống xử lý
        }
    }
}
