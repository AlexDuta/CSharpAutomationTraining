using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4
{
    public class Skype : Browser, IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine(WindoWWidth);
        }

        public void Ping()
        {
            Console.WriteLine("Skype Ping!");
        }

        public override void StartBrowser()
        {
            Console.WriteLine("Starting Skype!");
        }
    }
}
