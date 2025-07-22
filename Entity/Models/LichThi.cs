using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class LichThi
    {
        public Guid ClassID { get; set; }
        public string SubjectID { get; set; }
        public string ExamName { get; set; }
        public string ExamType { get; set; } // "Thi giữa kỳ", "Thi cuối kỳ"
        public DateTime ExamDateStart { get; set; }
        public DateTime ExamDateEnd { get; set; }
        public string Room { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
