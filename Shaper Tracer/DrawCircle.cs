using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shaper_Tracer
{
    class DrawCircle : ShapeTrace
    {
        private Circle circle;
        float rotationPointRotationInRadians;
        
        public DrawCircle(Circle circle)
        {
            this.circle = circle;
            rotationPointRotationInRadians = 0;
        }

        public override Vector2 Trace(Graphics graphics, Pen pen)
        {
            foreach (Vector2 position in GetPointAround(new Vector2()))
            {
                graphics.DrawEllipse(pen, position.x, position.y, 5, 5);
                return position;
            }
            return null;
        }

        public override IEnumerable<Vector2> GetPointAround(Vector2 position)
        {
            var nextPoint = new Vector2();
            rotationPointRotationInRadians = 0;
            
            while(rotationPointRotationInRadians <= (2 * Math.PI))
            {
                var x = (float)(circle.CenterPosition.x + Math.Cos(rotationPointRotationInRadians) * circle.Radius);
                var y = (float)(circle.CenterPosition.y + Math.Sin(rotationPointRotationInRadians) * circle.Radius);

                nextPoint = new Vector2(x, y) + position;

                rotationPointRotationInRadians += 0.1f;
                yield return nextPoint;
            }
        }
    }
}
