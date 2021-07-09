using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaper_Tracer
{
    class Circle
    {
        public readonly Vector2 CenterPosition;
        public readonly float Radius;

        public Circle(Vector2 centerPosition, float radius)
        {
            CenterPosition = centerPosition;
            Radius = radius;
        }
    }
}
