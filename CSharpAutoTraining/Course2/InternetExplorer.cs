using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course2
{
    class InternetExplorer
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void Display3Or2()
        {
            if (WindowWidth_int > 1920)
            {
                int dur = 0;
                while(dur < 3)
                {
                    Console.WriteLine("Window Width: {0}", WindowWidth_int);
                    dur++;
                }
            }
            else
            {
                for(int dur = 0; dur < 2; dur++)
                {
                    Console.WriteLine("Window Width: {0}", WindowWidth_int);
                }
            }
        }

    }
}
