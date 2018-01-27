using System;
using System.Collections.Generic;
using System.Text;
using CosmosGL.System.Graphics;

namespace CosmosUI.System
{
    public static class GuiEngine
    {
        public static ICanvas Canvas { get; set; }
        public static Graphics Graphics { get; set; }

        public static void Load(ICanvas canvas)
        {
            Canvas = canvas;
            Graphics = new Graphics(Canvas);
            Graphics.Clear(Colors.CornflowerBlue);

            Graphics.FillRectangle(10, 10, 10, 10, Colors.Red);
            Graphics.FillRectangle(20, 10, 10, 10, Colors.Green);
            Graphics.FillRectangle(30, 10, 10, 10, Colors.Blue);

            Graphics.FillRectangle(10, 20, 10, 10, Colors.Cyan);
            Graphics.FillRectangle(20, 20, 10, 10, Colors.Magenta);
            Graphics.FillRectangle(30, 20, 10, 10, Colors.Yellow);
        }

        public static void Run()
        {
            Graphics.Flush();
        }
    }
}