using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs2;

namespace CSharpAutoTraining
{
    internal class Test
    {
        static void Main(string[] args)
        {
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

            chrome.displayWindowWidth(1900);
            chrome.displayWindowWidth(2100);

            internetExplorer.displayWindowWidth(1900);
            internetExplorer.displayWindowWidth(2000);

            Console.ReadKey();

        }
    }
}
