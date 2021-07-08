using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaper_Tracer
{
    public partial class MainForm : Form
    {
        Graphics graphics;
        BasicPen pen;
        DrawSurface drawSurface;
        DrawCircle drawCircle;
        TraceSquare traceSquare;
        public MainForm()
        {
            InitializeComponent();

            graphics = DrawPanel.CreateGraphics();
            pen = new BasicPen(graphics);
            drawSurface = new DrawSurface(DrawPanel);

            Circle circle = new Circle(new Vector2(100, 200), 100);
            drawCircle = new DrawCircle(circle);

            traceSquare = new TraceSquare(new Square(new Vector2(100, 100), 100));
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //pen.DrawAt(e.Location);
        }

        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(drawSurface.StartColour);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            traceSquare.Draw(graphics, pen.pen);
        }
    }
}
