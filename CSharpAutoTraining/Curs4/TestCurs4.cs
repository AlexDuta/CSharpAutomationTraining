using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class TestCurs4
    {
        static void Main(string[] args)
        {
            // Browser_Curs4 browser = new Browser_Curs4();
            FirefoxCurs4 firefox = new FirefoxCurs4();
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
