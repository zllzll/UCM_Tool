using UCM_Tools.Config;
using UCM_Tools.Tools;
using LogProc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZLGCAN;
using static UCM_Tools.CAN_Conn.CAN_Function;
using UCM_Tools.Radar.Communication;
namespace UCM_Tools.CAN_Conn
{
    public class CAN_Function
    {
        const int STATUS_ERR = 0;
        const int STATUS_OK = 1;
        static IProperty _property ;
        static IntPtr device_handle = IntPtr.Zero;//设备指针
        static IntPtr channel_handle = IntPtr.Zero;//通道指针
        static uint[] kAbitTiming =
        {
            1000000,//1Mbps
	        800000,//800kbps
	        500000,//500kbps
	        250000,//250kbps
	        125000,//125kbps
	        100000,//100kbps
	        50000 //50kbps
        };

        static uint[] kDbitTiming =
        {
            5000000,//5Mbps
	        4000000,//4Mbps
	        2000000,//2Mbps
	        1000000 //1Mbps
        };


        const uint CAN_ID_FLAG = 0x1FFFFFFFU; /* id */

        public enum CAN_Factory
        {
            [Description("ZLG")]
            ZLG= 0,//周立功
            [Description("CX")]
            CX = 1,//创芯
        }

        public enum ZLG_TYPE
        {
            [Description("CAN")]
            TYPE_CAN = 0,//CAN系列
            [Description("CANFD")]
            TYPE_CANFD = 1,//CANFD系列
        }

        /// <summary>
        /// CANFD类型   加入其他通讯方式
        /// </summary>
        public enum ZLG_CAN_TYPE
        {
            [Description("USBCAN1")]
            USBCAN1 = 3,
            [Description("USBCAN2")]
            USBCAN2 = 4,
            //CANETUDP = 12,
            //CANETTCP = 17,
            //USBCAN_E_U = 20,
            //USBCAN_2E_U = 21,
            //PCIECANFD_100U = 38,
            //PCIECANFD_200U = 39,
            //PCIECANFD_400U = 40,
            [Description("USBCANFD-200U")]
            USBCANFD_200U = 41,
            //[Description("USBCANFD-100U")]
            //USBCANFD_100U = 42,
            //[Description("USBCANFD-MINI")]
            //USBCANFD_MINI = 43,
        }
        /// <summary>
        /// 仲裁域波特率
        /// </summary>
        public enum CANFD_BAUD_ARBITRATE : int
        {
            [Description("1Mbps 80%")]
            ABIT_BAUD_1M = 0x00018B2E,//1Mbps
            [Description("800kbps 80%")]
            ABIT_BAUD_800K = 0x00018E3A,//800kbps
            [Description("500kbps 80%")]
            ABIT_BAUD_500K = 0x0001975E,//500kbps
            [Description("250kbps 80%")]
            ABIT_BAUD_250K = 0x0001AFBE,//250kbps
            [Description("125kbps 80%")]
            ABIT_BAUD_125K = 0x0041AFBE,//125kbps
            [Description("100kbps 80%")]
            ABIT_BAUD_100K = 0x0041BBEE,//100kbps
            [Description("50kbps 80%")]
            ABIT_BAUD_50K = 0x00C1BBEE, //50kbps
        }

        public enum CANFD_BAUD_DATA : int
        {
            [Description("5Mbps 75%")]
            DBIT_BAUD_5M = 0x00010207,//5Mbps
            [Description("4Mbps 75%")]
            DBIT_BAUD_4M = 0x0001020A,//4Mbps
            [Description("2Mbps 75%")]
            DBIT_BAUD_2M = 0x0041020A,//2Mbps
            [Description("1Mbps 75%")]
            DBIT_BAUD_1M = 0x0081830E //1Mbps
        }

