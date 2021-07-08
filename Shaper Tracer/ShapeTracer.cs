using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaper_Tracer
{
    class ShapeTracer
    {
        List<ShapeTrace> tracers;

        public ShapeTracer()
        {
            tracers = new List<ShapeTrace>();
        }

        public void AddTracer(ShapeTrace tracer)
        {
            tracers.Add(tracer);
        }

        public void Trace(Graphics graphics, Pen pen)
        {
            foreach(ShapeTrace tracer in tracers)
            {
                foreach(Vector2 position in tracer.GetPointAround(new Vector2()))
                {
                    graphics.DrawEllipse(pen, position.x, position.y, 10, 10);
                }
            }
        }
    }
}
