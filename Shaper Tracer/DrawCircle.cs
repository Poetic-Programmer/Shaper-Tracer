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
        float angleInRadians;
        float radius;
        Point Center;
        public DrawCircle(Point Center)
        {
            angleInRadians = 0;
            radius = 100;
            this.Center = Center;
        }

        public void Draw(Point centerOfCircle, Graphics graphics, Pen pen)
        {
            foreach(Point p in Draw())
            {
                graphics.DrawEllipse(pen, p.X, p.Y, radius, radius);
                System.Threading.Thread.Sleep(10);
            }
        }

        private IEnumerable<Point> Draw()
        {
            var nextPoint = new Point();
            angleInRadians = 0;
            
            while(angleInRadians <= (2 * Math.PI))
            {
                var x = Center.X + Math.Cos(angleInRadians) * radius;
                var y = Center.Y + Math.Sin(angleInRadians) * radius;

                nextPoint = new Point((int)x, (int)y);

                angleInRadians += 0.1f;
                yield return nextPoint;
            }


            yield return nextPoint;
        }
    }
}
