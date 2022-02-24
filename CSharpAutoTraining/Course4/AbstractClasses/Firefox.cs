using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4.AbstractClasses
{
    public class Firefox : Browser
    {
        // Override ChangeWindowWidth() method
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Firefox method to change window width. ");
        }

        // Override abstract method
        public override void About()
        {
            Console.WriteLine("Firefox Browser.");
        }
    }
}
