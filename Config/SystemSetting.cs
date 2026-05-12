using CommonLib;
using Kitware.VTK;
using LogProc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using UCM_Tools.Tools;
using static CommonLib.ConfigXMLRadar;
using static UCM_Tools.CAN_Conn.CAN_Function;

namespace UCM_Tools.Config
{
    /// <summary>
    /// 配置文件 Nanoradar.config
    /// </summary>
    public class SystemSetting
    {
        // 全局变换对象
        public static vtkTransform GlobalTransform { get; private set; } = vtkTransform.New();

        /// <summary>
        /// 计算并应用非等比例缩放
        /// </summary>
        //public static void ApplyNonUniformScale()
        //{
        //    double rangeX = XMax - XMin;
        //    double rangeY = YMax - YMin;

        //    if (rangeY > 0 && rangeX > 0)
        //    {
        //        // 计算缩放因子，使视觉上接近正方形
        //        double scaleY = rangeX / rangeY;  // 如果Y长，则Y压缩

        //        GlobalTransform.Identity(); // 重置
        //        GlobalTransform.Scale(1.0, scaleY, 1.0); // X不变，Y压缩
        //    }
        //}
        /// <summary>
        /// 计算并应用非等比例缩放 - 改为放大短边，保持长边不变
        /// </summary>
        public static void ApplyNonUniformScale()
        {
            double rangeX = XMax - XMin;
            double rangeY = YMax - YMin;

            if (rangeY > 0 && rangeX > 0)
            {
                GlobalTransform.Identity(); // 重置

                if (rangeY > rangeX)
                {
                    // Y比X长，放大X轴，保持Y不变
                    double scaleX = rangeY / rangeX;
                    GlobalTransform.Scale(scaleX, 1.0, 1.0);
                }
                else
                {
                    // X比Y长或相等，放大Y轴，保持X不变
                    double scaleY = rangeX / rangeY;
                    GlobalTransform.Scale(1.0, scaleY, 1.0);
                }
            }
        }
        /// <summary>
        /// 将原始坐标转换为显示坐标（用于文本位置计算等）
        /// </summary>
        public static double[] TransformPoint(double x, double y, double z)
        {
            return GlobalTransform.TransformPoint(x, y, z);
        }

        private static bool _NonUniformScale = false;
        /// <summary>
        /// NonUniformScale
        /// </summary>
        public static bool NonUniformScale
        {
            get { return _NonUniformScale; }
            set
            {
                ConfigXML.SetKeyValue("NonUniformScale", value.ToString());
                _NonUniformScale = value;
            }
        }
        private static string _ThemeColor = "Default";
        /// <summary>
        /// 主题颜色 Default（自定义红黑）
        /// </summary>
        public static string ThemeColor
        {
            get { return _ThemeColor; }
            set
            {
                ConfigXML.SetKeyValue("ThemeColor", value.ToString());
                _ThemeColor = value;
            }
        }
        #region 图标参数

        private static int _PointSize;
        /// <summary>
        /// 3DVIew目标大小
        /// </summary>
        public static int PointSize
        {
            get { return _PointSize; }
            set
            {
                ConfigXML.SetKeyValue("PointSize", value.ToString());
                _PointSize = value;
            }
        }

        private static bool _View3D_ColorPan;
        /// <summary>
        /// 显示3DVIew颜色条
        /// </summary>
        public static bool View3D_ColorPan
        {
            get { return _View3D_ColorPan; }
            set
            {
                ConfigXML.SetKeyValue("View3D_ColorPan", value.ToString());
                _View3D_ColorPan = value;
            }
        }

        private static bool _DisplayText;
        /// <summary>
        /// 显示3D目标文本
        /// </summary>
        public static bool DisplayText
        {
            get { return _DisplayText; }
            set
            {
                ConfigXML.SetKeyValue("DisplayText", value.ToString());
                _DisplayText = value;
            }
        }
        private static bool _DisplayTrackText;
        /// <summary>
        /// 显示3D目标文本
        /// </summary>
        public static bool DisplayTrackText
        {
            get { return _DisplayTrackText; }
            set
            {
                ConfigXML.SetKeyValue("DisplayTrackText", value.ToString());
                _DisplayTrackText = value;
            }
        }
        private static int _DisplayTargetType;
        /// <summary>
        /// 0显示点云和跟踪；1显示点云；2：显示跟踪
        /// </summary>
        public static int DisplayTargetType
        {
            get { return _DisplayTargetType; }
            set
            {
                ConfigXML.SetKeyValue("DisplayTargetType", value.ToString());
                _DisplayTargetType = value;
            }
        }

        private static int _XMin;
        /// <summary>
        /// X轴最小值
        /// </summary>
        public static int XMin
        {
            get { return _XMin; }
            set
            {
                ConfigXML.SetKeyValue("XMin", value.ToString());
                _XMin = value;
            }
        }

