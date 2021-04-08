using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Firefox : Browser, IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("about Friefox");
        }

        public void Ping()
        {
            Console.WriteLine("ping Firefox");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Starting browser with windowWidth: " + WindowWidth);
        }
    }
}
