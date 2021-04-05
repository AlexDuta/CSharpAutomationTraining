using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.D
{
    class InternetExplorer
    {
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
