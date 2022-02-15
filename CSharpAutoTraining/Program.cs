using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Hello World program in C#
            Console.WriteLine("Hello world");
           
            Browser browser = new Browser(4000);

            Console.WriteLine(browser.WindowWidth);
            browser.ChangeWindowWidth(3000);
            Console.WriteLine(browser.WindowWidth);
            Console.ReadKey();


        }
    }
}