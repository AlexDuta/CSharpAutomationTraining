using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class InternetExplorer
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;
        public void displayWindowWidth()
        {
            if (WindowWidth_int > 1920)
            {
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine(WindowWidth_int);
                    i++;
                }
            }
            else
            {
                for(int i = 0;i<2;i++)
                {
                    Console.WriteLine(WindowWidth_int);
                }
            }
        }
    }
}
