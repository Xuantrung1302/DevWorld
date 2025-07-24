using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace DevEduManager.Screens
{
    public partial class frmBangDiem : Form
    {
        private List<(string ChuongTrinh, string MonHoc, double? Diem)> dsBangDiem;

        public frmBangDiem()
        {
            InitializeComponent();
            LoadBangDiemMau();
            dtgvBangDiem.CellPainting += DgvBangDiem_CellPainting;
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        private void LoadBangDiemMau()
        {
            dsBangDiem = new List<(string, string, double?)>
            {
                // Java
                ("Chương trình Java", "Lập trình Java Cơ bản", 8.5),
                ("Chương trình Java", "Cấu trúc dữ liệu", 7.5),
                ("Chương trình Java", "Spring Boot", 9.0),
                ("Chương trình Java", "Hibernate", null),

                // C#
                ("Chương trình C#", "C# Cơ bản", 8.0),
                ("Chương trình C#", "WinForms", 4.5),
                ("Chương trình C#", "Entity Framework", 8.8),
                ("Chương trình C#", "ASP.NET Core", 9.2),

                // Web Frontend
                ("Chương trình Web Frontend", "HTML & CSS", 9.0),
                ("Chương trình Web Frontend", "JavaScript", 8.5),
                ("Chương trình Web Frontend", "ReactJS", 8.8),
                ("Chương trình Web Frontend", "TypeScript", 8.7),

                // Python
                ("Chương trình Python", "Python Cơ bản", 8.9),
                ("Chương trình Python", "Django", 9.0),
                ("Chương trình Python", "Flask", 8.3),
                ("Chương trình Python", "Machine Learning", null)
            };

            dtgvBangDiem.Rows.Clear();

            foreach (var item in dsBangDiem)
            {
                string trangThai = "";
                if (item.Diem.HasValue)
                {
                    if (item.Diem.Value >= 5) trangThai = "Đạt";
                    else trangThai = "Chưa đạt";
                }

                dtgvBangDiem.Rows.Add(item.ChuongTrinh, item.MonHoc, item.Diem?.ToString() ?? "", trangThai);
            }

            // Xóa giá trị trùng ở cột Chương trình
            for (int i = 1; i < dtgvBangDiem.Rows.Count; i++)
            {
                if (dtgvBangDiem.Rows[i].Cells[0].Value?.ToString() ==
                    dtgvBangDiem.Rows[i - 1].Cells[0].Value?.ToString())
                {
                    dtgvBangDiem.Rows[i].Cells[0].Value = "";
                }
            }

            // Thêm dòng tổng kết
            var chuongTrinhGroups = dsBangDiem.GroupBy(x => x.ChuongTrinh);
            foreach (var group in chuongTrinhGroups)
            {
                double avg = group.Where(x => x.Diem.HasValue).Average(x => x.Diem.Value);
                dtgvBangDiem.Rows.Add($"→ Trung bình ({group.Key})", "", avg.ToString("0.00"), "");
            }
        }

        private void DgvBangDiem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                string value = e.FormattedValue?.ToString();
                if (string.IsNullOrEmpty(value) || value.StartsWith("→"))
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                }
                else
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
                }
            }
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Bảng điểm");

                // Header
                ws.Cell(1, 1).Value = "BẢNG ĐIỂM HỌC VIÊN";
                ws.Range(1, 1, 1, 4).Merge().Style
                    .Font.SetBold().Font.SetFontSize(16)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                // Tiêu đề cột
                ws.Cell(3, 1).Value = "Chương trình";
                ws.Cell(3, 2).Value = "Môn học";
                ws.Cell(3, 3).Value = "Điểm";
                ws.Cell(3, 4).Value = "Trạng thái";
                ws.Range(3, 1, 3, 4).Style
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.SteelBlue)
                    .Font.SetFontColor(XLColor.White)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                int row = 4;
                var groups = dsBangDiem.GroupBy(x => x.ChuongTrinh);
                foreach (var group in groups)
                {
                    int startRow = row;
                    foreach (var item in group)
                    {
                        ws.Cell(row, 1).Value = item.ChuongTrinh;
                        ws.Cell(row, 2).Value = item.MonHoc;
                        ws.Cell(row, 3).Value = item.Diem.HasValue ? item.Diem.Value.ToString("0.00") : "";
                        ws.Cell(row, 4).Value = item.Diem.HasValue ? (item.Diem >= 5 ? "Đạt" : "Chưa đạt") : "";
                        row++;
                    }
                    ws.Range(startRow, 1, row - 1, 1).Merge().Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    double avg = group.Where(x => x.Diem.HasValue).Average(x => x.Diem.Value);
                    ws.Cell(row, 1).Value = $"→ Trung bình ({group.Key})";
                    ws.Cell(row, 3).Value = avg.ToString("0.00");
                    ws.Row(row).Style.Font.SetItalic();
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
    }
}
