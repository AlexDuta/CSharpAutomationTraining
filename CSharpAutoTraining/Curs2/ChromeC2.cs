using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class ChromeC2
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void displayWindowWidth()
        {
            if(WindowWidth_int > 1920)
            {
                Console.WriteLine("Chrome: "+WindowWidth_int);
            }
            else
            {
                Console.WriteLine("Chrome: window width less than 1920");
            }
        }
    }
}
