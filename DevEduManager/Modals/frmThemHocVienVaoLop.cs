using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;
using Newtonsoft.Json;

namespace DevEduManager.Modals
{
    public partial class frmThemHocVienVaoLop : Form
    {
        private CallAPI callAPI = new CallAPI();
        private string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private string classID;
        private string _semesterName;
        private string _className;

        private CheckBox chkAll = new CheckBox(); // Check All trên header

        public frmThemHocVienVaoLop(string classId, string semesterName, string className)
        {
            InitializeComponent();
            classID = classId;
            _semesterName = semesterName;
            _className = className;
        }

        private void frmThemHocVienVaoLop_Load(object sender, EventArgs e)
        {
            txtKyHoc.Text = _semesterName;
            txtClass.Text = _className;
            LoadDataToGridView(classID);
        }

        private async void LoadDataToGridView(string classID)
        {
            try
            {
                string url = $"{_classUrl}layDanhSachHVDuocThemVaoLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
                gridListStudent.DataSource = result;

                gridListStudent.AllowUserToAddRows = false;
                gridListStudent.RowHeadersVisible = false;
                gridListStudent.ScrollBars = ScrollBars.Vertical;

                AddCheckAllHeader(); // thêm check all sau khi load dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void AddCheckAllHeader()
        {
            gridListStudent.Controls.Remove(chkAll);

            Rectangle rect = gridListStudent.GetCellDisplayRectangle(0, -1, true);
            chkAll.Size = new Size(18, 18);
            chkAll.Location = new Point(
                rect.X + (rect.Width - chkAll.Width) / 2,
                rect.Y + (rect.Height - chkAll.Height) / 2
            );
            chkAll.BackColor = Color.Transparent;
            chkAll.Checked = false;

            chkAll.CheckedChanged -= ChkAll_CheckedChanged;
            chkAll.CheckedChanged += ChkAll_CheckedChanged;

            gridListStudent.Controls.Add(chkAll);
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridListStudent.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = chkAll.Checked;
                }
            }
        }
        private async void FrmThemHocVienVaoLop_Shown(object sender, EventArgs e)
        {
            try
            {
                string url = $"{_classUrl}laySoLuongHienTaiVaThieuCuaLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
                if (result != null && result.Rows.Count > 0)
                {
                    lblStuCur.Text = result.Rows[0]["CurrentCount"].ToString();
                    lblAddStu.Text = result.Rows[0]["RemainingSeats"].ToString();
                }
                else
                {
                    lblStuCur.Text = "0";
                    lblAddStu.Text = "0";
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        private async void frmThemHocVienVaoLop_Shown(object sender, EventArgs e)
        {
            try
            {
                string url = $"{_classUrl}laySoLuongHienTaiVaThieuCuaLop?classID={classID}";
                DataTable result = await callAPI.GetAPI(url);
                if (result != null && result.Rows.Count > 0)
                {
                    lblStuCur.Text = result.Rows[0]["CurrentCount"].ToString();
                    lblAddStu.Text = result.Rows[0]["RemainingSeats"].ToString();
                }
                else
                {
                    lblStuCur.Text = "0";
                    lblAddStu.Text = "0";
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;

                foreach (DataGridViewRow row in gridListStudent.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) != true)
                        continue;

                    string studentID = row.Cells["StudentID"].Value?.ToString();
                    if (string.IsNullOrEmpty(studentID))
                        continue;

                    // Tạo object dữ liệu
                    var dangKy = new
                    {
                        StudentID = studentID,
                        ClassID = classID,
                        EnrollmentDate = now,
                        ApprovedBy = (string)null,
                        ApprovalDate = now,
                        CompletionStatus = "Đang học",
                        CompletionDate = (DateTime?)null
                    };

                    // Chuyển sang JSON string
                    string json = JsonConvert.SerializeObject(dangKy);

                    // Gọi API
                    string url = $"{_classUrl}themSinhVienVaoLop";
                    bool inserted = await callAPI.PostAPI(url, json);

                    if (!inserted)
                    {
                        MessageBox.Show($"Không thể thêm học viên {studentID} vào lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Thêm học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
