﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public enum UserType { NhanVien, HocVien, GiangVien }
    public static class GlobalSettings
    {
        /// <summary>
        /// Đại diện cho cơ sở dữ liệu của chương trình
        /// </summary>


        /// <summary>
        /// Đại diện cho chuỗi kết nối
        /// </summary>
        public static string ConnectionString { get; set; }

        /// <summary>
        /// Đại diện cho mã người dùng đăng nhập
        /// </summary>
        public static string UserID { get; set; }

        /// <summary>
        /// Đại diện cho tên người dùng đăng nhập
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// Đại diện cho kiểu người dùng đăng nhập
        /// </summary>
        public static UserType UserType { get; set; }

        /// <summary>
        /// Đại diện cho tên server
        /// </summary>
        public static string ServerName { get; set; }

        /// <summary>
        /// Đại diện cho tên database
        /// </summary>
        public static string ServerCatalog { get; set; }

        /// <summary>
        /// Đại diện cho tên trung tâm
        /// </summary>
        public static string CenterName { get; set; }

        /// <summary>
        /// Đại diện cho địa chỉ trung tâm
        /// </summary>
        public static string CenterAddress { get; set; }

        /// <summary>
        /// Đại diện cho website trung tâm
        /// </summary>
        public static string CenterWebsite { get; set; }

        /// <summary>
        /// Đại diện cho email trung tâm
        /// </summary>
        public static string CenterEmail { get; set; }

        /// <summary>
        /// Đại diện cho số điện thoại trung tâm
        /// </summary>
        public static string CenterTelephone { get; set; }

        /// <summary>
        /// Đại diện cho danh sách quy định
        /// </summary>
        public static Dictionary<string, int> QuyDinh { get; set; }

        
    }

   
}
