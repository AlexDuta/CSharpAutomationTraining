using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class FirefoxCurs4:BrowserCurs4,IComponent,INetwork
    {
        private int windowWidth = 1920;

        public int WindowWidth
        {
            get
            {
                return windowWidth;
            }
            set
            {
                if (value > 1024 & value <= 1920)
                {
                    windowWidth = value;
                }
                else
                {
                    Console.WriteLine("You can't set this value");
                }
            }

        }
        public void About()
        {
            Console.WriteLine("About Firefox");
        }
        public void Ping()
        {
            Console.WriteLine("Firefox Ping");
        }
        public override void StartBrowser()
        {
            Console.WriteLine("Start Firefox Browser with window width: "+WindowWidth);
        }
    }
}
