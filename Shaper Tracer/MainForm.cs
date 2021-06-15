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
        public MainForm()
        {
            InitializeComponent();

            graphics = DrawPanel.CreateGraphics();
            pen = new BasicPen(graphics);
            drawSurface = new DrawSurface(DrawPanel);
            drawCircle = new DrawCircle(drawSurface.CentrePoint);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //pen.DrawAt(e.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawCircle.Draw(drawSurface.CentrePoint, graphics, pen.pen);
        }

        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.AliceBlue);
        }
    }
}
