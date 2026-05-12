using UCM_Tools.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Tools
{
    public class SpatialTextManager
    {
        private static Dictionary<string, TargetInfo.RadarTargetInfoStruct> bestInGrid = new Dictionary<string, TargetInfo.RadarTargetInfoStruct>();

        /// <summary>
        /// 从目标列表中筛选代表目标（每网格1个）
        /// </summary>
        public static List<TargetInfo.RadarTargetInfoStruct> FilterRepresentatives(List<TargetInfo.RadarTargetInfoStruct> targets)
        {
            bestInGrid.Clear();

            foreach (var target in targets)
            {
                string gridKey = GetGridKey(target.XAxis, target.YAxis, target.ZAxis);

                // 选择网格中距离最近的目标
                if (!bestInGrid.ContainsKey(gridKey) ||
                    GetDistanceSquared(target) < GetDistanceSquared(bestInGrid[gridKey]))
                {
                    bestInGrid[gridKey] = target;
                }
            }

            return bestInGrid.Values.ToList();
        }

        private static string GetGridKey(double x, double y, double z)
        {
            return $"{(int)(x / SystemSetting.Grid_Size)},{(int)(y / SystemSetting.Grid_Size)},{(int)(z / SystemSetting.Grid_Size)}";
        }

        private static double GetDistanceSquared(TargetInfo.RadarTargetInfoStruct t)
        {
            return t.XAxis * t.XAxis + t.YAxis * t.YAxis + t.ZAxis * t.ZAxis;
        }
    }
}
