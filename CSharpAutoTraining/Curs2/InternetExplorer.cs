using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Curs2_D
{
    class InternetExplorer
    {
        //variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;
        public void DisplayWindowW()
        {
            int windowWidth = 1920;
            for (windowWidth = 1; windowWidth < 3; windowWidth++)
            {
                Console.WriteLine("Window width " + windowWidth);

            }
        }
    }
}
