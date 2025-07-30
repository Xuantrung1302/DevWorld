using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using Entity.Models;

namespace DevEduManager.Screens
{
    public partial class frmThoiKhoaBieu : Form
    {
        private DateTime currentMonday;
        private readonly string maHocVien = CurrentUser.UserId; // Lấy từ thông tin đăng nhập
        private readonly string _classUrl = $"{ConfigurationManager.AppSettings["HOST_API_URL"]}api/Class/";

        public frmThoiKhoaBieu()
        {
            InitializeComponent();
            EnableDoubleBuffering(dtgvTKB); // Giảm flicker
            InitializeTKB();
        }

        private void InitializeTKB()
        {
            currentMonday = GetMonday(DateTime.Now);
            dtpWeek.Value = currentMonday;

            dtgvTKB.EnableHeadersVisualStyles = false;
            dtgvTKB.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dtgvTKB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgvTKB.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dtgvTKB.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dtgvTKB.ShowCellToolTips = true;  // Bật tooltip
            InitializeCustomToolTip();
            LoadHeaders();
            _ = LoadScheduleFromAPI();

            btnPrevWeek.Click += BtnPrevWeek_Click;
            btnNextWeek.Click += BtnNextWeek_Click;
            dtpWeek.ValueChanged += DtpWeek_ValueChanged;
        }


        private void BtnPrevWeek_Click(object sender, EventArgs e)
        {
            currentMonday = currentMonday.AddDays(-7);
            dtpWeek.Value = currentMonday;
            LoadHeaders();
            _ = LoadScheduleFromAPI();
        }

        private void BtnNextWeek_Click(object sender, EventArgs e)
        {
            currentMonday = currentMonday.AddDays(7);
            dtpWeek.Value = currentMonday;
            LoadHeaders();
            _ = LoadScheduleFromAPI();
        }

        private void DtpWeek_ValueChanged(object sender, EventArgs e)
        {
            currentMonday = GetMonday(dtpWeek.Value);
            LoadHeaders();
            _ = LoadScheduleFromAPI();
        }

        private DateTime GetMonday(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        private void LoadHeaders()
        {
            string[] thu = { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ nhật" };
            for (int i = 0; i < 7; i++)
            {
                DateTime day = currentMonday.AddDays(i);
                dtgvTKB.Columns[i + 1].HeaderText = $"{thu[i]}\n({day:dd/MM})";
            }
        }

        private async Task LoadScheduleFromAPI()
        {
            try
            {
                dtgvTKB.Rows.Clear();

                string[] caHoc = {
            "08:00-10:00",
            "10:00-12:00",
            "13:00-15:00",
            "15:00-17:00",
            "17:00-19:00",
            "19:00-21:00"
        };

                foreach (var ca in caHoc)
                {
                    dtgvTKB.Rows.Add(ca, "", "", "", "", "", "", "");
                }

                string url = $"{_classUrl}layDanhSachLichHocTheoNguoiDung?studentID={maHocVien}";
                string jsonResponse = await GetAPI(url);
                var scheduleData = JsonConvert.DeserializeObject<List<ScheduleResponse>>(jsonResponse);

                if (scheduleData != null)
                {
                    foreach (var item in scheduleData)
                    {
                        DateTime startTime = item.StartTime;
                        DateTime endTime = item.EndTime;

                        if (startTime.Date < currentMonday || startTime.Date > currentMonday.AddDays(6))
                            continue;

                        string ca = $"{startTime:HH:mm}-{endTime:HH:mm}";
                        int rowIndex = GetRowIndex(ca);
                        int colIndex = GetColumnIndex(startTime.DayOfWeek);

                        if (rowIndex >= 0 && colIndex >= 0)
                        {
                            var cell = dtgvTKB.Rows[rowIndex].Cells[colIndex];
                            cell.Value = item.SubjectName;
                            cell.Style.BackColor = Color.LightSkyBlue;
                            cell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                            // Tooltip trực tiếp
                            cell.ToolTipText =
                                    $"📘 {item.CourseName}\n" +  // course_name từ SP
                                    $"🏫 Lớp: {item.ClassName}\n" +
                                    $"📍 Phòng: {item.Room}\n" +              // lấy đúng Room
                                    $"👨‍🏫 GV: {item.TeacherName}";

                        }
                    }
                }

                int totalHeight = dtgvTKB.Height - dtgvTKB.ColumnHeadersHeight;
                int rowHeight = totalHeight / dtgvTKB.Rows.Count;
                foreach (DataGridViewRow row in dtgvTKB.Rows)
                {
                    row.Height = rowHeight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }


        private void OptimizeDataGridViewPerformance()
        {
            dtgvTKB.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dtgvTKB, true, null);

            dtgvTKB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dtgvTKB.ScrollBars = ScrollBars.None;
            dtgvTKB.AllowUserToResizeRows = false;
            dtgvTKB.AllowUserToResizeColumns = false;

            this.DoubleBuffered = true; // Form cũng double buffered
        }



        private void DtgvTKB_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                var cell = dtgvTKB.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ToolTipText = cell.Tag?.ToString() ?? string.Empty;
            }
        }

        private int GetRowIndex(string ca)
        {
            for (int i = 0; i < dtgvTKB.Rows.Count; i++)
            {
                if (dtgvTKB.Rows[i].Cells[0].Value.ToString() == ca)
                    return i;
            }
            return -1;
        }

        private int GetColumnIndex(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return 1;
                case DayOfWeek.Tuesday: return 2;
                case DayOfWeek.Wednesday: return 3;
                case DayOfWeek.Thursday: return 4;
                case DayOfWeek.Friday: return 5;
                case DayOfWeek.Saturday: return 6;
                case DayOfWeek.Sunday: return 7;
                default: return -1;
            }
        }

