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

}