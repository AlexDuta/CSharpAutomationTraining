using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4
{
    public class Firefox : Browser, IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine(WindoWWidth);
        }

        public void Ping()
        {
            Console.WriteLine("Firefox Ping!");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Starting Firefox!");
        }
    }
}
