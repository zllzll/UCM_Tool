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
}
