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
}
