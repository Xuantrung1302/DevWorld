using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class ucThoiKhoaBieuThang : UserControl
    {
        private DateTime currentWeekStart;
        private Dictionary<DateTime, List<(string EventName, string TimeRange, Color BackColor, Color ForeColor)>> tkbData;
        private Label txtCalendar; // Reference to parent form's label
        private Button btnPrev;    // Reference to parent form's prev button
        private Button btnNext;    // Reference to parent form's next button

        public ucThoiKhoaBieuThang(Dictionary<DateTime, int> initialData, Label txtCalendar, Button btnPrev, Button btnNext)
        {
            // Initialize current week start
            currentWeekStart = GetStartOfWeek(DateTime.Today, DayOfWeek.Sunday);

            // Initialize tkbData
            tkbData = new Dictionary<DateTime, List<(string, string, Color, Color)>>();
            InitializeEventData(initialData);

            // Store references to parent form controls
            this.txtCalendar = txtCalendar ?? throw new ArgumentNullException(nameof(txtCalendar));
            this.btnPrev = btnPrev ?? throw new ArgumentNullException(nameof(btnPrev));
            this.btnNext = btnNext ?? throw new ArgumentNullException(nameof(btnNext));

            // Set up the UI
            this.Size = new Size(800, 600);
            this.Dock = DockStyle.Fill;
            InitLayout();
            RenderTimetable();

            // Attach navigation events to parent buttons
            this.btnPrev.Click += (s, e) => { currentWeekStart = currentWeekStart.AddDays(-7); RenderTimetable(); };
            this.btnNext.Click += (s, e) => { currentWeekStart = currentWeekStart.AddDays(7); RenderTimetable(); };
        }

        // Static method to get the start of the week
        private static DateTime GetStartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        private void InitLayout()
        {
            this.Controls.Clear();

            // Timetable panel with scrolling
            var timetablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Name = "timetablePanel"
            };
            this.Controls.Add(timetablePanel);
        }

        private void InitializeEventData(Dictionary<DateTime, int> initialData)
        {
            // Hardcoded events to match the image
            var events = new List<(DateTime Date, string EventName, string TimeRange, Color BackColor, Color ForeColor)>
            {
                (new DateTime(2025, 6, 8), "all-day Long Event", "all-day", Color.Blue, Color.White),
                (new DateTime(2025, 6, 9), "Conference", "all-day", Color.Blue, Color.White),
                (new DateTime(2025, 6, 11), "Birthday Party", "7:00", Color.Blue, Color.White),
                (new DateTime(2025, 6, 11), "Meeting", "11:00-12:00", Color.Blue, Color.White),
                (new DateTime(2025, 6, 11), "Lunch", "12:00", Color.Blue, Color.White),
                (new DateTime(2025, 6, 11), "Meeting", "2:00-3:00", Color.Blue, Color.White),
                (new DateTime(2025, 6, 12), "Event", "4:00", Color.Blue, Color.White)
            };

            foreach (var (date, eventName, timeRange, backColor, foreColor) in events)
            {
                if (!tkbData.ContainsKey(date))
                    tkbData[date] = new List<(string, string, Color, Color)>();
                tkbData[date].Add((eventName, timeRange, backColor, foreColor));
            }

            // Optionally map initialData to events
            foreach (var kvp in initialData)
            {
                if (!tkbData.ContainsKey(kvp.Key))
                    tkbData[kvp.Key] = new List<(string, string, Color, Color)>();
                tkbData[kvp.Key].Add(($"Class {kvp.Value}", "9:00-11:00", Color.LightSkyBlue, Color.Black));
            }
        }

        private void RenderTimetable()
        {
            var timetablePanel = this.Controls.Find("timetablePanel", true).FirstOrDefault() as Panel;
            if (timetablePanel == null) return;

            timetablePanel.Controls.Clear();
            txtCalendar.Text = $"{currentWeekStart:MMMM d, yyyy} - {(currentWeekStart.AddDays(6)):MMMM d, yyyy}";

            var tbl = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 8, // 7 days + time column
                RowCount = 24,   // 12am to 11pm + header
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = true
            };

            // Column styles
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10)); // Time column
            for (int i = 0; i < 7; i++)
                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F / 7));

            // Row styles
            for (int i = 0; i < 24; i++)
                tbl.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Header row (days)
            string[] days = { "Sun 6/8", "Mon 6/9", "Tue 6/10", "Wed 6/11", "Thu 6/12", "Fri 6/13", "Sat 6/14" };
            tbl.Controls.Add(new Label { Text = "Time", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);
            for (int col = 0; col < 7; col++)
            {
                tbl.Controls.Add(new Label
                {
                    Text = days[col],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                }, col + 1, 0);
            }

            // Time slots (12am to 11pm)
            string[] timeSlots = { "12am", "1am", "2am", "3am", "4am", "5am", "6am", "7am", "8am", "9am", "10am", "11am",
                                 "12pm", "1pm", "2pm", "3pm", "4pm", "5pm", "6pm", "7pm", "8pm", "9pm", "10pm", "11pm" };
            for (int row = 0; row < 24; row++)
            {
                tbl.Controls.Add(new Label
                {
                    Text = timeSlots[row],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true
                }, 0, row + 1);
            }

            // Add events
            DateTime currentDate = currentWeekStart;
            for (int col = 1; col <= 7; col++)
            {
                if (tkbData.ContainsKey(currentDate))
                {
                    foreach (var (eventName, timeRange, backColor, foreColor) in tkbData[currentDate])
                    {
                        int startRow = timeRange == "all-day" ? 1 : GetTimeRow(timeRange.Split('-')[0]);
                        int endRow = timeRange.Contains('-') ? GetTimeRow(timeRange.Split('-')[1]) : startRow;

                        for (int row = startRow; row <= endRow && row <= 24; row++)
                        {
                            var panel = tbl.GetControlFromPosition(col, row) as Panel ?? new Panel { Dock = DockStyle.Fill };
                            panel.BackColor = backColor;
                            panel.ForeColor = foreColor;
                            panel.Controls.Clear();
                            if (row == startRow)
                            {
                                var lbl = new Label
                                {
                                    Text = eventName,
                                    Dock = DockStyle.Fill,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    ForeColor = foreColor,
                                    AutoSize = true
                                };
                                panel.Controls.Add(lbl);
                            }
                            if (tbl.GetControlFromPosition(col, row) == null)
                                tbl.Controls.Add(panel, col, row);
                        }
                    }
                }
                currentDate = currentDate.AddDays(1);
            }

            // Highlight current day (Wednesday, June 11, 2025)
            int currentDayIndex = Array.IndexOf(days, "Wed 6/11");
            if (currentDayIndex >= 0)
            {
                for (int row = 1; row <= 24; row++)
                {
                    var panel = tbl.GetControlFromPosition(currentDayIndex + 1, row) as Panel;
                    if (panel != null) panel.BackColor = Color.LightYellow;
                }
            }

            timetablePanel.Controls.Add(tbl);
        }

        private int GetTimeRow(string time)
        {
            string[] timeSlots = { "12am", "1am", "2am", "3am", "4am", "5am", "6am", "7am", "8am", "9am", "10am", "11am",
                                 "12pm", "1pm", "2pm", "3pm", "4pm", "5pm", "6pm", "7pm", "8pm", "9pm", "10pm", "11pm" };
            time = time.Trim().ToLower();
            for (int i = 0; i < timeSlots.Length; i++)
            {
                if (timeSlots[i].StartsWith(time)) return i + 1;
            }
            return 1; // Default to 12am if not found
        }
    }
}