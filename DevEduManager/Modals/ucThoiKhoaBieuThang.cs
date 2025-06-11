using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevEduManager.Modals
{
    public partial class ucThoiKhoaBieuThang : UserControl
    {
        private DateTime currentMonth = DateTime.Today;


        private Dictionary<DateTime, int> tkbData;

        public ucThoiKhoaBieuThang(Dictionary<DateTime, int> data)
        {
            InitializeComponent();
            this.tkbData = data;
            InitLayout();
            RenderCalendar();
        }


        private void InitLayout()
        {
            this.Dock = DockStyle.Fill;
            this.Controls.Clear();

            // Main layout
            var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1,
            };
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10)); // Header
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90)); // Calendar

            // Header
            var headerPanel = new Panel { Dock = DockStyle.Fill };
            var btnPrev = new Button { Text = "<", Width = 40, Dock = DockStyle.Left };
            var btnNext = new Button { Text = ">", Width = 40, Dock = DockStyle.Right };
            var lblMonth = new Label
            {
                Text = currentMonth.ToString("MMMM yyyy", new CultureInfo("vi-VN")),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Name = "lblMonth"
            };

            btnPrev.Click += (s, e) => { currentMonth = currentMonth.AddMonths(-1); RenderCalendar(); };
            btnNext.Click += (s, e) => { currentMonth = currentMonth.AddMonths(1); RenderCalendar(); };

            headerPanel.Controls.Add(btnPrev);
            headerPanel.Controls.Add(btnNext);
            headerPanel.Controls.Add(lblMonth);

            mainLayout.Controls.Add(headerPanel, 0, 0);

            // Calendar placeholder
            var calendarPanel = new Panel { Dock = DockStyle.Fill, Name = "calendarPanel" };
            mainLayout.Controls.Add(calendarPanel, 0, 1);

            this.Controls.Add(mainLayout);
        }

        private void RenderCalendar()
        {
            var calendarPanel = this.Controls.Find("calendarPanel", true).FirstOrDefault() as Panel;
            var lblMonth = this.Controls.Find("lblMonth", true).FirstOrDefault() as Label;
            if (calendarPanel == null || lblMonth == null) return;

            calendarPanel.Controls.Clear();
            lblMonth.Text = currentMonth.ToString("MMMM yyyy", new CultureInfo("vi-VN"));

            var tbl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 7,
                RowCount = 7,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            for (int i = 0; i < 7; i++)
                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            for (int i = 0; i < 7; i++)
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 7));

            string[] days = { "T2", "T3", "T4", "T5", "T6", "T7", "CN" };
            foreach (var day in days)
            {
                tbl.Controls.Add(new Label
                {
                    Text = day,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                });
            }

            DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int startDay = ((int)firstDay.DayOfWeek + 6) % 7;
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int currentDay = 1;

            for (int row = 1; row <= 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 1 && col < startDay) || currentDay > daysInMonth)
                    {
                        tbl.Controls.Add(new Label()); // ô trống
                    }
                    else
                    {
                        var panel = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(2) };
                        DateTime thisDate = new DateTime(currentMonth.Year, currentMonth.Month, currentDay);

                        // Vẽ các ô vuông lớp học nếu có
                        if (tkbData.ContainsKey(thisDate))
                        {
                            int classCount = tkbData[thisDate];
                            for (int i = 0; i < classCount; i++)
                            {
                                var box = new Panel
                                {
                                    BackColor = Color.LightSkyBlue,
                                    Width = panel.Width - 6,
                                    Height = (panel.Width - 6) * 2 / 3,
                                    Margin = new Padding(1),
                                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                                };
                                box.Top = 18 + i * (box.Height + 2);
                                panel.Controls.Add(box);
                                panel.Controls.SetChildIndex(box, 0); // Đảm bảo lớp học nằm dưới label ngày
                            }
                        }

                        var lbl = new Label
                        {
                            Text = currentDay.ToString(),
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.TopRight,
                            Font = new Font("Segoe UI", 9)
                        };

                        // Bôi đậm ngày hôm nay
                        if (currentMonth.Year == DateTime.Today.Year &&
                            currentMonth.Month == DateTime.Today.Month &&
                            currentDay == DateTime.Today.Day)
                        {
                            lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                            lbl.ForeColor = Color.White;
                            lbl.BackColor = Color.DarkBlue;
                            lbl.Padding = new Padding(4);
                            lbl.Margin = new Padding(4);
                        }

                        // TODO: Vẽ ô vuông tượng trưng ca học/ca làm tại đây

                        panel.Controls.Add(lbl);
                        tbl.Controls.Add(panel);
                        currentDay++;
                    }
                }
            }

            calendarPanel.Controls.Add(tbl);
        }
    }


}
