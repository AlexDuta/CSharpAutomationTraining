using CSharpAutoTraining.Course1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Hello World program in C#
            Console.WriteLine("Hello Part Time Guys!");

            // Create Browser object
            Browser browser = new Browser(4000);

            // Show unmodified WindowWidth in Console
            Console.WriteLine(browser.WindowWidth);

            // Show modified WindowWidth in Console
            browser.ChangeWindowWidth(3000);
            Console.WriteLine(browser.WindowWidth);
            Console.ReadLine(); 
        }
    }
}