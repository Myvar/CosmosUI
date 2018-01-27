using System;
using System.Collections.Generic;
using System.Text;
using CosmosGL.System;
using CosmosGL.System.Graphics;
using CosmosUI.System;
using Sys = Cosmos.System;

namespace TestKernel
{
    public class Kernel: Sys.Kernel
    {
        public VbeScreen Screen = new VbeScreen();

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Booting CosmosUI");

            Screen.SetMode(VbeScreen.ScreenSize.Size1280X1024, VbeScreen.Bpp.Bpp32);
            Screen.Clear(Colors.Blue);

            GuiEngine.Load(new Canvas(1280, 1024));
        }
        
        protected override void Run()
        {
            GuiEngine.Run();
        }
    }
}
