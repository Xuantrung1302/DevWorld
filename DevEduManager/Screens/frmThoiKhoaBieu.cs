using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThoiKhoaBieu : Form
    {
        private DateTime currentMonday;
        private ToolTip toolTip1 = new ToolTip();

        public frmThoiKhoaBieu()
        {
            InitializeComponent();
            InitializeTKB();
        }

        private void InitializeTKB()
        {
            // Thêm dữ liệu lớp mẫu
            cboLop.Items.AddRange(new string[] { "C1307G", "C1310H" });
            cboLop.SelectedIndex = 0;

            // Xác định thứ 2 hiện tại
            currentMonday = GetMonday(DateTime.Now);
            dtpWeek.Value = currentMonday;

            // Cấu hình DataGridView
            dtgvTKB.EnableHeadersVisualStyles = false;
            dtgvTKB.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dtgvTKB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgvTKB.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dtgvTKB.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dtgvTKB.CellMouseEnter += dtgvTKB_CellMouseEnter;

            LoadHeaders();
            LoadSampleData();

            btnPrevWeek.Click += BtnPrevWeek_Click;
            btnNextWeek.Click += BtnNextWeek_Click;
            dtpWeek.ValueChanged += DtpWeek_ValueChanged;
        }

        private void BtnPrevWeek_Click(object sender, EventArgs e)
        {
            currentMonday = currentMonday.AddDays(-7);
            dtpWeek.Value = currentMonday;
            LoadHeaders();
            LoadSampleData();
        }

        private void BtnNextWeek_Click(object sender, EventArgs e)
        {
            currentMonday = currentMonday.AddDays(7);
            dtpWeek.Value = currentMonday;
            LoadHeaders();
            LoadSampleData();
        }

        private void DtpWeek_ValueChanged(object sender, EventArgs e)
        {
            currentMonday = GetMonday(dtpWeek.Value);
            LoadHeaders();
            LoadSampleData();
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

        private void LoadSampleData()
        {
            dtgvTKB.Rows.Clear();

            // Các ca học cố định
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

            // Auto chỉnh chiều cao để full DataGridView
            int totalHeight = dtgvTKB.Height - dtgvTKB.ColumnHeadersHeight;
            int rowHeight = totalHeight / dtgvTKB.Rows.Count;
            foreach (DataGridViewRow row in dtgvTKB.Rows)
            {
                row.Height = rowHeight;
            }

            // Load dữ liệu mẫu
            string selectedClass = cboLop.SelectedItem.ToString();
            var scheduleData = GetSampleSchedule(selectedClass);

            foreach (var item in scheduleData)
            {
                int rowIndex = GetRowIndex(item.Ca);
                int colIndex = GetColumnIndex(item.Day);

                if (rowIndex >= 0 && colIndex >= 0)
                {
                    var cell = dtgvTKB.Rows[rowIndex].Cells[colIndex];
                    cell.Value = selectedClass;
                    cell.Tag = $"Môn: {item.Subject}\nGV: {item.Teacher}\nPhòng: {item.Room}";
                    cell.Style.BackColor = Color.LightBlue;
                    cell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
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

        private List<ScheduleItem> GetSampleSchedule(string className)
        {
            DateTime start = currentMonday;

            return new List<ScheduleItem>()
            {
                new ScheduleItem(start.AddDays(0).DayOfWeek, "08:00-10:00", "Java", "GV Huy", "P101"),
                new ScheduleItem(start.AddDays(2).DayOfWeek, "10:00-12:00", "Java", "GV Huy", "P101"),
                new ScheduleItem(start.AddDays(1).DayOfWeek, "13:00-15:00", "C#", "GV Nam", "P102"),
                new ScheduleItem(start.AddDays(3).DayOfWeek, "19:00-21:00", "C#", "GV Nam", "P102"),
            };
        }

        private void dtgvTKB_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                var cell = dtgvTKB.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Tag != null)
                {
                    toolTip1.SetToolTip(dtgvTKB, cell.Tag.ToString());
                }
                else
                {
                    toolTip1.SetToolTip(dtgvTKB, "");
                }
            }
        }

        private class ScheduleItem
        {
            public DayOfWeek Day { get; set; }
            public string Ca { get; set; }
            public string Subject { get; set; }
            public string Teacher { get; set; }
            public string Room { get; set; }

            public ScheduleItem(DayOfWeek day, string ca, string subject, string teacher, string room)
            {
                Day = day; Ca = ca; Subject = subject; Teacher = teacher; Room = room;
            }
        }
    }
}
