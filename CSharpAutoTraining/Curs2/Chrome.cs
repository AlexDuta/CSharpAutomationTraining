using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    internal class Chrome
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void DisplayWindowWidth(int WindowWidth_int)
        {
            if(WindowWidth_int > 1920)
            {
                Console.WriteLine(WindowWidth_int);
            } else
            {
                Console.WriteLine("window width less than 1920");
            }

        }
    }
}
