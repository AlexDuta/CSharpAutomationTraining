using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class InternetExplorer
    {
        public int WindowWidth_int;
        public string WindowWidth_string;
        public double WindowWidth_double;

        public void displayInternetExplorerWidth()
        {
            int i = 0;
            if(WindowWidth_int > 1920)
            {
                while(i < 3){
                    Console.WriteLine("Explorer width is: " + WindowWidth_int);
                    i++;
                }
            }
            else
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Explorer width is: " + WindowWidth_int);
                }
            }
        }
    }
}
