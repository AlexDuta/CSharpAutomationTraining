using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4.Interfaces
{
    public class Firefox : Browser, Component
    {
        // Method for changing window width
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Firefox method to change window width.");
        }

        // Implemented About() method from Component interface
        public override void About()
        {
            Console.WriteLine("Firefox Browser.");
        }
    }
}
