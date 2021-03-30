using CSharpAutoTraining.Curs1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Hello World program in C#
            var browser = new Browser(780);


            Console.WriteLine(browser.WindowWidth);
            // browser.ChangeWindowWidth(100);
            //Console.WriteLine(browser.WindowWidth);


            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}