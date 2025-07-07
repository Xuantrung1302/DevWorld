using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace Enity.Models
{
    public class LopHoc
    {
        public string ClassName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Room { get; set; }
        public string Teacher { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class SelectItems
    {
        public string SelectText { get; set; }
        public byte SelectValue { get; set; }
    }

}