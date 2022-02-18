using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Course3
{
    public class Browser
    {
        // Variable
        public int WindowWidth = 1024;

        // Method for changing window width
        public virtual void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Browser");
        }

        // Method for showing window width
        public int GetWindowWidth()
        {
            return WindowWidth;
        }
    }
}
