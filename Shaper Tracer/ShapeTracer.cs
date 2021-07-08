using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Shaper_Tracer
{
    class ShapeTracer
    {
        readonly List<ShapeTrace> tracers;
        Vector2 center;
        public ShapeTracer()
        {
            tracers = new List<ShapeTrace>();
            center = new Vector2(100, 100);
        }

        public ShapeTracer(List<ShapeTrace> tracers)
        {
            this.tracers = tracers;
            center = new Vector2(250, 150);
        }

        public void AddTracer(ShapeTrace tracer)
        {
            tracers.Add(tracer);
        }

        public void Trace(Graphics graphics, Pen pen)
        {
            var tracerCopy = new List<ShapeTrace>(tracers);
            Trace(graphics, pen, tracerCopy, center);
        }

        private void Trace(Graphics graphics, Pen pen, List<ShapeTrace> tracer, Vector2 position)
        {
            while(tracer.Count > 1)
            {
                var lastElementIndex = tracer.Count - 1;
                var current = tracer[lastElementIndex];
                var previous = tracer[lastElementIndex - 1];      
                tracer.RemoveAt(lastElementIndex);

                foreach(Vector2 point in previous.GetPointAround(position))
                {
                    Trace(graphics, pen, tracer, point); 
                    
                    foreach(Vector2 p in current.GetPointAround(point))
                    {
                        graphics.DrawEllipse(pen, p.x, p.y, 10, 5f);                    
                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}