        public enum CAN_BAUD : int
        {
            [Description("1Mbps")]
            BAUD_1M = 0x0014,
            [Description("800kbps")]
            BAUD_800K = 0x0016,//800kbps
            [Description("500kbps")]
            BAUD_500K = 0x001C,//500kbps
            [Description("250kbps")]
            BAUD_250K = 0x011C,//250kbps
            [Description("125kbps")]
            BAUD_125K = 0x031C,//125kbps
            [Description("100kbps")]
            BAUD_100K = 0x041C,//100kbps
            [Description("50kbps")]
            BAUD_50K = 0x091C, //50kbps
            [Description("20kbps")]
            BAUD_20K = 0x181C, //20kbps
            [Description("10kbps")]
            BAUD_10K = 0x311C, //10kbps
            [Description("5kbps")]
            BAUD_5K = 0xBFFF, //5kbps
        }
        /// <summary>
        /// 打开CAN设备
        /// </summary>
        /// <returns></returns>
        public static bool OpenCAN(ConnParams connParams)
        {
            try
            {
                if (connParams == null) return false;
                device_handle = connParams.CAN_Company== CAN_Factory.ZLG?  Method_ZLGCAN.ZCAN_OpenDevice((uint)EnumCls.GetEnum<ZLG_CAN_TYPE>(connParams.Zlg_CAN_Type), connParams.CAN_Index, 0)
                    :Method.ZCAN_OpenDevice((uint)EnumCls.GetEnum<ZLG_CAN_TYPE>(connParams.Zlg_CAN_Type), connParams.CAN_Index, 0);//
                if (0 == (int)device_handle)
                {
                    //MessageBox.Show("打开设备失败,请检查设备类型和设备索引号是否正确", "提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Log.Error("打开设备失败,请检查设备类型和设备索引号是否正确");
                }
            }
            catch (Exception _ex)
            {
                Log.Error("OpenCAN Exception\r\n" + _ex.ToString());
                device_handle = IntPtr.Zero;
            }
            return 0 != (int)device_handle;
        }

        /// <summary>
        /// 关闭CAN
        /// </summary>
        /// <returns></returns>
        public static uint CloseCAN(ConnParams connParams)
        {
            
            try
            {
                if (connParams != null)
                    return connParams.CAN_Company == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_CloseDevice(device_handle):Method.ZCAN_CloseDevice(device_handle);
            }
            catch (Exception _ex)
            {
                Log.Error("CloseCAN Exception\r\n" + _ex.ToString());
            }
            return STATUS_ERR;
        }

        /// <summary>
        /// CAN初始化
        /// </summary>
        /// <returns></returns>
        public static bool InitCAN(ConnParams connParams)
        {
            try
            {
                if (connParams == null) return false;
                IntPtr ptr = connParams.CAN_Company == CAN_Factory.ZLG ? Method_ZLGCAN.GetIProperty(device_handle):Method.GetIProperty(device_handle);
                if (0 == (int)ptr)
                {
                    //MessageBox.Show("设置指定路径属性失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Log.Error("设置指定路径属性失败");
                    return false;
                }

                _property = (IProperty)Marshal.PtrToStructure((IntPtr)((UInt32)ptr), typeof(IProperty));

                ZCAN_CHANNEL_INIT_CONFIG channel_Init_Config = new ZCAN_CHANNEL_INIT_CONFIG();
                channel_Init_Config.canfd.mode = (byte)connParams.CAN_WorkMode;

                //由设备名称得到它属于CANFD还是CAN
                ZLG_TYPE type = EnumCls.GetEnum<ZLG_TYPE>(connParams.Zlg_Type);
                channel_Init_Config.can_type = (uint)type;

                if (type == ZLG_TYPE.TYPE_CANFD)
                {
                    if (!setCANFDStandard(connParams.CAN_Channel,connParams.CANFD_Standard)) //设置CANFD标准
                    {
                        //MessageBox.Show("设置CANFD标准失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Log.Error("设置CANFD标准失败");
                        return false;
                    }
                    // set rates fd
                    if (!setBaudrateFD(connParams.CAN_Channel, 'A', BaudrateFD(connParams.CANFD_Baud_Abit)))
                    {
                        //MessageBox.Show("设置仲裁波特率失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Log.Error("设置仲裁波特率失败");
                        return false;
                    }
                    if (!setBaudrateFD(connParams.CAN_Channel, 'D', BaudrateFD(connParams.CANFD_Baud_Dbit)))
                    {
                        //MessageBox.Show("设置数据波特率失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Log.Error("设置数据波特率失败");
                        return false;
                    }
                }
                else
                {
                    channel_Init_Config.can.timing0 = (byte)((connParams.CAN_Baud >> 8) & 0xFF);
                    channel_Init_Config.can.timing1 = (byte)(connParams.CAN_Baud & 0xFF); ;
                    channel_Init_Config.can.filter = 0;
                    channel_Init_Config.can.acc_code = 0;
                    channel_Init_Config.can.acc_mask = 0xFFFFFFFF;
                }
                IntPtr pConfig = Marshal.AllocHGlobal(Marshal.SizeOf(channel_Init_Config));
                Marshal.StructureToPtr(channel_Init_Config, pConfig, true);
                channel_handle = connParams.CAN_Company == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_InitCAN(device_handle, (uint)connParams.CAN_Index, pConfig):Method.ZCAN_InitCAN(device_handle, (uint)connParams.CAN_Index, pConfig);
                Marshal.FreeHGlobal(pConfig);

                if (0 == (int)channel_handle)
                {
                    //MessageBox.Show("初始化CAN失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Log.Error("初始化CAN失败");
                }
            }
            catch (Exception _ex)
            {
                Log.Error("InitCAN Exception\r\n" + _ex.ToString());
                channel_handle = IntPtr.Zero;
            }
            return (int)channel_handle != 0;
        }

