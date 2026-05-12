using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCM_Tools.Config;

namespace UCM_Tools.Tools
{
    #region 高性能3D文本 - 修复版（基于vtkFollower）

    public class DynamicFollowerText3D
    {
        private List<vtkFollower> followers = new List<vtkFollower>();
        private List<vtkVectorText> vectorTexts = new List<vtkVectorText>();
        private List<vtkPolyDataMapper> mappers = new List<vtkPolyDataMapper>();

        private Queue<int> freeIndices = new Queue<int>();
        private Dictionary<uint, int> idToIndex = new Dictionary<uint, int>();
        private HashSet<int> usedThisFrame = new HashSet<int>();

        private vtkRenderer targetRenderer = null;
        private bool initialized = false;
        private bool isCleaning = false;  // 防止重入

        private StringBuilder sb = new StringBuilder(100);

        /// <summary>
        /// 初始化（模仿VTKHelper.Scale的完整流程）
        /// </summary>
        public void Initialize(vtkRenderer renderer)
        {
            if (initialized || renderer == null) return;
            targetRenderer = renderer;
            initialized = true;
            isCleaning = false;
        }

        /// <summary>
        /// 获取或创建Actor（核心复用逻辑）
        /// </summary>
        private int GetOrCreateActor(uint targetId)
        {
            if (!initialized || isCleaning) return -1;

            if (idToIndex.TryGetValue(targetId, out int existingIndex))
            {
                usedThisFrame.Add(existingIndex);
                return existingIndex;
            }

            if (freeIndices.Count > 0)
            {
                int freeIndex = freeIndices.Dequeue();
                idToIndex[targetId] = freeIndex;
                usedThisFrame.Add(freeIndex);
                return freeIndex;
            }

            int newIndex = followers.Count;

            var vectorText = vtkVectorText.New();
            vectorTexts.Add(vectorText);

            var mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(vectorText.GetOutputPort());
            mappers.Add(mapper);

            var follower = vtkFollower.New();
            follower.SetMapper(mapper);
            follower.SetScale(0.5, 0.5, 0.5);
            follower.SetCamera(targetRenderer.GetActiveCamera());
            follower.SetVisibility(0);

            targetRenderer.AddActor(follower);
            followers.Add(follower);

            idToIndex[targetId] = newIndex;
            usedThisFrame.Add(newIndex);

            return newIndex;
        }

        /// <summary>
        /// 更新一帧（动态数量）
        /// </summary>
        public void UpdateFrame(List<TargetInfo.RadarTargetInfoStruct> trackData,
                               bool nonUniformScale,
                               vtkTransform globalTransform)
        {
            if (!initialized || isCleaning || targetRenderer == null) return;

            usedThisFrame.Clear();

            foreach (var target in trackData)
            {
                int index = GetOrCreateActor(target.ID);
                if (index >= 0)
                    UpdateActor(index, target, nonUniformScale, globalTransform);
            }

            // 回收未使用的
            var deadIds = new List<uint>();
            foreach (var kvp in idToIndex)
            {
                if (!usedThisFrame.Contains(kvp.Value))
                {
                    if (kvp.Value < followers.Count && followers[kvp.Value] != null)
                    {
                        followers[kvp.Value].SetVisibility(0);
                        freeIndices.Enqueue(kvp.Value);
                    }
                    deadIds.Add(kvp.Key);
                }
            }

            foreach (var id in deadIds)
            {
                idToIndex.Remove(id);
            }
        }

