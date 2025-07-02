using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmBaoCaoDiemDanhGiaoVien : Form
    {
        public frmBaoCaoDiemDanhGiaoVien()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Xóa cột mặc định
            gridReportAttendance.Columns.Clear();

            // Thêm cột "Mã HV" và "Tên HV" (chiếm 2 dòng)
            gridReportAttendance.Columns.Add("MaHV", "Mã HV");
            gridReportAttendance.Columns.Add("TenHV", "Tên HV");

            // Thêm nhóm cột "Ngày học" với 4 session
            gridReportAttendance.Columns.Add("NgayHoc1_Session1", "Session 1");
            gridReportAttendance.Columns.Add("NgayHoc1_Session2", "Session 2");
            gridReportAttendance.Columns.Add("NgayHoc2_Session1", "Session 1");
            gridReportAttendance.Columns.Add("NgayHoc2_Session2", "Session 2");

            // Thêm cột "Phần trăm" (chiếm 2 dòng)
            gridReportAttendance.Columns.Add("PhanTram", "Phần trăm");

            // Tùy chỉnh header
            gridReportAttendance.RowHeadersVisible = false;
            gridReportAttendance.AllowUserToAddRows = false;
            gridReportAttendance.ColumnHeadersHeight = 60; // Tăng chiều cao header để hiển thị 2 dòng

            // Vẽ header tùy chỉnh
            gridReportAttendance.CellPainting += (sender, e) =>
            {
                if (e.RowIndex == -1) // Header
                {
                    e.PaintBackground(e.ClipBounds, true);
                    using (SolidBrush brush = new SolidBrush(gridReportAttendance.ColumnHeadersDefaultCellStyle.ForeColor))
                    {
                        // Cột "Mã HV" và "Tên HV" (dòng 1)
                        if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                        {
                            e.Graphics.DrawString(gridReportAttendance.Columns[e.ColumnIndex].HeaderText,
                                gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                brush, e.CellBounds, StringFormat.GenericDefault);
                        }
                        // Nhóm "Ngày học" (dòng 1)
                        else if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
                        {
                            if (e.ColumnIndex == 2) // Bắt đầu nhóm "Ngày học 1"
                            {
                                Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y,
                                    gridReportAttendance.Columns[3].Width + gridReportAttendance.Columns[2].Width, e.CellBounds.Height);
                                e.Graphics.DrawString("Ngày học 1", gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                    brush, rect, new StringFormat { Alignment = StringAlignment.Center });
                            }
                            else if (e.ColumnIndex == 4) // Bắt đầu nhóm "Ngày học 2"
                            {
                                Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y,
                                    gridReportAttendance.Columns[5].Width + gridReportAttendance.Columns[4].Width, e.CellBounds.Height);
                                e.Graphics.DrawString("Ngày học 2", gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                    brush, rect, new StringFormat { Alignment = StringAlignment.Center });
                            }
                        }
                        // Cột "Phần trăm" (dòng 1)
                        else if (e.ColumnIndex == 6)
                        {
                            e.Graphics.DrawString(gridReportAttendance.Columns[e.ColumnIndex].HeaderText,
                                gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                brush, e.CellBounds, StringFormat.GenericDefault);
                        }
                    }
                    e.Handled = true;
                }
            };

            // Thêm dữ liệu mẫu
            gridReportAttendance.Rows.Add("Student23", "Bui Hoang Tien", "P", "P", "P", "P", "50%");
            gridReportAttendance.Rows.Add("Student24", "Nguyen Hoang Phan", "P", "A", "P", "A", "30%");
        }

        private void gridReportAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

                if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5) // Cột ngày học
                {
                    if (e.Value != null && e.Value.ToString() == "P")
                        e.CellStyle.BackColor = Color.LightGreen;
                    else if (e.Value != null && e.Value.ToString() == "A")
                        e.CellStyle.BackColor = Color.LightCoral;
                }

        }
    }
}
