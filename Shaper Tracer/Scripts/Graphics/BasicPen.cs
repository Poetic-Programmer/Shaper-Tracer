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
        private readonly Pen pen;

        public BasicPen(Graphics graphics)
        {
            this.graphics = graphics;
            pen = new Pen(Color.Black);
        }

        public void DrawAt(Vector2 position)
        {
            graphics.DrawEllipse(pen, position.x, position.y, 2, 2);
        }
    }
}
