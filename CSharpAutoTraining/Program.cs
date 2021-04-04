using System;
using A;
using B;
using C;
using D;
using CSharpAutoTraining.Curs3;

namespace Curs1
{
    class Program
    {
        static void Main(String[] args)
        {
            // testare exercitii de la cursul 2
            Console.WriteLine("Exercitii cursul 2");
            Browser browser = new Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();

            firefox.WindowWidth_int = 1920;
            firefox.WindowWidth_string = "1900";
            firefox.WindowWindth_double = 1935.5;
            String WindowWidthString = Convert.ToString(firefox.WindowWidth_int);
            double WindowWidthDouble = Convert.ToDouble(firefox.WindowWidth_string);
            int WindowWidthInt = Convert.ToInt16(firefox.WindowWindth_double);
            Console.WriteLine($"Converted to string {WindowWidthString}");
            Console.WriteLine($"Converted to double {WindowWidthDouble}");
            Console.WriteLine($"Converted to int {WindowWidthInt}");

            chrome.WindowWidth_int = 1930;
            chrome.DisplayWindowWidth();
            chrome.WindowWidth_int = 1900;
            chrome.DisplayWindowWidth();

            internetExplorer.WindowWidth_int = 1930;
            internetExplorer.DisplayWindowWidth();
            internetExplorer.WindowWidth_int = 1900;
            internetExplorer.DisplayWindowWidth();

            //testare exercitii de la cursul 3
            Console.WriteLine("\n Exercitii cursul 3");
            FirefoxCurs3 firefoxCurs3 = new FirefoxCurs3();
            ChromeCurs3 chromeCurs3 = new ChromeCurs3();
            InternetExplorerCurs3 internetExplorerCurs3 = new InternetExplorerCurs3();
            EdgeCurs3 edgeCurs3 = new EdgeCurs3();

            firefoxCurs3.About();
            firefoxCurs3.ChangeWindowWidth(1920);
            firefoxCurs3.SetProfile("Anda");

            chromeCurs3.About();
            chromeCurs3.ChangeWindowsWidt("2000");
            chromeCurs3.ChangeWindowWidth(1920);

            internetExplorerCurs3.About();
            internetExplorerCurs3.ChangeWindowWidth(1920);

            edgeCurs3.About();
            edgeCurs3.ChangeWindowWidth(1860);
            edgeCurs3.Version = 1;
            edgeCurs3.NewFutureFunction();
            Console.ReadKey();
        }
    }
}