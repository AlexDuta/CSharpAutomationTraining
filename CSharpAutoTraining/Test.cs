using A;
using B;
using C;
using CSharpAutoTraining.Curs1;
using CSharpAutoTraining.Curs3;
using CSharpAutoTraining.Curs4;
using CSharpAutoTraining.Curs5;
using D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining
{
    class Test
    {
        public static void Main(string[] args)
        {
            //Tema Curs 1
            //BrowserCurs1 browser = new BrowserCurs1();
            //browser.changeWindowHeight(1080);
            //browser.changeWindowWidth(1920);
            //browser.showWindowHeightandWidth();

            //Tema Curs 2
            //Browser browser = new Browser();
            //Firefox firefox = new Firefox();
            //Chrome chrome = new Chrome();
            //InternetExplorer internet = new InternetExplorer();

            //firefox.WindowWidth_int = 15;
            //firefox.WindowWidth_string = "54";
            //firefox.WindowWidth_double = 392.54;

            //String s = firefox.WindowWidth_int.ToString();
            //Console.WriteLine("String = " + s);

            //double d = Convert.ToDouble(firefox.WindowWidth_string);
            //Console.WriteLine("Double = " + d);

            //int nr = Convert.ToInt32(firefox.WindowWidth_double);
            //Console.WriteLine("Int = " + nr);

            //chrome.WindowWidth_int = 1930;
            //chrome.checkChromeWindowWidth();

            //internet.WindowWidth_int = 1930;
            //internet.displayInternetExplorerWidth();



            //Tema Curs 3
            //FirefoxCurs3 firefox = new FirefoxCurs3();
            //ChromeCurs3 chrome = new ChromeCurs3();
            //InternetExplorerCurs3 internet = new InternetExplorerCurs3();
            //EdgeCurs3 edge = new EdgeCurs3();

            //firefox.About();
            //firefox.ChangeWindowWidth(400);
            //firefox.SetProfile("raulB");

            //chrome.About();
            //chrome.ChangeWindowWidth(500);
            //chrome.ChangeWindowWidth("320");

            //internet.About();
            //internet.ChangeWindowWidth(259);

            //edge.ChangeWindowWidth(345);
            //edge.About();
            //edge.newFeatureFunction();
            //edge.version = 4;
            //Console.WriteLine("Edge version is: " + edge.version);

            //Tema Curs 4

            //FirefoxCurs4 firefox = new FirefoxCurs4();
            //Skype skype = new Skype();

            //firefox.About();
            //firefox.StartBrowser();
            //firefox.Ping();
            //firefox.WindowWidth = 1930;

            //skype.About();
            //skype.Ping();


            //Tema Curs 5

            BrowserCurs5 browser = new BrowserCurs5();
            browser.SendTextToElement();

            //pentru cazul cand metoda SendTextToElement este private nu va putea fi apelata aici in main
            //pentru cazul cand metoda SendTextToElement este internal ea va putea fi apelata aici in main



            Console.ReadKey();


        }
    }
}
