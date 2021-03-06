using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Shaper_Tracer
{
    class ShapeTracerProgram
    {
        BasicPen pen;
        DrawSurface drawSurface;
        List<ShapeTrace> tracers;
        ShapeTracer tracer;

        public ShapeTracerProgram(Graphics graphics, Panel drawPanel)
        {
            pen = new BasicPen(graphics);
            drawSurface = new DrawSurface(drawPanel);

            tracers = SetTracers();
            tracer = new ShapeTracer(tracers);
        }

        public Color GetBackgroundColour()
        {
            return drawSurface.StartColour;
        }

        public void RunTrace(Graphics graphics)
        {
            tracer.Trace(graphics, pen);
        }

        private List<ShapeTrace> SetTracers()
        {
            var tracers = new List<ShapeTrace>();

            var center = drawSurface.CentrePoint;

            //tracers.Add(new TraceSquare(new Square(new Vector2(0, center.Y), 25)));
            //tracers.Add(new DrawCircle(new Circle(new Vector2(0, 0), 50)));
            tracers.Add(new TraceSquare(new Square(new Vector2(0, 0), 50)));
            tracers.Add(new DrawCircle(new Circle(new Vector2(), 25)));
            //tracers.Add(new TraceSquare(new Square(new Vector2(center.X, center.Y), 50)));
            

            return tracers;
        }
    }
}
