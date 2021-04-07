using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public abstract class BrowserCurs4
    {
        private int windowWidth=1920;
        public int WindowWidth { get { return windowWidth; }
            set
            {
                if (value < 1024)
                {
                    Console.WriteLine("You cannot set the value less than 1024.");
                }
                else if(value > 1920)
                {
                    Console.WriteLine("You cannot set the value greater than 1920.");
                }
                else
                {
                    windowWidth = value;
                    Console.WriteLine("The new set value is: " + windowWidth);
                }
            }
        }

        public abstract void StartBrowser();

    }
}
