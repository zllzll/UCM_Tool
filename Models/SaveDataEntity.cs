using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Models
{
    public class PointCloudData
    {
        public float Range { get; set; }
        public double Azimuth { get; set; }
        public double Elevation { get; set; }
        public double Velocity { get; set; }
        public double SNR { get; set; }
        public double V_EGO_X { get; set; }
        public double V_EGO_Y { get; set; }
        public double V_EGO_Z { get; set; }
        
    }
    public class TrackData
    {
        public uint TarID { get; set; }
        public int TarClass { get; set; }
        public double Confidence { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Velocity { get; set; }
        public double Acc { get; set; }
        
    }

    public class IMUAndGPSData
    {
        public double AccX1 { get; set; }
        public double AccY1 { get; set; }
        public double AccZ1 { get; set; }
        public double AVX1 { get; set; }
        public double AVY1 { get; set; }
        public double AVZ1 { get; set; }
        public double AccX2 { get; set; }
        public double AccY2 { get; set; }
        public double AccZ2 { get; set; }
        public double AVX2 { get; set; }
        public double AVY2 { get; set; }
        public double AVZ2 { get; set; }
        public double GpsLong { get; set; }//GPS纬度
        public double GpsLat { get; set; }//GPS经度
        public double GpsHeight { get; set; }//GPS海拔高度
        public double GpsSpeed { get; set; }//GPS速度
        public double GpsDeclination { get; set; }//GPS磁偏角

    }

    public class FCData
    {
        public bool GpsLocValid = false;//gps数据有效位
        public bool UavAttitudeValid = false;//无人机姿态有效位
        public double GpsLong { get; set; }//GPS纬度
        public double GpsLat { get; set; }//GPS经度
        public double GpsHeight { get; set; }//GPS海拔高度
        public double AGL { get; set; }//无人机相对地面高度
        public double VN { get; set; }//飞行速度 VN  朝北运动速度
        public double VE { get; set; }//飞行速度 VE  朝东运动速度
        public double VD { get; set; }//飞行速度 VD  朝下运动速度
        public double RollAngle { get; set; }//横滚角
        public double PitchAngle { get; set; }//俯仰角
        public double YawAngle { get; set; }//航向角
        public double RollSpeed { get; set; }//横滚角速度
        public double PitchSpeed { get; set; }//俯仰角速度
        public double YawSpeed { get; set; }//航向角速度
    }
}
