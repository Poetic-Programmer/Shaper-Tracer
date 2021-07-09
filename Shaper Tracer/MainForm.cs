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
        ShapeTracerProgram shapeTracerProgram;

        public MainForm()
        {
            InitializeComponent();

            graphics = DrawPanel.CreateGraphics();
            shapeTracerProgram = new ShapeTracerProgram(graphics, DrawPanel);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(shapeTracerProgram.GetBackgroundColour());
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            shapeTracerProgram.RunTrace(graphics); 
        }
    }
}
