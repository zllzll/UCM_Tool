using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCM_Tools.Config;
using UCM_Tools.Radar.Communication;
using UCM_Tools.Radar.Protocols;

namespace UCM_Tools.Radar
{
    /// <summary>
    /// 根据类型全名获取对象
    /// </summary>
    public class ProtocolManage
    {
        public static IProtocol InitProtocol(string proStr)
        {
            string str_ClassType = $"UCM_Tools.Radar.Protocols.{proStr}";
            Type type = Type.GetType(str_ClassType);
            if (type == null)
                return null;
            object instance = Activator.CreateInstance(type);
            return (IProtocol)instance;
        }

        public static IConn InitConn(string connStr)
        {
            string str_ClassType = $"UCM_Tools.Radar.Communication.Conn_{connStr}";
            Type type = Type.GetType(str_ClassType);
            if (type == null)
                return null;
            object instance = Activator.CreateInstance(type);
            return (IConn)instance;
        }
    }
}
