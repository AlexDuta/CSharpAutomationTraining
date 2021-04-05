using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAutoTraining.A;
using CSharpAutoTraining.B;
using CSharpAutoTraining.C;
using CSharpAutoTraining.D;


namespace CSharpAutoTraining.Curs2
{
    class Test
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            Chrome chrome = new Chrome();
            Firefox fireFox = new Firefox();
            InternetExplorer internetExplorer = new InternetExplorer();

            fireFox.WindowWidth_int = 10;
            fireFox.WindowWidth_double = 10.5;
            fireFox.WindowWidth_string = "10.51";

            string fireFox_string = Convert.ToString(fireFox.WindowWidth_int);
            Console.WriteLine("String: " + fireFox_string);

            double fireFox_double = Convert.ToDouble(fireFox.WindowWidth_string);
            Console.WriteLine("Double: " + fireFox_double);

            int fireFox_int = Convert.ToInt32(fireFox.WindowWidth_double);
            Console.WriteLine("Integer: " + fireFox_int);

            Console.WriteLine(fireFox_string);
            Console.WriteLine(fireFox_double);
            Console.WriteLine(fireFox_int);

            chrome.WindowWidth_int = 1921;
            chrome.DisplayWidowWidth();

            internetExplorer.WindowWidth_int = 1920;
            internetExplorer.DisplayThreeTimesWindowFrame();

            Console.ReadLine();

        }
    }
}
