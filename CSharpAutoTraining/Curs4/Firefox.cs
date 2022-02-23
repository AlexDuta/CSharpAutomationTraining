using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    internal class Firefox:Browser, IComponent, INetwork
    {
        public override void StartBrowser()
        {
            Console.WriteLine("Starting broswer Firefox");
        }

        public void About()
        {
            Console.WriteLine("About Firefox");
        }

        public void Ping()
        {
            Console.WriteLine("Ping Firefox");
        }
    }
}