        public static bool StartCAN(ConnParams connParams)
        {
            try
            {
                if(connParams==null) return false;
                if ((connParams.CAN_Company == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_StartCAN(channel_handle):Method.ZCAN_StartCAN(channel_handle)) != STATUS_OK)
                {
                    //MessageBox.Show("启动CAN失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Log.Error("启动CAN失败");
                    return false;
                }
            }
            catch (Exception _ex)
            {
                Log.Error("StartCAN Exception\r\n" + _ex.ToString());
                return false;
            }
            return true;
        }

        public static IntPtr GetChannel()
        {
            return channel_handle;
        }

        #region 设置属性
        //设置CANFD标准
        private static bool setCANFDStandard(int channel,int canfd_standard)
        {
            string path = channel + "/canfd_standard";
            string value = canfd_standard.ToString();
            return 1 == _property.SetValue(path, value);
        }

        private static bool setBaudrateFD(int channel, char ad, UInt32 baud)
        {
            string path = "";

            if (ad == 'A')
            {
                path = channel + "/canfd_abit_baud_rate";
            }
            else if (ad == 'D')
            {
                path = channel + "/canfd_dbit_baud_rate";
            }

            string value = baud.ToString();
            return 1 == _property.SetValue(path, value);
        }

        private static uint BaudrateFD(uint baud)
        {
            switch (baud)
            {
                case (uint)CANFD_BAUD_DATA.DBIT_BAUD_5M:
                    return 5000000;//5Mbps
                case (uint)CANFD_BAUD_DATA.DBIT_BAUD_4M:
                    return 4000000;//4Mbps
                case (uint)CANFD_BAUD_DATA.DBIT_BAUD_2M:
                    return 2000000;//2Mbps
	            case (uint)CANFD_BAUD_DATA.DBIT_BAUD_1M:
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_1M:
                default:
                    return 1000000;
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_800K:
                    return 800000;//800kbps
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_500K:
                    return 500000;//500kbps
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_250K:
                    return 250000;//250kbps
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_125K:
                    return 125000;//125kbps
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_100K:
                    return 100000;//100kbps
                case (uint)CANFD_BAUD_ARBITRATE.ABIT_BAUD_50K:
                    return 50000;//50kbps
            }
        }

        #endregion 设置属性

        public static uint GetId(uint id)
        {
            
            return id & CAN_ID_FLAG;
        }

