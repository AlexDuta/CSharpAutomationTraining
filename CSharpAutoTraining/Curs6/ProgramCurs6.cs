using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class ProgramCurs6
    {
        public static void Main()
        {
            Firefox firefox = new Firefox();
            Firefox firefoxInt = new Firefox(1922);
            Firefox firefoxDouble = new Firefox(1923.2);

            var Width = firefox.GetWindowWidth();
            var Width1 = firefoxInt.GetWindowWidth();
            var Width2 = firefoxDouble.GetWindowWidth();

            Console.WriteLine(Width + " " + Width1 + " " + Width2);
        }
    }
}
