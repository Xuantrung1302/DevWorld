using System;

namespace Entity.Models
{
    public class LopDay
    {
        public string TeacherID { get; set; }
        public string ClassName { get; set; }
        public string ClassID { get; set; }
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int DaysOfWeek { get; set; }
        public string Room { get; set; }
        public int StudentCount { get; set; }
        public string SemesterName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
