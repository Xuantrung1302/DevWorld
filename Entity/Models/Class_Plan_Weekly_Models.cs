using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Modals
{
    public partial class T_Schedule_Class_Plan_Weekly_Models
    {
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public string SemesterID { get; set; }
        public string Schedule { get; set; }
        public int IsStudy { get; set; }
        public string TuitionFee { get; set; }
        public int HaveTeacherFLG { get; set; }

        /// <summary>
        /// Phân tách và định dạng lại Schedule thành các trường riêng biệt (DayOfWeek, StartTime, EndTime)
        /// </summary>
        /// <returns>Tuple chứa (DaysOfWeek, StartTime, EndTime)</returns>
        public (string DaysOfWeek, string StartTime, string EndTime) ParseSchedule()
        {
            if (string.IsNullOrEmpty(Schedule))
                return (string.Empty, string.Empty, string.Empty);

            try
            {
                // Tách phần ngày (Thứ 2, 4, 6) và phần giờ (18:00-20:00)
                string[] parts = Schedule.Split(new[] { '(' }, 2);
                if (parts.Length < 2)
                    return (string.Empty, string.Empty, string.Empty);

                string dayPart = parts[0].Trim(); // "Thứ 2, 4, 6"
                string timePart = parts[1].Replace(")", "").Trim(); // "18:00-20:00"

                // Chuyển đổi ngày từ tiếng Việt sang tiếng Anh
                string[] vietnameseDays = dayPart.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(d => d.Trim().Replace("Thứ ", "").Trim()).ToArray(); // ["2", "4", "6"]
                string[] englishDays = vietnameseDays.Select(day =>
                {
                    int dayNum = int.Parse(day);
                    return GetEnglishDayOfWeek(dayNum);
                }).ToArray();
                string daysOfWeek = string.Join(", ", englishDays); // "Monday, Wednesday, Friday"

                // Tách giờ bắt đầu và giờ kết thúc
                string[] timeRange = timePart.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim()).ToArray(); // ["18:00", "20:00"]
                string startTime = timeRange.Length > 0 ? timeRange[0] : string.Empty; // "18:00"
                string endTime = timeRange.Length > 1 ? timeRange[1] : string.Empty; // "20:00"

                // Chuyển đổi định dạng giờ từ "HH:mm" sang "HH:mm" (giữ nguyên nếu đã đúng)
                if (!string.IsNullOrEmpty(startTime) && startTime.Length == 5 && startTime[2] == ':')
                    startTime = startTime.Replace(":", ";"); // "18;00"
                if (!string.IsNullOrEmpty(endTime) && endTime.Length == 5 && endTime[2] == ':')
                    endTime = endTime.Replace(":", ";"); // "20;00"

                return (daysOfWeek, startTime, endTime);
            }
            catch (Exception)
            {
                return (string.Empty, string.Empty, string.Empty);
            }
        }

        /// <summary>
        /// Chuyển đổi số ngày trong tuần từ tiếng Việt sang tiếng Anh
        /// </summary>
        /// <param name="dayNum">Số thứ tự ngày (2 = Monday, 3 = Tuesday, ...)</param>
        /// <returns>Tên ngày bằng tiếng Anh</returns>
        private string GetEnglishDayOfWeek(int dayNum)
        {
            string result = string.Empty;
            switch (dayNum)
            {
                case 2:
                    result = "Monday";
                    break;
                case 3:
                    result = "Tuesday";
                    break;
                case 4:
                    result = "Wednesday";
                    break;
                case 5:
                    result = "Thursday";
                    break;
                case 6:
                    result = "Friday";
                    break;
                case 7:
                    result = "Saturday";
                    break;
                case 1:
                    result = "Sunday";
                    break;
                default:
                    result = string.Empty;
                    break;
            }
            return result;
        }
    }
}
