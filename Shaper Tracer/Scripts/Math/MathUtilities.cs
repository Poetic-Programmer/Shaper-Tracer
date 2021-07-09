using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaper_Tracer
{
    static class MathUtilities
    {
        public static Vector2 Lerp(Vector2 start, Vector2 end, float t)
        {
            var point = ((1 - t) * start) + ((t) * end);
            return point;
        }
    }
}
