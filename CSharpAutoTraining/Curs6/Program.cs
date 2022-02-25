using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int val;
            FirefoxCurs6_1 firefox1 = new FirefoxCurs6_1();
            FirefoxCurs6_1 firefox2 = new FirefoxCurs6_1(2000);
            FirefoxCurs6_1 firefox3 = new FirefoxCurs6_1(1000.50);
            val = firefox1.GetWindowWidth();
            Console.Write("No args: ");
            Console.WriteLine(val);
            val = firefox2.GetWindowWidth();
            Console.Write("Int arg:");
            Console.WriteLine(val);
            val = firefox3.GetWindowWidth();
            Console.Write("Double arg:");
            Console.WriteLine(val);
            Console.ReadLine();

        }
    }
}