        /// <summary>
        /// 更新单个Actor
        /// </summary>
        private void UpdateActor(int index, TargetInfo.RadarTargetInfoStruct target,
                                bool nonUniformScale, vtkTransform globalTransform)
        {
            if (index < 0 || index >= followers.Count) return;

            var follower = followers[index];
            var vectorText = vectorTexts[index];

            if (follower == null || vectorText == null) return;

            // 构建文本
            sb.Clear();
            sb.Append(VTKHelper.GetDetectionTextH(target));

            // 更新
            vectorText.SetText(sb.ToString());
            vectorText.Update();

            if (index < mappers.Count && mappers[index] != null)
                mappers[index].Modified();

            // 位置计算
            double posX = target.XAxis;
            double posY = target.YAxis + SystemSetting.TrackSize + 1.2;
            double posZ = target.ZAxis;

            if (nonUniformScale && globalTransform != null)
            {
                double[] transformed = globalTransform.TransformPoint(posX, posY, posZ);
                posX = transformed[0];
                posY = transformed[1];
                posZ = transformed[2];
            }

            double[] bounds = vectorText.GetOutput().GetBounds();
            double scale = 0.7;//SystemSetting.TrackTextSize > 0 ?
                           //SystemSetting.TrackTextSize / 50.0 : 0.5;
            double textWidth = (bounds[1] - bounds[0]) * scale;
            posX -= textWidth / 2;

            follower.SetPosition(posX, posY, posZ);
            follower.SetScale(scale, scale, scale);

            // 颜色
            Color color = SystemSetting.TrackTextColor;
            follower.GetProperty().SetColor(
                color.R / 255.0,
                color.G / 255.0,
                color.B / 255.0
            );

            follower.SetCamera(targetRenderer.GetActiveCamera());
            follower.SetVisibility(1);
            follower.Modified();
        }

        /// <summary>
        /// 动态颜色：根据ID或系统设置
        /// </summary>
        private Color GetTextColor(TargetInfo.RadarTargetInfoStruct target)
        {
            // 选项1：根据ID生成颜色（区分不同目标）
            //if (SystemSetting.TrackTextColorMode == 1) // 假设有这个设置
            //{
            //    return GetColorById(target.ID);
            //}

            // 选项2：使用系统设置的颜色
            return SystemSetting.TrackTextColor;
        }

        private Color GetColorById(uint id)
        {
            // 简单的ID到颜色映射
            byte r = (byte)((id * 50) % 200 + 55);
            byte g = (byte)((id * 80) % 200 + 55);
            byte b = (byte)((id * 110) % 200 + 55);
            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// 关键修复：安全的清理方法
        /// </summary>
        public void Cleanup(vtkRenderer renderer)
        {
            if (!initialized || isCleaning) return;
            isCleaning = true;

            try
            {
                // 1. 先隐藏所有（避免渲染时删除）
                foreach (var follower in followers)
                {
                    if (follower != null)
                        follower.SetVisibility(0);
                }

                // 2. 强制渲染一次，确保GPU完成
                if (renderer != null && renderer.GetRenderWindow() != null)
                {
                    renderer.GetRenderWindow().Render();
                }

                // 3. 从渲染器移除
                foreach (var follower in followers)
                {
                    if (follower != null && renderer != null)
                    {
                        renderer.RemoveActor(follower);
                    }
                }

                // 4. 延迟释放VTK对象（避免访问冲突）
                var followersToDispose = new List<vtkFollower>(followers);
                var mappersToDispose = new List<vtkPolyDataMapper>(mappers);
                var textsToDispose = new List<vtkVectorText>(vectorTexts);

                // 清空列表，防止后续访问
                followers.Clear();
                mappers.Clear();
                vectorTexts.Clear();
                idToIndex.Clear();
                freeIndices.Clear();
                usedThisFrame.Clear();

                // 5. 在后台线程延迟Dispose（关键！）
                Task.Run(() =>
                {
                    System.Threading.Thread.Sleep(100); // 延迟100ms确保渲染完成

                    foreach (var m in mappersToDispose) m?.Dispose();
                    foreach (var t in textsToDispose) t?.Dispose();
                    foreach (var f in followersToDispose) f?.Dispose();
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Cleanup error: {ex.Message}");
            }
            finally
            {
                initialized = false;
                isCleaning = false;
                targetRenderer = null;
            }
        }

        /// <summary>
        /// 快速清空显示（不销毁对象）
        /// </summary>
        public void HideAll()
        {
            if (!initialized || isCleaning) return;

            foreach (var kvp in idToIndex)
            {
                int index = kvp.Value;
                if (index < followers.Count && followers[index] != null)
                {
                    followers[index].SetVisibility(0);
                }
            }

            // 全部移入空闲队列
            freeIndices.Clear();
            foreach (var kvp in idToIndex)
            {
                freeIndices.Enqueue(kvp.Value);
            }
            idToIndex.Clear();
            usedThisFrame.Clear();
        }

        /// <summary>
        /// 获取当前统计信息
        /// </summary>
        public string GetStats()
        {
            return $"Pool: {followers.Count} total, {idToIndex.Count} active, {freeIndices.Count} free";
        }
    }



    #endregion
}
