﻿namespace Enity.Models
{
    public class NhanVien
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        // Foreign keys
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

}