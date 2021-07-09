using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Shaper_Tracer
{
    class BasicPen
    {
        private readonly Graphics graphics;
        public readonly Pen pen;
        public BasicPen(Graphics graphics)
        {
            this.graphics = graphics;
            pen = new Pen(Color.Black);
        }

        public void DrawAt(Point point)
        {
            graphics.DrawEllipse(pen, point.X, point.Y, 10, 10);
        }
    }
}
