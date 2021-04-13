using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Curs2_C
{
    class Chrome
    {
        //variables
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;
        public void DisplayWindowWidth()
        {
            int windowWidth = 1920;
            if (windowWidth < 1920)
            {
                Console.WriteLine("Window width less than 1920");
            }

        }
    }
}
