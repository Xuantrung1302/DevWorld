using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Modals
{
    public class Post
    {
        public string NewsID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public string PostedBy { get; set; } // EmployeeID
        public string FullName { get; set; } // Thêm FullName từ EMPLOYEE
    }
}
