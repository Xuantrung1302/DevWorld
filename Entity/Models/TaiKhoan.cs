using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enity.Models
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public ICollection<HocVien> HocViens { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }
        public ICollection<GiangVien> GiangViens { get; set; }
    }

    public class ChiTietTaiKhoan
    {
        public string Username { get; set; }
        public string Role { get; set; }
    }

    public class TaiKhoanResponse
    {
        public int TotalCount { get; set; }
        public List<ChiTietTaiKhoan> Data { get; set; }
    }
}