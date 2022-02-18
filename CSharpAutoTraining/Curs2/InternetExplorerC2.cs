using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class InternetExplorerC2
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void displayWindowWidht()
        {
            if(WindowWidth_int > 1920)
            {
                int index = 0;
                while(index < 3)
                {
                    Console.WriteLine("InternetExplorer: "+WindowWidth_int);
                    index++;
                }
            }
            else
            {
                for(int i = 0; i < 2;  i++)
                {
                    Console.WriteLine("InternetExplorer: "+WindowWidth_int);
                }
            }
        }
    }
}
