using System;
using CSharpAutoTraining.Course1;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Hello World program in C#
            Console.WriteLine("Hello world");

            var browser = new Browser(4000,3000);

            browser.DisplayResolution();
            browser.ChangeWindowWidth(1920);
            browser.ChangeWindowHeight(1080);
            browser.DisplayResolution();
            Console.ReadLine();

        }
    }
}