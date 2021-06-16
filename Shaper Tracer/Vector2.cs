using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaper_Tracer
{
    class Vector2
    {
        public float x;
        public float y;

        public Vector2()
        {
            x = 0;
            y = 0;
        }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator *(Vector2 a, float scalar)
            => new Vector2(a.x * scalar, a.y * scalar);

        public static Vector2 operator *(float scalar, Vector2 a)
            => new Vector2(a.x * scalar, a.y * scalar);

        public static Vector2 operator +(Vector2 left, Vector2 right)
            => new Vector2(left.x + right.x, left.y + right.y);
    }
}
