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

        public void Trace(Graphics graphics, BasicPen pen)
        {
            var tracerCopy = new List<ShapeTrace>(tracers);
            var index = tracers.Count - 1;

            foreach(Vector2 position in Trace(index, center))
            {
                pen.DrawAt(position);
            }
        }

        private IEnumerable<Vector2> Trace(int index, Vector2 position)
        {
            if (index >= 0)
            {
                var current = tracers[index];
                index = index - 1;

                foreach (Vector2 point in current.GetPointAround(position))
                {
                    if (index < 0)
                    {
                        yield return point;
                    }

                    foreach(var rec in Trace(index, point))
                    {
                        yield return rec;
                    }
                }
            }
        }
    }
}
