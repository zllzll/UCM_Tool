using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCM_Tools.Tools;

namespace UCM_Tools.Radar.Protocols.UpgradeProtocol
{
    public class Upgrade_UCM211_Bytes
    {
        #region 协议打包
        private const byte HEAD0 = 0xEB;
        private const byte HEAD1 = 0xCD;
        private const byte TYPE = 0x05;
        private const byte UPGRADE_PREPARE = 0x01;//升级准备
        private const byte TRANSPORT_DATA = 0x02;//传输数据
        private const byte UPGRADE_WRITE = 0x03;//升级烧写

        public static List<byte> PackageUpgradeProtocol(byte funCode, List<byte> datas)
        {
            List<byte> returnList = new List<byte>();
            try
            {
                returnList.InsertRange(0, BitConverter.GetBytes((UInt16)((datas == null ? 0 : datas.Count) + 2)));//长度
                returnList.Add(TYPE);
                returnList.Add(funCode);
                if (datas != null && datas.Count > 0)
                    returnList.AddRange(datas);
                byte checkSum = PubClass.GetCheckSum(returnList.ToArray(), 0, returnList.Count);
                returnList.Add(checkSum);
                returnList.Insert(0, HEAD1);
                returnList.Insert(0, HEAD0);
            }
            catch (Exception ex)
            {
                returnList = new List<byte>();
            }
            return returnList;
        }

        public static List<byte> PackageUpgradeWriteData(int address, List<byte> datas)
        {
            List<byte> returnList = new List<byte>();
            try
            {
                returnList.AddRange(BitConverter.GetBytes(address));
                returnList.AddRange(BitConverter.GetBytes(datas == null ? 0 : datas.Count));
                if (datas != null && datas.Count > 0)
                    returnList.AddRange(datas);
            }
            catch (Exception ex)
            {
                returnList = new List<byte>();
            }
            return returnList;
        }
        #endregion 协议打包
    }
}