        private async Task<string> GetAPI(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        // Giảm giật khi redraw DataGridView
        private void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }

        // Model mapping dữ liệu trả về từ API
        private class ScheduleResponse
        {
            public string ClassName { get; set; }         // Lớp học
            public string SubjectName { get; set; }       // Môn học
            public string TeacherName { get; set; }       // GV
            public string SemesterName { get; set; }      // Học kỳ
            public string CourseName { get; set; }        // Tên chương trình
            public string Room { get; set; }              // Phòng học - từ c.Room
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }

        private ToolTip toolTipDefault;

        private void InitializeCustomToolTip()
        {
            toolTipDefault = new ToolTip
            {
                AutoPopDelay = 15000,    // 15 giây hiển thị
                InitialDelay = 500,      // Chờ 0.5s mới hiển thị
                ReshowDelay = 100,
                ShowAlways = true,
                UseFading = true,
                IsBalloon = true // bóng đẹp hơn
            };

            toolTipDefault.OwnerDraw = true; // vẽ lại để tăng kích thước
            toolTipDefault.Draw += ToolTipDefault_Draw;
        }

        private void ToolTipDefault_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Gray, e.Bounds);
            using (Font font = new Font("Segoe UI", 11, FontStyle.Regular)) // Tăng font chữ
            {
                e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, e.Bounds);
            }
        }


        private void CustomToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Vẽ nền
            using (SolidBrush backgroundBrush = new SolidBrush(Color.FromArgb(40, 40, 60)))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            // Vẽ viền
            using (Pen borderPen = new Pen(Color.LightBlue, 1))
            {
                e.Graphics.DrawRectangle(borderPen, e.Bounds);
            }

            // Vẽ icon
            var icon = SystemIcons.Information.ToBitmap();
            e.Graphics.DrawImage(icon, e.Bounds.Left + 5, e.Bounds.Top + 5, 16, 16);

            // Vẽ text
            using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
            {
                e.Graphics.DrawString(e.ToolTipText, font, Brushes.White, e.Bounds.Left + 26, e.Bounds.Top + 5);
            }
        }


    }
}
