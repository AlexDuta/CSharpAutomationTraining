using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.B
{
    class Firefox
    {
        public int WindowWidth_int = 1000;
        public string WindowWidth_string = "10000,4567,123.875";
        public double WindowWidth_double = 5678.754;

        public void DisplayConvertWidth()
        {
            Console.WriteLine(Convert.ToInt32(WindowWidth_double));
            Console.WriteLine(Convert.ToDouble(WindowWidth_string));
            Console.WriteLine(Convert.ToString(WindowWidth_int));
        }
    }
}
