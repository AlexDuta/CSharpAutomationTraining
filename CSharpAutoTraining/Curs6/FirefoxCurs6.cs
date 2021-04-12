using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class FirefoxCurs6
    {
        int WindowWidth = 0;
        public FirefoxCurs6()
        {
            Console.WriteLine(WindowWidth);
        }
        public FirefoxCurs6(int val)
        {
            WindowWidth = val;
        }
        public FirefoxCurs6(double val)
        {
            WindowWidth = (int)val;
        }
        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
