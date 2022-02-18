using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3_HW
{
    public class InternetExplorer : Browser
    {
        // Method for changing window width int value (overriden)
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth_int = newWindowWidth;
            Console.WriteLine("WindowWidth for Internet Explorer set: " + newWindowWidth);
        }

        // Method for describing browser (overrriden)
        public override void About()
        {
            Console.WriteLine("This is the Internet Explorer Browser.");
        }
    }
}
