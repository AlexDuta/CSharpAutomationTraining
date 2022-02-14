using CSharpAutoTraining.Curs_1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {

            var browser = new Browser(3000);
            Console.WriteLine(browser.WindowWidth);
            browser.ChangeWindowWidth(2022);
            Console.WriteLine(browser.WindowWidth);
            // simple Hello World program in C#
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}