using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class FirefoxCurs6
    {
        public int WindowWidth=0;

        public FirefoxCurs6()
        {

        }

        public FirefoxCurs6(int val)
        {
            Console.WriteLine("Valoarea int este: " + val);
        }

        public FirefoxCurs6(double val)
        {
            Console.WriteLine("Valoarea double este: " + val);
        }

        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
