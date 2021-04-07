using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs4
{
    public class Skype : IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("This is the Skype app.");
        }

        public void Ping()
        {
            Console.WriteLine("Skype ping is 20ms.");
        }
    }
}
