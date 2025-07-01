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
    public partial class ucThoiKhoaBieuTuan : UserControl
    {
        private DateTime currentWeekStart;
        private Dictionary<DateTime, List<(string EventName, string TimeRange, Color BackColor, Color ForeColor)>> scheduleData;

        public ucThoiKhoaBieuTuan()
        {
            // Initialize current week start to the first day of the current week (Sunday)
            currentWeekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            scheduleData = new Dictionary<DateTime, List<(string, string, Color, Color)>>();

            // Set up the UI
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            InitLayout();
            RenderSchedule();
        }

        private void InitLayout()
        {
            this.Controls.Clear();

            // Header panel
            var headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = SystemColors.ControlDark
            };

            // Prev Button
            Button btnPrev = new Button
            {
                Text = "<",
                Dock = DockStyle.Left,
                Width = 40,
                Margin = new Padding(5)
            };
            btnPrev.Click += BtnPrev_Click;
            headerPanel.Controls.Add(btnPrev);

            // Today Button
            Button btnToday = new Button
            {
                Text = "today",
                Dock = DockStyle.Left,
                Width = 70,
                Margin = new Padding(5)
            };
            btnToday.Click += BtnToday_Click;
            headerPanel.Controls.Add(btnToday);

            // Week Label (centered)
            Label lblWeek = new Label
            {
                Text = $"{currentWeekStart:MMM dd} - {currentWeekStart.AddDays(6):MMM dd, yyyy}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Margin = new Padding(5)
            };
            headerPanel.Controls.Add(lblWeek);

            // Next Button
            Button btnNext = new Button
            {
                Text = ">",
                Dock = DockStyle.Right,
                Width = 40,
                Margin = new Padding(5)
            };
            btnNext.Click += BtnNext_Click;
            headerPanel.Controls.Add(btnNext);

            this.Controls.Add(headerPanel);

            // Main content panel
            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            // headermain panel (fixed, contains day headers)
            var headermainPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60, // Height for day headers
                BackColor = Color.Yellow
            };
            mainPanel.Controls.Add(headermainPanel);

            // bodymain panel (scrollable, contains timeline and events)
            var bodymainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true // Enable vertical scrolling only for bodymain
            };
            mainPanel.Controls.Add(bodymainPanel);

            this.Controls.Add(mainPanel);
        }

        private void RenderSchedule()
        {
            // Clear existing controls
            var mainPanel = this.Controls[1] as Panel;
            if (mainPanel == null) return;
            var headermainPanel = mainPanel.Controls[0] as Panel;
            var bodymainPanel = mainPanel.Controls[1] as Panel;
            if (headermainPanel == null || bodymainPanel == null) return;
            headermainPanel.Controls.Clear();
            bodymainPanel.Controls.Clear();

            // Update week label
            var headerPanel = this.Controls[0] as Panel;
            if (headerPanel != null)
            {
                var lblWeek = headerPanel.Controls[2] as Label;
                if (lblWeek != null)
                    lblWeek.Text = $"{currentWeekStart:MMM dd} - {currentWeekStart.AddDays(6):MMM dd, yyyy}";
            }

            // Initialize sample data for the week
            InitializeSampleData();

            // Render headermain (day headers)
            var tblHeadermain = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 8, // 7 days + time column
                RowCount = 1,    // Only 1 row for day headers
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            // Column styles
            tblHeadermain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Time column (empty)
            for (int i = 0; i < 7; i++)
                tblHeadermain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 7)); // 7 days

            // Day headers
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            DateTime currentDay = currentWeekStart;
            tblHeadermain.Controls.Add(new Label
            {
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            }, 0, 0);
            for (int col = 1; col <= 7; col++)
            {
                tblHeadermain.Controls.Add(new Label
                {
                    Text = $"{days[col - 1]} {currentDay:MM/dd}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    BackColor = Color.LightGray
                }, col, 0);
                currentDay = currentDay.AddDays(1);
            }
            headermainPanel.Controls.Add(tblHeadermain);

            // Render bodymain (timeline and events)
            var tblBodymain = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 8, // 7 days + time column
                RowCount = 24,   // 24 hours (12am to 11pm) + 1 row for alignment
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = true
            };

            // Column styles
            tblBodymain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Time column
            for (int i = 0; i < 7; i++)
                tblBodymain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 7)); // 7 days

            // Row styles
            for (int i = 0; i < tblBodymain.RowCount; i++)
                tblBodymain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // Increased height to 60 pixels

            // Time slots (12am to 11pm)
            string[] timeSlots = { "12am", "1am", "2am", "3am", "4am", "5am", "6am", "7am", "8am", "9am", "10am", "11am",
                         "12pm", "1pm", "2pm", "3pm", "4pm", "5pm", "6pm", "7pm", "8pm", "9pm", "10pm", "11pm" };
            for (int row = 0; row < timeSlots.Length; row++)
            {
                tblBodymain.Controls.Add(new Label
                {
                    Text = timeSlots[row],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(5, 0, 0, 0)
                }, 0, row);
            }

            // Add events
            currentDay = currentWeekStart;
            for (int col = 1; col <= 7; col++)
            {
                if (scheduleData.ContainsKey(currentDay))
                {
                    foreach (var (eventName, timeRange, backColor, foreColor) in scheduleData[currentDay])
                    {
                        int startRow = GetTimeRow(timeRange.Split('-')[0]);
                        int endRow = timeRange.Contains('-') ? GetTimeRow(timeRange.Split('-')[1]) : startRow;

                        for (int row = startRow; row <= endRow && row < tblBodymain.RowCount; row++)
                        {
                            var panel = tblBodymain.GetControlFromPosition(col, row) as Panel ?? new Panel { Dock = DockStyle.Fill };
                            panel.BackColor = backColor;
                            panel.ForeColor = foreColor;
                            panel.Controls.Clear();
                            if (row == startRow)
                            {
                                var lbl = new Label
                                {
                                    Text = eventName,
                                    Dock = DockStyle.Fill,
                                    TextAlign = ContentAlignment.MiddleLeft,
                                    ForeColor = foreColor,
                                    Font = new Font("Segoe UI", 10),
                                    Padding = new Padding(5, 0, 0, 0)
                                };
                                panel.Controls.Add(lbl);

                                // Add time range label if applicable
                                if (timeRange.Contains('-'))
                                {
                                    var timeLbl = new Label
                                    {
                                        Text = timeRange,
                                        Dock = DockStyle.Right,
                                        Width = 80,
                                        TextAlign = ContentAlignment.MiddleCenter,
                                        ForeColor = foreColor,
                                        Font = new Font("Segoe UI", 8),
                                        Padding = new Padding(5)
                                    };
                                    panel.Controls.Add(timeLbl);
                                }
                            }
                            if (tblBodymain.GetControlFromPosition(col, row) == null)
                                tblBodymain.Controls.Add(panel, col, row);
                        }
                    }
                }
                currentDay = currentDay.AddDays(1);
            }

            bodymainPanel.Controls.Add(tblBodymain);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(-7);
            RenderSchedule();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(7);
            RenderSchedule();
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            currentWeekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            RenderSchedule();
        }

        private void InitializeSampleData()
        {
            // Sample data for the week of Jun 15 - 21, 2025
            scheduleData.Clear();
            scheduleData[new DateTime(2025, 6, 15)] = new List<(string, string, Color, Color)>
            {
                ("Conference", "all-day", Color.FromArgb(0, 120, 215), Color.White)
            };
            scheduleData[new DateTime(2025, 6, 17)] = new List<(string, string, Color, Color)>
            {
                ("Birthday Party", "7:00", Color.FromArgb(0, 120, 215), Color.White),
                ("Meeting", "10:30 - 11:30", Color.FromArgb(0, 120, 215), Color.White),
                ("Lunch", "12:00", Color.FromArgb(0, 120, 215), Color.White),
                ("Meeting", "2:30", Color.FromArgb(0, 120, 215), Color.White)
            };
        }

        private int GetTimeRow(string time)
        {
            string[] timeSlots = { "12am", "1am", "2am", "3am", "4am", "5am", "6am", "7am", "8am", "9am", "10am", "11am",
                                 "12pm", "1pm", "2pm", "3pm", "4pm", "5pm", "6pm", "7pm", "8pm", "9pm", "10pm", "11pm",};
            time = time.Trim().ToLower();
            for (int i = 0; i < timeSlots.Length; i++)
            {
                if (timeSlots[i].StartsWith(time)) return i;
            }
            return 0; // Default to all-day if not found
        }
    }
}