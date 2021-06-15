using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Shaper_Tracer
{
    class DrawSurface
    {
        public readonly Point CentrePoint;
        public DrawSurface(Panel panel)
        {
            CentrePoint = GetCentrePoint(panel);
        }

        private Point GetCentrePoint(Panel panel)
        {
            var topleft = panel.Location;
            var halfWidth = panel.Width / 2;
            var halfHeight = panel.Height / 2;
            
            return new Point(topleft.X, topleft.Y);
        }
    }
}