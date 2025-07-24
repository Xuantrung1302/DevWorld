using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevEduManager.Screens
{
    public partial class frmThoiKhoaBieu : Form
    {
        private DateTime startOfWeek;
        private Dictionary<string, List<string>> scheduleData;

        public frmThoiKhoaBieu()
        {
            InitializeComponent();
            InitData();
            LoadSchedule();
        }

        private void InitData()
        {
            cboLop.Items.AddRange(new string[] { "ACCP i13", "C1307G" });
            cboLop.SelectedIndex = 0;

            // Tuần hiện tại
            startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1);
            dtpWeek.Value = startOfWeek;

            // Data: Khóa có nhiều môn, mỗi môn 8 buổi (4 tuần, 2 buổi/tuần)
            scheduleData = new Dictionary<string, List<string>>
            {
                { "ACCP i13", new List<string>{ "Lập trình C#", "SQL Server", "WinForms", "Project" } },
                { "C1307G", new List<string>{ "Java", "Spring Boot", "MySQL", "Project" } }
            };

            btnPrevWeek.Click += (s, e) => { startOfWeek = startOfWeek.AddDays(-7); dtpWeek.Value = startOfWeek; LoadSchedule(); };
            btnNextWeek.Click += (s, e) => { startOfWeek = startOfWeek.AddDays(7); dtpWeek.Value = startOfWeek; LoadSchedule(); };
            dtpWeek.ValueChanged += (s, e) => { startOfWeek = dtpWeek.Value; LoadSchedule(); };
        }

        private void LoadSchedule()
        {
            dtgvTKB.Rows.Clear();
            string[] khungGio = { "08:00-10:00", "10:00-12:00", "13:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00" };

            foreach (var time in khungGio)
                dtgvTKB.Rows.Add(time, "", "", "", "", "", "", "");

            string lop = cboLop.SelectedItem.ToString();
            var monHoc = scheduleData[lop];

            // Xác định môn hiện tại theo tuần
            int weekIndex = (int)((startOfWeek - DateTime.Today.AddDays(-30)).TotalDays / 7);
            int monIndex = weekIndex / 4 < monHoc.Count ? weekIndex / 4 : monHoc.Count - 1;
            string currentSubject = monHoc[monIndex];

            // Gán vào 2 buổi mỗi tuần: Thứ 2 sáng, Thứ 4 sáng
            dtgvTKB.Rows[0].Cells[1].Value = currentSubject; // Thứ 2
            dtgvTKB.Rows[0].Cells[3].Value = currentSubject; // Thứ 4
        }
    }
}
