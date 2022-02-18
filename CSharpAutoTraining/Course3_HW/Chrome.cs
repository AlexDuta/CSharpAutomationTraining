using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_HW
{
    public class Chrome : Browser
    {
        // Method for changing window width string value
        public void ChangeWindowWidth(string newWindowWidth)
        {
            WindowWidth_string = newWindowWidth;
            Console.WriteLine("WindowWidth string for Chrome set: " + newWindowWidth);
        }

        // Method for changing window width int value (overriden)
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth_int = newWindowWidth;
            Console.WriteLine("WindowWidth for Chrome set: " + newWindowWidth);
        }

        // Method for describing browser (overrriden)
        public override void About()
        {
            Console.WriteLine("This is the Chrome Browser.");
        }
    }
}
