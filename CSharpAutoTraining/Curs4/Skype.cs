using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    class Skype : IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("About Skype");
        }

        public void Ping()
        {
            Console.WriteLine("Ping Skype");
        }
    }
}
