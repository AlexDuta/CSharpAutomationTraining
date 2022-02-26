using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class FirefoxC4 : BrowserC4, IComponent,INetwork
    {
        public void About()
        {
            Console.WriteLine("About Firefox");
        }

        public void Ping()
        {
            Console.WriteLine("Ping Firefox");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Starting browser Firefox.");
        }
    }
}
