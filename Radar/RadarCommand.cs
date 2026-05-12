using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Radar
{
    public enum RadarCommand : uint
    {
        ReadSoftwareVersion,
        ReadRadarId,
        ReadAliveStatus,
        ReadHardwareId,
        WriteKeyId,
        EnterUpgrade,
        EarseFile,
        SendFile,
        SendFileCheck,
        StartUpgrade,

        SetParamsUCM211,
        ReadParamsUCM211,
    }
}
