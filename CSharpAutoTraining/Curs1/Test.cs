using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        static void Main(string[] args)
        {
            var browser = new Browser();
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidth(1920);
            browser.DisplayWidthAndHeight();
            Console.ReadKey();

            byte a1 = 124;
            object a11 = 56;
            float a2 = 1.2345677777f;
            double a3 = 1.2121441121212;
            decimal a4 = 1.8998890m;
            Console.WriteLine(Convert.ToInt32(a1));

            int a5 = 10;
            Console.WriteLine(a5);
            Console.WriteLine(a5++);
            Console.WriteLine(a5);

            int index = 9;
            if (index == 9)
            {
                Console.WriteLine("index = 9");
            }
            else if (index < 0)
            {
                Console.WriteLine("index < 0");
            }
            else if (index > 0)
            {
                Console.WriteLine("index > 0");
            }
            else
            {
                Console.WriteLine("Error");
            }

            int a7 = 5;
            switch (a7)
            {
                case 5:
                    Console.WriteLine("switch: a7 = 5");
                    break;
                case 8:
                    Console.WriteLine("switch a7 = 8");
                    break;
                default:
                    Console.WriteLine("unknown value");
                    break;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"For: {i}");
            }
        }
    }
}
