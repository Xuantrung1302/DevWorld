using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class DiemDanh
    {
        public Guid AttendanceID { get; set; }
        public Guid Class_ScheID { get; set; }
        public DateTime StartTime { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public int Status { get; set; }
        public DateTime RecordedTime { get; set; }
        public string RecordedBy { get; set; }
        public string Notes { get; set; }
        public bool DELETE_FLG { get; set; }
    }

    public class DiemDanhViewModel
    {
        public Guid AttendanceID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public bool IsChecked { get; set; }
        public string Notes { get; set; }
    }
}
