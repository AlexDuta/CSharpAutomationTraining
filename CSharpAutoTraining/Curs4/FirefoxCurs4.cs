using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class FirefoxCurs4:BrowserCurs4,IComponent,INetwork
    {
        public void About()
        {
            Console.WriteLine("Firefox is red");
        }

        public void Ping()
        {
            Console.WriteLine("Firefox Ping");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Starting Firefox with window width: " + WindowWidth);
        }
    }
}
