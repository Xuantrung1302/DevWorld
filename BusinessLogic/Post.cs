using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class DataStore
    {
        public static List<Post> Posts { get; set; } = new List<Post>();
    }
    public class Post
    {
        public string MaBangTin { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string MaNV { get; set; }
        public DateTime CreateDate { get; set; }
    }

}