        private static int _XMax;
        /// <summary>
        /// X轴最大值
        /// </summary>
        public static int XMax
        {
            get { return _XMax; }
            set
            {
                ConfigXML.SetKeyValue("XMax", value.ToString());
                _XMax = value;
            }
        }
        private static int _XStep;
        /// <summary>
        /// X轴步长 view3D
        /// </summary>
        public static int XStep
        {
            get { return _XStep; }
            set
            {
                ConfigXML.SetKeyValue("XStep", value.ToString());
                _XStep = value;
            }
        }
        private static int _YMin;
        /// <summary>
        /// Y轴最小值
        /// </summary>
        public static int YMin
        {
            get { return _YMin; }
            set
            {
                ConfigXML.SetKeyValue("YMin", value.ToString());
                _YMin = value;
            }
        }
        private static int _YMax;
        /// <summary>
        /// Y轴最大值
        /// </summary>
        public static int YMax
        {
            get { return _YMax; }
            set
            {
                ConfigXML.SetKeyValue("YMax", value.ToString());
                _YMax = value;
            }
        }
        private static int _YStep;
        /// <summary>
        /// Y轴步长 view3D
        /// </summary>
        public static int YStep
        {
            get { return _YStep; }
            set
            {
                ConfigXML.SetKeyValue("YStep", value.ToString());
                _YStep = value;
            }
        }

        private static int _ZMin;
        /// <summary>
        /// Z轴最大值
        /// </summary>
        public static int ZMin
        {
            get { return _ZMin; }
            set
            {
                ConfigXML.SetKeyValue("ZMin", value.ToString());
                _ZMin = value;
            }
        }

        private static int _ZMax;
        /// <summary>
        /// Z轴最大值
        /// </summary>
        public static int ZMax
        {
            get { return _ZMax; }
            set
            {
                ConfigXML.SetKeyValue("ZMax", value.ToString());
                _ZMax = value;
            }
        }
        private static int _CumulativeFrameNum;
        /// <summary>
        /// 累计多少帧显示
        /// </summary>
        public static int CumulativeFrameNum
        {
            get { return _CumulativeFrameNum; }
            set
            {
                ConfigXML.SetKeyValue("CumulativeFrameNum", value.ToString());
                _CumulativeFrameNum = value;
            }
        }
        private static int _CumulativeFrameType;
        /// <summary>
        /// 累计帧数方式
        /// 0：超过CumulativeFrameNum帧数之后一直保持最新CumulativeFrameNum帧数
        /// 1：超过CumulativeFrameNum帧数之后清空重新累计
        /// </summary>
        public static int CumulativeFrameType
        {
            get { return _CumulativeFrameType; }
            set
            {
                ConfigXML.SetKeyValue("CumulativeFrameType", value.ToString());
                _CumulativeFrameType = value;
            }
        }
        private static bool _HardwareAcc;
        /// <summary>
        /// 累计多少帧显示
        /// </summary>
        public static bool HardwareAcc
        {
            get { return _HardwareAcc; }
            set
            {
                ConfigXML.SetKeyValue("HardwareAcc", value.ToString());
                _HardwareAcc = value;
            }
        }
        private static bool _UseScreenSpaceText;
        /// <summary>
        /// true=屏幕空间2D文本（高性能），false=世界空间3D文本（高质量）
        /// </summary>
        public static bool UseScreenSpaceText
        {
            get { return _UseScreenSpaceText; }
            set
            {
                ConfigXML.SetKeyValue("UseScreenSpaceText", value.ToString());
                _UseScreenSpaceText = value;
            }
        }
        private static int _Max2DTextCount;
        /// <summary>
        /// 2D文本最大显示数量（0=不限制）
        /// </summary>
        public static int Max2DTextCount
        {
            get { return _Max2DTextCount; }
            set
            {
                ConfigXML.SetKeyValue("Max2DTextCount", value.ToString());
                _Max2DTextCount = value;
            }
        }
        private static int _Max3DTextCount;
        /// <summary>
        /// 通过 Max3DTextCount 控制显示数量，避免过度绘制
        /// 警告：超过30个3D文本时，性能会急剧下降。建议改用2D文本（vtkTextActor）或标签跟随算法（只显示视野中心的文本）。
        /// </summary>
        public static int Max3DTextCount
        {
            get { return _Max3DTextCount; }
            set
            {
                ConfigXML.SetKeyValue("Max3DTextCount", value.ToString());
                _Max3DTextCount = value;
            }
        }
        private static int _Grid_Size;
        /// <summary>
        /// 空间哈希网格筛选目标 单位m
        /// </summary>
        public static int Grid_Size
        {
            get { return _Grid_Size; }
            set
            {
                ConfigXML.SetKeyValue("Grid_Size", value.ToString());
                _Grid_Size = value;
            }
        }
        /// <summary>
        /// 是否自动隐藏被遮挡的目标文本（仅2D文本有效）
        /// </summary>
        public static bool HideOccludedText { get; set; } = false; // 可选优化
        private static bool _EnableVtkObjectPool;
        /// <summary>
        /// 是否启用VTK对象池优化（禁用可减少内存但降低性能）
        /// 启用时：vtkTextActor3D 对象被复用，避免每帧创建/销毁
        /// 禁用时：文本Actor在清理时直接销毁，内存占用略低但GC频繁
        /// 建议：在系统设置界面添加复选框，让用户在"高性能模式"和"节能模式"间选择。
        /// </summary>
        public static bool EnableVtkObjectPool
        {
            get { return _EnableVtkObjectPool; }
            set
            {
                ConfigXML.SetKeyValue("EnableVtkObjectPool", value.ToString());
                _EnableVtkObjectPool = value;
            }
        }
        #endregion 图标参数

