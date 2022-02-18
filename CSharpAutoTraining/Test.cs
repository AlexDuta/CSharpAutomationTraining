using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs3;

namespace CSharpAutoTraining
{
    internal class Test
    {
        static void Main(string[] args)
        {
            /*
            --tema 2

            Browser browser = new Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();

            firefox.WindowWidth_int = 1200;
            firefox.WindowWidth_double = 1000.2;
            firefox.WindowWidth_string = "1020";

            string s = Convert.ToString(firefox.WindowWidth_int);
            double d = Convert.ToDouble(firefox.WindowWidth_string);
            int i = Convert.ToInt32(firefox.WindowWidth_double);

            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.WriteLine(i);

            chrome.DisplayWindowWidth(1900);
            chrome.DisplayWindowWidth(2100);

            internetExplorer.DisplayWindowWidth(1900);
            internetExplorer.DisplayWindowWidth(2000);*/

 
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internetExplorer = new InternetExplorer();
            Edge edge = new Edge();

            Console.WriteLine("Firefox");
            firefox.ChangeWindowWidth(1000);
            firefox.setProfile("user");

            Console.WriteLine("\nChrome");
            chrome.ChangeWindowWidth(1000);
            chrome.ChangeWindowWidth("1200");

            Console.WriteLine("\nInternet Explorer");
            internetExplorer.ChangeWindowWidth(1000);

            Console.WriteLine("\nEdge");
            edge.ChangeWindowWidth(1000);
            edge.NewFeatureFunction();
            


            Console.ReadKey();

        }
    }
}
