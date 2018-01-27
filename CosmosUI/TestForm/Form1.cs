using CosmosUI.System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FormCanvas canvas;

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
             canvas = new FormCanvas(Width, Height);
            GuiEngine.Load(canvas);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var g = CreateGraphics();

            GuiEngine.Run();

            //g.Clear(System.Drawing.Color.White);
            g.DrawImageUnscaled(canvas.Bitmap, 0, 0);
        }
    }
}
