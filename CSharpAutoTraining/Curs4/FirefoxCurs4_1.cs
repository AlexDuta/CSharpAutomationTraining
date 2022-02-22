using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Firefox : Browser,IComponent,INetwork
    {
        public void About()
        {
            Console.WriteLine("Firefox About()");
        }

        public void Ping()
        {
            Console.WriteLine("Firefox Ping()");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Firefox StartBrowser()");

        }
    }
}
