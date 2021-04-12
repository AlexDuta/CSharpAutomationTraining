using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class FirefoxCurs6
    {
        private int WindowWidth;

        public FirefoxCurs6()
        {

        }

        public FirefoxCurs6(int val)
        {
            WindowWidth = val;
        }

        public FirefoxCurs6(double val)
        {
            WindowWidth = Convert.ToInt32(val);
        }

        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
