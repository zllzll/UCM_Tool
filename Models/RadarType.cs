using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Models
{
    public class RadarType
    {
        public string RadarNo { get; set; }
        public string RadarName { get; set; }
    }

    public enum ConnState
    {
        Reconnecting,//重连中
        Connected,//连接成功
        Disconnected,//连接失败
    }
}
