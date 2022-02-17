using System;
using A;
using B;
using C;
using D;

namespace Curs1
{
    class TestCurs2_1
    {
        static void MainCurs2(string[] args)
        {
            // simple Hello World program in C#
            /*Console.WriteLine("Hello world");

            var browser = new Browser(4000,3000);

            browser.DisplayResolution();
            browser.ChangeWindowWidth(1920);
            browser.ChangeWindowHeight(1080);
            browser.DisplayResolution();
            Console.ReadLine();
            */
            Browser browser = new Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();
            firefox.WindowWidth_int = 1920;
            firefox.WindowWidth_double = 1920;
            firefox.WindowWidth_string = "1920";
            Console.Write("Int to String:");
            Console.WriteLine(Convert.ToString(firefox.WindowWidth_int));
            Console.Write("String to Double:");
            Console.WriteLine(Convert.ToDouble(firefox.WindowWidth_string));
            Console.Write("Double to Int:");
            Console.WriteLine(Convert.ToInt32(firefox.WindowWidth_double));
            Console.WriteLine("Chrome check");
            chrome.WindowWidth_int = 800;
            chrome.displayWindowWidth();
            chrome.WindowWidth_int = 3000;
            chrome.displayWindowWidth();
            Console.WriteLine("Internet Explorer check");
            internetExplorer.WindowWidth_int = 800;
            internetExplorer.displayWindowWidth();
            internetExplorer.WindowWidth_int = 3000;
            internetExplorer.displayWindowWidth();

            Console.ReadLine();
        }
    }
}