        #region 数据存储参数

        private static bool _TargetData;
        /// <summary>
        /// 数据存储是否开启
        /// </summary>
        public static bool TargetData
        {
            get { return _TargetData; }
            set
            {
                ConfigXML.SetKeyValue("TargetData", value.ToString());
                _TargetData = value;
            }
        }
        private static int _FileSize;
        /// <summary>
        /// 文件存储行数
        /// </summary>
        public static int FileSize
        {
            get { return _FileSize; }
            set
            {
                ConfigXML.SetKeyValue("FileSize", value.ToString());
                _FileSize = value;
            }
        }
        private static string _FileRoute;
        /// <summary>
        /// 文件存储路径
        /// </summary>
        public static string FileRoute
        {
            get { return _FileRoute; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("FileRoute", value.ToString());
                    _FileRoute = value;
                }
            }
        }
        #endregion 数据存储参数

        #region 连接配置

        private static string _RadarType;
        /// <summary>
        /// 雷达型号
        /// </summary>
        public static string RadarType
        {
            get { return _RadarType; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("RadarType", value.ToString());
                    _RadarType = value;
                }
            }
        }
        private static string _ConnType;
        /// <summary>
        /// 通讯方式 TCP/CAN/COM
        /// </summary>
        public static string ConnType
        {
            get { return _ConnType; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("ConnType", value.ToString());
                    _ConnType = value;
                }
            }
        }
        private static string _Zlg_Type;
        /// <summary>
        /// 周立功CAN类型 CAN/CANFD
        /// </summary>
        public static string Zlg_Type
        {
            get { return _Zlg_Type; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("Zlg_Type", value.ToString());
                    _Zlg_Type = value;
                }
            }
        }
        private static CAN_Factory _CAN_Company;
        /// <summary>
        /// CAN设备制造商
        /// </summary>
        public static CAN_Factory CAN_Company
        {
            get { return _CAN_Company; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("CAN_Company", EnumCls.GetEnumDescription<CAN_Factory>(value));
                    _CAN_Company = value;
                }
            }
        }

        private static string _Zlg_CAN_Type;
        /// <summary>
        /// CAN型号
        /// </summary>
        public static string Zlg_CAN_Type
        {
            get { return _Zlg_CAN_Type; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("Zlg_CAN_Type", value.ToString());
                    _Zlg_CAN_Type = value;
                }
            }
        }

        private static uint _CAN_Index;
        /// <summary>
        /// 设备索引号
        /// </summary>
        public static uint CAN_Index
        {
            get { return _CAN_Index; }
            set
            {
                ConfigXML.SetKeyValue("CAN_Index", value.ToString());
                _CAN_Index = value;
            }
        }

        private static int _CAN_Channel;
        /// <summary>
        /// 设备通道
        /// </summary>
        public static int CAN_Channel
        {
            get { return _CAN_Channel; }
            set
            {

                ConfigXML.SetKeyValue("CAN_Channel", value.ToString());
                _CAN_Channel = value;
            }
        }

        private static int _WorkMode;
        /// <summary>
        /// 工作模式
        /// </summary>
        public static int WorkMode
        {
            get { return _WorkMode; }
            set
            {
                ConfigXML.SetKeyValue("WorkMode", value.ToString());
                _WorkMode = value;
            }
        }

        private static int _CANFD_Standard;
        /// <summary>
        /// CANFD标准
        /// </summary>
        public static int CANFD_Standard
        {
            get { return _CANFD_Standard; }
            set
            {
                ConfigXML.SetKeyValue("CANFD_Standard", value.ToString());
                _CANFD_Standard = value;
            }
        }

        private static UInt32 _CANFD_Baud_Abit;
        /// <summary>
        /// 仲裁域波特率
        /// </summary>
        public static UInt32 CANFD_Baud_Abit
        {
            get { return _CANFD_Baud_Abit; }
            set
            {
                ConfigXML.SetKeyValue("CANFD_Baud_Abit", value.ToString("X"));
                _CANFD_Baud_Abit = value;
            }
        }

        private static UInt32 _CANFD_Baud_Dbit;
        /// <summary>
        /// 数据域波特率
        /// </summary>
        public static UInt32 CANFD_Baud_Dbit
        {
            get { return _CANFD_Baud_Dbit; }
            set
            {
                ConfigXML.SetKeyValue("CANFD_Baud_Dbit", value.ToString("X"));
                _CANFD_Baud_Dbit = value;
            }
        }

        private static UInt32 _CAN_Baud;
        /// <summary>
        /// CAN波特率
        /// </summary>
        public static UInt32 CAN_Baud
        {
            get { return _CAN_Baud; }
            set
            {
                ConfigXML.SetKeyValue("CAN_Baud", value.ToString("X"));
                _CAN_Baud = value;
            }
        }
        private static string _TCP_IP;
        /// <summary>
        /// TCP IP
        /// </summary>
        public static string TCP_IP
        {
            get { return _TCP_IP; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("TCP_IP", value.ToString());
                    _TCP_IP = value;
                }
            }
        }
        private static int _TCP_Port;
        /// <summary>
        /// TCP Port
        /// </summary>
        public static int TCP_Port
        {
            get { return _TCP_Port; }
            set
            {
                ConfigXML.SetKeyValue("TCP_Port", value.ToString());
                _TCP_Port = value;
            }
        }
        private static string _COM_No;
        /// <summary>
        /// 串口号
        /// </summary>
        public static string COM_No
        {
            get { return _COM_No; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("COM_No", value.ToString());
                    _COM_No = value;
                }
            }
        }
        private static int _COM_Baud;
        /// <summary>
        /// 串口波特率
        /// </summary>
        public static int COM_Baud
        {
            get { return _COM_Baud; }
            set
            {
                ConfigXML.SetKeyValue("COM_Baud", value.ToString());
                _COM_Baud = value;
            }
        }
        private static string _COM_Parity;
        /// <summary>
        /// 校验位
        /// </summary>
        public static string COM_Parity
        {
            get { return _COM_Parity; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("COM_Parity", value.ToString());
                    _COM_Parity = value;
                }
            }
        }
        private static string _COM_DataBit;
        /// <summary>
        /// 数据位
        /// </summary>
        public static string COM_DataBit
        {
            get { return _COM_DataBit; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("COM_DataBit", value.ToString());
                    _COM_DataBit = value;
                }
            }
        }
        private static string _COM_StopBit;
        /// <summary>
        /// 停止位
        /// </summary>
        public static string COM_StopBit
        {
            get { return _COM_StopBit; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("COM_StopBit", value.ToString());
                    _COM_StopBit = value;
                }
            }
        }
        #endregion 连接配置

        #region 颜色匹配高度
        private static bool _Default_Color;
        /// <summary>
        /// 是否默认颜色
        /// </summary>
        public static bool Default_Color
        {
            get { return _Default_Color; }
            set
            {
                ConfigXML.SetKeyValue("DefaultColor", value.ToString());
                _Default_Color = value;
            }
        }

        private static int _RedValue;
        /// <summary>
        /// 超过该值都为红色（不包含该值）
        /// </summary>
        public static int RedValue
        {
            get { return _RedValue; }
            set
            {
                ConfigXML.SetKeyValue("RedValue", value.ToString());
                _RedValue = value;
            }
        }
        private static int _OrangeValue;
        /// <summary>
        /// 小于红色值大于该值为橙色（不包含该值）
        /// </summary>
        public static int OrangeValue
        {
            get { return _OrangeValue; }
            set
            {
                ConfigXML.SetKeyValue("OrangeValue", value.ToString());
                _OrangeValue = value;
            }
        }
        private static int _YellowValue;
        /// <summary>
        /// 小于橙色值大于该值为黄色（不包含该值）
        /// </summary>
        public static int YellowValue
        {
            get { return _YellowValue; }
            set
            {
                ConfigXML.SetKeyValue("YellowValue", value.ToString());
                _YellowValue = value;
            }
        }
        private static int _GreenValue;
        /// <summary>
        /// 小于黄色值大于该值为绿色（不包含该值）
        /// </summary>
        public static int GreenValue
        {
            get { return _GreenValue; }
            set
            {
                ConfigXML.SetKeyValue("GreenValue", value.ToString());
                _GreenValue = value;
            }
        }
        private static int _CyanValue;
        /// <summary>
        /// 小于绿色值大于该值为青色（不包含该值）
        /// </summary>
        public static int CyanValue
        {
            get { return _CyanValue; }
            set
            {
                ConfigXML.SetKeyValue("CyanValue", value.ToString());
                _CyanValue = value;
            }
        }
        private static int _BlueValue;
        /// <summary>
        /// 小于青色值大于该值为蓝色（不包含该值）小于该值为紫色
        /// </summary>
        public static int BlueValue
        {
            get { return _BlueValue; }
            set
            {
                ConfigXML.SetKeyValue("BlueValue", value.ToString());
                _BlueValue = value;
            }
        }
        #endregion 颜色匹配高度

        #region 文本配置
        private static bool _Tar_ID;
        /// <summary>
        /// 显示ID
        /// </summary>
        public static bool Tar_ID
        {
            get { return _Tar_ID; }
            set
            {
                ConfigXML.SetKeyValue("Tar_ID", value.ToString());
                _Tar_ID = value;
            }
        }
        private static bool _Tar_X;
        /// <summary>
        /// 显示X
        /// </summary>
        public static bool Tar_X
        {
            get { return _Tar_X; }
            set
            {
                ConfigXML.SetKeyValue("Tar_X", value.ToString());
                _Tar_X = value;
            }
        }
        private static bool _Tar_Y;
        /// <summary>
        /// 显示Y
        /// </summary>
        public static bool Tar_Y
        {
            get { return _Tar_Y; }
            set
            {
                ConfigXML.SetKeyValue("Tar_Y", value.ToString());
                _Tar_Y = value;
            }
        }
        private static bool _Tar_Z;
        /// <summary>
        /// 显示Z
        /// </summary>
        public static bool Tar_Z
        {
            get { return _Tar_Z; }
            set
            {
                ConfigXML.SetKeyValue("Tar_Z", value.ToString());
                _Tar_Z = value;
            }
        }
        private static bool _Tar_V;
        /// <summary>
        /// 显示V
        /// </summary>
        public static bool Tar_V
        {
            get { return _Tar_V; }
            set
            {
                ConfigXML.SetKeyValue("Tar_V", value.ToString());
                _Tar_V = value;
            }
        }
        private static bool _Tar_A;
        /// <summary>
        /// 显示A
        /// </summary>
        public static bool Tar_A
        {
            get { return _Tar_A; }
            set
            {
                ConfigXML.SetKeyValue("Tar_A", value.ToString());
                _Tar_A = value;
            }
        }
        private static bool _Tar_C;
        /// <summary>
        /// 显示C
        /// </summary>
        public static bool Tar_C
        {
            get { return _Tar_C; }
            set
            {
                ConfigXML.SetKeyValue("Tar_C", value.ToString());
                _Tar_C = value;
            }
        }
        #endregion 文本配置

        private static bool _ShowDataReplay;
        /// <summary>
        /// 显示数据回放按钮
        /// </summary>
        public static bool ShowDataReplay
        {
            get { return _ShowDataReplay; }
            set
            {
                ConfigXML.SetKeyValue("ShowDataReplay", value.ToString());
                _ShowDataReplay = value;
            }
        }
        private static int _DataReplayFormatType;
        /// <summary>
        /// 数据回放格式类型
        /// </summary>
        public static int DataReplayFormatType
        {
            get { return _DataReplayFormatType; }
            set
            {
                ConfigXML.SetKeyValue("DataReplayFormatType", value.ToString());
                _DataReplayFormatType = value;
            }
        }
        private static int _DataReplayFrameCycle;
        /// <summary>
        /// 数据回放格式类型
        /// </summary>
        public static int DataReplayFrameCycle
        {
            get { return _DataReplayFrameCycle; }
            set
            {
                ConfigXML.SetKeyValue("DataReplayFrameCycle", value.ToString());
                _DataReplayFrameCycle = value;
            }
        }

      
        private static bool _B_AddTimestamp;
        /// <summary>
        /// 是否加时间戳
        /// </summary>
        public static bool B_AddTimestamp
        {
            get { return _B_AddTimestamp; }
            set
            {
                ConfigXML.SetKeyValue("B_AddTimestamp", value.ToString());
                _B_AddTimestamp = value;
            }
        }

        private static string _RTSPStream;
        /// <summary>
        /// 历史视频流
        /// </summary>
        public static string RTSPStream
        {
            get { return _RTSPStream; }
            set
            {
                if (value != null)
                {
                    ConfigXML.SetKeyValue("RTSPStream", value.ToString());
                    _RTSPStream = value;
                }
            }
        }
        private static int _SendWaitTime;
        /// <summary>
        /// 升级发送0x104等待时间
        /// </summary>
        public static int SendWaitTime
        {
            get { return _SendWaitTime; }
            set
            {
                ConfigXML.SetKeyValue("SendWaitTime", value.ToString());
                _SendWaitTime = value;
            }
        }
        private static double _TrackSize;
        /// <summary>
        /// 球体半径  跟踪目标球体半径
        /// </summary>
        public static double TrackSize
        {
            get { return _TrackSize; }
            set
            {
                ConfigXML.SetKeyValue("TrackSize", value.ToString());
                _TrackSize = value;
            }
        }
        private static Color _TrackColor = Color.Red; 
        /// <summary>
        /// 跟踪点颜色
        /// </summary>
        public static Color TrackColor
        {
            get { return _TrackColor; }
            set
            {
                ConfigXML.SetKeyValue("TrackColor", value.ToArgb().ToString());
                _TrackColor = value;
            }
        }
        private static Color _TrackTextColor = Color.Red; 
        /// <summary>
        /// 跟踪点颜色
        /// </summary>
        public static Color TrackTextColor
        {
            get { return _TrackTextColor; }
            set
            {
                ConfigXML.SetKeyValue("TrackTextColor", value.ToArgb().ToString());
                _TrackTextColor = value;
            }
        }
        private static int _TrackTextSize = 25; 
        /// <summary>
        /// 跟踪点颜色
        /// </summary>
        public static int TrackTextSize
        {
            get { return _TrackTextSize; }
            set
            {
                ConfigXML.SetKeyValue("TrackTextSize", value.ToString());
                _TrackTextSize = value;
            }
        }
        private static int _TrackColorMode = 0; 
        /// <summary>
        /// 跟踪点颜色模式
        /// </summary>
        public static int TrackColorMode
        {
            get { return _TrackColorMode; }
            set
            {
                ConfigXML.SetKeyValue("TrackColorMode", value.ToString());
                _TrackColorMode = value;
            }
        }
        #region 跟踪轨迹相关参数
        private static bool _DisplayTrackTrajectory = true;      // 
        /// <summary>
        /// 是否显示跟踪轨迹
        /// </summary>
        public static bool DisplayTrackTrajectory
        {
            get { return _DisplayTrackTrajectory; }
            set
            {
                ConfigXML.SetKeyValue("DisplayTrackTrajectory", value.ToString());
                _DisplayTrackTrajectory = value;
            }
        }
        private static float _TrackTrajectoryLineWidth = 2.0f;   // 
        /// <summary>
        /// 跟踪轨迹线宽
        /// </summary>
        public static float TrackTrajectoryLineWidth
        {
            get { return _TrackTrajectoryLineWidth; }
            set
            {
                ConfigXML.SetKeyValue("TrackTrajectoryLineWidth", value.ToString());
                _TrackTrajectoryLineWidth = value;
            }
        }
        private static Color _TrackTrajectoryColor = Color.Green; // 轨迹颜色
        /// <summary>
        /// 跟踪轨迹线宽
        /// </summary>
        public static Color TrackTrajectoryColor
        {
            get { return _TrackTrajectoryColor; }
            set
            {
                ConfigXML.SetKeyValue("TrackTrajectoryColor", value.ToArgb().ToString());
                _TrackTrajectoryColor = value;
            }
        }
        private static int _TrackTrajectoryPointCount = 50;
        /// <summary>
        /// 单目标轨迹点数（默认50）
        /// </summary>
        public static int TrackTrajectoryPointCount
        {
            get { return _TrackTrajectoryPointCount; }
            set
            {
                ConfigXML.SetKeyValue("TrackTrajectoryPointCount", value.ToString());
                _TrackTrajectoryPointCount = value;
            }
        }
        private static int _ClearTrackTrajectoryType = 0;
        /// <summary>
        /// 清除轨迹方式   0：超时清除；其他没有这个ID就清除
        /// </summary>
        public static int ClearTrackTrajectoryType
        {
            get { return _ClearTrackTrajectoryType; }
            set
            {
                ConfigXML.SetKeyValue("ClearTrackTrajectoryType", value.ToString());
                _ClearTrackTrajectoryType = value;
            }
        }
        private static int _TrackTrajectoryTime = 1000;
        /// <summary>
        /// 单目标轨迹未出现时间清除   单位ms
        /// </summary>
        public static int TrackTrajectoryTime
        {
            get { return _TrackTrajectoryTime; }
            set
            {
                ConfigXML.SetKeyValue("TrackTrajectoryTime", value.ToString());
                _TrackTrajectoryTime = value;
            }
        }
        #endregion 跟踪轨迹相关参数
        private static int _GetTimeType = 0;
        /// <summary>
        /// 若协议中存在帧时间时使用。点云和跟踪目标周期时间的取值 0：取获取完整帧时间 1:取雷达提供的时间
        /// </summary>
        public static int GetTimeType
        {
            get { return _GetTimeType; }
            set
            {
                ConfigXML.SetKeyValue("GetTimeType", value.ToString());
                _GetTimeType = value;
            }
        }
        private static bool _VTKBackColor = false;
        /// <summary>
        /// VTK背景颜色 true:白色
        /// </summary>
        public static bool VTKBackColor
        {
            get { return _VTKBackColor; }
            set
            {
                ConfigXML.SetKeyValue("VTKBackColor", value.ToString());
                _VTKBackColor = value;
            }
        }
        private static int _WaitUpgradeEndTime = 0;
        /// <summary>
        /// 部分雷达需升级完成回复后等待雷达升级重启 单位毫秒  0时不等待
        /// </summary>
        public static int WaitUpgradeEndTime
        {
            get { return _WaitUpgradeEndTime; }
            set
            {
                ConfigXML.SetKeyValue("WaitUpgradeEndTime", value.ToString());
                _WaitUpgradeEndTime = value;
            }
        }
        private static int _VtkDrawTimeInLostFocus = 0;
        /// <summary>
        /// 代表1、VTK失去焦点的时候多久渲染一次所有对象  2、没失去焦点时多久渲染一次文本
        /// </summary>
        public static int VtkDrawTimeInLostFocus
        {
            get { return _VtkDrawTimeInLostFocus; }
            set
            {
                ConfigXML.SetKeyValue("VtkDrawTimeInLostFocus", value.ToString());
                _VtkDrawTimeInLostFocus = value;
            }
        }
        /// <summary>
        /// 配置文件初始化
        /// </summary>
        public static void Init()
        {
            try
            {
                _NonUniformScale =  bool.Parse(ConfigXML.GetKeyString("NonUniformScale", "false"));
                _ThemeColor = ConfigXML.GetKeyString("ThemeColor", "Default");
                #region 图标参数
                _PointSize = int.Parse(ConfigXML.GetKeyString("PointSize", "3"));
                _View3D_ColorPan = bool.Parse(ConfigXML.GetKeyString("View3D_ColorPan", "false"));
                _DisplayText = bool.Parse(ConfigXML.GetKeyString("DisplayText", "false"));
                _DisplayTrackText = bool.Parse(ConfigXML.GetKeyString("DisplayTrackText", "false"));
                _DisplayTargetType = int.Parse(ConfigXML.GetKeyString("DisplayTargetType", "0"));
                _XMin = int.Parse(ConfigXML.GetKeyString("XMin", "0"));
                _XMax = int.Parse(ConfigXML.GetKeyString("XMax", "0"));
                _XStep = int.Parse(ConfigXML.GetKeyString("XStep", "0"));
                _YMin = int.Parse(ConfigXML.GetKeyString("YMin", "0"));
                _YMax = int.Parse(ConfigXML.GetKeyString("YMax", "0"));
                _YStep = int.Parse(ConfigXML.GetKeyString("YStep", "0"));
                _ZMin = int.Parse(ConfigXML.GetKeyString("ZMin", "0"));
                _ZMax = int.Parse(ConfigXML.GetKeyString("ZMax", "0"));
                _CumulativeFrameNum = int.Parse(ConfigXML.GetKeyString("CumulativeFrameNum", "1"));
                _CumulativeFrameType= int.Parse(ConfigXML.GetKeyString("CumulativeFrameType", "0"));
                _HardwareAcc = bool.Parse(ConfigXML.GetKeyString("HardwareAcc", "false"));
                #endregion 图标参数

                #region 数据存储
                _TargetData = bool.Parse(ConfigXML.GetKeyString("TargetData", "false"));
                _FileSize = int.Parse(ConfigXML.GetKeyString("FileSize", "0"));
                _FileRoute = ConfigXML.GetKeyString("FileRoute", "C:\\SR75_Data\\");
                #endregion 数据存储

                #region 连接配置
                _RadarType = ConfigXML.GetKeyString("RadarType", "TCM211");
                _ConnType = ConfigXML.GetKeyString("ConnType", "TCP");//TCP或CANFD
                _CAN_Company = EnumCls.GetEnum<CAN_Factory>(ConfigXML.GetKeyString("CAN_Company", "ZLG"));//TCP或CANFD
                _Zlg_Type = ConfigXML.GetKeyString("Zlg_Type", "CAN");//CAN或CANFD
                _Zlg_CAN_Type = ConfigXML.GetKeyString("Zlg_CAN_Type", "USBCANFD-200U");
                _CAN_Index = uint.Parse(ConfigXML.GetKeyString("CAN_Index", "0"));
                _CAN_Channel = int.Parse(ConfigXML.GetKeyString("CAN_Channel", "0"));
                _WorkMode = int.Parse(ConfigXML.GetKeyString("WorkMode", "0"));
                _CANFD_Standard = int.Parse(ConfigXML.GetKeyString("CANFD_Standard", "0"));
                _CANFD_Baud_Abit = Convert.ToUInt32(ConfigXML.GetKeyString("CANFD_Baud_Abit", "0x00018B2E"), 16);
                _CANFD_Baud_Dbit = Convert.ToUInt32(ConfigXML.GetKeyString("CANFD_Baud_Dbit", "0x00010207"), 16);
                _CAN_Baud = Convert.ToUInt32(ConfigXML.GetKeyString("CAN_Baud", "0x0014"), 16);
                _TCP_IP = ConfigXML.GetKeyString("TCP_IP", "192.168.1.123");
                _TCP_Port = int.Parse(ConfigXML.GetKeyString("TCP_Port", "50000"));
                _COM_No = ConfigXML.GetKeyString("COM_No", "COM1");
                _COM_Baud = int.Parse(ConfigXML.GetKeyString("COM_Baud", "115200"));
                _COM_Parity = ConfigXML.GetKeyString("COM_Parity", "None");
                _COM_DataBit = ConfigXML.GetKeyString("COM_DataBit", "8");
                _COM_StopBit = ConfigXML.GetKeyString("COM_StopBit", "One");
                #endregion 连接配置

                #region 颜色匹配高度
                _Default_Color = bool.Parse(ConfigXML.GetKeyString("DefaultColor", "false"));
                _RedValue = int.Parse(ConfigXML.GetKeyString("RedValue", "1000"));
                _OrangeValue = int.Parse(ConfigXML.GetKeyString("OrangeValue", "4"));
                _YellowValue = int.Parse(ConfigXML.GetKeyString("YellowValue", "3"));
                _GreenValue = int.Parse(ConfigXML.GetKeyString("GreenValue", "2"));
                _CyanValue = int.Parse(ConfigXML.GetKeyString("CyanValue", "1"));
                _BlueValue = int.Parse(ConfigXML.GetKeyString("BlueValue", "0"));
                #endregion 颜色匹配高度
                #region 文本配置
                _UseScreenSpaceText = bool.Parse(ConfigXML.GetKeyString("UseScreenSpaceText", "false"));
                _EnableVtkObjectPool = bool.Parse(ConfigXML.GetKeyString("EnableVtkObjectPool", "false"));
                _Max2DTextCount = int.Parse(ConfigXML.GetKeyString("Max2DTextCount", "10"));
                _Max3DTextCount = int.Parse(ConfigXML.GetKeyString("Max3DTextCount", "10"));
                _Grid_Size = int.Parse(ConfigXML.GetKeyString("Grid_Size", "10"));
                _Tar_ID = bool.Parse(ConfigXML.GetKeyString("Tar_ID", "false"));
                _Tar_X = bool.Parse(ConfigXML.GetKeyString("Tar_X", "false"));
                _Tar_Y = bool.Parse(ConfigXML.GetKeyString("Tar_Y", "false"));
                _Tar_Z = bool.Parse(ConfigXML.GetKeyString("Tar_Z", "false"));
                _Tar_V = bool.Parse(ConfigXML.GetKeyString("Tar_V", "false"));
                _Tar_A = bool.Parse(ConfigXML.GetKeyString("Tar_A", "false"));
                _Tar_C = bool.Parse(ConfigXML.GetKeyString("Tar_C", "false"));
                #endregion 文本配置
                _ShowDataReplay = bool.Parse(ConfigXML.GetKeyString("ShowDataReplay", "false"));
                _DataReplayFormatType = int.Parse(ConfigXML.GetKeyString("DataReplayFormatType", "0"));
                _DataReplayFrameCycle = int.Parse(ConfigXML.GetKeyString("DataReplayFrameCycle", "100"));
                _B_AddTimestamp = bool.Parse(ConfigXML.GetKeyString("B_AddTimestamp", "false"));
                _RTSPStream = ConfigXML.GetKeyString("RTSPStream", "rtsp://192.168.10.66/live/0");
                _SendWaitTime = int.Parse(ConfigXML.GetKeyString("SendWaitTime", "0"));
                _TrackSize = double.Parse(ConfigXML.GetKeyString("TrackSize", "0.3"));
                int.TryParse(ConfigXML.GetKeyString("TrackColor", "255"), out int colorTrack);
                _TrackColor = Color.FromArgb(colorTrack);
                int.TryParse(ConfigXML.GetKeyString("TrackColorMode", "0"), out _TrackColorMode);
                int.TryParse(ConfigXML.GetKeyString("TrackTextColor", "255"), out int colorTrackText);
                _TrackTextColor = Color.FromArgb(colorTrackText); 
                int.TryParse(ConfigXML.GetKeyString("TrackTextSize", "255"), out _TrackTextSize);
                #region 跟踪轨迹
                _DisplayTrackTrajectory = bool.Parse(ConfigXML.GetKeyString("DisplayTrackTrajectory", "false"));
                float.TryParse(ConfigXML.GetKeyString("TrackTrajectoryLineWidth", "1"),out _TrackTrajectoryLineWidth);
                int.TryParse(ConfigXML.GetKeyString("TrackTrajectoryColor", "255"),out int colorTrackTrajectory);
                _TrackTrajectoryColor = Color.FromArgb(colorTrackTrajectory);
                int.TryParse(ConfigXML.GetKeyString("TrackTrajectoryPointCount", "255"), out _TrackTrajectoryPointCount);
                int.TryParse(ConfigXML.GetKeyString("TrackTrajectoryTime", "1000"), out _TrackTrajectoryTime);
                int.TryParse(ConfigXML.GetKeyString("ClearTrackTrajectoryType", "0"), out _ClearTrackTrajectoryType);
                #endregion 跟踪轨迹
                int.TryParse(ConfigXML.GetKeyString("GetTimeType", "0"), out _GetTimeType);
                _VTKBackColor = bool.Parse(ConfigXML.GetKeyString("VTKBackColor", "false"));
                int.TryParse(ConfigXML.GetKeyString("WaitUpgradeEndTime", "0"), out _WaitUpgradeEndTime);
                int.TryParse(ConfigXML.GetKeyString("VtkDrawTimeInLostFocus", "250"), out _VtkDrawTimeInLostFocus);
            }
            catch (Exception _ex)
            {
                Log.Error("System Init Failed\r\n" + _ex.ToString());
            }
        }

    }
}
