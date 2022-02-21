using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2
{
    class Chrome
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayWindowWidth()
        {
            if (WindowWidth_int > 1920)
            {
                Console.WriteLine("Window Width > 1920");
            }
            else
            {
                Console.WriteLine("Window Width less than 1920");
            }
        }
    }
}
