using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Models
{
    /// <summary>
    /// 功能 名字更改会导致发送命令改变
    /// </summary>
    public enum FuncTYType
    {
        getVer,//参数获取 获取版本
        reboot,//雷达重启
        getPara,//读取参数 
        setPara,//设置参数
        update,//升级
        upgrade,//升级
        setTime,//设置系统时间
    }
}
