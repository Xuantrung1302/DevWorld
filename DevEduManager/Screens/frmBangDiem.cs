using BusinessLogic;
using Entity.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace DevEduManager.Screens
{
    public partial class frmBangDiem : Form
    {
        private readonly CallAPI callAPI = new CallAPI();
        private readonly string _url = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Score/";
        private DataTable _dtBangDiem;

        public frmBangDiem()
        {
            InitializeComponent();
            dtgvBangDiem.CellPainting += DtgvBangDiem_CellPainting;
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        private async void frmBangDiem_Load(object sender, EventArgs e)
        {
            await LoadBangDiem();
        }

        private async Task LoadBangDiem()
        {
            try
            {
                string url = $"{_url}diemTheoHocVien?StudentID={CurrentUser.UserId}";
                _dtBangDiem = await callAPI.GetAPI(url);

                dtgvBangDiem.Rows.Clear();

                if (_dtBangDiem != null && _dtBangDiem.Rows.Count > 0)
                {
                    string lastCourseName = "";
                    foreach (DataRow row in _dtBangDiem.Rows)
                    {
                        string courseName = row["CourseName"].ToString();
                        string courseId = row["CourseID"].ToString();
                        string subjectId = row["SubjectID"].ToString();
                        string subjectName = row["SubjectName"].ToString();

                        double? score = null;
                        if (double.TryParse(row["Score"].ToString(), out double s))
                            score = s;

                        string status = "";
                        if (score.HasValue)
                            status = score.Value >= 5 ? "Đạt" : "Chưa đạt";

                        string displayCourseName = courseName == lastCourseName ? "" : courseName;
                        lastCourseName = courseName;

                        dtgvBangDiem.Rows.Add(courseId, displayCourseName, subjectId, subjectName,
                                              score?.ToString("0.00") ?? "", status);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu bảng điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bảng điểm: " + ex.Message);
            }
        }


        /// <summary>
        /// Xóa đường kẻ ở ô bị để trống (CourseName)
        /// </summary>
        private void DtgvBangDiem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) // Cột CourseName
            {
                string value = e.FormattedValue?.ToString();
                if (string.IsNullOrEmpty(value))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
                }
            }
        }

        /// <summary>
        /// Xuất Excel
        /// </summary>
        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Bảng điểm");

                    // Header
                    ws.Cell(1, 1).Value = "BẢNG ĐIỂM HỌC VIÊN";
                    ws.Range(1, 1, 1, 6).Merge().Style
                        .Font.SetBold().Font.SetFontSize(16)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Tiêu đề cột
                    //ws.Cell(3, 1).Value = "Mã khóa";
                    ws.Cell(3, 2).Value = "Chương trình";
                    //ws.Cell(3, 3).Value = "Mã môn";
                    ws.Cell(3, 4).Value = "Tên môn";
                    ws.Cell(3, 5).Value = "Điểm";
                    ws.Cell(3, 6).Value = "Trạng thái";
                    ws.Range(3, 1, 3, 6).Style
                        .Font.SetBold()
                        .Fill.SetBackgroundColor(XLColor.SteelBlue)
                        .Font.SetFontColor(XLColor.White)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    int row = 4;
                    string lastCourseName = "";

                    foreach (DataRow dr in _dtBangDiem.Rows)
                    {
                        string courseName = dr["CourseName"].ToString();
                        string displayCourseName = courseName == lastCourseName ? "" : courseName;
                        lastCourseName = courseName;

                        //ws.Cell(row, 1).Value = dr["CourseID"].ToString();
                        ws.Cell(row, 2).Value = displayCourseName;
                        //ws.Cell(row, 3).Value = dr["SubjectID"].ToString();
                        ws.Cell(row, 4).Value = dr["SubjectName"].ToString();
                        ws.Cell(row, 5).Value = dr["Score"].ToString();
                        ws.Cell(row, 6).Value = dr["Score"] != DBNull.Value && double.Parse(dr["Score"].ToString()) >= 5 ? "Đạt" : "Chưa đạt";

                        row++;
                    }

                    ws.Columns().AdjustToContents();

                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Lưu bảng điểm"
                    };

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }

    }
}
