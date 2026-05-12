using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCM_Tools.CAN_Conn;
using static UCM_Tools.CAN_Conn.CAN_Function;

namespace UCM_Tools.Radar.Communication
{
    public class ConnParams
    {
        public string ConnType = "COM";

        public string COM_No = "COM1";
        public int COM_Baud = 115200;
        public string COM_Parity = "None";
        public string COM_DataBit = "8";
        public string COM_StopBit = "One";

        public ConnParams() { }
        public ConnParams(string connType = "COM",string name="COM1",int baud=115200,string parity="None",string databit="8",string stopbit="One")
        {
            ConnType = connType;
            COM_No = name;
            COM_Baud = baud;
            COM_Parity = parity;
            COM_DataBit = databit;
            COM_StopBit = stopbit;
        }

        public string Zlg_Type = "CAN";
        public CAN_Factory CAN_Company = CAN_Factory.ZLG;
        public string Zlg_CAN_Type = "USBCAN1";
        public uint CAN_Index = 0;
        public int CAN_Channel = 0;
        public int CAN_WorkMode = 0;
        public int CANFD_Standard = 0;
        public uint CANFD_Baud_Abit = 0;
        public uint CANFD_Baud_Dbit = 0;
        public uint CAN_Baud = 0;

        public ConnParams(string connType = "CAN", CAN_Factory company = CAN_Factory.ZLG, string type = "CAN", string name = "USBCAN1", uint index = 0, int channel = 0, int workmode = 0, int standard = 0, uint abit = 0, uint dbit = 0, uint canBaud = 0)
        {
            ConnType = connType;
            CAN_Company = company;
            Zlg_Type = type;
            Zlg_CAN_Type = name;
            CAN_Index = index;
            CAN_Channel = channel;
            CAN_WorkMode = workmode;
            CANFD_Standard = standard;
            CANFD_Baud_Abit = abit;
            CANFD_Baud_Dbit = dbit;
            CAN_Baud = canBaud;
        }

        public string IP = "192.168.10.123";
        public int Port = 50000;

        public ConnParams(string connType = "TCP", string ip = "192.16810.123", int port = 50000)
        {
            ConnType = connType;
            IP = ip;
            Port = port;
        }
    }
}
