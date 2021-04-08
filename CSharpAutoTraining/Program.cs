using System;
using A;
using B;
using C;
using D;
using CSharpAutoTraining.Curs3;
using CSharpAutoTraining.Curs4;
using CSharpAutoTraining.Curs5;

namespace Curs1
{
    class Program
    {
        static void Main(String[] args)
        {
            //testare exercitii de la cursul 5
            Console.WriteLine("Exercitii cursul 5");
            BrowserCurs5 browserCurs5 = new BrowserCurs5();
            browserCurs5.SendTextToElement();

            BrowserCurs5Internal browserCurs5Internal = new BrowserCurs5Internal();
            browserCurs5Internal.SendTextToElement();

            BrowserCurs5Private browserCurs5Private = new BrowserCurs5Private();
            //browserCurs5Private. can not call method because is private
            //testare exercitii de la cursul 4
            Console.WriteLine("\n Exercitii cursul 4");
            FirefoxCurs4 firefox = new FirefoxCurs4();
            firefox.WindowWidth = 1000;
            firefox.StartBrowser();
            firefox.About();
            firefox.Ping();

            SkypeCurs4 skype = new SkypeCurs4();
            skype.About();
            skype.Ping();
            /**
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
            **/
            Console.ReadKey();
        }
    }
}