using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course4.AbstractClasses
{
    public class InternetExplorer : Browser
    {
        // Override ChangeWindowWidth() method
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Firefox method to change window width: " + newWindowWidth);
        }

        // Override abstract method
        public override void About()
        {
            Console.WriteLine("Internet Explorer Browser.");
        }
    }
}
