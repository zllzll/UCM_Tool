using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Camera
{
    /// <summary>
    /// 视频源列表项
    /// </summary>
    public class VideoSourceItem
    {
        public string Name { get; set; }
        public string Type { get; set; } // "usb" 或 "rtsp"
        public string ConnectionString { get; set; }

        public VideoSourceItem(string name, string type, string connectionString)
        {
            Name = name;
            Type = type;
            ConnectionString = connectionString;
        }

        public override string ToString() => Name;
    }
}
