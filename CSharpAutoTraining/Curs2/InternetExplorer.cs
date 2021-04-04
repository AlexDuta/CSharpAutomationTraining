using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class InternetExplorer
    {
        public int WindowWidth_int;
        public String WindowWidth_string;
        public double WindowWindth_double;

        public void DisplayWindowWidth()
        {
            int i = 0;
            if (WindowWidth_int > 1920)
            {
                while( i < 3)
                {
                    Console.WriteLine($"Window width is {WindowWidth_int} in InternetExplorer");
                    i++;
                }
            }
            else
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Window width is {WindowWidth_int} in InternetExplorer");
                }
            }
        }
    }
}
