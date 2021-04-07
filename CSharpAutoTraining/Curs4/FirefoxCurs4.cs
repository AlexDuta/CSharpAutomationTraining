using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public class FirefoxCurs4 : BrowserCurs4 , IComponent , INetwork
    {
        public void About()
        {
            Console.WriteLine("This is the Firefox browser.");
        }

        public void Ping()
        {
            Console.WriteLine("Firefox ping is 30ms.");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Firefox started");
        }
    }
}