        public static bool WriteBytes(CAN_Factory company, ZLG_TYPE type,byte[] bytes, uint frameId,bool canExp = false)
        {
            try
            {
                if (bytes != null && ((type == ZLG_TYPE.TYPE_CANFD && bytes.Length <= 64) || (type == ZLG_TYPE.TYPE_CAN && bytes.Length <= 8)))
                {
                    uint result = 0; //发送的帧数
                    if (type == ZLG_TYPE.TYPE_CANFD)
                    {
                        ZCAN_TransmitFD_Data canfd_data = new ZCAN_TransmitFD_Data();
                        canfd_data.frame.can_id = frameId;
                        byte[] data = new byte[64];
                        Array.Clear(data, 0, data.Length);
                        Array.Copy(bytes, 0, data, 0, bytes.Length);
                        canfd_data.frame.data = data;
                        canfd_data.frame.len = (byte)bytes.Length;
                        canfd_data.transmit_type = 0x00;//正常发送
                        canfd_data.frame.flags = (byte)(canExp? 0x01 : 0x00);//(byte)((canfd_exp_index != 0) ? CANFD_BRS : 0);1是CANFD加速
                        IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(canfd_data));
                        Marshal.StructureToPtr(canfd_data, ptr, true);
                        result = company == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_TransmitFD(channel_handle, ptr, 1):Method.ZCAN_TransmitFD(channel_handle, ptr, 1);
                        Marshal.FreeHGlobal(ptr);
                    }
                    else
                    {
                        ZCAN_Transmit_Data can_data = new ZCAN_Transmit_Data();
                        can_data.frame.can_id = frameId;
                        byte[] data = new byte[8];
                        Array.Clear(data, 0, data.Length);
                        Array.Copy(bytes, 0, data, 0, bytes.Length);
                        can_data.frame.data = data;
                        can_data.frame.can_dlc = (byte)bytes.Length;
                        can_data.transmit_type = 0x00;
                        IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(can_data));
                        Marshal.StructureToPtr(can_data, ptr, true);
                        result = company == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_Transmit(channel_handle, ptr, 1) : Method.ZCAN_Transmit(channel_handle, ptr, 1);
                        Marshal.FreeHGlobal(ptr);
                    }
                    return result == 1;
                }
            }
            catch(Exception ex)
            {
                Log.Error($"WriteBytes({type},{bytes}, {frameId},{canExp}) Ex \r\n{ex.ToString()}");
            }
            return false;
        }

        public static bool WriteBytesMulti(CAN_Factory company, ZLG_TYPE type, List<byte[]> bytesList, List<uint> frameIdList, bool canExp = false)
        {
            try
            {
                if (bytesList == null || bytesList.Count <= 0 || frameIdList==null || frameIdList.Count<=0 || bytesList.Count != frameIdList.Count)
                    return false;
                uint frameCount = (uint)bytesList.Count;
                uint result = 0; //发送的帧数
                if (type == ZLG_TYPE.TYPE_CANFD)
                {
                    // 使用数组而不是List，因为Marshal需要连续的内存布局
                    ZCAN_TransmitFD_Data[] canfd_dataArray = new ZCAN_TransmitFD_Data[frameIdList.Count];
                    for (int i = 0; i < frameIdList.Count; i++) {
                        ZCAN_TransmitFD_Data canfd_data = new ZCAN_TransmitFD_Data();
                        canfd_data.frame.can_id = frameIdList[i];
                        byte[] data = new byte[64];
                        Array.Clear(data, 0, data.Length);
                        if (bytesList[i] != null)
                            Array.Copy(bytesList[i], 0, data, 0, bytesList[i].Length);
                        canfd_data.frame.data = data;
                        canfd_data.frame.len = (byte)(bytesList[i]==null? 0:bytesList[i].Length);
                        canfd_data.transmit_type = 0x00;//正常发送
                        canfd_data.frame.flags = (byte)(canExp ? 0x01 : 0x00);//(byte)((canfd_exp_index != 0) ? CANFD_BRS : 0);1是CANFD加速
                        canfd_dataArray[i] = canfd_data;
                    }
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ZCAN_TransmitFD_Data)) * canfd_dataArray.Length);
                    try
                    {
                        // 手动复制每个结构体到非托管内存的连续区域
                        for (int i = 0; i < canfd_dataArray.Length; i++)
                        {
                            IntPtr elementPtr = new IntPtr(ptr.ToInt64() + i * Marshal.SizeOf(typeof(ZCAN_TransmitFD_Data)));
                            Marshal.StructureToPtr(canfd_dataArray[i], elementPtr, false);
                        }

                        result = company == CAN_Factory.ZLG
                            ? Method_ZLGCAN.ZCAN_TransmitFD(channel_handle, ptr, frameCount)
                            : Method.ZCAN_TransmitFD(channel_handle, ptr, frameCount);
                    }
                    finally
                    {
                        // 释放非托管内存
                        Marshal.FreeHGlobal(ptr);
                    }
                    result = company == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_TransmitFD(channel_handle, ptr, frameCount) : Method.ZCAN_TransmitFD(channel_handle, ptr, frameCount);
                    //Marshal.FreeHGlobal(ptr);
                }
                else
                {
                    ZCAN_Transmit_Data[] can_dataArray = new ZCAN_Transmit_Data[frameIdList.Count];
                    for (int i = 0; i < frameIdList.Count; i++)
                    {
                        ZCAN_Transmit_Data can_data = new ZCAN_Transmit_Data();
                        can_data.frame.can_id = frameIdList[i];
                        byte[] data = new byte[8];
                        Array.Clear(data, 0, data.Length);
                        if (bytesList[i] != null)
                            Array.Copy(bytesList[i], 0, data, 0, bytesList[i].Length);
                        can_data.frame.data = data;
                        can_data.frame.can_dlc = (byte)(bytesList[i] == null ? 0 : bytesList[i].Length);
                        can_data.transmit_type = 0x00;
                        can_dataArray[i] = can_data;
                    }
                    int size = Marshal.SizeOf(typeof(ZCAN_Transmit_Data)) * can_dataArray.Length;
                    IntPtr ptr = Marshal.AllocHGlobal(size);

                    try
                    {
                        for (int i = 0; i < can_dataArray.Length; i++)
                        {
                            IntPtr elementPtr = new IntPtr(ptr.ToInt64() + i * Marshal.SizeOf(typeof(ZCAN_Transmit_Data)));
                            Marshal.StructureToPtr(can_dataArray[i], elementPtr, false);
                        }

                        result = company == CAN_Factory.ZLG
                            ? Method_ZLGCAN.ZCAN_Transmit(channel_handle, ptr, frameCount)
                            : Method.ZCAN_Transmit(channel_handle, ptr, frameCount);
                    }
                    finally
                    {
                        Marshal.FreeHGlobal(ptr);
                    }
                }
                return result == frameCount;
                
            }
            catch (Exception ex)
            {
                Log.Error($"WriteBytesMulti Ex \r\n{ex.ToString()}");
            }
            return false;
        }

        #region 辅助方法
        public static byte[] CANFDFrameConvertToBytes(canfd_frame canfd_Frame)
        {
            int size = Marshal.SizeOf(canfd_Frame);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);
            try { Marshal.StructureToPtr(canfd_Frame, ptr, false); Marshal.Copy(ptr, arr, 0, size); }
            finally { Marshal.FreeHGlobal(ptr); }
            return arr;

        }

        public static canfd_frame BytesConvertToCANFDFrame(byte[] data)
        {
            canfd_frame structure = new canfd_frame();
            int size = Marshal.SizeOf(structure);
            IntPtr ptr = Marshal.AllocHGlobal(size);
            try { Marshal.Copy(data, 0, ptr, size); structure = (canfd_frame)Marshal.PtrToStructure(ptr, typeof(canfd_frame)); }
            finally { Marshal.FreeHGlobal(ptr); }
            return structure;
        }
        #endregion 辅助方法
        //public static uint 
    }

    //接收数据线程类
    class recvdatathread
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void RecvCANDataEventHandler(ZCAN_Receive_Data[] data, uint len);//CAN数据接收事件委托

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void RecvFDDataEventHandler(ZCAN_ReceiveFD_Data[] data, uint len);//CANFD数据接收事件委托

        const int TYPE_CAN = 0;
        const int TYPE_CANFD = 1;

        bool m_bStart;
        IntPtr channel_handle_;
        Thread recv_thread_;
        static object locker = new object();
        public static RecvCANDataEventHandler OnRecvCANDataEvent;
        public static RecvFDDataEventHandler OnRecvFDDataEvent;
        public recvdatathread()
        {
        }

        public event RecvCANDataEventHandler RecvCANData
        {
            add { OnRecvCANDataEvent += new RecvCANDataEventHandler(value); }
            remove { OnRecvCANDataEvent -= new RecvCANDataEventHandler(value); }
        }

        public event RecvFDDataEventHandler RecvFDData
        {
            add { OnRecvFDDataEvent += new RecvFDDataEventHandler(value); }
            remove { OnRecvFDDataEvent -= new RecvFDDataEventHandler(value); }
        }
        public CAN_Factory canFactory = CAN_Factory.ZLG;
        public void setStart(bool start)
        {
            m_bStart = start;
            if (start)
            {
                recv_thread_ = new Thread(RecvDataFunc);
                recv_thread_.IsBackground = true;
                recv_thread_.Start();
            }
            else
            {
                recv_thread_?.Join();
                //try
                //{
                //    recv_thread_?.Abort();
                //}
                //catch(Exception ex)
                //{

                //}
                recv_thread_ = null;
            }
        }

        public void setChannelHandle(IntPtr channel_handle)
        {

            channel_handle_ = channel_handle;
            uint v = canFactory == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_ClearBuffer(channel_handle_):Method.ZCAN_ClearBuffer(channel_handle_);
        }

        //数据接收函数
        protected void RecvDataFunc()
        {
            ZCAN_Receive_Data[] can_data;
            ZCAN_ReceiveFD_Data[] canfd_data;
            while (m_bStart)
            {
                #region CAN接收数据

                uint len = canFactory == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_GetReceiveNum(channel_handle_, TYPE_CAN) : Method.ZCAN_GetReceiveNum(channel_handle_, TYPE_CAN);
                if (len > 0)
                {
                    int size = Marshal.SizeOf(typeof(ZCAN_Receive_Data));
                    IntPtr ptr = Marshal.AllocHGlobal((int)len * size);
                    len = canFactory == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_Receive(channel_handle_, ptr, len, 10) : Method.ZCAN_Receive(channel_handle_, ptr, len, 10);
                    can_data = new ZCAN_Receive_Data[len];
                    for (int i = 0; i < len; ++i)
                    {
                        can_data[i] = (ZCAN_Receive_Data)Marshal.PtrToStructure(
                            (IntPtr)((UInt32)ptr + i * size), typeof(ZCAN_Receive_Data));
                    }
                    OnRecvCANDataEvent(can_data, len);
                    Marshal.FreeHGlobal(ptr);
                }
                    
                #endregion CAN接收数据
                
                #region CANFD接收数据
                uint len2 = canFactory == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_GetReceiveNum(channel_handle_, TYPE_CANFD) : Method.ZCAN_GetReceiveNum(channel_handle_, TYPE_CANFD);
                if (len2 > 0)
                {
                    int size = Marshal.SizeOf(typeof(ZCAN_ReceiveFD_Data));
                    IntPtr ptr = Marshal.AllocHGlobal((int)len2 * size);
                    len2 = canFactory == CAN_Factory.ZLG ? Method_ZLGCAN.ZCAN_ReceiveFD(channel_handle_, ptr, len2, 10) : Method.ZCAN_ReceiveFD(channel_handle_, ptr, len2, 10);
                    canfd_data = new ZCAN_ReceiveFD_Data[len2];
                    for (int i = 0; i < len2; ++i)
                    {
                        canfd_data[i] = (ZCAN_ReceiveFD_Data)Marshal.PtrToStructure(
                            (IntPtr)((UInt32)ptr + i * size), typeof(ZCAN_ReceiveFD_Data));
                    }
                    OnRecvFDDataEvent(canfd_data, len2);
                    Marshal.FreeHGlobal(ptr);
                }
                if (len <= 0 && len2 <= 0)
                    Thread.Sleep(1);
                #endregion CANFD接收数据
            }
            
        }
    }
}
