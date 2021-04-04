using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class EdgeCurs3:InternetExplorerCurs3
    {
        public int Version;
        public void NewFutureFunction()
        {
            Console.WriteLine($"You have to update your version of Edge ({Version}) to benefit new future function");
        }
        public override void About()
        {
            Console.WriteLine("The browser is Edge");
        }
    }
}
