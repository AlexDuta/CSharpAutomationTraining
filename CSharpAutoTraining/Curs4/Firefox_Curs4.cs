using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Firefox_Curs4 : Browser_Curs4 , IComponent, INetwork
    {

        public override void StartBrowser()
        {
            Console.WriteLine("Firefox browser has started!");
        }

        public void About()
        {
            Console.WriteLine("This is Firefox browser.");
        }

        public void Ping()
        {
            Console.WriteLine("This is Firefox ping.");
        }
    }
}
