using UCM_Tools.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCM_Tools.CAN_Conn;

namespace UCM_Tools.Tools
{
    public class TargetInfo
    {
        public List<double> _X = new List<double>();                 //当前显示横轴
        public List<double> _Y = new List<double>();                //当前显示纵轴
        public List<double> _Z = new List<double>();                 //当前显示Z高度
        public List<string> _PlotText = new List<string>();        //当前显示文本
        public List<string> _PlotTextX_Z = new List<string>();        //当前显示文本

        public TargetInfo()
        {
            _X = new List<double>();
            _Y = new List<double>();
            _Z = new List<double>();
            _PlotText = new List<string>();
            _PlotTextX_Z = new List<string>();
        }
        /// <summary>
        /// 目标信息
        /// </summary>
        public struct RadarTargetInfoStruct
        {
            public uint ID;
            public uint Num;
            public int Type;//动态属性
            public int Class;//类型
            public double Range;
            public double PAngle;//水平角度
            public double TAngle;//俯仰角度
            public double Vx;
            public double Vy;
            public double Velocity;
            public double XAxis;
            public double YAxis;
            public double ZAxis;
            public double RCS;
            public double SNR;//信噪比
            public string SaveTime;
            public string RadarAdd;
            public double RadarAcc;//加速度
            public string RadarType;
            public int Confidence;//置信度
        };

        public void SetInfo(RadarTargetInfoStruct tar)
        {
            try
            {

                this._X.Add(tar.XAxis);
                this._Y.Add(tar.YAxis);
                this._Z.Add(tar.ZAxis);
                string str_All = string.Empty;
                string str_X_Z = string.Empty;
                if (SystemSetting.Tar_ID)
                {
                    str_All += $"ID={tar.ID} ";
                    str_X_Z += $"ID={tar.ID} ";
                }
                if (SystemSetting.Tar_X)
                {
                    str_All += $"X={tar.XAxis.ToString("F2")} ";
                    str_X_Z += $"X={tar.XAxis.ToString("F2")} ";
                }
                if (SystemSetting.Tar_Y)
                    str_All += $"Y={tar.YAxis.ToString("F2")} ";
                if (SystemSetting.Tar_Z)
                {
                    //str_All += $"Z={tar.ZAxis.ToString("F2")} ";
                    str_X_Z += $"Z={tar.ZAxis.ToString("F2")} ";
                }
                //if (string.Compare(SystemSetting.Zlg_Type, EnumCls.GetEnumDescription(ZLG_TYPE.TYPE_CANFD), true) == 0)
                //{
                //    str_All += string.Format("ID={0} X={1} Y={2} Z={3}", tar.ID, tar.XAxis.ToString("F2"), tar.YAxis.ToString("F2"), tar.ZAxis.ToString("F2"));
                //}
                //else if (string.Compare(SystemSetting.Zlg_Type, EnumCls.GetEnumDescription(ZLG_TYPE.TYPE_CAN), true) == 0)
                //    str_All = string.Format("ID={0} X={1} Y={2} R={3}", tar.ID, tar.XAxis.ToString("F2"), tar.YAxis.ToString("F2"), tar.Range.ToString("F2"));
                //else
                //    str_All = string.Format("ID={0}", tar.ID);
                this._PlotText.Add(str_All);
                _PlotTextX_Z.Add(str_X_Z);
            }
            catch { }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        public void Clear()
        {
            _X.Clear();
            _Y.Clear();
            _Z.Clear();
            _PlotText.Clear();
            _PlotTextX_Z.Clear();
        }
    }
}
