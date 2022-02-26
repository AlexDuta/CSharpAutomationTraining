using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class FirefoxC6
    {
        int WindowWidth = 1024;
        public FirefoxC6() { }
        public FirefoxC6(int val)
        {
            WindowWidth = val;
        }
        public FirefoxC6(double val) 
        {
            Console.WriteLine("Nu stiu ce ar trebui sa faca constructorul asta.");
        }
        public int GetWindowWidth()
        {
            return WindowWidth;
        }

        
    }
}
