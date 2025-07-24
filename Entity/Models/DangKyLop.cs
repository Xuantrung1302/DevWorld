using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    internal class DangKyLop
    {
        public string StudentID { get; set; }
        public string ClassID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string CompletionStatus { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
