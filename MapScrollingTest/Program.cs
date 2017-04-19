using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapScrollingTest
{
    using MapScrollingTest.GameScreens;
    using SFML.Graphics;
    using SFML.Window;

    class Program
    {
        private static RenderWindow window;
        private static MapScreen map;

        static void Main(string[] args)
        {
            Initialize();
            MainLoop();
            //Console.ReadKey(); //can't readkey if there is no console.
        }

        private static void MainLoop()
        {
            while(window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                map.Draw(window);
                window.Display();
            }
            Console.WriteLine("main loop ended");
        }

        private static void Initialize()
        {
            var contextSettings = new ContextSettings { DepthBits = 24 };
            var vidMode = new VideoMode(640, 480);
            window = new RenderWindow(vidMode, "Map Scroller", Styles.Close | Styles.Titlebar, contextSettings);
            window.SetActive();
            window.SetKeyRepeatEnabled(false);
            window.Closed += (sender, args) => ShutDown();

            map = new MapScreen();
        }

        private static void ShutDown()
        {
            window.SetActive(false);
            window.Close();
        }
    }
}
