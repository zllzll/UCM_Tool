using LogProc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ZLGCAN;

namespace UCM_Tools.Radar.Communication
{
    public abstract class IConn
    {
        public ConnParams connParams = null;
        public abstract bool IsConnected { get; }
        //public abstract bool SetConnParams(string ConnParamsJson);
        public abstract Task<bool> OpenDevice();

        public abstract bool SendCmd(ConnData data);

        public abstract void CloseDevice();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void RecvCANDataEventHandler(ZCAN_Receive_Data[] data, uint len);//CAN数据接收事件委托

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void RecvCANFDDataEventHandler(ZCAN_ReceiveFD_Data[] data, uint len);//CANFD数据接收事件委托

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void RecvBytesDataEventHandler(byte[] data, uint len);//Bytes数据接收事件委托
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void RecvConnDataEventHandler(ConnData connDataList);//ConnData数据接收事件委托

        public RecvCANDataEventHandler OnRecvCANDataEvent;
        public RecvCANFDDataEventHandler OnRecvCANFDDataEvent;
        public RecvBytesDataEventHandler OnRecvBytesDataEvent;
        public RecvConnDataEventHandler OnRecvConnDataEvent;


        public event RecvCANDataEventHandler RecvCANData
        {
            add { OnRecvCANDataEvent += new RecvCANDataEventHandler(value); }
            remove { OnRecvCANDataEvent -= new RecvCANDataEventHandler(value); }
        }

        public event RecvCANFDDataEventHandler RecvFDData
        {
            add { OnRecvCANFDDataEvent += new RecvCANFDDataEventHandler(value); }
            remove { OnRecvCANFDDataEvent -= new RecvCANFDDataEventHandler(value); }
        }
        public event RecvBytesDataEventHandler RecvBytesData
        {
            add { OnRecvBytesDataEvent += new RecvBytesDataEventHandler(value); }
            remove { OnRecvBytesDataEvent -= new RecvBytesDataEventHandler(value); }
        }
        public event RecvConnDataEventHandler RecvConnData
        {
            add { OnRecvConnDataEvent += new RecvConnDataEventHandler(value); }
            remove { OnRecvConnDataEvent -= new RecvConnDataEventHandler(value); }
        }

        #region 辅助方法
        /// <summary>
        /// 将任意结构体数组转换为字节数组
        /// </summary>
        public static byte[] GenericStructArrayConvertToBytes<T>(T[] structures) where T : struct
        {
            if (structures == null || structures.Length == 0)
                return null;

            int singleSize = Marshal.SizeOf<T>();
            int totalSize = singleSize * structures.Length;
            byte[] byteArray = new byte[totalSize];

            IntPtr ptr = Marshal.AllocHGlobal(totalSize);
            try
            {
                // 逐个写入结构体到非托管内存
                for (int i = 0; i < structures.Length; i++)
                {
                    IntPtr offsetPtr = new IntPtr(ptr.ToInt64() + (i * singleSize));
                    Marshal.StructureToPtr(structures[i], offsetPtr, false);
                }
                // 批量复制到字节数组
                Marshal.Copy(ptr, byteArray, 0, totalSize);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return byteArray;
        }

        /// <summary>
        /// 将字节数组转换为指定结构体数组
        /// </summary>
        public static T[] BytesConvertToGenericStructArray<T>(byte[] data) where T : struct
        {
            if (!typeof(T).IsValueType || typeof(T).IsPrimitive)
            {
                Log.Error("T必须是自定义结构体类型");
                return null;
            }
            if (data == null || data.Length == 0)
                return null;

            int singleSize = Marshal.SizeOf<T>();

            // 验证数据完整性
            if (data.Length % singleSize != 0)
            {
                Log.Error($"数据长度({data.Length})必须是结构体大小({singleSize})的整数倍:{nameof(data)}");
                return null;
            }
            int count = data.Length / singleSize;
            T[] structures = new T[count];

            IntPtr ptr = Marshal.AllocHGlobal(data.Length);
            try
            {
                Marshal.Copy(data, 0, ptr, data.Length);

                // 逐个读取结构体
                for (int i = 0; i < count; i++)
                {
                    IntPtr offsetPtr = new IntPtr(ptr.ToInt64() + (i * singleSize));
                    structures[i] = Marshal.PtrToStructure<T>(offsetPtr);
                }
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return structures;
        }
        #endregion 辅助方法
    }
}
