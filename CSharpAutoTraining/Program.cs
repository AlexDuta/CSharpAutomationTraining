using CSharpAutoTraining.Course1;
using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Hello World program in C#
            Console.WriteLine("Hello world");
           

            Browser browser = new Browser();

            //valoare initiala
            Console.WriteLine(browser.WindowWidth);
            //schimbare valoare
            Console.WriteLine("Change width");
            browser.ChangeWindowWidth(3000);
            Console.WriteLine(browser.WindowWidth);

            //afisez size cu metoda
            browser.DisplayWindowWidth();

            //change window height to 1080 and width to 1920
            Console.WriteLine("Change size");
            browser.ChangeWindowWidthHeight(1980, 1920);
            browser.DisplayWindowWidth();

            Console.ReadKey();
           


        }
    }
}