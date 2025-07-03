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

            // Thêm các cột với độ rộng gấp đôi
            gridReportAttendance.Columns.Add("MaHV", "Mã HV");
            gridReportAttendance.Columns.Add("TenHV", "Tên HV");
            gridReportAttendance.Columns.Add("NgayHoc1_Session1", "Session 1");
            gridReportAttendance.Columns.Add("NgayHoc1_Session2", "Session 2");
            gridReportAttendance.Columns.Add("NgayHoc2_Session1", "Session 1");
            gridReportAttendance.Columns.Add("NgayHoc2_Session2", "Session 2");
            gridReportAttendance.Columns.Add("PhanTram", "Phần trăm");

            // Đặt độ rộng các cột (gấp đôi bình thường)
            gridReportAttendance.Columns["MaHV"].Width = 120; // Tăng từ ~60 lên 120
            gridReportAttendance.Columns["TenHV"].Width = 200; // Tăng từ ~100 lên 200
            gridReportAttendance.Columns["NgayHoc1_Session1"].Width = 80;
            gridReportAttendance.Columns["NgayHoc1_Session2"].Width = 80;
            gridReportAttendance.Columns["NgayHoc2_Session1"].Width = 80;
            gridReportAttendance.Columns["NgayHoc2_Session2"].Width = 80;
            gridReportAttendance.Columns["PhanTram"].Width = 120;

            // Tùy chỉnh header
            gridReportAttendance.RowHeadersVisible = false;
            gridReportAttendance.AllowUserToAddRows = false;
            gridReportAttendance.ColumnHeadersHeight = 60; // Chiều cao header
            gridReportAttendance.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; // Màu nền xám
            gridReportAttendance.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold); // Font đậm
            gridReportAttendance.EnableHeadersVisualStyles = false; // Tắt style mặc định để áp dụng màu

            // Vẽ header tùy chỉnh
            gridReportAttendance.CellPainting += (sender, e) =>
            {
                if (e.RowIndex == -1) // Header
                {
                    // Vẽ nền xám cho toàn bộ header
                    using (SolidBrush backBrush = new SolidBrush(Color.LightGray))
                    {
                        e.Graphics.FillRectangle(backBrush, e.CellBounds);
                    }

                    // Vẽ border
                    e.Graphics.DrawRectangle(Pens.Gray, e.CellBounds);

                    using (SolidBrush brush = new SolidBrush(gridReportAttendance.ColumnHeadersDefaultCellStyle.ForeColor))
                    {
                        // Cột "Mã HV", "Tên HV" và "Phần trăm" (chiếm cả 2 dòng)
                        if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 6)
                        {
                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;

                            e.Graphics.DrawString(gridReportAttendance.Columns[e.ColumnIndex].HeaderText,
                                gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                brush, e.CellBounds, sf);
                        }
                        // Các cột ngày học
                        else if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
                        {
                            // Dòng 1: Tên ngày học
                            Rectangle topRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y,
                                                            e.CellBounds.Width, e.CellBounds.Height / 2);

                            // Dòng 2: Tên session
                            Rectangle bottomRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y + e.CellBounds.Height / 2,
                                                               e.CellBounds.Width, e.CellBounds.Height / 2);

                            // Xác định tên ngày học dựa trên cột
                            string ngayHoc = e.ColumnIndex <= 3 ? "Ngày học 1" : "Ngày học 2";

                            // Vẽ dòng 1 (ngày học)
                            StringFormat sfTop = new StringFormat();
                            sfTop.Alignment = StringAlignment.Center;
                            sfTop.LineAlignment = StringAlignment.Center;
                            e.Graphics.DrawString(ngayHoc, gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                                 brush, topRect, sfTop);

                            // Vẽ dòng 2 (session)
                            StringFormat sfBottom = new StringFormat();
                            sfBottom.Alignment = StringAlignment.Center;
                            sfBottom.LineAlignment = StringAlignment.Center;
                            e.Graphics.DrawString(gridReportAttendance.Columns[e.ColumnIndex].HeaderText,
                                                gridReportAttendance.ColumnHeadersDefaultCellStyle.Font,
                                                brush, bottomRect, sfBottom);

                            // Vẽ đường phân cách giữa 2 dòng
                            e.Graphics.DrawLine(Pens.Gray, e.CellBounds.X, e.CellBounds.Y + e.CellBounds.Height / 2,
                                              e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y + e.CellBounds.Height / 2);
                        }
                    }
                    e.Handled = true;
                }
            };

            // Merge header cho các cột chiếm 2 dòng
            gridReportAttendance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

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
