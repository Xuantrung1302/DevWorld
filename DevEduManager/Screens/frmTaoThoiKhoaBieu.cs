using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Linq;

namespace DevEduManager.Screens
{
    public partial class frmTaoThoiKhoaBieu : Form
    {
        public frmTaoThoiKhoaBieu()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSampleData();
        }

        private void InitializeDataGridView()
        {
            // Cấu hình DataGridView
            dtgvLich.AllowUserToAddRows = false;
            dtgvLich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLich.ColumnHeadersHeight = 35;
            dtgvLich.RowHeadersVisible = false;
            dtgvLich.EnableHeadersVisualStyles = false;

            dtgvLich.DefaultCellStyle = new DataGridViewCellStyle
            {
                Padding = new Padding(3),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // Nếu đã thiết kế cột sẵn trong Designer thì KHÔNG cần add lại
            // Nếu chưa có cột, thêm vào đây:
            if (dtgvLich.Columns.Count == 0)
            {
                dtgvLich.Columns.Add("ClassID", "Mã lớp");
                dtgvLich.Columns.Add("ClassName", "Tên lớp");
                dtgvLich.Columns.Add("DayOfWeek", "Thứ");
                dtgvLich.Columns.Add("StartTime", "Bắt đầu");
                dtgvLich.Columns.Add("EndTime", "Kết thúc");
                dtgvLich.Columns.Add("Room", "Phòng");
                dtgvLich.Columns.Add("MaxSeats", "Số chỗ");
            }

            // Định dạng header
            dtgvLich.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // Định dạng cột giờ
            if (dtgvLich.Columns.Contains("StartTime"))
                dtgvLich.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm";

            if (dtgvLich.Columns.Contains("EndTime"))
                dtgvLich.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm";
        }

        private void LoadSampleData()
        {
            var sampleData = new List<ClassSchedule>
            {
                // 8 bản ghi cho Python.1
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 2", "09:00", "11:00", "P501", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 3", "14:00", "16:00", "P502", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 4", "09:00", "11:00", "P501", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 5", "14:00", "16:00", "P503", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 6", "09:00", "11:00", "P502", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 7", "08:00", "10:00", "P504", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 2", "13:00", "15:00", "P501", 30),
                new ClassSchedule("PYTHON.1", "Lập trình Python nâng cao", "Thứ 4", "13:00", "15:00", "P503", 30),

                // 8 bản ghi cho Java.1
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 2", "08:00", "10:00", "J301", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 3", "10:00", "12:00", "J302", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 4", "13:00", "15:00", "J303", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 5", "15:00", "17:00", "J301", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 6", "08:00", "10:00", "J302", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 2", "15:00", "17:00", "J304", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 3", "13:00", "15:00", "J303", 25),
                new ClassSchedule("JAVA.1", "Lập trình Java OOP", "Thứ 5", "10:00", "12:00", "J302", 25),


                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 2", "08:00", "10:00", "J301", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 3", "10:00", "12:00", "J302", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 4", "13:00", "15:00", "J303", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 5", "15:00", "17:00", "J301", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 6", "08:00", "10:00", "J302", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 2", "15:00", "17:00", "J304", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 3", "13:00", "15:00", "J303", 25),
                new ClassSchedule("OOP.1", "Lập trình  OOP", "Thứ 5", "10:00", "12:00", "J302", 25),



                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 2", "08:00", "10:00", "J301", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 3", "10:00", "12:00", "J302", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 4", "13:00", "15:00", "J303", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 5", "15:00", "17:00", "J301", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 6", "08:00", "10:00", "J302", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 2", "15:00", "17:00", "J304", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 3", "13:00", "15:00", "J303", 25),
                new ClassSchedule("Ruby.1", "Lập trình Ruby", "Thứ 5", "10:00", "12:00", "J302", 25),


                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 2", "08:00", "10:00", "J301", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 3", "10:00", "12:00", "J302", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 4", "13:00", "15:00", "J303", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 5", "15:00", "17:00", "J301", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 6", "08:00", "10:00", "J302", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 2", "15:00", "17:00", "J304", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 3", "13:00", "15:00", "J303", 25),
                new ClassSchedule("CSharp.1", "Lập trình C#", "Thứ 5", "10:00", "12:00", "J302", 25)


            };

            var groupedData = sampleData.GroupBy(x => x.ClassName);

            foreach (var subjectGroup in groupedData)
            {
                // Thêm hàng tiêu đề môn học
                int headerRowIndex = dtgvLich.Rows.Add();
                DataGridViewRow headerRow = dtgvLich.Rows[headerRowIndex];

                headerRow.Cells[0].Value = subjectGroup.Key;
                headerRow.DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Arial", 11, FontStyle.Bold),
                    BackColor = Color.SteelBlue,
                    ForeColor = Color.White,
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };
                headerRow.Height = 32;

                for (int i = 1; i < dtgvLich.Columns.Count; i++)
                {
                    headerRow.Cells[i].Value = "";
                    headerRow.Cells[i].Style.BackColor = Color.SteelBlue;
                }

                // Thêm các lớp học
                foreach (var classItem in subjectGroup)
                {
                    int rowIndex = dtgvLich.Rows.Add(
                        classItem.ClassID,
                        "",
                        classItem.DayOfWeek,
                        classItem.StartTime,
                        classItem.EndTime,
                        classItem.Room,
                        classItem.MaxSeats
                    );

                    DataGridViewRow dataRow = dtgvLich.Rows[rowIndex];
                    dataRow.DefaultCellStyle.BackColor = (classItem.StartTime.Hours < 12)
                        ? Color.LightYellow : Color.LightCyan;

                    if (classItem.Room.StartsWith("P") || classItem.Room.StartsWith("J"))
                    {
                        dataRow.Cells["Room"].Style.Font = new Font(dtgvLich.Font, FontStyle.Bold);
                        dataRow.Cells["Room"].Style.ForeColor = Color.DarkBlue;
                    }
                }
            }

            dtgvLich.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var row = dtgvLich.Rows[e.RowIndex];
                    if (row.Cells[0].Style.Font?.Bold == true) return;

                    string classInfo = "Mã lớp: " + row.Cells["ClassID"].Value + Environment.NewLine +
                                     "Môn học: " + GetSubjectNameForRow(e.RowIndex) + Environment.NewLine +
                                     "Thời gian: " + row.Cells["DayOfWeek"].Value + " " +
                                     row.Cells["StartTime"].Value + " - " + row.Cells["EndTime"].Value + Environment.NewLine +
                                     "Phòng: " + row.Cells["Room"].Value + " (Tối đa: " +
                                     row.Cells["MaxSeats"].Value + " chỗ)";

                    MessageBox.Show(classInfo, "Thông tin lớp học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private string GetSubjectNameForRow(int rowIndex)
        {
            for (int i = rowIndex; i >= 0; i--)
            {
                if (dtgvLich.Rows[i].Cells[0].Style.Font?.Bold == true)
                {
                    return dtgvLich.Rows[i].Cells[0].Value.ToString();
                }
            }
            return "Không xác định";
        }

        public class ClassSchedule
        {
            public string ClassID { get; set; }
            public string ClassName { get; set; }
            public string DayOfWeek { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
            public string Room { get; set; }
            public int MaxSeats { get; set; }

            public ClassSchedule(string id, string name, string day, string start, string end, string room, int seats)
            {
                ClassID = id;
                ClassName = name;
                DayOfWeek = day;
                StartTime = TimeSpan.Parse(start);
                EndTime = TimeSpan.Parse(end);
                Room = room;
                MaxSeats = seats;
            }
        }
    }
}
