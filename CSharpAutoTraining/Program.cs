using System;
using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs2;
using CSharpAutoTraining.Curs3;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curs1 - Practice

            /*Browser browser = new Browser();
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidht(1920);
            browser.DisplayBrowserResolution();*/

            //Curs2 - Practice

            /*BrowserC2 browserC2 = new BrowserC2();
            ChromeC2 chromeC2 = new ChromeC2();
            FirefoxC2 firefoxC2 = new FirefoxC2();
            InternetExplorerC2 internetExplorerC2 = new InternetExplorerC2();

            firefoxC2.WindowWidth_int = 1024;
            firefoxC2.WindowWidth_string = "1024";
            firefoxC2.WindowWidth_double = 1024.0;

            Console.WriteLine(Convert.ToString(firefoxC2.WindowWidth_int));
            Console.WriteLine(Convert.ToDouble(firefoxC2.WindowWidth_string));
            Console.WriteLine(Convert.ToInt32(firefoxC2.WindowWidth_double));


            chromeC2.displayWindowWidth();
            chromeC2.WindowWidth_int = 2000;
            chromeC2.displayWindowWidth();

            internetExplorerC2.displayWindowWidht();
            internetExplorerC2.WindowWidth_int = 2000;
            internetExplorerC2.displayWindowWidht();

            Console.ReadLine();*/

            //Curs3 - Practice

            FirefoxC3 firefoxC3 = new FirefoxC3();
            ChromeC3 chromeC3 = new ChromeC3();
            InternetExplorerC3 internetExplorerC3 = new InternetExplorerC3();
            EdgeC3 edgeC3 = new EdgeC3();

            firefoxC3.ChangeWindowWidth(1);
            firefoxC3.About();
            firefoxC3.SetProfile("firefox");

            chromeC3.ChangeWindowWidth(1);
            chromeC3.ChangeWindowWidth("chrome");
            chromeC3.About();

            internetExplorerC3.ChangeWindowWidth(1);
            internetExplorerC3.About();

            edgeC3.ChangeWindowWidth(1);
            edgeC3.About();
            edgeC3.NewFeatureFunction();

            Console.ReadLine();




        }
    }
}