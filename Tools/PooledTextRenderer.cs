using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using UCM_Tools.Config;

namespace UCM_Tools.Tools
{
    /// <summary>
    /// 优化的VTK文本渲染 - 使用对象池和批量更新
    /// 避免每帧创建/销毁VTK对象
    /// </summary>
    public class PooledTextRenderer
    {
        private vtkRenderer renderer;

        // 对象池 - 存储完整的对象组
        private Queue<TextRendererItem> itemPool = new Queue<TextRendererItem>();

        // 活跃对象
        private Dictionary<uint, TextRendererItem> activeItems = new Dictionary<uint, TextRendererItem>();

        // 预创建数量
        private const int POOL_SIZE = 300;

        // 内部类：包装一组相关的VTK对象
        private class TextRendererItem
        {
            public vtkVectorText VectorText;
            public vtkPolyDataMapper Mapper;
            public vtkFollower Follower;

            public void Dispose()
            {
                Follower?.Dispose();
                Mapper?.Dispose();
                VectorText?.Dispose();
            }
        }

        public void Initialize(vtkRenderer vtkRenderer)
        {
            renderer = vtkRenderer;

            // 预创建对象池
            for (int i = 0; i < POOL_SIZE; i++)
            {
                var item = CreateItem();
                item.Follower.SetVisibility(0); // 初始隐藏
                itemPool.Enqueue(item);
            }
        }

        /// <summary>
        /// 创建一个新的渲染项
        /// </summary>
        private TextRendererItem CreateItem()
        {
            var vt = vtkVectorText.New();

            var mapper = vtkPolyDataMapper.New();
            // 修复：使用 SetInputConnection 连接 vtkVectorText 的输出端口
            mapper.SetInputConnection(vt.GetOutputPort());

            var follower = vtkFollower.New();
            follower.SetMapper(mapper);
            follower.SetScale(0.5, 0.5, 0.5);
            follower.SetCamera(renderer.GetActiveCamera());
            renderer.AddActor(follower);

            return new TextRendererItem
            {
                VectorText = vt,
                Mapper = mapper,
                Follower = follower
            };
        }

        /// <summary>
        /// 更新一帧文本
        /// </summary>
        public void UpdateFrame(List<TargetInfo.RadarTargetInfoStruct> targets)
        {
            if (targets == null) return;

            var usedIds = new HashSet<uint>();

            foreach (var target in targets)
            {
                usedIds.Add(target.ID);

                TextRendererItem item;
                if (!activeItems.TryGetValue(target.ID, out item))
                {
                    // 从池中获取或创建新的
                    if (itemPool.Count > 0)
                    {
                        item = itemPool.Dequeue();
                    }
                    else
                    {
                        // 池耗尽，创建新的（可能超出POOL_SIZE）
                        item = CreateItem();
                    }
                    activeItems[target.ID] = item;
                }

                // 更新文本内容
                string text = VTKHelper.GetDetectionTextH(target);
                item.VectorText.SetText(text);
                item.VectorText.Update();

                // 更新位置
                double x = target.XAxis;
                double y = target.YAxis + SystemSetting.TrackSize + 1.0;
                double z = target.ZAxis;

                if (SystemSetting.NonUniformScale)
                {
                    double[] t = SystemSetting.TransformPoint(x, y, z);
                    x = t[0]; y = t[1]; z = t[2];
                }

                item.Follower.SetPosition(x, y, z);

                // 更新颜色
                Color c = SystemSetting.TrackTextColor;
                item.Follower.GetProperty().SetColor(c.R / 255.0, c.G / 255.0, c.B / 255.0);

                // 确保可见
                item.Follower.SetVisibility(1);
                item.Follower.Modified();
            }

            // 回收未使用的项
            var toRemove = new List<uint>();
            foreach (var kvp in activeItems)
            {
                if (!usedIds.Contains(kvp.Key))
                {
                    var item = kvp.Value;
                    item.Follower.SetVisibility(0);
                    itemPool.Enqueue(item);
                    toRemove.Add(kvp.Key);
                }
            }

            foreach (var id in toRemove)
            {
                activeItems.Remove(id);
            }
        }

        /// <summary>
        /// 清空所有显示（不销毁对象）
        /// </summary>
        public void Clear()
        {
            foreach (var kvp in activeItems)
            {
                var item = kvp.Value;
                item.Follower.SetVisibility(0);
                itemPool.Enqueue(item);
            }
            activeItems.Clear();
        }

        /// <summary>
        /// 完全清理所有资源
        /// </summary>
        public void Cleanup()
        {
            Clear();

            // 清理池中的所有对象
            while (itemPool.Count > 0)
            {
                var item = itemPool.Dequeue();
                renderer.RemoveActor(item.Follower);
                item.Dispose();
            }

            // 清理活跃对象
            foreach (var item in activeItems.Values)
            {
                renderer.RemoveActor(item.Follower);
                item.Dispose();
            }
            activeItems.Clear();
        }
    }
}