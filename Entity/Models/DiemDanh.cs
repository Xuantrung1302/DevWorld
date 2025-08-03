using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class DiemDanh
    {
        public Guid ClassScheduleID { get; set; }
        public string RecordedBy { get; set; }
        public List<ChiTietDiemDanh> ChiTiet { get; set; }
    }

    public class ChiTietDiemDanh
    {
        public string StudentID { get; set; }
        public bool Status { get; set; }
        public string Notes { get; set; }
    }


    public class DiemDanhViewModel
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public bool Status { get; set; }
        public string Notes { get; set; }
    }

    public class BaoCaoDiemDanh
    {
        public Guid? AttendanceID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public bool Status { get; set; }
        public Guid Class_ScheID { get; set; }
        public string Notes { get; set; }
        public bool IsLearned { get; set; }
    }
}
