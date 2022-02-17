using CSharpAutoTraining.Course1;
using System;

namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* COURSE 1 */

            // Hello World program
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            // Browser
            Console.WriteLine("BROWSER CLASS");
            Browser browser = new Browser(1024,2048);
            Console.Write("Resolution before change: ");
            browser.DisplayWindowWidthHeight();
            browser.ChangeWindowWidth(1920);
            browser.ChangeWindowHeight(1080);
            Console.Write("Resolution after change: ");
            browser.DisplayWindowWidthHeight();
            Console.WriteLine();


            Console.ReadLine();
            
        }
    }
}