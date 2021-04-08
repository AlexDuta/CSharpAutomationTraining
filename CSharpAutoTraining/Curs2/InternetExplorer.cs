using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1.Curs2
{
    class InternetExplorer : Browser
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayThreeTimesWindowFrame()
        {
            if (WindowWidth_int > 1920)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Window width is higher than 1920: {WindowWidth_int}");
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Windows width is less than 1920 : { WindowWidth_int}");
                }
            }
        }
    }
}
