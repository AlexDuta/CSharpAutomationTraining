using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class FirefoxCurs6_1
    {
        int WindowWidth;

        public FirefoxCurs6_1()
        {
            WindowWidth = 1920;
        }

        public FirefoxCurs6_1(int val)
        {
            WindowWidth = val;
        }

        public FirefoxCurs6_1(double val)
        {
            WindowWidth = (int)val;
        }

        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
