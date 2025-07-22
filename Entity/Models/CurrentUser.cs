using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public static class CurrentUser
    {
        public static string UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
    }
}
