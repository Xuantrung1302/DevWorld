using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using ClosedXML.Excel;

namespace DevEduManager.Screens
{
    public partial class frmTaoThoiKhoaBieu : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _courseUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Course/";
        private readonly string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";
        private readonly string _scheduleUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Schedule/";

        public frmTaoThoiKhoaBieu()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.Load += frmTaoThoiKhoaBieu_Load;
            cboCT.SelectedIndexChanged += cboCT_SelectedIndexChanged;
            cboLH.SelectedIndexChanged += cboLH_SelectedIndexChanged;
            btnExportExcel.Click += btnExportExcel_Click;
        }

        private async void frmTaoThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            await LoadComboBoxCourseAsync();
        }

        private void InitializeDataGridView()
        {
            dtgvLich.AllowUserToAddRows = false;
            dtgvLich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLich.RowHeadersVisible = false;

            if (dtgvLich.Columns.Count == 0)
            {
                dtgvLich.Columns.Add("ClassName", "Tên lớp");
                dtgvLich.Columns.Add("Session", "Ca học");
                dtgvLich.Columns.Add("DayOfWeek", "Thứ");
                dtgvLich.Columns.Add("StudyDate", "Ngày học");
                dtgvLich.Columns.Add("Room", "Phòng");
                dtgvLich.Columns.Add("TeacherName", "Tên GV");
            }

            dtgvLich.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            dtgvLich.CellClick += DtgvLich_CellClick;
        }

        private async Task LoadComboBoxCourseAsync()
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

                await LoadComboBoxClassAsync(cboCT.SelectedValue?.ToString());
            }
        }

        private async void cboCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCT.SelectedValue != null)
                await LoadComboBoxClassAsync(cboCT.SelectedValue.ToString());
        }

        private async Task LoadComboBoxClassAsync(string courseId)
        {
            string url = $"{_courseUrl}danhSachLopTrongKhoaHoc?CourseID={courseId}";
            DataTable dt = await callAPI.GetAPI(url);
            if (dt != null && dt.Rows.Count > 0)
            {
                cboLH.SelectedIndexChanged -= cboLH_SelectedIndexChanged;

                cboLH.DataSource = dt;
                cboLH.DisplayMember = "ClassName";
                cboLH.ValueMember = "ClassID";
                cboLH.SelectedIndex = 0;

                cboLH.SelectedIndexChanged += cboLH_SelectedIndexChanged;

                await LoadScheduleDataAsync(courseId, cboLH.SelectedValue.ToString());
            }
        }

        private async void cboLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCT.SelectedValue != null && cboLH.SelectedValue != null)
            {
                await LoadScheduleDataAsync(cboCT.SelectedValue.ToString(), cboLH.SelectedValue.ToString());
            }
        }

        private async Task LoadScheduleDataAsync(string courseId, string classId)
        {
            try
            {
                string url = $"{_classUrl}layDanhSachLichHoc?CourseID={courseId}&ClassID={classId}";
                DataTable dt = await callAPI.GetAPI(url);

                dtgvLich.Rows.Clear();

                if (dt == null || dt.Rows.Count == 0) return;

                var grouped = dt.AsEnumerable().GroupBy(r => r.Field<string>("SubjectName"));

                foreach (var subjectGroup in grouped)
                {
                    // Header môn học
                    int headerIndex = dtgvLich.Rows.Add();
                    DataGridViewRow headerRow = dtgvLich.Rows[headerIndex];
                    headerRow.Cells[0].Value = subjectGroup.Key;
                    headerRow.DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        Font = new Font("Arial", 11, FontStyle.Bold),
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                    headerRow.Height = 32;
                    for (int i = 1; i < dtgvLich.Columns.Count; i++)
                        headerRow.Cells[i].Value = "";

                    // Các dòng dữ liệu
                    foreach (var row in subjectGroup)
                    {
                        int rowIndex = dtgvLich.Rows.Add(
                            row["ClassName"].ToString(),
                            $"{Convert.ToDateTime(row["StartTime"]).ToString("HH:mm")}-{Convert.ToDateTime(row["EndTime"]).ToString("HH:mm")}",
                            row["DayOfWeek"].ToString(),
                            Convert.ToDateTime(row["StartTime"]).ToString("dd/MM/yyyy"),
                            "P101", // Có thể thay bằng field nếu có
                            row["FullName"].ToString()
                        );

                        var dataRow = dtgvLich.Rows[rowIndex];
                        dataRow.DefaultCellStyle.BackColor = Convert.ToDateTime(row["StartTime"]).Hour < 12
                            ? Color.LightYellow : Color.LightCyan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải lịch học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgvLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvLich.Rows[e.RowIndex].Cells[0].Style.Font?.Bold != true)
            {
                var row = dtgvLich.Rows[e.RowIndex];
                string info = $"Tên lớp: {row.Cells["ClassName"].Value}\n" +
                              $"Ca học: {row.Cells["Session"].Value}\n" +
                              $"Thứ: {row.Cells["DayOfWeek"].Value}\n" +
                              $"Ngày học: {row.Cells["StudyDate"].Value}\n" +
                              $"Phòng: {row.Cells["Room"].Value}\n" +
                              $"Giảng viên: {row.Cells["TeacherName"].Value}";
                MessageBox.Show(info, "Thông tin chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvLich.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "ThoiKhoaBieu.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var ws = workbook.Worksheets.Add("Lịch học");
                            int currentRow = 1;

                            ws.Cell(currentRow, 1).Value = "THỜI KHÓA BIỂU LỚP";
                            ws.Range(currentRow, 1, currentRow, 6).Merge().Style
                                .Font.SetBold().Font.FontSize = 16;
                            ws.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            currentRow += 2;

                            string[] headers = { "Tên lớp", "Ca học", "Thứ", "Ngày học", "Phòng", "Tên GV" };
                            for (int i = 0; i < headers.Length; i++)
                            {
                                ws.Cell(currentRow, i + 1).Value = headers[i];
                                ws.Cell(currentRow, i + 1).Style.Fill.BackgroundColor = XLColor.DarkBlue;
                                ws.Cell(currentRow, i + 1).Style.Font.FontColor = XLColor.White;
                                ws.Cell(currentRow, i + 1).Style.Font.SetBold();
                                ws.Cell(currentRow, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }
                            currentRow++;

                            foreach (DataGridViewRow row in dtgvLich.Rows)
                            {
                                if (row.Cells[0].Style.Font?.Bold == true)
                                {
                                    ws.Cell(currentRow, 1).Value = (XLCellValue)row.Cells[0].Value;
                                    ws.Range(currentRow, 1, currentRow, 6).Merge();
                                    ws.Range(currentRow, 1, currentRow, 6).Style
                                        .Fill.SetBackgroundColor(XLColor.SteelBlue)
                                        .Font.SetBold()
                                        .Font.SetFontColor(XLColor.White)
                                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                                    currentRow++;
                                }
                                else
                                {
                                    for (int col = 0; col < 6; col++)
                                        ws.Cell(currentRow, col + 1).Value = row.Cells[col].Value?.ToString();

                                    if (row.DefaultCellStyle.BackColor == Color.LightYellow)
                                        ws.Range(currentRow, 1, currentRow, 6).Style.Fill.BackgroundColor = XLColor.LightYellow;
                                    else if (row.DefaultCellStyle.BackColor == Color.LightCyan)
                                        ws.Range(currentRow, 1, currentRow, 6).Style.Fill.BackgroundColor = XLColor.LightCyan;

                                    currentRow++;
                                }
                            }

                            ws.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
