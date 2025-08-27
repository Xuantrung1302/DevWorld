using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Course
    {
        public Guid course_id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool delete_flg { get; set; }

        // ✅ Thay vì chỉ có Semester1, Semester2
        public List<Semester> Semesters { get; set; }
    }

    public class Semester
    {
        public string SemesterID { get; set; }
        public string SemesterName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Subject> Subjects { get; set; }
    }

    public class Subject
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public decimal TuitionFee { get; set; }
        public string SemesterID { get; set; }
    }
}
