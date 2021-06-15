using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shaper_Tracer
{
    class DrawCircle
    {
        private Circle circle;
        float rotationPointRotationInRadians;
        
        public DrawCircle(Circle circle)
        {
            this.circle = circle;
            rotationPointRotationInRadians = 0;
        }

        public void Draw(Point centerOfCircle, Graphics graphics, Pen pen)
        {
            foreach(Vector2 position in Draw())
            {
                graphics.DrawEllipse(pen, position.x, position.y, circle.Radius, circle.Radius);
                System.Threading.Thread.Sleep(10);
            }
        }

        private IEnumerable<Vector2> Draw()
        {
            var nextPoint = new Vector2();
            rotationPointRotationInRadians = 0;
            
            while(rotationPointRotationInRadians <= (2 * Math.PI))
            {
                var x = (float)(circle.CenterPosition.x + Math.Cos(rotationPointRotationInRadians) * circle.Radius);
                var y = (float)(circle.CenterPosition.y + Math.Sin(rotationPointRotationInRadians) * circle.Radius);

                nextPoint = new Vector2(x, y);

                rotationPointRotationInRadians += 0.1f;
                yield return nextPoint;
            }


            yield return nextPoint;
        }
    }
}
