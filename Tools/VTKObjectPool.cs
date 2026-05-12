using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCM_Tools.Tools
{
    public class VTKObjectPool : IDisposable
    {
        private Queue<vtkTextActor3D> textActorPool = new Queue<vtkTextActor3D>();
        private const int MAX_POOL_SIZE = 20;

        public vtkTextActor3D GetTextActor()
        {
            lock (textActorPool)
            {
                if (textActorPool.Count > 0) return textActorPool.Dequeue();
            }
            return vtkTextActor3D.New();
        }

        public void ReturnActor(vtkTextActor3D actor)
        {
            lock (textActorPool)
            {
                if (textActorPool.Count < MAX_POOL_SIZE)
                {
                    actor.SetInput(""); // 清空
                    textActorPool.Enqueue(actor);
                    return;
                }
            }
            actor.Dispose();
        }

        public void Dispose()
        {
            lock (textActorPool)
            {
                while (textActorPool.Count > 0)
                    textActorPool.Dequeue().Dispose();
            }
        }
    }
}
