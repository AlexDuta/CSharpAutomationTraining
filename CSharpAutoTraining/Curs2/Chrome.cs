using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Chrome
    {
        public int WindowWidth_int;
        public String WindowWidth_string;
        public double WindowWindth_double;

        public void DisplayWindowWidth()
        {
            if (WindowWidth_int > 1920)
            {
                Console.WriteLine($"Window width is {WindowWidth_int} in Chrome");
            }
            else
            {
                Console.WriteLine("Window width is less than 1920");
            }
        }
    }
}
