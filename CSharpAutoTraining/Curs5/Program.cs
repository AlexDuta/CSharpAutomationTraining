using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class Program
    {
        public static void Main(String[] args) {
            //public access
            Browser browser = new Browser();
            browser.SendTextToElement();
            Console.ReadKey();
            //internal access
            BrowserCurs5_1 browserCurs5_1 = new BrowserCurs5_1();
            browserCurs5_1.SendTextToElement();
            Console.ReadKey();
            //private access
            BrowserCurs5_2 browserCurs5_2 = new BrowserCurs5_2();
            // browserCurs5_2.SendTextToElement();
            Console.ReadKey();
        }
    }
}
