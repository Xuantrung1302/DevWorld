using System;
using System.Collections.Generic;

namespace Enity.Models
{
    public class GiangVien
    {

        public string TeacherID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Degree { get; set; }

        // Foreign key
        public string Username { get; set; }
        //public TaiKhoan TaiKhoan { get; set; }
        public string Password { get; set; }
    }

    public class ThongTinGiangDay
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public Guid ClassScheduleID { get; set; }
        public DateTime Date { get; set; }
    }

    public class GiangVienResponse
    {
        public int TotalCount { get; set; }
        public List<GiangVien> Data { get; set; }
    }
}