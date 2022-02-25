using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.Curs5;

namespace CSharpAutoTraining
{
    class Test
    {
        public static void Main_5(string[] args)
        {
            Browser browser = new Browser();
            Browser_2 browser2 = new Browser_2();
            Browser_3 browser3 = new Browser_3();
            browser.SendTextToElement();
            browser2.SendTextToElement();
            //browser3.SendTextToElement(); Compiler Error
            Console.ReadLine();
        }
    }
}
