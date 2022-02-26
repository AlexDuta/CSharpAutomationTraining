using System;
using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs2;
using CSharpAutoTraining.Curs3;
using CSharpAutoTraining.Curs4;
using CSharpAutoTraining.Curs5;
using CSharpAutoTraining.Curs6;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curs1 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 1");
            Console.WriteLine("--------------------------------------");

            /*Browser browser = new Browser();
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidht(1920);
            browser.DisplayBrowserResolution();*/

            //Curs2 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 2");
            Console.WriteLine("--------------------------------------");

            BrowserC2 browserC2 = new BrowserC2();
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



            //Curs3 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 3");
            Console.WriteLine("--------------------------------------");
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




            //Curs4 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 4");
            Console.WriteLine("--------------------------------------");

            FirefoxC4 firefoxC4 = new FirefoxC4();
            Skype skype = new Skype();

            firefoxC4.StartBrowser();
            firefoxC4.WindowWidht = 1080;
            Console.WriteLine(firefoxC4.WindowWidht);
            firefoxC4.WindowWidht = 1000;
            Console.WriteLine(firefoxC4.WindowWidht);
            firefoxC4.About();
            firefoxC4.Ping();

            skype.About();
            skype.Ping();

            //Curs5 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 5");
            Console.WriteLine("--------------------------------------");

            BrowserC5 browserC5 = new BrowserC5();
            browserC5.SendTextToElement();
            BrowserC5a browserC5a = new BrowserC5a();
            browserC5a.SendTextToElement();
            BrowserC5b browserC5b = new BrowserC5b();
            //browserC5b.SendTextToElement();


            //Curs6 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 6");
            Console.WriteLine("--------------------------------------");

            var WindowWidth = 0;
            FirefoxC6 firefoxC6a = new FirefoxC6();
            FirefoxC6 firefoxC6b = new FirefoxC6(1920);
            WindowWidth = firefoxC6b.GetWindowWidth();
            Console.WriteLine("WindowWidth: " + WindowWidth);
            FirefoxC6 firefoxC6c = new FirefoxC6(1500.5);
            WindowWidth = firefoxC6c.GetWindowWidth();
            Console.WriteLine("WindowWidth: " + WindowWidth);

            HomePage homePage = new HomePage();
            Console.WriteLine("Image: " + homePage.Image);


            //Curs7 - Practice

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Curs 7");
            Console.WriteLine("--------------------------------------");

            Console.ReadLine();

        }
    }
}