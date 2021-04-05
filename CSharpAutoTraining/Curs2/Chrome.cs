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
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void checkChromeWindowWidth()
        {
            if(WindowWidth_int >= 1920)
            {
                Console.WriteLine("Chrome Window Width is greater or equal than 1920");
            }
            else
            {
                Console.WriteLine("Chrome Window Width is less than 1920");
            }
        }
    }
}
