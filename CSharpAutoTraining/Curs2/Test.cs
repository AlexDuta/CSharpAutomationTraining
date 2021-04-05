using A;
using B;
using C;
using D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs2
{
    class Test
    {
        public static void Main(string[] args)
        {
            Browser browser = new Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            InternetExplorer internet = new InternetExplorer();

            firefox.WindowWidth_int = 15;
            firefox.WindowWidth_string = "54";
            firefox.WindowWidth_double = 392.54;

            String s = firefox.WindowWidth_int.ToString();
            Console.WriteLine("String = " + s);

            double d = Convert.ToDouble(firefox.WindowWidth_string);
            Console.WriteLine("Double = " + d);

            int nr = Convert.ToInt32(firefox.WindowWidth_double);
            Console.WriteLine("Int = " + nr);

            chrome.WindowWidth_int = 1930;
            chrome.checkChromeWindowWidth();

            internet.WindowWidth_int = 1930;
            internet.displayInternetExplorerWidth();

            Console.ReadKey();
        }
    }
}
