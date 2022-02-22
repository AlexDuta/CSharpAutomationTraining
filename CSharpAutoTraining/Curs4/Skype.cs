using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Skype : INetwork, IComponent
    {
        public void About()
        {
            Console.WriteLine("Skype About()");
        }

        public void Ping()
        {
            Console.WriteLine("Skype Ping()");
        }
    }
}
