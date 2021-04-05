using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Curs2_B
{
    class Firefox
    {
        //variable
        public int intFireFox = 32;
        public String stringFireFox = "10076,8765,76.765";
        public double doubleFireFox = 23.345;

        public void DisplayConvert()
        {
            Console.WriteLine(Convert.ToInt32(doubleFireFox));
            Console.WriteLine(Convert.ToDouble(stringFireFox));
            Console.WriteLine(Convert.ToString(intFireFox));
        }
    }
}
