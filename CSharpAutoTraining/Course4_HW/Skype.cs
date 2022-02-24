using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4_HW
{
    public class Skype : IComponent, INetwork
    {
        // Implement IComponent's About() method
        public void About()
        {
            Console.WriteLine("Skype Desktop Application.");
        }

        // Implement INetwork's Ping() method
        public void Ping()
        {
            Console.WriteLine("Skype Desktop Application Ping... Done.");
        }
    }
}
