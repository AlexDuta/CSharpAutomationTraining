using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Test_Curs4
    {
        static void Main(string[] args)
        {
            // Browser_Curs4 browser = new Browser_Curs4();
            Firefox_Curs4 firefox = new Firefox_Curs4();
            Skype skype = new Skype();

            firefox.WindowWidth = 1920;
            firefox.StartBrowser();
            firefox.About();
            firefox.Ping();

            skype.About();
            skype.Ping();

            Console.ReadKey();
        } 

    }
}
