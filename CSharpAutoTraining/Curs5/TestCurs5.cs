using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs5
{
    class TestCurs5
    {
        static void Main(string[] args)
        {
            BrowserCurs5 browser = new BrowserCurs5();
            BrowserCurs5_1 browser1 = new BrowserCurs5_1();
            BrowserCurs5_2 browser2 = new BrowserCurs5_2();

            browser.SendTextToElement(); // public - accesible
            browser1.SendTextToElement(); // internal - accesible
            // browser2.SendTextToElement(); // private - inaccesible due his protection level

            Console.ReadKey();
        }
    }
}
