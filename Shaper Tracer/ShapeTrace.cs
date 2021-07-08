using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shaper_Tracer
{
    abstract class ShapeTrace
    {
        public abstract Vector2 Trace(Graphics graphics, Pen pen);
        public abstract IEnumerable<Vector2> GetPointAround(Vector2 point);
        public abstract string Name();
    }
}
