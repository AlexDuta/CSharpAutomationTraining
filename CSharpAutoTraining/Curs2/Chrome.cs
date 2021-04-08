using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1.Curs2
{
    class Chrome :Browser
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayWidowWidth()
        {
            if (WindowWidth_int > 1920)
            {
                Console.WriteLine(WindowWidth_int);
            }
            else
            {
                Console.WriteLine("Window width less than 1920");
            }
        }
    }
}